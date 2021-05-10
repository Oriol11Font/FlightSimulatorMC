using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using UtilsMuchoCodigo;

namespace PersonalControls
{
    public partial class SpaceShipDetails : UserControl
    {
        private const string DbFileName = "DataBank.xml";
        private List<OnBoardCategory> _categories;
        XDocument xDoc;
        //int selectedCategoryId = -1;
        int selectedOptionId = -1;
        String selectedOptionText = "";
        String dbPath = Application.StartupPath + "\\assets" + "\\" + DbFileName;
        TreeNode rootTreeNode;
        String selectedCategoryName;


        public SpaceShipDetails()
        {
            InitializeComponent();
            xDoc = XDocument.Load(dbPath);
            fillCategoryCombobox();
            initializeRootTreeNode();

        }

        private void initializeRootTreeNode()
        {
        }

        private static string FindFileByName(string path, string name)
        {
            var dir = new DirectoryInfo(path);
            var files = dir.GetFiles($@"{name}*", SearchOption.TopDirectoryOnly);
            return files != null && files.Length > 0 ? files[0].Name : null;
        }

        private static FileInfo[] GetZoneFiles(string directoryPath, string fileName)
        {
            var dir = new DirectoryInfo(directoryPath);
            var files = dir.GetFiles($@"{fileName}*", SearchOption.TopDirectoryOnly);
            return files;
        }
        private void fillCategoryCombobox()
        {

            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            { };
            dictionary.Add("", "-1");
            dictionary.Add("Planets", "1");
            dictionary.Add("Regions", "2");
            dictionary.Add("Routes", "3");
            dictionary.Add("Maps", "4");
            foreach (KeyValuePair<string, string> register in dictionary)
            {

                cbxCategories.Items.Add(register.Key);

            }
        }
        private void fillTreeView(String rootNodeName)
        {
            treeView1.Nodes.Clear();
            rootTreeNode = new TreeNode()
            {
                Tag = "-1",
                Text = rootNodeName,


            };
            String rootNodeNameToLower = rootNodeName.ToLower();
            switch (rootNodeNameToLower)
            {
                case "planets":
                    IEnumerable<XElement> listaPlanets = xDoc.Root.Elements(rootNodeNameToLower).Elements("planet");
                    populateNodeWithPlanets(rootTreeNode, listaPlanets);
                    break;
                case "regions":

                    IEnumerable<XElement> listaRegions = xDoc.Root.Elements(rootNodeNameToLower).Elements("Region");
                    rootTreeNode = populateNodeWithRegions(rootTreeNode, listaRegions);
                    break;
                case "routes":
                    IEnumerable<XElement> listaRoutes = xDoc.Root.Elements("planets").Elements("planet").Elements("hyperspaceRoute").Elements("route");
                    rootTreeNode = populateWithRoutes(rootTreeNode, listaRoutes);

                    break;
                case "maps":
                    String directoryPath = Path.Combine(Application.StartupPath, "assets", "planetes");
                    FileInfo[] filesArray = GetZoneFiles(directoryPath, "zona");
                    rootTreeNode = populateWithMaps(rootTreeNode, filesArray);
                    break;
                default:
                    break;
            }



            treeView1.Nodes.Add(rootTreeNode);
        }

        private TreeNode populateNodeWithPlanets(TreeNode root, IEnumerable<XElement> listOfPlanets)
        {
            root.Nodes.Clear();
            int index = 0;
            foreach (XElement element in listOfPlanets)
            {
                String planetName = element.Element("name").Value.ToString();
                String tag = index.ToString();
                TreeNode treeNode = new TreeNode()
                {
                    Tag = index.ToString(),
                    Text = planetName,
                };
                root.Nodes.Add(treeNode);
                index++;
            }

            return root;

        }

        private TreeNode populateNodeWithRegions(TreeNode root, IEnumerable<XElement> listOfRegions)
        {
            root.Nodes.Clear();
            int indexRegion = 0;

            foreach (XElement element in listOfRegions)
            {
                String regionName = element.Element("nameRegion").Value.ToString();
                String tag = indexRegion.ToString();
                TreeNode treeNode = new TreeNode()
                {
                    Tag = indexRegion.ToString(),
                    Text = regionName,
                };
                rootTreeNode.Nodes.Add(treeNode);
                indexRegion++;
            }

            return root;

        }

        private TreeNode populateWithRoutes(TreeNode root, IEnumerable<XElement> listOfRoutes)
        {
            root.Nodes.Clear();
            int indexRoutes = 0;
            List<string> addedRouteNames = new List<string>(new string[] { });
            foreach (XElement element in listOfRoutes)
            {
                String routeName = element.Value.ToString();

                if (!addedRouteNames.Contains(routeName))
                {
                    String tag = indexRoutes.ToString();
                    TreeNode treeNode = new TreeNode()
                    {
                        Tag = indexRoutes.ToString(),
                        Text = routeName,
                    };
                    rootTreeNode.Nodes.Add(treeNode);
                    addedRouteNames.Add(routeName);
                    indexRoutes++;
                }

            }

            return root;

        }

        private TreeNode populateWithMaps(TreeNode root, FileInfo[] listOfMaps)
        {
            root.Nodes.Clear();
            int indexMaps = 0;
            foreach (FileInfo element in listOfMaps)
            {
                String mapNameWithExtension = listOfMaps[indexMaps].Name;

                String mapName = mapNameWithExtension.Substring(4, 2);


                TreeNode treeNode = new TreeNode()
                {
                    Name = mapNameWithExtension,
                    Tag = indexMaps.ToString(),
                    Text = mapName
                };
                root.Nodes.Add(treeNode);
                indexMaps++;


            }

            return root;

        }




        private void fillDetails(String selectedCategoryName, int selectedOptionId)
        {
            //When user clicks on treenode, it grabs index and puts it here
            //Switch to check selectedCategory
            if (selectedOptionId != -1)
            {
                switch (selectedCategoryName.ToLower())
                {
                    case "planets":
                        fillPlanetDetails(selectedOptionId);
                        break;
                    case "regions":
                        fillRegionDetails(selectedOptionId);


                        break;
                    case "routes":
                        fillRouteDetails(selectedOptionText);


                        break;
                    case "maps":
                        fillMapDetails();

                        break;
                    default:
                        break;
                }

            }
            else
            {
                hidePanels();
            }



        }

        private void fillPlanetDetails(int selectedOptionId)
        {
            //IEnumerable<XElement> listaPlanets = xDoc.Root.Elements("planets").Elements("planet");
            XElement planetElement = xDoc.Root.Elements("planets").Elements("planet").ElementAt(selectedOptionId);

            String planetName = planetElement.Element("name").Value.ToString();
            String planetSector = planetElement.Element("sector").Value.ToString();
            String planetFiliation = planetElement.Element("filiation").Value.ToString();
            String planetLatitude = planetElement.Element("situation").Element("lat").Value.ToString();
            String planetLongitude = planetElement.Element("situation").Element("long").Value.ToString();
            String planetNatives = planetElement.Element("natives").Value.ToString();
            String imageName = FindFileByName(Path.Combine(Application.StartupPath,
                        "assets", "planetes"), planetName);
            IEnumerable<XElement> planetRoutes = planetElement.Element("hyperspaceRoute").Elements("route");

            lbxPlanetRoutes.Items.Clear();

            foreach (XElement route in planetRoutes)
            {
                lbxPlanetRoutes.Items.Add(route.Value.ToString());
            }

            lblPlanetName.Text = planetName;
            lblPlanetSector.Text = planetSector;
            lblPlanetFiliation.Text = planetFiliation;
            lblLatitude.Text = planetLatitude;
            lblLongitude.Text = planetLongitude;
            lblNatives.Text = planetNatives;
            pcbPlanetImage.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", imageName));
            pnlPlanetDetails.Visible = true;
        }

        private void fillMapDetails()
        {
            throw new NotImplementedException();
        }

        private void fillRouteDetails(String selectedOptionText)
        {
            
            lblRouteName.Text = selectedOptionText;
            lsbRoutePlanets.Items.Clear();
            //IEnumerable<XElement> ddd = xDoc.Root.Elements("planets").Elements("planet").Elements("hperspaceRoute").Elements("route");
            IEnumerable<XElement> listaPlanets = xDoc.Root.Elements("planets").Elements("planet");

            //XElement routeElement = xDoc.Root.Elements("regions").Elements("Region").ElementAt(selectedOptionId);

            List<String> planetsInRoute = new List<String>();
            listaPlanets.Count();
            foreach (XElement element in listaPlanets)
            {
                IEnumerable<XElement> planetHyperspaceRouteElements = element.Elements("hyperspaceRoute").Elements("route");
                foreach (XElement route in planetHyperspaceRouteElements)
                {
                    if(route.Value.ToString().ToLower() == selectedOptionText.ToLower())
                    {
                        String planetName = element.Element("name").Value.ToString();
                        lsbRoutePlanets.Items.Add(planetName);
                    }
                }
                
            }

            pcbRoute.Image = Image.FromFile(Path.Combine(Application.StartupPath, "assets", "placeholder.png"));

            hidePanels();

            pnlRoute.Visible = true;




        }

        private void fillRegionDetails(int selectedOptionId)
        {
            //IEnumerable<XElement> listaPlanets = xDoc.Root.Elements("planets").Elements("planet");
            XElement regionElement = xDoc.Root.Elements("regions").Elements("Region").ElementAt(selectedOptionId);

            String regionName = regionElement.Element("nameRegion").Value.ToString();
            String regionDescription = regionElement.Element("descriptionRegion").Value.ToString();
            String imageName = regionElement.Element("mapRegion").Value.ToString();


            

            lblRegionName.Text = regionName;
            txbRegionDescription.Text = regionDescription;
            pcbRegionImage.Image = Image.FromFile(Path.Combine(Application.StartupPath,
                        "assets", "planetes", imageName));
            hidePanels();
            pnlRegion.Visible = true;
        }


        private void cbxCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedCategoryName = cbxCategories.SelectedItem.ToString();
            bool isOptionSelected = selectedCategoryName == "";
            if (selectedCategoryName == "")
            {
                clearTreeview();
                //Hide controllers
                hidePanels();
            }
            else
            {
                clearTreeview();
                fillTreeView(selectedCategoryName);
            }
        }

        private void hidePanels()
        {
            //Hide Panel
            pnlPlanetDetails.Visible = false;
            pnlRegion.Visible = false;
            pnlRoute.Visible = false;
        }

        private void clearTreeview()
        {
            treeView1.Nodes.Clear();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedOptionId = Convert.ToInt32(treeView1.SelectedNode.Tag);
            selectedOptionText = treeView1.SelectedNode.Text.ToString();

            //Hay que coger como elemento padre el
            fillDetails(selectedCategoryName, selectedOptionId);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }





}
