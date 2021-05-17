namespace FlightControlScreens
{
    partial class OnBoardMaps
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
            this.pcbSelectedImage = new System.Windows.Forms.PictureBox();
            this.btnBackward = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pcbLeftImage = new System.Windows.Forms.PictureBox();
            this.pcbMiddleImage = new System.Windows.Forms.PictureBox();
            this.pcbRightImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSelectedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLeftImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMiddleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRightImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbSelectedImage
            // 
            this.pcbSelectedImage.Location = new System.Drawing.Point(3, 0);
            this.pcbSelectedImage.Name = "pcbSelectedImage";
            this.pcbSelectedImage.Size = new System.Drawing.Size(580, 336);
            this.pcbSelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSelectedImage.TabIndex = 0;
            this.pcbSelectedImage.TabStop = false;
            // 
            // btnBackward
            // 
            this.btnBackward.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackward.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackward.Location = new System.Drawing.Point(16, 452);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(70, 70);
            this.btnBackward.TabIndex = 3;
            this.btnBackward.Text = "<";
            this.btnBackward.UseVisualStyleBackColor = false;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(496, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcbLeftImage
            // 
            this.pcbLeftImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbLeftImage.Location = new System.Drawing.Point(118, 452);
            this.pcbLeftImage.Name = "pcbLeftImage";
            this.pcbLeftImage.Size = new System.Drawing.Size(80, 80);
            this.pcbLeftImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLeftImage.TabIndex = 5;
            this.pcbLeftImage.TabStop = false;
            // 
            // pcbMiddleImage
            // 
            this.pcbMiddleImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbMiddleImage.Location = new System.Drawing.Point(237, 432);
            this.pcbMiddleImage.Name = "pcbMiddleImage";
            this.pcbMiddleImage.Size = new System.Drawing.Size(100, 100);
            this.pcbMiddleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMiddleImage.TabIndex = 6;
            this.pcbMiddleImage.TabStop = false;
            // 
            // pcbRightImage
            // 
            this.pcbRightImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbRightImage.Location = new System.Drawing.Point(381, 452);
            this.pcbRightImage.Name = "pcbRightImage";
            this.pcbRightImage.Size = new System.Drawing.Size(80, 80);
            this.pcbRightImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRightImage.TabIndex = 7;
            this.pcbRightImage.TabStop = false;
            // 
            // OnBoardMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.pcbRightImage);
            this.Controls.Add(this.pcbMiddleImage);
            this.Controls.Add(this.pcbLeftImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.pcbSelectedImage);
            this.Name = "OnBoardMaps";
            this.Size = new System.Drawing.Size(583, 567);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSelectedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLeftImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMiddleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRightImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSelectedImage;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pcbLeftImage;
        private System.Windows.Forms.PictureBox pcbMiddleImage;
        private System.Windows.Forms.PictureBox pcbRightImage;
    }
}
