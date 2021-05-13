
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
            this.pnlSelectedCategory = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRouteNameTitle = new System.Windows.Forms.Label();
            this.lblRouteName = new System.Windows.Forms.Label();
            this.lblRoutePlanetsTitle = new System.Windows.Forms.Label();
            this.pcbRoute = new System.Windows.Forms.PictureBox();
            this.lsbRoutePlanets = new System.Windows.Forms.ListBox();
            this.pnlRoute = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoute)).BeginInit();
            this.pnlRoute.SuspendLayout();
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
            this.panel6.Controls.Add(this.pnlRoute);
            this.panel6.Controls.Add(this.pnlSelectedCategory);
            this.panel6.Controls.Add(this.treeView1);
            this.panel6.Controls.Add(this.cbxCategories);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(12, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1103, 1026);
            this.panel6.TabIndex = 6;
            // 
            // pnlSelectedCategory
            // 
            this.pnlSelectedCategory.Location = new System.Drawing.Point(475, 129);
            this.pnlSelectedCategory.Name = "pnlSelectedCategory";
            this.pnlSelectedCategory.Size = new System.Drawing.Size(619, 591);
            this.pnlSelectedCategory.TabIndex = 15;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(70, 227);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(229, 238);
            this.treeView1.TabIndex = 14;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.HandleFormChange);
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
            // lblRouteNameTitle
            // 
            this.lblRouteNameTitle.AutoSize = true;
            this.lblRouteNameTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRouteNameTitle.Location = new System.Drawing.Point(45, 51);
            this.lblRouteNameTitle.Name = "lblRouteNameTitle";
            this.lblRouteNameTitle.Size = new System.Drawing.Size(49, 17);
            this.lblRouteNameTitle.TabIndex = 17;
            this.lblRouteNameTitle.Text = "Name:";
            // 
            // lblRouteName
            // 
            this.lblRouteName.AutoSize = true;
            this.lblRouteName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRouteName.Location = new System.Drawing.Point(45, 83);
            this.lblRouteName.Name = "lblRouteName";
            this.lblRouteName.Size = new System.Drawing.Size(0, 17);
            this.lblRouteName.TabIndex = 18;
            // 
            // lblRoutePlanetsTitle
            // 
            this.lblRoutePlanetsTitle.AutoSize = true;
            this.lblRoutePlanetsTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoutePlanetsTitle.Location = new System.Drawing.Point(45, 129);
            this.lblRoutePlanetsTitle.Name = "lblRoutePlanetsTitle";
            this.lblRoutePlanetsTitle.Size = new System.Drawing.Size(98, 17);
            this.lblRoutePlanetsTitle.TabIndex = 19;
            this.lblRoutePlanetsTitle.Text = "Planets within:";
            // 
            // pcbRoute
            // 
            this.pcbRoute.Location = new System.Drawing.Point(325, 322);
            this.pcbRoute.Name = "pcbRoute";
            this.pcbRoute.Size = new System.Drawing.Size(223, 216);
            this.pcbRoute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRoute.TabIndex = 29;
            this.pcbRoute.TabStop = false;
            // 
            // lsbRoutePlanets
            // 
            this.lsbRoutePlanets.FormattingEnabled = true;
            this.lsbRoutePlanets.ItemHeight = 16;
            this.lsbRoutePlanets.Location = new System.Drawing.Point(45, 166);
            this.lsbRoutePlanets.Name = "lsbRoutePlanets";
            this.lsbRoutePlanets.Size = new System.Drawing.Size(160, 244);
            this.lsbRoutePlanets.TabIndex = 30;
            // 
            // pnlRoute
            // 
            this.pnlRoute.Controls.Add(this.lsbRoutePlanets);
            this.pnlRoute.Controls.Add(this.pcbRoute);
            this.pnlRoute.Controls.Add(this.lblRoutePlanetsTitle);
            this.pnlRoute.Controls.Add(this.lblRouteName);
            this.pnlRoute.Controls.Add(this.lblRouteNameTitle);
            this.pnlRoute.Location = new System.Drawing.Point(-1, 115);
            this.pnlRoute.Name = "pnlRoute";
            this.pnlRoute.Size = new System.Drawing.Size(583, 567);
            this.pnlRoute.TabIndex = 32;
            this.pnlRoute.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoute)).EndInit();
            this.pnlRoute.ResumeLayout(false);
            this.pnlRoute.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel pnlSelectedCategory;
        private System.Windows.Forms.Panel pnlRoute;
        private System.Windows.Forms.ListBox lsbRoutePlanets;
        private System.Windows.Forms.PictureBox pcbRoute;
        private System.Windows.Forms.Label lblRoutePlanetsTitle;
        private System.Windows.Forms.Label lblRouteName;
        private System.Windows.Forms.Label lblRouteNameTitle;
    }
}
