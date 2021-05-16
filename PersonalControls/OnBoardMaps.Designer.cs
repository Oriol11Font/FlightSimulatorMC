namespace PersonalControls
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBackward = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pcbMini1 = new System.Windows.Forms.PictureBox();
            this.pcbMini2 = new System.Windows.Forms.PictureBox();
            this.pcbMini3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMini1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMini2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMini3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // pcbMini1
            // 
            this.pcbMini1.Location = new System.Drawing.Point(118, 452);
            this.pcbMini1.Name = "pcbMini1";
            this.pcbMini1.Size = new System.Drawing.Size(80, 80);
            this.pcbMini1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMini1.TabIndex = 5;
            this.pcbMini1.TabStop = false;
            // 
            // pcbMini2
            // 
            this.pcbMini2.Location = new System.Drawing.Point(237, 432);
            this.pcbMini2.Name = "pcbMini2";
            this.pcbMini2.Size = new System.Drawing.Size(100, 100);
            this.pcbMini2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMini2.TabIndex = 6;
            this.pcbMini2.TabStop = false;
            // 
            // pcbMini3
            // 
            this.pcbMini3.Location = new System.Drawing.Point(381, 452);
            this.pcbMini3.Name = "pcbMini3";
            this.pcbMini3.Size = new System.Drawing.Size(80, 80);
            this.pcbMini3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMini3.TabIndex = 7;
            this.pcbMini3.TabStop = false;
            // 
            // OnBoardMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.pcbMini3);
            this.Controls.Add(this.pcbMini2);
            this.Controls.Add(this.pcbMini1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OnBoardMaps";
            this.Size = new System.Drawing.Size(583, 567);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMini1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMini2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMini3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pcbMini1;
        private System.Windows.Forms.PictureBox pcbMini2;
        private System.Windows.Forms.PictureBox pcbMini3;
    }
}
