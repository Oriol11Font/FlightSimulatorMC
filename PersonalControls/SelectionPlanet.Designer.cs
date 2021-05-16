
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
            this.panel_selectplanet = new System.Windows.Forms.Panel();
            this.mapa1 = new PersonalControls.Mapa();
            this.btn_calc_vector = new System.Windows.Forms.Button();
            this.gpb_route = new System.Windows.Forms.GroupBox();
            this.pb_route_image = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_route_end = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_route_start = new System.Windows.Forms.Label();
            this.lbl_route_type = new System.Windows.Forms.Label();
            this.lbl_route_name = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpb_planet = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_sector = new System.Windows.Forms.Label();
            this.pb_planet_image = new System.Windows.Forms.PictureBox();
            this.lbl_natives = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_filiation = new System.Windows.Forms.Label();
            this.lbl_situation = new System.Windows.Forms.Label();
            this.lb_routes = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_destination_planet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_origin_planet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_selectplanet.SuspendLayout();
            this.gpb_route.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pb_route_image)).BeginInit();
            this.gpb_planet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pb_planet_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel_selectplanet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 1056);
            this.panel1.TabIndex = 8;
            // 
            // panel_selectplanet
            // 
            this.panel_selectplanet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_selectplanet.Controls.Add(this.mapa1);
            this.panel_selectplanet.Controls.Add(this.btn_calc_vector);
            this.panel_selectplanet.Controls.Add(this.gpb_route);
            this.panel_selectplanet.Controls.Add(this.gpb_planet);
            this.panel_selectplanet.Controls.Add(this.lb_routes);
            this.panel_selectplanet.Controls.Add(this.label11);
            this.panel_selectplanet.Controls.Add(this.cbx_destination_planet);
            this.panel_selectplanet.Controls.Add(this.label2);
            this.panel_selectplanet.Controls.Add(this.label1);
            this.panel_selectplanet.Controls.Add(this.cbx_origin_planet);
            this.panel_selectplanet.Controls.Add(this.label10);
            this.panel_selectplanet.Location = new System.Drawing.Point(40, 30);
            this.panel_selectplanet.Name = "panel_selectplanet";
            this.panel_selectplanet.Size = new System.Drawing.Size(1057, 995);
            this.panel_selectplanet.TabIndex = 6;
            // 
            // mapa1
            // 
            this.mapa1.ApproachVector = null;
            this.mapa1.DestinationPlanet = "";
            this.mapa1.DestinationVector = "asdasdasd";
            this.mapa1.Location = new System.Drawing.Point(208, 255);
            this.mapa1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapa1.Name = "mapa1";
            this.mapa1.Size = new System.Drawing.Size(588, 459);
            this.mapa1.TabIndex = 34;
            this.mapa1.Visible = false;
            // 
            // btn_calc_vector
            // 
            this.btn_calc_vector.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_calc_vector.Enabled = false;
            this.btn_calc_vector.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_calc_vector.ForeColor = System.Drawing.Color.White;
            this.btn_calc_vector.Location = new System.Drawing.Point(355, 813);
            this.btn_calc_vector.Name = "btn_calc_vector";
            this.btn_calc_vector.Size = new System.Drawing.Size(682, 165);
            this.btn_calc_vector.TabIndex = 33;
            this.btn_calc_vector.Text = "Calculate Vector";
            this.btn_calc_vector.UseVisualStyleBackColor = false;
            this.btn_calc_vector.Click += new System.EventHandler(this.btn_calc_vector_Click);
            // 
            // gpb_route
            // 
            this.gpb_route.Controls.Add(this.pb_route_image);
            this.gpb_route.Controls.Add(this.label13);
            this.gpb_route.Controls.Add(this.lbl_route_end);
            this.gpb_route.Controls.Add(this.label14);
            this.gpb_route.Controls.Add(this.lbl_route_start);
            this.gpb_route.Controls.Add(this.lbl_route_type);
            this.gpb_route.Controls.Add(this.lbl_route_name);
            this.gpb_route.Controls.Add(this.label12);
            this.gpb_route.Controls.Add(this.label4);
            this.gpb_route.ForeColor = System.Drawing.SystemColors.Control;
            this.gpb_route.Location = new System.Drawing.Point(355, 490);
            this.gpb_route.Name = "gpb_route";
            this.gpb_route.Size = new System.Drawing.Size(682, 304);
            this.gpb_route.TabIndex = 32;
            this.gpb_route.TabStop = false;
            this.gpb_route.Text = "Route";
            // 
            // pb_route_image
            // 
            this.pb_route_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_route_image.Location = new System.Drawing.Point(368, 26);
            this.pb_route_image.Name = "pb_route_image";
            this.pb_route_image.Size = new System.Drawing.Size(301, 263);
            this.pb_route_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_route_image.TabIndex = 28;
            this.pb_route_image.TabStop = false;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(15, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(334, 23);
            this.label13.TabIndex = 34;
            this.label13.Text = "End";
            this.label13.Visible = false;
            // 
            // lbl_route_end
            // 
            this.lbl_route_end.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_route_end.ForeColor = System.Drawing.Color.White;
            this.lbl_route_end.Location = new System.Drawing.Point(14, 241);
            this.lbl_route_end.Name = "lbl_route_end";
            this.lbl_route_end.Size = new System.Drawing.Size(332, 42);
            this.lbl_route_end.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(15, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(334, 23);
            this.label14.TabIndex = 32;
            this.label14.Text = "Start";
            this.label14.Visible = false;
            // 
            // lbl_route_start
            // 
            this.lbl_route_start.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_route_start.ForeColor = System.Drawing.Color.White;
            this.lbl_route_start.Location = new System.Drawing.Point(14, 179);
            this.lbl_route_start.Name = "lbl_route_start";
            this.lbl_route_start.Size = new System.Drawing.Size(332, 42);
            this.lbl_route_start.TabIndex = 31;
            // 
            // lbl_route_type
            // 
            this.lbl_route_type.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_route_type.ForeColor = System.Drawing.Color.White;
            this.lbl_route_type.Location = new System.Drawing.Point(14, 114);
            this.lbl_route_type.Name = "lbl_route_type";
            this.lbl_route_type.Size = new System.Drawing.Size(332, 42);
            this.lbl_route_type.TabIndex = 30;
            // 
            // lbl_route_name
            // 
            this.lbl_route_name.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_route_name.ForeColor = System.Drawing.Color.White;
            this.lbl_route_name.Location = new System.Drawing.Point(15, 49);
            this.lbl_route_name.Name = "lbl_route_name";
            this.lbl_route_name.Size = new System.Drawing.Size(332, 42);
            this.lbl_route_name.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(334, 23);
            this.label12.TabIndex = 29;
            this.label12.Text = "Type";
            this.label12.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Name";
            this.label4.Visible = false;
            // 
            // gpb_planet
            // 
            this.gpb_planet.Controls.Add(this.label3);
            this.gpb_planet.Controls.Add(this.lbl_name);
            this.gpb_planet.Controls.Add(this.label5);
            this.gpb_planet.Controls.Add(this.lbl_sector);
            this.gpb_planet.Controls.Add(this.pb_planet_image);
            this.gpb_planet.Controls.Add(this.lbl_natives);
            this.gpb_planet.Controls.Add(this.label8);
            this.gpb_planet.Controls.Add(this.label6);
            this.gpb_planet.Controls.Add(this.label7);
            this.gpb_planet.Controls.Add(this.lbl_filiation);
            this.gpb_planet.Controls.Add(this.lbl_situation);
            this.gpb_planet.ForeColor = System.Drawing.SystemColors.Control;
            this.gpb_planet.Location = new System.Drawing.Point(355, 113);
            this.gpb_planet.Name = "gpb_planet";
            this.gpb_planet.Size = new System.Drawing.Size(682, 360);
            this.gpb_planet.TabIndex = 31;
            this.gpb_planet.TabStop = false;
            this.gpb_planet.Text = "Planet";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name";
            this.label3.Visible = false;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(14, 50);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(332, 42);
            this.lbl_name.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sector";
            this.label5.Visible = false;
            // 
            // lbl_sector
            // 
            this.lbl_sector.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_sector.ForeColor = System.Drawing.Color.White;
            this.lbl_sector.Location = new System.Drawing.Point(14, 115);
            this.lbl_sector.Name = "lbl_sector";
            this.lbl_sector.Size = new System.Drawing.Size(332, 42);
            this.lbl_sector.TabIndex = 20;
            // 
            // pb_planet_image
            // 
            this.pb_planet_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_planet_image.Location = new System.Drawing.Point(368, 21);
            this.pb_planet_image.Name = "pb_planet_image";
            this.pb_planet_image.Size = new System.Drawing.Size(301, 326);
            this.pb_planet_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_planet_image.TabIndex = 16;
            this.pb_planet_image.TabStop = false;
            // 
            // lbl_natives
            // 
            this.lbl_natives.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_natives.ForeColor = System.Drawing.Color.White;
            this.lbl_natives.Location = new System.Drawing.Point(14, 310);
            this.lbl_natives.Name = "lbl_natives";
            this.lbl_natives.Size = new System.Drawing.Size(332, 42);
            this.lbl_natives.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Filiation";
            this.label8.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Natives";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Situation";
            this.label7.Visible = false;
            // 
            // lbl_filiation
            // 
            this.lbl_filiation.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_filiation.ForeColor = System.Drawing.Color.White;
            this.lbl_filiation.Location = new System.Drawing.Point(15, 180);
            this.lbl_filiation.Name = "lbl_filiation";
            this.lbl_filiation.Size = new System.Drawing.Size(332, 42);
            this.lbl_filiation.TabIndex = 25;
            // 
            // lbl_situation
            // 
            this.lbl_situation.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_situation.ForeColor = System.Drawing.Color.White;
            this.lbl_situation.Location = new System.Drawing.Point(15, 245);
            this.lbl_situation.Name = "lbl_situation";
            this.lbl_situation.Size = new System.Drawing.Size(332, 42);
            this.lbl_situation.TabIndex = 24;
            // 
            // lb_routes
            // 
            this.lb_routes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_routes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_routes.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lb_routes.ForeColor = System.Drawing.Color.White;
            this.lb_routes.FormattingEnabled = true;
            this.lb_routes.ItemHeight = 25;
            this.lb_routes.Location = new System.Drawing.Point(19, 374);
            this.lb_routes.Name = "lb_routes";
            this.lb_routes.Size = new System.Drawing.Size(319, 100);
            this.lb_routes.TabIndex = 30;
            this.lb_routes.SelectedValueChanged += new System.EventHandler(this.lb_routes_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(319, 23);
            this.label11.TabIndex = 28;
            this.label11.Text = "Routes";
            this.label11.Visible = false;
            // 
            // cbx_destination_planet
            // 
            this.cbx_destination_planet.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cbx_destination_planet.FormattingEnabled = true;
            this.cbx_destination_planet.Location = new System.Drawing.Point(18, 255);
            this.cbx_destination_planet.Name = "cbx_destination_planet";
            this.cbx_destination_planet.Size = new System.Drawing.Size(320, 40);
            this.cbx_destination_planet.TabIndex = 15;
            this.cbx_destination_planet.SelectionChangeCommitted += new System.EventHandler(this.cbx_planets_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 36);
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
            this.label1.Size = new System.Drawing.Size(330, 35);
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
            this.cbx_origin_planet.Size = new System.Drawing.Size(319, 40);
            this.cbx_origin_planet.TabIndex = 12;
            this.cbx_origin_planet.SelectionChangeCommitted += new System.EventHandler(this.cbx_origin_planet_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1057, 110);
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
            this.panel_selectplanet.ResumeLayout(false);
            this.gpb_route.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pb_route_image)).EndInit();
            this.gpb_planet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pb_planet_image)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel_selectplanet;

        private System.Windows.Forms.Button btn_calc_vector;

        private System.Windows.Forms.PictureBox pb_route_image;

        private System.Windows.Forms.Label lbl_route_name;
        private System.Windows.Forms.Label lbl_route_type;
        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.GroupBox gpb_route;

        private System.Windows.Forms.GroupBox gpb_planet;

        private System.Windows.Forms.ListBox lb_routes;

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
        private System.Windows.Forms.Label lbl_route_start;
        private System.Windows.Forms.Label lbl_route_end;
        
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private PersonalControls.Mapa mapa1;
    }
}
