
namespace PersonalControls
{
    partial class SpaceShipDetails
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlPlanetDetails = new System.Windows.Forms.Panel();
            this.pnlRegion = new System.Windows.Forms.Panel();
            this.pcbRegionImage = new System.Windows.Forms.PictureBox();
            this.lblRegionDescriptionTitle = new System.Windows.Forms.Label();
            this.lblRegionName = new System.Windows.Forms.Label();
            this.lblRegionNameTitle = new System.Windows.Forms.Label();
            this.lblPlanetRoutesTitle = new System.Windows.Forms.Label();
            this.pcbPlanetImage = new System.Windows.Forms.PictureBox();
            this.lblNatives = new System.Windows.Forms.Label();
            this.lblNativesTitle = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLatitudeTitle = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLongitudeTitle = new System.Windows.Forms.Label();
            this.lblPlanetFiliation = new System.Windows.Forms.Label();
            this.lblPlanetFiliationTitle = new System.Windows.Forms.Label();
            this.lblPlanetSector = new System.Windows.Forms.Label();
            this.lblPlanetSectorTitle = new System.Windows.Forms.Label();
            this.lblPlanetName = new System.Windows.Forms.Label();
            this.lblPlanetNameTitle = new System.Windows.Forms.Label();
            this.lbxPlanetRoutes = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbRegionDescription = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlPlanetDetails.SuspendLayout();
            this.pnlRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlanetImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 1056);
            this.panel1.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.pnlRegion);
            this.panel6.Controls.Add(this.pnlPlanetDetails);
            this.panel6.Controls.Add(this.treeView1);
            this.panel6.Controls.Add(this.cbxCategories);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(14, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1103, 1026);
            this.panel6.TabIndex = 6;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // pnlPlanetDetails
            // 
            this.pnlPlanetDetails.Controls.Add(this.lblPlanetRoutesTitle);
            this.pnlPlanetDetails.Controls.Add(this.pcbPlanetImage);
            this.pnlPlanetDetails.Controls.Add(this.lblNatives);
            this.pnlPlanetDetails.Controls.Add(this.lblNativesTitle);
            this.pnlPlanetDetails.Controls.Add(this.lblLatitude);
            this.pnlPlanetDetails.Controls.Add(this.lblLatitudeTitle);
            this.pnlPlanetDetails.Controls.Add(this.lblLongitude);
            this.pnlPlanetDetails.Controls.Add(this.lblLongitudeTitle);
            this.pnlPlanetDetails.Controls.Add(this.lblPlanetFiliation);
            this.pnlPlanetDetails.Controls.Add(this.lblPlanetFiliationTitle);
            this.pnlPlanetDetails.Controls.Add(this.lblPlanetSector);
            this.pnlPlanetDetails.Controls.Add(this.lblPlanetSectorTitle);
            this.pnlPlanetDetails.Controls.Add(this.lblPlanetName);
            this.pnlPlanetDetails.Controls.Add(this.lblPlanetNameTitle);
            this.pnlPlanetDetails.Controls.Add(this.lbxPlanetRoutes);
            this.pnlPlanetDetails.Location = new System.Drawing.Point(463, 146);
            this.pnlPlanetDetails.Name = "pnlPlanetDetails";
            this.pnlPlanetDetails.Size = new System.Drawing.Size(583, 567);
            this.pnlPlanetDetails.TabIndex = 30;
            this.pnlPlanetDetails.Visible = false;
            // 
            // pnlRegion
            // 
            this.pnlRegion.Controls.Add(this.txbRegionDescription);
            this.pnlRegion.Controls.Add(this.pcbRegionImage);
            this.pnlRegion.Controls.Add(this.lblRegionDescriptionTitle);
            this.pnlRegion.Controls.Add(this.lblRegionName);
            this.pnlRegion.Controls.Add(this.lblRegionNameTitle);
            this.pnlRegion.Location = new System.Drawing.Point(463, 149);
            this.pnlRegion.Name = "pnlRegion";
            this.pnlRegion.Size = new System.Drawing.Size(583, 567);
            this.pnlRegion.TabIndex = 31;
            this.pnlRegion.Visible = false;
            // 
            // pcbRegionImage
            // 
            this.pcbRegionImage.Location = new System.Drawing.Point(48, 366);
            this.pcbRegionImage.Name = "pcbRegionImage";
            this.pcbRegionImage.Size = new System.Drawing.Size(187, 173);
            this.pcbRegionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRegionImage.TabIndex = 29;
            this.pcbRegionImage.TabStop = false;
            // 
            // lblRegionDescriptionTitle
            // 
            this.lblRegionDescriptionTitle.AutoSize = true;
            this.lblRegionDescriptionTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegionDescriptionTitle.Location = new System.Drawing.Point(45, 129);
            this.lblRegionDescriptionTitle.Name = "lblRegionDescriptionTitle";
            this.lblRegionDescriptionTitle.Size = new System.Drawing.Size(83, 17);
            this.lblRegionDescriptionTitle.TabIndex = 19;
            this.lblRegionDescriptionTitle.Text = "Description:";
            // 
            // lblRegionName
            // 
            this.lblRegionName.AutoSize = true;
            this.lblRegionName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegionName.Location = new System.Drawing.Point(45, 83);
            this.lblRegionName.Name = "lblRegionName";
            this.lblRegionName.Size = new System.Drawing.Size(0, 17);
            this.lblRegionName.TabIndex = 18;
            // 
            // lblRegionNameTitle
            // 
            this.lblRegionNameTitle.AutoSize = true;
            this.lblRegionNameTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegionNameTitle.Location = new System.Drawing.Point(45, 51);
            this.lblRegionNameTitle.Name = "lblRegionNameTitle";
            this.lblRegionNameTitle.Size = new System.Drawing.Size(49, 17);
            this.lblRegionNameTitle.TabIndex = 17;
            this.lblRegionNameTitle.Text = "Name:";
            // 
            // lblPlanetRoutesTitle
            // 
            this.lblPlanetRoutesTitle.AutoSize = true;
            this.lblPlanetRoutesTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlanetRoutesTitle.Location = new System.Drawing.Point(274, 207);
            this.lblPlanetRoutesTitle.Name = "lblPlanetRoutesTitle";
            this.lblPlanetRoutesTitle.Size = new System.Drawing.Size(57, 17);
            this.lblPlanetRoutesTitle.TabIndex = 30;
            this.lblPlanetRoutesTitle.Text = "Routes:";
            // 
            // pcbPlanetImage
            // 
            this.pcbPlanetImage.Location = new System.Drawing.Point(48, 366);
            this.pcbPlanetImage.Name = "pcbPlanetImage";
            this.pcbPlanetImage.Size = new System.Drawing.Size(187, 173);
            this.pcbPlanetImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPlanetImage.TabIndex = 29;
            this.pcbPlanetImage.TabStop = false;
            // 
            // lblNatives
            // 
            this.lblNatives.AutoSize = true;
            this.lblNatives.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNatives.Location = new System.Drawing.Point(274, 161);
            this.lblNatives.Name = "lblNatives";
            this.lblNatives.Size = new System.Drawing.Size(0, 17);
            this.lblNatives.TabIndex = 28;
            // 
            // lblNativesTitle
            // 
            this.lblNativesTitle.AutoSize = true;
            this.lblNativesTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNativesTitle.Location = new System.Drawing.Point(274, 129);
            this.lblNativesTitle.Name = "lblNativesTitle";
            this.lblNativesTitle.Size = new System.Drawing.Size(59, 17);
            this.lblNativesTitle.TabIndex = 27;
            this.lblNativesTitle.Text = "Natives:";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLatitude.Location = new System.Drawing.Point(274, 83);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(0, 17);
            this.lblLatitude.TabIndex = 26;
            // 
            // lblLatitudeTitle
            // 
            this.lblLatitudeTitle.AutoSize = true;
            this.lblLatitudeTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLatitudeTitle.Location = new System.Drawing.Point(274, 51);
            this.lblLatitudeTitle.Name = "lblLatitudeTitle";
            this.lblLatitudeTitle.Size = new System.Drawing.Size(63, 17);
            this.lblLatitudeTitle.TabIndex = 25;
            this.lblLatitudeTitle.Text = "Latitude:";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLongitude.Location = new System.Drawing.Point(45, 316);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(0, 17);
            this.lblLongitude.TabIndex = 24;
            // 
            // lblLongitudeTitle
            // 
            this.lblLongitudeTitle.AutoSize = true;
            this.lblLongitudeTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLongitudeTitle.Location = new System.Drawing.Point(45, 284);
            this.lblLongitudeTitle.Name = "lblLongitudeTitle";
            this.lblLongitudeTitle.Size = new System.Drawing.Size(75, 17);
            this.lblLongitudeTitle.TabIndex = 23;
            this.lblLongitudeTitle.Text = "Longitude:";
            // 
            // lblPlanetFiliation
            // 
            this.lblPlanetFiliation.AutoSize = true;
            this.lblPlanetFiliation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlanetFiliation.Location = new System.Drawing.Point(45, 239);
            this.lblPlanetFiliation.Name = "lblPlanetFiliation";
            this.lblPlanetFiliation.Size = new System.Drawing.Size(0, 17);
            this.lblPlanetFiliation.TabIndex = 22;
            // 
            // lblPlanetFiliationTitle
            // 
            this.lblPlanetFiliationTitle.AutoSize = true;
            this.lblPlanetFiliationTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlanetFiliationTitle.Location = new System.Drawing.Point(45, 207);
            this.lblPlanetFiliationTitle.Name = "lblPlanetFiliationTitle";
            this.lblPlanetFiliationTitle.Size = new System.Drawing.Size(60, 17);
            this.lblPlanetFiliationTitle.TabIndex = 21;
            this.lblPlanetFiliationTitle.Text = "Filiation:";
            // 
            // lblPlanetSector
            // 
            this.lblPlanetSector.AutoSize = true;
            this.lblPlanetSector.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlanetSector.Location = new System.Drawing.Point(45, 161);
            this.lblPlanetSector.Name = "lblPlanetSector";
            this.lblPlanetSector.Size = new System.Drawing.Size(0, 17);
            this.lblPlanetSector.TabIndex = 20;
            // 
            // lblPlanetSectorTitle
            // 
            this.lblPlanetSectorTitle.AutoSize = true;
            this.lblPlanetSectorTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlanetSectorTitle.Location = new System.Drawing.Point(45, 129);
            this.lblPlanetSectorTitle.Name = "lblPlanetSectorTitle";
            this.lblPlanetSectorTitle.Size = new System.Drawing.Size(53, 17);
            this.lblPlanetSectorTitle.TabIndex = 19;
            this.lblPlanetSectorTitle.Text = "Sector:";
            // 
            // lblPlanetName
            // 
            this.lblPlanetName.AutoSize = true;
            this.lblPlanetName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlanetName.Location = new System.Drawing.Point(45, 83);
            this.lblPlanetName.Name = "lblPlanetName";
            this.lblPlanetName.Size = new System.Drawing.Size(0, 17);
            this.lblPlanetName.TabIndex = 18;
            // 
            // lblPlanetNameTitle
            // 
            this.lblPlanetNameTitle.AutoSize = true;
            this.lblPlanetNameTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlanetNameTitle.Location = new System.Drawing.Point(45, 51);
            this.lblPlanetNameTitle.Name = "lblPlanetNameTitle";
            this.lblPlanetNameTitle.Size = new System.Drawing.Size(49, 17);
            this.lblPlanetNameTitle.TabIndex = 17;
            this.lblPlanetNameTitle.Text = "Name:";
            // 
            // lbxPlanetRoutes
            // 
            this.lbxPlanetRoutes.FormattingEnabled = true;
            this.lbxPlanetRoutes.ItemHeight = 16;
            this.lbxPlanetRoutes.Location = new System.Drawing.Point(277, 233);
            this.lbxPlanetRoutes.Name = "lbxPlanetRoutes";
            this.lbxPlanetRoutes.Size = new System.Drawing.Size(227, 100);
            this.lbxPlanetRoutes.TabIndex = 15;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(70, 227);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(229, 238);
            this.treeView1.TabIndex = 14;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // cbxCategories
            // 
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(70, 115);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(229, 24);
            this.cbxCategories.TabIndex = 12;
            this.cbxCategories.SelectedValueChanged += new System.EventHandler(this.cbxCategories_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1101, 88);
            this.label11.TabIndex = 11;
            this.label11.Text = "SPACESHIP DETAILS";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbRegionDescription
            // 
            this.txbRegionDescription.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbRegionDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbRegionDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbRegionDescription.Location = new System.Drawing.Point(48, 158);
            this.txbRegionDescription.Multiline = true;
            this.txbRegionDescription.Name = "txbRegionDescription";
            this.txbRegionDescription.ReadOnly = true;
            this.txbRegionDescription.Size = new System.Drawing.Size(475, 158);
            this.txbRegionDescription.TabIndex = 30;
            // 
            // SpaceShipDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "SpaceShipDetails";
            this.Size = new System.Drawing.Size(1135, 1056);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pnlPlanetDetails.ResumeLayout(false);
            this.pnlPlanetDetails.PerformLayout();
            this.pnlRegion.ResumeLayout(false);
            this.pnlRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlanetImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox lbxPlanetRoutes;
        private System.Windows.Forms.Label lblNatives;
        private System.Windows.Forms.Label lblNativesTitle;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLatitudeTitle;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLongitudeTitle;
        private System.Windows.Forms.Label lblPlanetFiliation;
        private System.Windows.Forms.Label lblPlanetFiliationTitle;
        private System.Windows.Forms.Label lblPlanetSector;
        private System.Windows.Forms.Label lblPlanetSectorTitle;
        private System.Windows.Forms.Label lblPlanetName;
        private System.Windows.Forms.Label lblPlanetNameTitle;
        private System.Windows.Forms.PictureBox pcbPlanetImage;
        private System.Windows.Forms.Panel pnlPlanetDetails;
        private System.Windows.Forms.Label lblPlanetRoutesTitle;
        private System.Windows.Forms.Panel pnlRegion;
        private System.Windows.Forms.PictureBox pcbRegionImage;
        private System.Windows.Forms.Label lblRegionDescriptionTitle;
        private System.Windows.Forms.Label lblRegionName;
        private System.Windows.Forms.Label lblRegionNameTitle;
        private System.Windows.Forms.TextBox txbRegionDescription;
    }
}
