using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FlightControlScreens
{
    public partial class OnBoardPlanets : UserControl
    {
        public OnBoardPlanets()
        {
            InitializeComponent();
        }

        private String _imagePath;

        public Image ImagePath
        {
            set
            {
                pcbPlanetImage.Image = value;

            }
        }


        private String _planetName;

        public String PlanetName
        {
            get { return _planetName; }
            set
            {
                lblPlanetName.Text = value;
                _planetName = value;
            }
        }

        private String _planetSector;

        public String PlanetSector
        {
            get { return _planetSector; }
            set
            {
                lblPlanetSector.Text = value;
                _planetSector = value;
            }
        }

        private String _planetFiliation;

        public String PlanetFiliation
        {
            get { return _planetFiliation; }
            set
            {
                lblPlanetFiliation.Text = value;
                _planetFiliation = value;
            }
        }

        private String _planetLongitude;

        public String PlanetLongitude
        {
            get { return _planetLongitude; }
            set
            {
                lblLongitude.Text = value;
                _planetLongitude = value;
            }
        }

        private String _planetLatitude;

        public String PlanetLatitude
        {
            get { return _planetLatitude; }
            set
            {
                lblLatitude.Text = value;
                _planetLatitude = value;
            }
        }

        private String _planetNatives;

        public String PlanetNatives
        {
            get { return _planetNatives; }
            set
            {
                lblNatives.Text = value;
                _planetNatives = value;
            }
        }

        private List<string> _planetRoutesList;

        public List<string> PlanetRoutesList
        {
            get { return _planetRoutesList; }
            set
            {
                _planetRoutesList = value;
                fillPlanetRouteList(value);
            }
        }

        private String _planetParsecs;

        public String PlanetParsecs
        {
            get { return _planetParsecs; }
            set
            {
                _planetParsecs = value;
                lblPlanetParsecs.Text = value;
            }
        }


        private void fillPlanetRouteList(List<string> planetList)
        {
            lbxPlanetRoutes.Items.Clear();
            foreach (string planet in planetList)
            {
                lbxPlanetRoutes.Items.Add(planet);
            }
        }
    }
}
