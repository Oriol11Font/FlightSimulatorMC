using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FlightControlScreens
{
    public partial class OnBoardMaps : UserControl
    {
        public OnBoardMaps()
        {
            InitializeComponent();
        }


        private int _selectedIndex = 0;

        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                _selectedIndex = value;
                afterIndexUpdate(_selectedIndex);
            }
        }


        private List<String> _imageList;

        public List<String> ImageList
        {
            get { return _imageList; }
            set
            {
                _imageList = value;
                afterIndexUpdate(_selectedIndex);
            }
        }

        public void afterIndexUpdate(int selectedIndex)
        {
            pcbSelectedImage.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[_selectedIndex]));
            int indexMini1 = getIndexBackward(_selectedIndex);
            int indexMini2 = _selectedIndex;

            int indexMini3 = getIndexForward(_selectedIndex);

            pcbLeftImage.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[indexMini1]));

            pcbMiddleImage.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[indexMini2]));

            pcbRightImage.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[indexMini3]));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _selectedIndex = getIndexForward(_selectedIndex);
            int indexMini1 = getIndexBackward(_selectedIndex);
            int indexMini2 = _selectedIndex;

            int indexMini3 = getIndexForward(_selectedIndex);

            pcbLeftImage.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[indexMini1]));

            pcbMiddleImage.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[indexMini2]));

            pcbSelectedImage.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[_selectedIndex]));

            pcbRightImage.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[indexMini3]));

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
            _selectedIndex = getIndexBackward(_selectedIndex);
            int indexMini1 = getIndexBackward(_selectedIndex);
            int indexMini2 = _selectedIndex;

            int indexMini3 = getIndexForward(_selectedIndex);

            pcbLeftImage.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[indexMini1]));

            pcbMiddleImage.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[indexMini2]));

            pcbSelectedImage.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", _imageList[_selectedIndex]));

            pcbRightImage.Image = Image.FromFile(Path.Combine(Application.StartupPath,
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
