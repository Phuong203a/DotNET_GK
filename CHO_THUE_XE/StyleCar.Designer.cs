namespace CHO_THUE_XE
{
    partial class StyleCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StyleCar));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.radioDien = new System.Windows.Forms.RadioButton();
            this.radioXang = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SameMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameNatu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIdCar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIdKH = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBoxBanDo = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(270, 528);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(46, 527);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cooper Std Black", 27.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(488, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(273, 45);
            this.label11.TabIndex = 1;
            this.label11.Text = "Cho Thuê Xe";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(1703, 0);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(37, 35);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 4;
            this.pictureBox16.TabStop = false;
            // 
            // radioDien
            // 
            this.radioDien.AutoSize = true;
            this.radioDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDien.Location = new System.Drawing.Point(270, 21);
            this.radioDien.Name = "radioDien";
            this.radioDien.Size = new System.Drawing.Size(78, 29);
            this.radioDien.TabIndex = 28;
            this.radioDien.TabStop = true;
            this.radioDien.Text = "Điện";
            this.radioDien.UseVisualStyleBackColor = true;
            this.radioDien.CheckedChanged += new System.EventHandler(this.radioDien_CheckedChanged);
            // 
            // radioXang
            // 
            this.radioXang.AutoSize = true;
            this.radioXang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioXang.Location = new System.Drawing.Point(41, 21);
            this.radioXang.Name = "radioXang";
            this.radioXang.Size = new System.Drawing.Size(84, 29);
            this.radioXang.TabIndex = 21;
            this.radioXang.TabStop = true;
            this.radioXang.Text = "Xăng";
            this.radioXang.UseVisualStyleBackColor = true;
            this.radioXang.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(631, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 31);
            this.label13.TabIndex = 34;
            this.label13.Text = "Chức năng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(85, 360);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 31);
            this.label14.TabIndex = 35;
            this.label14.Text = "Nhiên liệu";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(727, 554);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 36;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(849, 528);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(335, 40);
            this.txtTotal.TabIndex = 43;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(933, 595);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 42;
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.SameMoney,
            this.NameRole,
            this.NameNatu,
            this.SumMoney});
            this.dgv1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv1.Location = new System.Drawing.Point(0, 598);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.Size = new System.Drawing.Size(1241, 167);
            this.dgv1.TabIndex = 45;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Id xe";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // SameMoney
            // 
            this.SameMoney.HeaderText = "Mã KH";
            this.SameMoney.MinimumWidth = 6;
            this.SameMoney.Name = "SameMoney";
            this.SameMoney.Width = 125;
            // 
            // NameRole
            // 
            this.NameRole.HeaderText = "Tên chức năng";
            this.NameRole.MinimumWidth = 6;
            this.NameRole.Name = "NameRole";
            this.NameRole.Width = 125;
            // 
            // NameNatu
            // 
            this.NameNatu.HeaderText = "Tên nhiên liệu";
            this.NameNatu.MinimumWidth = 6;
            this.NameNatu.Name = "NameNatu";
            this.NameNatu.Width = 125;
            // 
            // SumMoney
            // 
            this.SumMoney.HeaderText = "Tổng tiền";
            this.SumMoney.MinimumWidth = 6;
            this.SumMoney.Name = "SumMoney";
            this.SumMoney.Width = 125;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Location = new System.Drawing.Point(507, 528);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(126, 40);
            this.btnLoad.TabIndex = 46;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(730, 528);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(109, 40);
            this.btnTotal.TabIndex = 48;
            this.btnTotal.Text = "Tổng tiền";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(227, 140);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(335, 30);
            this.txtId.TabIndex = 49;
            // 
            // txtIdCar
            // 
            this.txtIdCar.Location = new System.Drawing.Point(227, 205);
            this.txtIdCar.Multiline = true;
            this.txtIdCar.Name = "txtIdCar";
            this.txtIdCar.Size = new System.Drawing.Size(335, 29);
            this.txtIdCar.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 24);
            this.label10.TabIndex = 51;
            this.label10.Text = "Mã thuê";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(87, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 24);
            this.label15.TabIndex = 54;
            this.label15.Text = "Mã KH";
            // 
            // txtIdKH
            // 
            this.txtIdKH.Location = new System.Drawing.Point(227, 275);
            this.txtIdKH.Multiline = true;
            this.txtIdKH.Name = "txtIdKH";
            this.txtIdKH.Size = new System.Drawing.Size(335, 27);
            this.txtIdKH.TabIndex = 53;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioXang);
            this.groupBox.Controls.Add(this.radioDien);
            this.groupBox.Location = new System.Drawing.Point(120, 408);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(442, 73);
            this.groupBox.TabIndex = 56;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Fuel";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(87, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 24);
            this.label12.TabIndex = 57;
            this.label12.Text = "Mã xe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBoxBanDo);
            this.groupBox1.Location = new System.Drawing.Point(637, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 254);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuel";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox5.Location = new System.Drawing.Point(256, 175);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(158, 29);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "Camera 360";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox6.Location = new System.Drawing.Point(256, 125);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(200, 29);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "cảnh báo tốc độ";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox7.Location = new System.Drawing.Point(256, 73);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(225, 29);
            this.checkBox7.TabIndex = 5;
            this.checkBox7.Text = "Camera hành trình";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox8.Location = new System.Drawing.Point(256, 21);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(131, 29);
            this.checkBox8.TabIndex = 4;
            this.checkBox8.Text = "Bluetooth";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox3.Location = new System.Drawing.Point(21, 170);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(175, 29);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Khe cắm USB";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox4.Location = new System.Drawing.Point(21, 120);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(169, 29);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Cảm biến lốp";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBox2.Location = new System.Drawing.Point(21, 68);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(183, 29);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Camera cập lề";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxBanDo
            // 
            this.checkBoxBanDo.AutoSize = true;
            this.checkBoxBanDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxBanDo.Location = new System.Drawing.Point(21, 16);
            this.checkBoxBanDo.Name = "checkBoxBanDo";
            this.checkBoxBanDo.Size = new System.Drawing.Size(105, 29);
            this.checkBoxBanDo.TabIndex = 0;
            this.checkBoxBanDo.Text = "Bản đồ";
            this.checkBoxBanDo.UseVisualStyleBackColor = true;
            this.checkBoxBanDo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1205, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StyleCar
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1240, 777);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtIdKH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIdCar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.StyleCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.RadioButton radioDien;
        private System.Windows.Forms.RadioButton radioXang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIdCar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIdKH;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SameMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameNatu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumMoney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBoxBanDo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}