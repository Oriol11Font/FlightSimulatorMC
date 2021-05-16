using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightControlScreen
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

            pn_total.SendToBack();
            

            Parallel.Invoke(
                () => CreatePlanet(ApproachVector, Color.Yellow),
                () => CreatePlanet(DestinationVector, Color.Yellow, DestinationPlanet));
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

            if (planetName is null) return;

            var label = new Label
            {
                BackColor = Color.Transparent, Visible = true, Location = new Point(location.X,
                    location.Y + 10), ForeColor = Color.White, Text = planetName
            };

            Controls.Add(label);
            label.Show();
            label.BringToFront();
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