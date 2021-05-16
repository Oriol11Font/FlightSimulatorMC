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
    public partial class OnBoardMaps : UserControl
    {
        public OnBoardMaps()
        {
            InitializeComponent();
        }

        private List<String> _imageList;

        public List<String> ImageList
        {
            get { return _imageList; }
            set { _imageList = value; }
        }

    }
}
