
using System;

namespace PersonalControls
{
    partial class SelectionPlanet
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pb_planet = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_planets = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pb_planet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 1056);
            this.panel1.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.pb_planet);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.cbx_planets);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(40, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1057, 995);
            this.panel7.TabIndex = 6;
            // 
            // pb_planet
            // 
            this.pb_planet.Location = new System.Drawing.Point(38, 202);
            this.pb_planet.Name = "pb_planet";
            this.pb_planet.Size = new System.Drawing.Size(441, 306);
            this.pb_planet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_planet.TabIndex = 14;
            this.pb_planet.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Origin:";
            // 
            // cbx_planets
            // 
            this.cbx_planets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cbx_planets.FormattingEnabled = true;
            this.cbx_planets.Location = new System.Drawing.Point(169, 142);
            this.cbx_planets.Name = "cbx_planets";
            this.cbx_planets.Size = new System.Drawing.Size(286, 37);
            this.cbx_planets.TabIndex = 12;
            this.cbx_planets.SelectionChangeCommitted += new System.EventHandler(this.cbx_planets_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1055, 110);
            this.label10.TabIndex = 11;
            this.label10.Text = "PLANETS AVAILABLE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectionPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "SelectionPlanet";
            this.Size = new System.Drawing.Size(1135, 1056);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pb_planet)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pb_planet;

        private System.Windows.Forms.ComboBox cbx_planets;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox comboBox1;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
    }
}
