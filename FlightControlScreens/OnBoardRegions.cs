using System.Drawing;
using System.Windows.Forms;

namespace FlightControlScreens
{
    public partial class OnBoardRegions : UserControl
    {
        public OnBoardRegions()
        {
            InitializeComponent();
        }

        private string _regionName;

        public string RegionName
        {
            get { return _regionName; }
            set
            {
                _regionName = value;
                lblRegionName.Text = _regionName;
            }
        }


        private string _regionDescription;

        public string RegionDescription
        {
            get { return _regionDescription; }
            set
            {
                _regionDescription = value;
                txbRegionDescription.Text = value;
            }
        }

        private Image _regionImage;

        public Image RegionImage
        {
            set
            {
                pcbRegionImage.Image = value;

            }
        }



    }
}
