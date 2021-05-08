using System.ComponentModel;

namespace PersonalControls
{
    partial class Mapa
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pb_background)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_background
            // 
            this.pb_background.Location = new System.Drawing.Point(0, 0);
            this.pb_background.Name = "pb_background";
            this.pb_background.Size = new System.Drawing.Size(851, 540);
            this.pb_background.TabIndex = 0;
            this.pb_background.TabStop = false;
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_background);
            this.Name = "Mapa";
            this.Size = new System.Drawing.Size(851, 543);
            ((System.ComponentModel.ISupportInitialize) (this.pb_background)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pb_background;

        #endregion
    }
}