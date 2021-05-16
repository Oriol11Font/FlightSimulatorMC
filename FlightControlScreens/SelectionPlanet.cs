using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using UtilsMuchoCodigo;

namespace FlightControlScreen
{
    public partial class SelectionPlanet : UserControl
    {
        private readonly string _dbFilePath =
            Path.Combine(Application.StartupPath, "assets", "DataBank.xml");

        private List<DefinedRoute> _definedRoutes;
        private List<Planet> _planets;
        private List<Route> _routes;
        private Planet _selectedDestinationPlanet;

        private Planet _selectedOriginPlanet;
        private Route _selectedRoute;

        public SelectionPlanet()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs eventArgs)
        {
            Init();
        }

        private void Init()
        {
            Parallel.Invoke(() => _planets = ReadPlanets(_dbFilePath),
                () => _routes = ReadRoutes(_dbFilePath),
                () => _definedRoutes = ReadDefinedRoutes(_dbFilePath));

            if (!(_planets.Count() > 0)) return;

            cbx_origin_planet.Items.Clear();
            cbx_destination_planet.Items.Clear();

            foreach (var planet in _planets)
            {
                cbx_origin_planet.Items.Add(planet.Name);
                cbx_destination_planet.Items.Add(planet.Name);
            }
        }

        private void cbx_origin_planet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _selectedOriginPlanet = _planets[cbx_origin_planet.SelectedIndex];
        }

        private void cbx_planets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _selectedDestinationPlanet = _planets[cbx_destination_planet.SelectedIndex];

            MapPlanetToControls();
        }

        private void MapPlanetToControls()
        {
            var labelControls = gpb_planet.Controls.OfType<Label>();
            MakeLabelsVisible(labelControls);

            if (!label11.Visible) label11.Visible = true;

            lbl_name.Text = _selectedDestinationPlanet.Name;
            lbl_sector.Text = _selectedDestinationPlanet.Sector;
            lbl_filiation.Text = _selectedDestinationPlanet.Filiation;
            lbl_situation.Text =
                $@"{_selectedDestinationPlanet.Situation.Latitude.ToString(CultureInfo.InvariantCulture)}, 
                {_selectedDestinationPlanet.Situation
                    .Longitude.ToString(CultureInfo.InvariantCulture)}";
            lbl_natives.Text = _selectedDestinationPlanet.Natives;

            lb_routes.Items.Clear();
            foreach (var routeName in _selectedDestinationPlanet.HyperspaceRoutes)
            {
                var route = _routes.Find(x => x.Name == routeName);
                var major = route.Type.ToLower().Contains("major");

                lb_routes.Items.Add($"{route.Name} ({(major ? "Major" : "Minor")})");
            }

            var imagePath = _selectedDestinationPlanet.ImageName != null
                ? Path.Combine(Application.StartupPath,
                    "assets",
                    "planetes",
                    _selectedDestinationPlanet.ImageName)
                : Path.Combine
                    ("assets", "placeholder.png");

            pb_planet_image.Image = Image.FromFile(imagePath);
            FitPictureBoxImage(pb_planet_image);
        }

        private static List<Planet> ReadPlanets(string dbPath)
        {
            var doc = new XmlDocument();
            doc.Load(dbPath);

            var root = doc.DocumentElement;

            if (root == null) return null;

            return (from XmlNode planet in root.SelectNodes("//planet")
                let name = planet.SelectSingleNode("name")?.InnerText
                let sector = planet.SelectSingleNode("sector")?.InnerText.Split('-')
                let filiation = planet.SelectSingleNode("filiation")?.InnerText
                let natives = planet.SelectSingleNode("natives")?.InnerText
                let situationNode = planet.SelectSingleNode("situation")
                let latitude =
                    double.Parse(situationNode.SelectSingleNode("lat")?.InnerText ?? string.Empty)
                let longitude = double.Parse(situationNode.SelectSingleNode("long")?.InnerText ??
                                             string.Empty)
                let parsecs = situationNode.SelectSingleNode("parsecs")?.InnerText
                let situation = new Coordinates
                {
                    Latitude = latitude, Longitude = longitude,
                    Parsecs = parsecs
                }
                let routes = planet.SelectNodes($"//planet[name=\"{name}\"]/hyperspaceRoute/route")
                let hyperSpaceRoutes =
                    (from XmlNode route in routes select route.InnerText).ToList()
                let imageInfo = FindFileByName(Path.Combine(Application.StartupPath,
                    "assets", "planetes"), name)
                select new Planet
                {
                    Name = name,
                    Sector = sector[0],
                    Region = sector[1],
                    Filiation = filiation,
                    Situation = situation,
                    Natives = natives,
                    HyperspaceRoutes = hyperSpaceRoutes,
                    ImageName = imageInfo?.Name
                }).ToList();
        }

        private static List<Route> ReadRoutes(string dbPath)
        {
            var doc = new XmlDocument();
            doc.Load(dbPath);

            var root = doc.DocumentElement;

            if (root == null) return null;

            return (from XmlNode route in root.SelectNodes("//Route")
                    let type = route.SelectSingleNode("type")?.InnerText
                    let name = route.SelectSingleNode("nameRoute")?.InnerText
                    let start = route.SelectSingleNode("start")?.InnerText
                    let end = route.SelectSingleNode("end")?.InnerText
                    let imageInfo = FindFileByName(Path.Combine(Application.StartupPath,
                        "assets", "planetes"), name)
                    select new Route
                    {
                        Name = name, Type = type, Start = start, End = end,
                        ImageName = imageInfo?.Name
                    }
                ).ToList();
        }

        private static List<DefinedRoute> ReadDefinedRoutes(string dbPath)
        {
            var doc = new XmlDocument();
            doc.Load(dbPath);

            var root = doc.DocumentElement;

            if (root == null) return null;

            return (from XmlNode route in root.SelectNodes("//defineRoute")
                    let ordes = route.SelectSingleNode("OrDes")?.InnerText.Split('-')
                    let routes = route.SelectSingleNode("selectedRoute")?.InnerText.Split('-')
                    let map = route.SelectSingleNode("map")?.InnerText
                    select new DefinedRoute
                    {
                        Origin = ordes[0], Destination = ordes[1], Routes = routes,
                        Map = map
                    }
                ).ToList();
        }

        private static void AddDefinedRoute(string dbPath, DefinedRoute definedRoute)
        {
            var doc = new XmlDocument();
            doc.Load(dbPath);

            var defineRoute = doc.CreateElement("defineRoute");

            var orDes = doc.CreateElement("OrDes");
            orDes.InnerText = $@"{definedRoute.Origin}-{definedRoute.Destination}";
            defineRoute.AppendChild(orDes);

            var selectedRoute = doc.CreateElement("selectedRoute");
            selectedRoute.InnerText = string.Join("-", definedRoute.Routes);
            defineRoute.AppendChild(selectedRoute);

            if (definedRoute.Map != null)
            {
                var map = doc.CreateElement("map");
                map.InnerText = definedRoute.Map;
                defineRoute.AppendChild(map);
            }

            var parent = doc.SelectSingleNode("//definedRoutes");
            parent?.AppendChild(defineRoute);
            doc.Save(dbPath);
        }

        private static void MakeLabelsVisible(IEnumerable<Label> labels)
        {
            var enumerable = labels as Label[] ?? labels.ToArray();

            var isAnyLabelInvisible = enumerable.Any(x => x.Visible == false);
            if (!isAnyLabelInvisible) return;

            foreach (var label in enumerable)
                if (!label.Visible)
                    label.Visible = true;
        }

        private static void FitPictureBoxImage(PictureBox pb)
        {
            var imageSize = pb.Image.Size;
            var fitSize = pb.ClientSize;
            pb.SizeMode =
                imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height
                    ? PictureBoxSizeMode.Zoom
                    : PictureBoxSizeMode.CenterImage;
        }

        private static FileInfo FindFileByName(string path, string name)
        {
            var dir = new DirectoryInfo(path);

            var files = dir.GetFiles($@"{name}*", SearchOption.TopDirectoryOnly);

            if (files.Length > 0)
            {
                return files[0];
            }

            return null;
        }

        private void lb_routes_SelectedValueChanged(object sender, EventArgs e)
        {
            _selectedRoute = _routes.Find(x => lb_routes.Text.Contains(x.Name));
            MapRouteToControls();

            if (!btn_calc_vector.Enabled) btn_calc_vector.Enabled = true;
        }

        private void MapRouteToControls()
        {
            var labelControls = gpb_route.Controls.OfType<Label>();

            MakeLabelsVisible(labelControls);
            if (!label11.Visible) label11.Visible = true;
            lbl_route_name.Text = _selectedRoute.Name;
            lbl_route_type.Text = _selectedRoute.Type;
            lbl_route_start.Text = _selectedRoute.Start;
            lbl_route_end.Text = _selectedRoute.End;

            var imagePath = _selectedRoute.ImageName != null
                ? Path.Combine(Application.StartupPath,
                    "assets",
                    "planetes",
                    _selectedRoute.ImageName)
                : Path.Combine(Application.StartupPath,
                    "assets",
                    "placeholder.png");

            pb_route_image.Image = Image.FromFile(imagePath);
            FitPictureBoxImage(pb_route_image);
        }

        private void btn_calc_vector_Click(object sender, EventArgs e)
        {
            CalculateCoordinates();
        }

        private void CalculateCoordinates()
        {
            var selectedDefinedRoute = new DefinedRoute
            {
                Origin = _selectedOriginPlanet.Name,
                Destination = _selectedDestinationPlanet.Name, Routes = _selectedOriginPlanet
                    .HyperspaceRoutes.Concat(_selectedDestinationPlanet.HyperspaceRoutes)
            };

            var isDefinedRouteExist = _definedRoutes.Any(x =>
                x.Origin.Equals(selectedDefinedRoute.Origin) && x.Destination.Equals(
                    selectedDefinedRoute.Destination) &&
                x.Routes.SequenceEqual(selectedDefinedRoute.Routes));


            var originVector = Hyperspace.CalculateVector(_selectedOriginPlanet.Situation);
            var destinationVector = Hyperspace.CalculateVector();

            if (originVector == null)
            {
                MessageBox.Show(
                    @"No s'ha trobat cap ruta segura per per a apropar-se al planeta de destí");
                return;
            }

            if (!isDefinedRouteExist)
                SaveDefinedRoute(selectedDefinedRoute);

            foreach (Control control in panel_selectplanet.Controls)
                control.Visible = false;

            mapa1.ApproachVector = originVector;
            mapa1.DestinationVector = destinationVector;
            mapa1.DestinationPlanet = _selectedDestinationPlanet.Name;

            mapa1.Init();
            mapa1.Visible = true;
            mapa1.BringToFront();
        }

        private void SaveDefinedRoute(DefinedRoute selectedDefinedRoute)
        {
            var msg = MessageBox.Show(
                @"You have selected a new route not saved on the database, do you want to save it now?",
                null, MessageBoxButtons.YesNo);

            if (msg == DialogResult.Yes)
            {
                var initialPath = Path.Combine(Application.StartupPath, "assets", "planetes");

                var fileDialog = new OpenFileDialog
                {
                    InitialDirectory = initialPath,
                    CheckFileExists = true, Filter = @"*.png|*.jpg",
                    Title = @"Select an image tied to this route"
                };

                selectedDefinedRoute.Map = fileDialog.ShowDialog() == DialogResult.OK
                    ? fileDialog.SafeFileName
                    : null;
            }

            Task.Run(() => AddDefinedRoute(_dbFilePath, selectedDefinedRoute));
            _definedRoutes.Add(selectedDefinedRoute);
        }
    }
}