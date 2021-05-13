using System.Drawing;
using System.Windows.Forms;

namespace PersonalControls
{
    public partial class Mapa : UserControl
    {
        public Mapa()
        {
            InitializeComponent();
            Init();
        }

        public string ApproachVector { get; set; } = null;
        public string DestinationVector { get; set; } = "asdasdasd";
        public string DestinationPlanet { get; set; } = "";

        private const int Rows = 5;
        private const int Columns = 6;

        public void Init()
        {
            if (ApproachVector == null || DestinationVector == null) return;

            CreatePlanet(ApproachVector, Color.Yellow);
            CreatePlanet(DestinationVector, Color.Yellow, DestinationPlanet);
        }

        private void CreatePlanet(string approachPoint, Color color, string planetName = null)
        {
            var letterPos = char.ToUpper(approachPoint[0]) - 64;
            var numPos = int.Parse
                (approachPoint[1].ToString());

            var location = GetCoordsPosition(pn_total, letterPos, numPos);

            var pane = new Panel
            {
                Size = new Size(10, 10), BackColor = color, Visible = true,
                Location = location
            };

            Controls.Add(pane);
            pane.Show();
            pane.BringToFront();
        }

        private static Point GetCoordsPosition(Control cnt, int row, int column)
        {
            var controlPos = cnt.Location;

            var boxBounds = new Size(cnt.Size.Width / Columns, cnt.Size.Height / Rows);

            var boxPoint = new Point(controlPos.X + boxBounds.Width * column + boxBounds.Width / 2,
                controlPos.Y + boxBounds.Height * row + boxBounds.Height / 2);

            return boxPoint;
        }
    }
}