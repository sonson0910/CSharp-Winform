namespace Bai5_1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTPNgayGui = new System.Windows.Forms.DateTimePicker();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnAddDs = new System.Windows.Forms.Button();
            this.cbThoiGianGui = new System.Windows.Forms.ComboBox();
            this.txbTienGui = new System.Windows.Forms.TextBox();
            this.txbDiachi = new System.Windows.Forms.TextBox();
            this.txbTenKhach = new System.Windows.Forms.TextBox();
            this.txbMaKhach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPhatLoc = new System.Windows.Forms.RadioButton();
            this.rbThuong = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsb = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTPNgayGui);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnAddDs);
            this.groupBox1.Controls.Add(this.cbThoiGianGui);
            this.groupBox1.Controls.Add(this.txbTienGui);
            this.groupBox1.Controls.Add(this.txbDiachi);
            this.groupBox1.Controls.Add(this.txbTenKhach);
            this.groupBox1.Controls.Add(this.txbMaKhach);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // DTPNgayGui
            // 
            this.DTPNgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPNgayGui.Location = new System.Drawing.Point(93, 210);
            this.DTPNgayGui.Name = "DTPNgayGui";
            this.DTPNgayGui.Size = new System.Drawing.Size(200, 22);
            this.DTPNgayGui.TabIndex = 7;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(198, 397);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(106, 23);
            this.btnThemMoi.TabIndex = 6;
            this.btnThemMoi.Text = "Thêm &Mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnAddDs
            // 
            this.btnAddDs.Location = new System.Drawing.Point(19, 397);
            this.btnAddDs.Name = "btnAddDs";
            this.btnAddDs.Size = new System.Drawing.Size(125, 23);
            this.btnAddDs.TabIndex = 6;
            this.btnAddDs.Text = "Thêm vào danh sách";
            this.btnAddDs.UseVisualStyleBackColor = true;
            this.btnAddDs.Click += new System.EventHandler(this.btnAddDs_Click);
            // 
            // cbThoiGianGui
            // 
            this.cbThoiGianGui.FormattingEnabled = true;
            this.cbThoiGianGui.Location = new System.Drawing.Point(93, 250);
            this.cbThoiGianGui.Name = "cbThoiGianGui";
            this.cbThoiGianGui.Size = new System.Drawing.Size(169, 24);
            this.cbThoiGianGui.TabIndex = 5;
            // 
            // txbTienGui
            // 
            this.txbTienGui.Location = new System.Drawing.Point(93, 164);
            this.txbTienGui.Name = "txbTienGui";
            this.txbTienGui.Size = new System.Drawing.Size(169, 22);
            this.txbTienGui.TabIndex = 3;
            this.txbTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTienGui_KeyPress);
            // 
            // txbDiachi
            // 
            this.txbDiachi.Location = new System.Drawing.Point(74, 99);
            this.txbDiachi.Multiline = true;
            this.txbDiachi.Name = "txbDiachi";
            this.txbDiachi.Size = new System.Drawing.Size(234, 59);
            this.txbDiachi.TabIndex = 3;
            // 
            // txbTenKhach
            // 
            this.txbTenKhach.Location = new System.Drawing.Point(74, 71);
            this.txbTenKhach.Name = "txbTenKhach";
            this.txbTenKhach.Size = new System.Drawing.Size(234, 22);
            this.txbTenKhach.TabIndex = 3;
            // 
            // txbMaKhach
            // 
            this.txbMaKhach.Location = new System.Drawing.Point(74, 29);
            this.txbMaKhach.Name = "txbMaKhach";
            this.txbMaKhach.Size = new System.Drawing.Size(234, 22);
            this.txbMaKhach.TabIndex = 3;
            this.txbMaKhach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMaKhach_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tháng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Thời gian gửi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày gửi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "VND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số tiền gửi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khách";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbPhatLoc);
            this.groupBox3.Controls.Add(this.rbThuong);
            this.groupBox3.Location = new System.Drawing.Point(6, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 68);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại gửi";
            // 
            // rbPhatLoc
            // 
            this.rbPhatLoc.AutoSize = true;
            this.rbPhatLoc.Location = new System.Drawing.Point(211, 31);
            this.rbPhatLoc.Name = "rbPhatLoc";
            this.rbPhatLoc.Size = new System.Drawing.Size(76, 20);
            this.rbPhatLoc.TabIndex = 0;
            this.rbPhatLoc.TabStop = true;
            this.rbPhatLoc.Text = "Phát lộc";
            this.rbPhatLoc.UseVisualStyleBackColor = true;
            // 
            // rbThuong
            // 
            this.rbThuong.AutoSize = true;
            this.rbThuong.Location = new System.Drawing.Point(30, 31);
            this.rbThuong.Name = "rbThuong";
            this.rbThuong.Size = new System.Drawing.Size(74, 20);
            this.rbThuong.TabIndex = 0;
            this.rbThuong.TabStop = true;
            this.rbThuong.Text = "Thường";
            this.rbThuong.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsb);
            this.groupBox2.Location = new System.Drawing.Point(353, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 406);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hiện có";
            // 
            // lsb
            // 
            this.lsb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsb.FormattingEnabled = true;
            this.lsb.ItemHeight = 16;
            this.lsb.Location = new System.Drawing.Point(3, 18);
            this.lsb.Name = "lsb";
            this.lsb.Size = new System.Drawing.Size(537, 385);
            this.lsb.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(433, 424);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(700, 424);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbTienGui;
        private System.Windows.Forms.TextBox txbDiachi;
        private System.Windows.Forms.TextBox txbTenKhach;
        private System.Windows.Forms.TextBox txbMaKhach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DTPNgayGui;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnAddDs;
        private System.Windows.Forms.ComboBox cbThoiGianGui;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbPhatLoc;
        private System.Windows.Forms.RadioButton rbThuong;
        private System.Windows.Forms.ListBox lsb;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
    }
}

