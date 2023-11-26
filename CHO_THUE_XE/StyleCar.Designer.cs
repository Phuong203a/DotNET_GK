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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIdCar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIdKH = new System.Windows.Forms.TextBox();
            this.txtChucNang = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SameMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameNatu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(404, 475);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(161, 475);
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
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(172, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(391, 69);
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
            this.radioDien.Size = new System.Drawing.Size(95, 35);
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
            this.radioXang.Size = new System.Drawing.Size(102, 35);
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
            this.label13.Location = new System.Drawing.Point(718, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 39);
            this.label13.TabIndex = 34;
            this.label13.Text = "Chức năng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(729, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 39);
            this.label14.TabIndex = 35;
            this.label14.Text = "Nhiên liệu";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(731, 427);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 16);
            this.label17.TabIndex = 36;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(853, 401);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(335, 32);
            this.txtTotal.TabIndex = 43;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(933, 595);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 16);
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
            this.dgv1.Location = new System.Drawing.Point(0, 521);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.Size = new System.Drawing.Size(831, 167);
            this.dgv1.TabIndex = 45;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(605, 475);
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
            this.btnTotal.Location = new System.Drawing.Point(722, 401);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(109, 32);
            this.btnTotal.TabIndex = 48;
            this.btnTotal.Text = "Tổng tiền";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(228, 147);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(335, 32);
            this.txtId.TabIndex = 49;
            // 
            // txtIdCar
            // 
            this.txtIdCar.Location = new System.Drawing.Point(228, 247);
            this.txtIdCar.Multiline = true;
            this.txtIdCar.Name = "txtIdCar";
            this.txtIdCar.Size = new System.Drawing.Size(335, 32);
            this.txtIdCar.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 49);
            this.label10.TabIndex = 51;
            this.label10.Text = "Id thuê";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(31, 348);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 39);
            this.label15.TabIndex = 54;
            this.label15.Text = "Id KH";
            // 
            // txtIdKH
            // 
            this.txtIdKH.Location = new System.Drawing.Point(228, 354);
            this.txtIdKH.Multiline = true;
            this.txtIdKH.Name = "txtIdKH";
            this.txtIdKH.Size = new System.Drawing.Size(335, 32);
            this.txtIdKH.TabIndex = 53;
            // 
            // txtChucNang
            // 
            this.txtChucNang.Location = new System.Drawing.Point(722, 189);
            this.txtChucNang.Multiline = true;
            this.txtChucNang.Name = "txtChucNang";
            this.txtChucNang.Size = new System.Drawing.Size(335, 32);
            this.txtChucNang.TabIndex = 55;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioXang);
            this.groupBox.Controls.Add(this.radioDien);
            this.groupBox.Location = new System.Drawing.Point(722, 322);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(442, 73);
            this.groupBox.TabIndex = 56;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Fuel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 39);
            this.label12.TabIndex = 57;
            this.label12.Text = "Id xe";
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
            // StyleCar
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1240, 711);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.txtChucNang);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtIdKH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIdCar);
            this.Controls.Add(this.txtId);
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
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
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
        private System.Windows.Forms.TextBox txtChucNang;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SameMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameNatu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumMoney;
    }
}