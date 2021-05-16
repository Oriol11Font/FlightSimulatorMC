using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalControls
{
    public partial class OnBoardRoutes : UserControl
    {
        public OnBoardRoutes()
        {
            InitializeComponent();
        }

        private String _type;

        public String RouteType
        {
            get { return _type; }
            set { _type = value;
                lblRouteType.Text = value;
            }
        }

        private String _routeName;

        public String RouteName
        {
            get { return _routeName; }
            set { _routeName = value;
                lblRouteName.Text = value;
            }
        }

        private String _routeStart;

        public String RouteStart
        {
            get { return _routeStart; }
            set { _routeStart = value;
                lblRouteStart.Text = value;
            }
        }

        private String _routeEnd;

        public String RouteEnd
        {
            get { return _routeEnd; }
            set { _routeEnd = value;
                lblRouteEnd.Text = value;
            }
        }

        private Image _routeImage;

        public Image RouteImage
        {
            get { return _routeImage; }
            set { _routeImage = value;
                pcbRoute.Image = value;
            }
        }

        private void pnlRoute_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
