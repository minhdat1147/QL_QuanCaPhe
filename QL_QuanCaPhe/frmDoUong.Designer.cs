namespace QL_QuanCaPhe
{
    partial class frmDoUong
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
            this.components = new System.ComponentModel.Container();
            this.cboDVT = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lOAIDOUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_QUANCAPHEDataSet1 = new QL_QuanCaPhe.QL_QUANCAPHEDataSet1();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.TG = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lOAIDOUONGTableAdapter = new QL_QuanCaPhe.QL_QUANCAPHEDataSet1TableAdapters.LOAIDOUONGTableAdapter();
            this.cboMaLoai = new System.Windows.Forms.ComboBox();
            this.lOAIDOUONGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.abc = new QL_QuanCaPhe.abc();
            this.lOAIDOUONGTableAdapter1 = new QL_QuanCaPhe.abcTableAdapters.LOAIDOUONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_QUANCAPHEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOUONGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abc)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDVT
            // 
            this.cboDVT.FormattingEnabled = true;
            this.cboDVT.Items.AddRange(new object[] {
            "Lon",
            "Chai",
            "Ly",
            "Bịch"});
            this.cboDVT.Location = new System.Drawing.Point(577, 270);
            this.cboDVT.Name = "cboDVT";
            this.cboDVT.Size = new System.Drawing.Size(100, 21);
            this.cboDVT.TabIndex = 73;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(541, 225);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 23);
            this.button6.TabIndex = 72;
            this.button6.Text = "Tìm";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(425, 227);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(100, 20);
            this.txtTim.TabIndex = 71;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(397, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 23);
            this.button5.TabIndex = 70;
            this.button5.Text = "Quản lý loại đồ uống";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Loại sản phẩm";
            // 
            // cboLoai
            // 
            this.cboLoai.DataSource = this.lOAIDOUONGBindingSource;
            this.cboLoai.DisplayMember = "TENLOAI";
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(240, 12);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(120, 21);
            this.cboLoai.TabIndex = 67;
            this.cboLoai.ValueMember = "MALOAI";
            this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);
            // 
            // lOAIDOUONGBindingSource
            // 
            this.lOAIDOUONGBindingSource.DataMember = "LOAIDOUONG";
            this.lOAIDOUONGBindingSource.DataSource = this.qL_QUANCAPHEDataSet1;
            // 
            // qL_QUANCAPHEDataSet1
            // 
            this.qL_QUANCAPHEDataSet1.DataSetName = "QL_QUANCAPHEDataSet1";
            this.qL_QUANCAPHEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(542, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 23);
            this.button4.TabIndex = 66;
            this.button4.Text = "Quay lại";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(524, 168);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(354, 318);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 64;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(289, 325);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(24, 13);
            this.label.TabIndex = 63;
            this.label.Text = "GIá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Mã loại";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(132, 318);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 61;
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(132, 273);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(100, 20);
            this.txtMS.TabIndex = 60;
            // 
            // TG
            // 
            this.TG.AutoSize = true;
            this.TG.Location = new System.Drawing.Point(489, 278);
            this.TG.Name = "TG";
            this.TG.Size = new System.Drawing.Size(60, 13);
            this.TG.TabIndex = 59;
            this.TG.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tên đồ uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Mã đồ uống";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(542, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 49);
            this.button3.TabIndex = 56;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(542, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 52);
            this.button2.TabIndex = 55;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(542, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 55);
            this.button1.TabIndex = 54;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(179, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 27);
            this.label1.TabIndex = 53;
            this.label1.Text = "Thông tin đồ uống";
            // 
            // lOAIDOUONGTableAdapter
            // 
            this.lOAIDOUONGTableAdapter.ClearBeforeFill = true;
            // 
            // cboMaLoai
            // 
            this.cboMaLoai.DataSource = this.lOAIDOUONGBindingSource1;
            this.cboMaLoai.DisplayMember = "TENLOAI";
            this.cboMaLoai.FormattingEnabled = true;
            this.cboMaLoai.Location = new System.Drawing.Point(354, 270);
            this.cboMaLoai.Name = "cboMaLoai";
            this.cboMaLoai.Size = new System.Drawing.Size(100, 21);
            this.cboMaLoai.TabIndex = 69;
            this.cboMaLoai.ValueMember = "MALOAI";
            this.cboMaLoai.SelectedIndexChanged += new System.EventHandler(this.cboMaLoai_SelectedIndexChanged);
            // 
            // lOAIDOUONGBindingSource1
            // 
            this.lOAIDOUONGBindingSource1.DataMember = "LOAIDOUONG";
            this.lOAIDOUONGBindingSource1.DataSource = this.abc;
            // 
            // abc
            // 
            this.abc.DataSetName = "abc";
            this.abc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAIDOUONGTableAdapter1
            // 
            this.lOAIDOUONGTableAdapter1.ClearBeforeFill = true;
            // 
            // frmDoUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(689, 360);
            this.Controls.Add(this.cboDVT);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cboMaLoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMS);
            this.Controls.Add(this.TG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmDoUong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồ uống";
            this.Load += new System.EventHandler(this.frmDoUong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_QUANCAPHEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOUONGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDVT;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.Label TG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private QL_QUANCAPHEDataSet1 qL_QUANCAPHEDataSet1;
        private System.Windows.Forms.BindingSource lOAIDOUONGBindingSource;
        private QL_QUANCAPHEDataSet1TableAdapters.LOAIDOUONGTableAdapter lOAIDOUONGTableAdapter;
        private System.Windows.Forms.ComboBox cboMaLoai;
        private abc abc;
        private System.Windows.Forms.BindingSource lOAIDOUONGBindingSource1;
        private abcTableAdapters.LOAIDOUONGTableAdapter lOAIDOUONGTableAdapter1;
    }
}