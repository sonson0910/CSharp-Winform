namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMaSach = new TextBox();
            label2 = new Label();
            txtTenSach = new TextBox();
            txtTacGia = new TextBox();
            label3 = new Label();
            txtSoLuong = new TextBox();
            label4 = new Label();
            txtQRCode = new TextBox();
            label5 = new Label();
            btnThemVaoDS = new Button();
            btnThemMoi = new Button();
            btnXoaKhoiDS = new Button();
            btnThoat = new Button();
            lstDS = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 38);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sách";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(158, 35);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(202, 27);
            txtMaSach.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 82);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên sách";
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(158, 82);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(202, 27);
            txtTenSach.TabIndex = 2;
            // 
            // txtTacGia
            // 
            txtTacGia.Location = new Point(158, 134);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(202, 27);
            txtTacGia.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 134);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Tác giả";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(158, 184);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(202, 27);
            txtSoLuong.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 184);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 2;
            label4.Text = "Số lượng";
            // 
            // txtQRCode
            // 
            txtQRCode.Location = new Point(158, 236);
            txtQRCode.Name = "txtQRCode";
            txtQRCode.Size = new Size(202, 27);
            txtQRCode.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 236);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 2;
            label5.Text = "QR Code";
            // 
            // btnThemVaoDS
            // 
            btnThemVaoDS.Location = new Point(409, 35);
            btnThemVaoDS.Name = "btnThemVaoDS";
            btnThemVaoDS.Size = new Size(133, 29);
            btnThemVaoDS.TabIndex = 6;
            btnThemVaoDS.Text = "Thêm vào DS";
            btnThemVaoDS.UseVisualStyleBackColor = true;
            btnThemVaoDS.Click += btnThemVaoDS_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Location = new Point(409, 82);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(133, 29);
            btnThemMoi.TabIndex = 7;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnXoaKhoiDS
            // 
            btnXoaKhoiDS.Location = new Point(409, 134);
            btnXoaKhoiDS.Name = "btnXoaKhoiDS";
            btnXoaKhoiDS.Size = new Size(133, 29);
            btnXoaKhoiDS.TabIndex = 8;
            btnXoaKhoiDS.Text = "Xóa khỏi DS";
            btnXoaKhoiDS.UseVisualStyleBackColor = true;
            btnXoaKhoiDS.Click += btnXoaKhoiDS_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(409, 184);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(133, 29);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lstDS
            // 
            lstDS.FormattingEnabled = true;
            lstDS.ItemHeight = 20;
            lstDS.Location = new Point(59, 299);
            lstDS.Name = "lstDS";
            lstDS.Size = new Size(475, 144);
            lstDS.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 491);
            Controls.Add(lstDS);
            Controls.Add(btnThoat);
            Controls.Add(btnXoaKhoiDS);
            Controls.Add(btnThemMoi);
            Controls.Add(btnThemVaoDS);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtQRCode);
            Controls.Add(txtSoLuong);
            Controls.Add(txtTacGia);
            Controls.Add(txtTenSach);
            Controls.Add(txtMaSach);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaSach;
        private Label label2;
        private TextBox txtTenSach;
        private TextBox txtTacGia;
        private Label label3;
        private TextBox txtSoLuong;
        private Label label4;
        private TextBox txtQRCode;
        private Label label5;
        private Button btnThemVaoDS;
        private Button btnThemMoi;
        private Button btnXoaKhoiDS;
        private Button btnThoat;
        private ListBox lstDS;
    }
}