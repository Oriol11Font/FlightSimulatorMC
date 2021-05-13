
namespace PersonalControls
{
    partial class WeaponsSystem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponsSystem));
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Abort = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_misil = new System.Windows.Forms.Button();
            this.btn_laser = new System.Windows.Forms.Button();
            this.aimPanel = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.picture_SpaceShip = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.slider2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.slider1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reloadWeapons = new System.Windows.Forms.Timer(this.components);
            this.aimEnemy = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aimPanel)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_SpaceShip)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Start.Enabled = false;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Alien Encounters", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Start.Location = new System.Drawing.Point(0, 287);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(1135, 45);
            this.btn_Start.TabIndex = 8;
            this.btn_Start.Text = "DETECT SPACESHIP";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_load
            // 
            this.btn_load.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("Alien Encounters", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_load.Location = new System.Drawing.Point(0, 0);
            this.btn_load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(1135, 45);
            this.btn_load.TabIndex = 9;
            this.btn_load.Text = "LOAD WEAPON SYSTEM";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Abort);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.btn_Start);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_load);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 1056);
            this.panel1.TabIndex = 10;
            // 
            // btn_Abort
            // 
            this.btn_Abort.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Abort.Enabled = false;
            this.btn_Abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Abort.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abort.ForeColor = System.Drawing.Color.Red;
            this.btn_Abort.Location = new System.Drawing.Point(0, 898);
            this.btn_Abort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Abort.Name = "btn_Abort";
            this.btn_Abort.Size = new System.Drawing.Size(1135, 93);
            this.btn_Abort.TabIndex = 3;
            this.btn_Abort.Text = "ABORT";
            this.btn_Abort.UseVisualStyleBackColor = true;
            this.btn_Abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 569F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 332);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1135, 566);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.btn_misil);
            this.panel6.Controls.Add(this.btn_laser);
            this.panel6.Controls.Add(this.aimPanel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(572, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(560, 562);
            this.panel6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(0, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(560, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "FIRE!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // btn_misil
            // 
            this.btn_misil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_misil.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_misil.ForeColor = System.Drawing.Color.White;
            this.btn_misil.Location = new System.Drawing.Point(293, 441);
            this.btn_misil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_misil.Name = "btn_misil";
            this.btn_misil.Size = new System.Drawing.Size(244, 93);
            this.btn_misil.TabIndex = 2;
            this.btn_misil.Text = "MISIL SHOT";
            this.btn_misil.UseVisualStyleBackColor = true;
            this.btn_misil.Visible = false;
            this.btn_misil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_laser
            // 
            this.btn_laser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_laser.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laser.ForeColor = System.Drawing.Color.White;
            this.btn_laser.Location = new System.Drawing.Point(31, 441);
            this.btn_laser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_laser.Name = "btn_laser";
            this.btn_laser.Size = new System.Drawing.Size(257, 93);
            this.btn_laser.TabIndex = 1;
            this.btn_laser.Text = "LASER SHOT";
            this.btn_laser.UseVisualStyleBackColor = true;
            this.btn_laser.Visible = false;
            this.btn_laser.Click += new System.EventHandler(this.button1_Click);
            // 
            // aimPanel
            // 
            this.aimPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.aimPanel.Location = new System.Drawing.Point(0, 0);
            this.aimPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aimPanel.Name = "aimPanel";
            this.aimPanel.Size = new System.Drawing.Size(560, 387);
            this.aimPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aimPanel.TabIndex = 0;
            this.aimPanel.TabStop = false;
            this.aimPanel.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(563, 562);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(563, 34);
            this.label4.TabIndex = 2;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(563, 34);
            this.label3.TabIndex = 1;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(466, 471);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.picture_SpaceShip);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(563, 384);
            this.panel7.TabIndex = 5;
            // 
            // picture_SpaceShip
            // 
            this.picture_SpaceShip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_SpaceShip.Image = ((System.Drawing.Image)(resources.GetObject("picture_SpaceShip.Image")));
            this.picture_SpaceShip.Location = new System.Drawing.Point(0, 0);
            this.picture_SpaceShip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_SpaceShip.Name = "picture_SpaceShip";
            this.picture_SpaceShip.Size = new System.Drawing.Size(563, 384);
            this.picture_SpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_SpaceShip.TabIndex = 0;
            this.picture_SpaceShip.TabStop = false;
            this.picture_SpaceShip.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 242);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.slider2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 189);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1135, 34);
            this.panel4.TabIndex = 3;
            // 
            // slider2
            // 
            this.slider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.slider2.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider2.Location = new System.Drawing.Point(0, 0);
            this.slider2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slider2.Name = "slider2";
            this.slider2.Size = new System.Drawing.Size(0, 34);
            this.slider2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Alien Encounters", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1135, 81);
            this.label2.TabIndex = 1;
            this.label2.Text = "MISILE SYSTEM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.slider1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1135, 34);
            this.panel3.TabIndex = 2;
            // 
            // slider1
            // 
            this.slider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.slider1.Dock = System.Windows.Forms.DockStyle.Left;
            this.slider1.Location = new System.Drawing.Point(0, 0);
            this.slider1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(0, 34);
            this.slider1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Alien Encounters", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1135, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "LASER SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reloadWeapons
            // 
            this.reloadWeapons.Tick += new System.EventHandler(this.reloadWeapons_Tick);
            // 
            // aimEnemy
            // 
            this.aimEnemy.Interval = 3000;
            this.aimEnemy.Tick += new System.EventHandler(this.aimEnemy_Tick);
            // 
            // WeaponsSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Name = "WeaponsSystem";
            this.Size = new System.Drawing.Size(1135, 1056);
            this.Load += new System.EventHandler(this.WeaponsSystem_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aimPanel)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_SpaceShip)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer reloadWeapons;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel slider2;
        private System.Windows.Forms.Panel slider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_misil;
        private System.Windows.Forms.Button btn_laser;
        private System.Windows.Forms.PictureBox aimPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picture_SpaceShip;
        private System.Windows.Forms.Button btn_Abort;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Timer aimEnemy;
        private System.Windows.Forms.Label label5;
    }
}
