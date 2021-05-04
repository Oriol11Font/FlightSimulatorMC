﻿using System;
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
        public SelectionPlanet()
        {
            InitializeComponent();
        }

        private const string DbFileName = "DataBank.xml";
        private List<Planet> _planets;

        private void OnFormLoad(object sender, EventArgs eventArgs)
        {
            Init();
        }

        private void Init()
        {
            _planets = ReadPlanets(DbFileName);
            
            if (!(_planets.Count > 0)) return;
            
            cbx_planets.Items.Clear();
            foreach (var planet in _planets)
                cbx_planets.Items.Add(planet.Name);
        }
        
        private void cbx_planets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedPlanet = _planets[cbx_planets.SelectedIndex];

            var imagePath = FindFileByName(Path.Combine(Application.StartupPath, "assets", "planetes"), selectedPlanet.Name);
            pb_planet.Image = Image.FromFile(imagePath ?? Path.Combine
                (Application.StartupPath, "assets", "placeholder.png"));
        }

        private static List<Planet> ReadPlanets(string dbName)
        {
            var doc = new XmlDocument();
            doc.Load(dbName);

            var root = doc.DocumentElement;

            var planets = root.SelectNodes("//planet");

            return (from XmlNode planet in planets
                let name = planet.SelectSingleNode("name").InnerText
                let sector = planet.SelectSingleNode("sector").InnerText
                let filiation = planet.SelectSingleNode("filiation").InnerText
                let natives = planet.SelectSingleNode("natives").InnerText
                let situationNode = planet.SelectSingleNode("situation")
                let latitude = double.Parse(situationNode.SelectSingleNode("lat").InnerText)
                let longitude = double.Parse(situationNode.SelectSingleNode("long").InnerText)
                let situation = new Coordinates {Latitude = latitude, Longitude = longitude}
                let routes = planet.SelectNodes($"//planet[name=\"{name}\"]/hyperspaceRoute/route")
                let hyperSpaceRoutes = (from XmlNode route in routes select route.InnerText).ToList()
                select new Planet
                {
                    Name = name,
                    Sector = sector,
                    Filiation = filiation,
                    Situation = situation,
                    Natives = natives,
                    HyperspaceRoutes = hyperSpaceRoutes
                }).ToList();
        }
        
        private static string FindFileByName(string path, string name)
        {
            var dir = new DirectoryInfo(path);
            var files = dir.GetFiles($@"{name}*", SearchOption.TopDirectoryOnly);
            return files != null && files.Length > 0 ? files[0].FullName : null;
        }
    }
}