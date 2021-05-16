using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonalControls
{
    public partial class OnBoardMaps : UserControl
    {
        int selectedIndex = 0;
        public OnBoardMaps()
        {
            InitializeComponent();
        }

        private List<String> _imageList;

        public List<String> ImageList
        {
            get { return _imageList; }
            set { _imageList = value;
                pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[selectedIndex]));
                int indexMini1 = getIndexBackward(selectedIndex);
                int indexMini2 = selectedIndex;

                int indexMini3 = getIndexForward(selectedIndex);

                pcbMini1.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                            "assets", "planetes", _imageList[indexMini1]));

                pcbMini2.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                            "assets", "planetes", _imageList[indexMini2]));

                pcbMini3.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                            "assets", "planetes", _imageList[indexMini3]));
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            selectedIndex = getIndexForward(selectedIndex);
            int indexMini1 = getIndexBackward(selectedIndex);
            int indexMini2 = selectedIndex;

            int indexMini3 = getIndexForward(selectedIndex);

            pcbMini1.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[indexMini1]));

            pcbMini2.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[indexMini2]));

            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[selectedIndex]));

            pcbMini3.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[indexMini3]));
            //if (selectedIndex == _imageList.Count - 1)
            //{
            //    selectedIndex = 0;

            //}
            //else
            //{
            //    selectedIndex++;
            //}
            //getIndexForward(selectedIndex);
            //pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath,
            //            "assets", "planetes", _imageList[selectedIndex]));

            //int indexMini1 = getIndexForward(selectedIndex - 1);
            //int indexMini2 = getIndexForward(selectedIndex);

            //int indexMini3 = getIndexForward(selectedIndex + 1);

            //pcbMini1.Image = Image.FromFile(Path.Combine(Application.StartupPath,
            //            "assets", "planetes", _imageList[indexMini1]));

            //pcbMini2.Image = Image.FromFile(Path.Combine(Application.StartupPath,
            //            "assets", "planetes", _imageList[indexMini2]));

            //pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath,
            //            "assets", "planetes", _imageList[indexMini2]));

            //pcbMini3.Image = Image.FromFile(Path.Combine(Application.StartupPath,
            //            "assets", "planetes", _imageList[indexMini3]));
        }

        private int getIndexForward(int selectedIndex)
        {
            if (selectedIndex == _imageList.Count - 1)
            {
                selectedIndex = 0;

            }
            else
            {
                selectedIndex++;
            }

            return selectedIndex;
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {

            //if (selectedIndex != 0)
            //{
            //    selectedIndex--;
            //}
            //else
            //{
            //    selectedIndex = _imageList.Count - 1;
            //}
            selectedIndex = getIndexBackward(selectedIndex);
            int indexMini1 = getIndexBackward(selectedIndex);
            int indexMini2 = selectedIndex;

            int indexMini3 = getIndexForward(selectedIndex);

            pcbMini1.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[indexMini1]));

            pcbMini2.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[indexMini2]));

            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[selectedIndex]));

            pcbMini3.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[indexMini3]));
        }

        private int getIndexBackward(int selectedIndex)
        {
            if (selectedIndex != 0)
            {
                selectedIndex--;
            }
            else
            {
                selectedIndex = _imageList.Count - 1;
            }

            return selectedIndex;
        }
    }
}
