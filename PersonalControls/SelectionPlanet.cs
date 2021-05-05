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

        private readonly string DbFilePath =
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
            _planets = ReadPlanets(DbFilePath);
            _routes = ReadRoutes(DbFilePath);

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
            if (!label3.Visible)
                // var labels = new[] {label3, label5, label6, label7, label8, label11};
                // foreach (var label in labels)
                //     label.Visible = true;
                foreach (var label in panel7.Controls.OfType<Label>())
                    if (!label.Visible)
                        label.Visible = true;

            lbl_name.Text = planet.Name;
            lbl_sector.Text = planet.Sector;
            lbl_filiation.Text = planet.Filiation;
            lbl_situation.Text = $@"{planet.Situation.Latitude}, {planet.Situation.Longitude}";
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
                : null;

            pb_planet_image.Image = Image.FromFile(imagePath ?? Path.Combine
                ("assets", "placeholder.png"));

            // fit image in picturebox
            var imageSize = pb_planet_image.Image.Size;
            var fitSize = pb_planet_image.ClientSize;
            pb_planet_image.SizeMode =
                imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height
                    ? PictureBoxSizeMode.Zoom
                    : PictureBoxSizeMode.CenterImage;
        }

        private static List<Planet> ReadPlanets(string dbPath)
        {
            var doc = new XmlDocument();
            doc.Load(dbPath);

            var root = doc.DocumentElement;

            var planets = root.SelectNodes("//planet");

            return (from XmlNode planet in planets
                let name = planet.SelectSingleNode("name").InnerText
                let sector = planet.SelectSingleNode("sector").InnerText.Split('-')
                let filiation = planet.SelectSingleNode("filiation").InnerText
                let natives = planet.SelectSingleNode("natives").InnerText
                let situationNode = planet.SelectSingleNode("situation")
                let latitude = double.Parse(situationNode.SelectSingleNode("lat").InnerText)
                let longitude = double.Parse(situationNode.SelectSingleNode("long").InnerText)
                let parsecs = situationNode.SelectSingleNode("parsecs").InnerText
                let situation = new Coordinates
                {
                    Latitude = latitude, Longitude = longitude,
                    Parsecs = parsecs
                }
                let routes = planet.SelectNodes($"//planet[name=\"{name}\"]/hyperspaceRoute/route")
                let hyperSpaceRoutes =
                    (from XmlNode route in routes select route.InnerText).ToList()
                let imageName = FindFileByName(Path.Combine(Application.StartupPath,
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
                    ImageName = imageName
                }).ToList();
        }
        
        private static List<Route> ReadRoutes(string dbPath)
        {
            var doc = new XmlDocument();
            doc.Load(dbPath);

            var root = doc.DocumentElement;

            var routes = root.SelectNodes("//Route");

            return (from XmlNode route in routes
                    let type = route.SelectSingleNode("type").InnerText
                    let name = route.SelectSingleNode("nameRoute").InnerText
                    let start = route.SelectSingleNode("start").InnerText
                    let end = route.SelectSingleNode("end").InnerText
                    select new Route {Name = name, Type = type, Start = start, End = end}   
                ).ToList();
        }

        private static string FindFileByName(string path, string name)
        {
            var dir = new DirectoryInfo(path);
            var files = dir.GetFiles($@"{name}*", SearchOption.TopDirectoryOnly);
            return files is {Length: > 0} ? files[0].Name : null;
        }
    }
}