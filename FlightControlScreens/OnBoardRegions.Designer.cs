namespace FlightControlScreens
{
    partial class OnBoardRegions
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
            this.pnlRegion = new System.Windows.Forms.Panel();
            this.txbRegionDescription = new System.Windows.Forms.TextBox();
            this.pcbRegionImage = new System.Windows.Forms.PictureBox();
            this.lblRegionDescriptionTitle = new System.Windows.Forms.Label();
            this.lblRegionName = new System.Windows.Forms.Label();
            this.lblRegionNameTitle = new System.Windows.Forms.Label();
            this.pnlRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegion
            // 
            this.pnlRegion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlRegion.Controls.Add(this.txbRegionDescription);
            this.pnlRegion.Controls.Add(this.pcbRegionImage);
            this.pnlRegion.Controls.Add(this.lblRegionDescriptionTitle);
            this.pnlRegion.Controls.Add(this.lblRegionName);
            this.pnlRegion.Controls.Add(this.lblRegionNameTitle);
            this.pnlRegion.Location = new System.Drawing.Point(0, 0);
            this.pnlRegion.Name = "pnlRegion";
            this.pnlRegion.Size = new System.Drawing.Size(583, 567);
            this.pnlRegion.TabIndex = 32;
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
            // pcbRegionImage
            // 
            this.pcbRegionImage.Location = new System.Drawing.Point(48, 347);
            this.pcbRegionImage.Name = "pcbRegionImage";
            this.pcbRegionImage.Size = new System.Drawing.Size(475, 192);
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
            // OnBoardRegions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRegion);
            this.Name = "OnBoardRegions";
            this.Size = new System.Drawing.Size(578, 565);
            this.pnlRegion.ResumeLayout(false);
            this.pnlRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRegionImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegion;
        private System.Windows.Forms.TextBox txbRegionDescription;
        private System.Windows.Forms.PictureBox pcbRegionImage;
        private System.Windows.Forms.Label lblRegionDescriptionTitle;
        private System.Windows.Forms.Label lblRegionName;
        private System.Windows.Forms.Label lblRegionNameTitle;
    }
}
