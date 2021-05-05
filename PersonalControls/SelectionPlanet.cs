using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using UtilsMuchoCodigo;

namespace PersonalControls
{
    public partial class SelectionPlanet : UserControl
    {
        private List<Planet> _planets;
        private List<Route> _routes;

        private readonly string _dbFilePath =
            Path.Combine(Application.StartupPath, "assets", "DataBank.xml");

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
            _planets = ReadPlanets(_dbFilePath);
            _routes = ReadRoutes(_dbFilePath);

            if (_planets is not {Count: > 0}) return;

            cbx_origin_planet.Items.Clear();
            cbx_destination_planet.Items.Clear();

            foreach (var planet in _planets)
            {
                cbx_origin_planet.Items.Add(planet.Name);
                cbx_destination_planet.Items.Add(planet.Name);
            }
        }

        private void cbx_planets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedPlanet = _planets[cbx_destination_planet.SelectedIndex];


            MapPlanetToControls(selectedPlanet);
        }

        private void MapPlanetToControls(Planet planet)
        {
            var labelControls = gpb_planet.Controls.OfType<Label>();
            MakeLabelsVisible(labelControls);

            if (!label11.Visible) label11.Visible = true;

            lbl_name.Text = planet.Name;
            lbl_sector.Text = planet.Sector;
            lbl_filiation.Text = planet.Filiation;
            lbl_situation.Text = $@"{planet.Situation.Latitude.ToString()}, {planet.Situation
                .Longitude.ToString()}";
            lbl_natives.Text = planet.Natives;

            lb_routes.Items.Clear();
            foreach (var routeName in planet.HyperspaceRoutes)
            {
                var route = _routes.Find(x => x.Name == routeName);
                var major = route.Type.ToLower().Contains("major");

                lb_routes.Items.Add($"{route.Name} ({(major ? "Major" : "Minor")})");
            }

            var imagePath = planet.ImageName != null
                ? Path.Combine(Application.StartupPath,
                    "assets",
                    "planetes",
                    planet.ImageName)
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

            var planets = root.SelectNodes("//planet");

            return (from XmlNode planet in planets
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

            var routes = root.SelectNodes("//Route");

            return (from XmlNode route in routes
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
            return files is {Length: > 0} ? files[0] : null;
        }

        private void lb_routes_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedRoute = _routes.Find(x => lb_routes.Text.Contains(x.Name));

            MapRouteToControls(selectedRoute);
        }

        private void MapRouteToControls(Route route)
        {
            var labelControls = gpb_route.Controls.OfType<Label>();
            MakeLabelsVisible(labelControls);

            lbl_route_name.Text = route.Name;
            lbl_route_type.Text = route.Type;
            lbl_route_start.Text = route.Start;
            lbl_route_end.Text = route.End;

            var imagePath = route.ImageName != null
                ? Path.Combine(Application.StartupPath,
                    "assets",
                    "planetes",
                    route.ImageName)
                : Path.Combine(Application.StartupPath,
                    "assets",
                    "placeholder.png");

            pb_route_image.Image = Image.FromFile(imagePath);
            FitPictureBoxImage(pb_route_image);
        }
    }
}