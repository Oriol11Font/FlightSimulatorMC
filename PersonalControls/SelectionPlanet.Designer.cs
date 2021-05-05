
using System;
using System.Windows.Forms;

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
            this.lb_routes = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_natives = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_filiation = new System.Windows.Forms.Label();
            this.lbl_situation = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_sector = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_planet_image = new System.Windows.Forms.PictureBox();
            this.cbx_destination_planet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_origin_planet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pb_planet_image)).BeginInit();
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
            this.panel7.Controls.Add(this.lb_routes);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.lbl_natives);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.lbl_filiation);
            this.panel7.Controls.Add(this.lbl_situation);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.lbl_sector);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.lbl_name);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.pb_planet_image);
            this.panel7.Controls.Add(this.cbx_destination_planet);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.cbx_origin_planet);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(40, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1057, 995);
            this.panel7.TabIndex = 6;
            // 
            // lb_routes
            // 
            this.lb_routes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_routes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_routes.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lb_routes.ForeColor = System.Drawing.Color.White;
            this.lb_routes.FormattingEnabled = true;
            this.lb_routes.ItemHeight = 25;
            this.lb_routes.Location = new System.Drawing.Point(21, 669);
            this.lb_routes.Name = "lb_routes";
            this.lb_routes.Size = new System.Drawing.Size(373, 75);
            this.lb_routes.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(18, 666);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(373, 42);
            this.label9.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 643);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(375, 23);
            this.label11.TabIndex = 28;
            this.label11.Text = "Routes";
            this.label11.Visible = false;
            // 
            // lbl_natives
            // 
            this.lbl_natives.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_natives.ForeColor = System.Drawing.Color.White;
            this.lbl_natives.Location = new System.Drawing.Point(18, 601);
            this.lbl_natives.Name = "lbl_natives";
            this.lbl_natives.Size = new System.Drawing.Size(373, 42);
            this.lbl_natives.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(375, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Natives";
            this.label6.Visible = false;
            // 
            // lbl_filiation
            // 
            this.lbl_filiation.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_filiation.ForeColor = System.Drawing.Color.White;
            this.lbl_filiation.Location = new System.Drawing.Point(19, 471);
            this.lbl_filiation.Name = "lbl_filiation";
            this.lbl_filiation.Size = new System.Drawing.Size(373, 42);
            this.lbl_filiation.TabIndex = 25;
            // 
            // lbl_situation
            // 
            this.lbl_situation.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_situation.ForeColor = System.Drawing.Color.White;
            this.lbl_situation.Location = new System.Drawing.Point(19, 536);
            this.lbl_situation.Name = "lbl_situation";
            this.lbl_situation.Size = new System.Drawing.Size(373, 42);
            this.lbl_situation.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 513);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Situation";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(375, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Filiation";
            this.label8.Visible = false;
            // 
            // lbl_sector
            // 
            this.lbl_sector.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_sector.ForeColor = System.Drawing.Color.White;
            this.lbl_sector.Location = new System.Drawing.Point(18, 406);
            this.lbl_sector.Name = "lbl_sector";
            this.lbl_sector.Size = new System.Drawing.Size(373, 42);
            this.lbl_sector.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(375, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sector";
            this.label5.Visible = false;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(18, 341);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(373, 42);
            this.lbl_name.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name";
            this.label3.Visible = false;
            // 
            // pb_planet_image
            // 
            this.pb_planet_image.Location = new System.Drawing.Point(413, 126);
            this.pb_planet_image.Name = "pb_planet_image";
            this.pb_planet_image.Size = new System.Drawing.Size(615, 837);
            this.pb_planet_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_planet_image.TabIndex = 16;
            this.pb_planet_image.TabStop = false;
            // 
            // cbx_destination_planet
            // 
            this.cbx_destination_planet.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cbx_destination_planet.FormattingEnabled = true;
            this.cbx_destination_planet.Location = new System.Drawing.Point(18, 255);
            this.cbx_destination_planet.Name = "cbx_destination_planet";
            this.cbx_destination_planet.Size = new System.Drawing.Size(375, 40);
            this.cbx_destination_planet.TabIndex = 15;
            this.cbx_destination_planet.SelectionChangeCommitted += new System.EventHandler(this.cbx_planets_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Destination";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Origin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx_origin_planet
            // 
            this.cbx_origin_planet.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cbx_origin_planet.FormattingEnabled = true;
            this.cbx_origin_planet.Location = new System.Drawing.Point(19, 164);
            this.cbx_origin_planet.Name = "cbx_origin_planet";
            this.cbx_origin_planet.Size = new System.Drawing.Size(374, 40);
            this.cbx_origin_planet.TabIndex = 12;
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
            ((System.ComponentModel.ISupportInitialize) (this.pb_planet_image)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lb_routes;

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label lbl_name;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.PictureBox pb_planet_image;

        private System.Windows.Forms.ComboBox cbx_destination_planet;
        private System.Windows.Forms.ComboBox cbx_origin_planet;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label lbl_sector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_filiation;
        private System.Windows.Forms.Label lbl_situation;
        private System.Windows.Forms.Label lbl_natives;
        
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
    }
}
