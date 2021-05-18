namespace FlightControlScreens
{
    partial class OnBoardRoutes
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
            this.pnlRoute = new System.Windows.Forms.Panel();
            this.lblRouteStart = new System.Windows.Forms.Label();
            this.lblRouteStartTitle = new System.Windows.Forms.Label();
            this.lblRouteEnd = new System.Windows.Forms.Label();
            this.lblRouteEndTitle = new System.Windows.Forms.Label();
            this.lblRouteType = new System.Windows.Forms.Label();
            this.lblRouteTypeTitle = new System.Windows.Forms.Label();
            this.pcbRoute = new System.Windows.Forms.PictureBox();
            this.lblRouteName = new System.Windows.Forms.Label();
            this.lblRouteNameTitle = new System.Windows.Forms.Label();
            this.pnlRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRoute
            // 
            this.pnlRoute.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlRoute.Controls.Add(this.lblRouteStart);
            this.pnlRoute.Controls.Add(this.lblRouteStartTitle);
            this.pnlRoute.Controls.Add(this.lblRouteEnd);
            this.pnlRoute.Controls.Add(this.lblRouteEndTitle);
            this.pnlRoute.Controls.Add(this.lblRouteType);
            this.pnlRoute.Controls.Add(this.lblRouteTypeTitle);
            this.pnlRoute.Controls.Add(this.pcbRoute);
            this.pnlRoute.Controls.Add(this.lblRouteName);
            this.pnlRoute.Controls.Add(this.lblRouteNameTitle);
            this.pnlRoute.Location = new System.Drawing.Point(0, 0);
            this.pnlRoute.Name = "pnlRoute";
            this.pnlRoute.Size = new System.Drawing.Size(583, 567);
            this.pnlRoute.TabIndex = 33;
            this.pnlRoute.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRoute_Paint);
            // 
            // lblRouteStart
            // 
            this.lblRouteStart.AutoSize = true;
            this.lblRouteStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRouteStart.Location = new System.Drawing.Point(282, 83);
            this.lblRouteStart.Name = "lblRouteStart";
            this.lblRouteStart.Size = new System.Drawing.Size(0, 17);
            this.lblRouteStart.TabIndex = 35;
            // 
            // lblRouteStartTitle
            // 
            this.lblRouteStartTitle.AutoSize = true;
            this.lblRouteStartTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRouteStartTitle.Location = new System.Drawing.Point(282, 51);
            this.lblRouteStartTitle.Name = "lblRouteStartTitle";
            this.lblRouteStartTitle.Size = new System.Drawing.Size(42, 17);
            this.lblRouteStartTitle.TabIndex = 34;
            this.lblRouteStartTitle.Text = "Start:";
            // 
            // lblRouteEnd
            // 
            this.lblRouteEnd.AutoSize = true;
            this.lblRouteEnd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRouteEnd.Location = new System.Drawing.Point(282, 178);
            this.lblRouteEnd.Name = "lblRouteEnd";
            this.lblRouteEnd.Size = new System.Drawing.Size(0, 17);
            this.lblRouteEnd.TabIndex = 33;
            // 
            // lblRouteEndTitle
            // 
            this.lblRouteEndTitle.AutoSize = true;
            this.lblRouteEndTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRouteEndTitle.Location = new System.Drawing.Point(282, 151);
            this.lblRouteEndTitle.Name = "lblRouteEndTitle";
            this.lblRouteEndTitle.Size = new System.Drawing.Size(37, 17);
            this.lblRouteEndTitle.TabIndex = 32;
            this.lblRouteEndTitle.Text = "End:";
            // 
            // lblRouteType
            // 
            this.lblRouteType.AutoSize = true;
            this.lblRouteType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRouteType.Location = new System.Drawing.Point(49, 83);
            this.lblRouteType.Name = "lblRouteType";
            this.lblRouteType.Size = new System.Drawing.Size(0, 17);
            this.lblRouteType.TabIndex = 31;
            // 
            // lblRouteTypeTitle
            // 
            this.lblRouteTypeTitle.AutoSize = true;
            this.lblRouteTypeTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRouteTypeTitle.Location = new System.Drawing.Point(49, 51);
            this.lblRouteTypeTitle.Name = "lblRouteTypeTitle";
            this.lblRouteTypeTitle.Size = new System.Drawing.Size(44, 17);
            this.lblRouteTypeTitle.TabIndex = 30;
            this.lblRouteTypeTitle.Text = "Type:";
            // 
            // pcbRoute
            // 
            this.pcbRoute.Location = new System.Drawing.Point(32, 255);
            this.pcbRoute.Name = "pcbRoute";
            this.pcbRoute.Size = new System.Drawing.Size(516, 283);
            this.pcbRoute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRoute.TabIndex = 29;
            this.pcbRoute.TabStop = false;
            // 
            // lblRouteName
            // 
            this.lblRouteName.AutoSize = true;
            this.lblRouteName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRouteName.Location = new System.Drawing.Point(49, 178);
            this.lblRouteName.Name = "lblRouteName";
            this.lblRouteName.Size = new System.Drawing.Size(0, 17);
            this.lblRouteName.TabIndex = 18;
            // 
            // lblRouteNameTitle
            // 
            this.lblRouteNameTitle.AutoSize = true;
            this.lblRouteNameTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRouteNameTitle.Location = new System.Drawing.Point(49, 151);
            this.lblRouteNameTitle.Name = "lblRouteNameTitle";
            this.lblRouteNameTitle.Size = new System.Drawing.Size(49, 17);
            this.lblRouteNameTitle.TabIndex = 17;
            this.lblRouteNameTitle.Text = "Name:";
            // 
            // OnBoardRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRoute);
            this.Name = "OnBoardRoutes";
            this.Size = new System.Drawing.Size(582, 562);
            this.pnlRoute.ResumeLayout(false);
            this.pnlRoute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRoute;
        private System.Windows.Forms.PictureBox pcbRoute;
        private System.Windows.Forms.Label lblRouteName;
        private System.Windows.Forms.Label lblRouteNameTitle;
        private System.Windows.Forms.Label lblRouteStart;
        private System.Windows.Forms.Label lblRouteStartTitle;
        private System.Windows.Forms.Label lblRouteEnd;
        private System.Windows.Forms.Label lblRouteEndTitle;
        private System.Windows.Forms.Label lblRouteType;
        private System.Windows.Forms.Label lblRouteTypeTitle;
    }
}
