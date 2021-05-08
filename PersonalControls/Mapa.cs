using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PersonalControls
{
    public partial class Mapa : UserControl
    {
        public Mapa(string approachVector, string destinationVector, string destinationPlanet)
        {
            ApproachVector = approachVector;
            DestinationVector = destinationVector;
            DestinationPlanet = destinationPlanet;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            pb_background.Image =
                Image.FromFile(Path.Combine(Application.StartupPath, "assets", "galaxybg.jpg"));
        }

        private string ApproachVector { get; set; }
        private string DestinationVector { get; set; }
        private string DestinationPlanet { get; set; }
    }
}