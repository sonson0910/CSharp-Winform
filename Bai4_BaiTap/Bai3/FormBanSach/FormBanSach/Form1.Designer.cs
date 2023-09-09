namespace FormBanSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstbListProduct = new System.Windows.Forms.ListBox();
            this.lstbPurchasedGoods = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCredit = new System.Windows.Forms.RadioButton();
            this.rdbSec = new System.Windows.Forms.RadioButton();
            this.rdbCash = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.cbFax = new System.Windows.Forms.CheckBox();
            this.cbPhoneNumber = new System.Windows.Forms.CheckBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(122, 30);
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(278, 27);
            this.txbName.TabIndex = 1;
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(609, 30);
            this.txbPhoneNumber.Multiline = true;
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(273, 27);
            this.txbPhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh sách các mặt hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hàng đã đặt mua";
            // 
            // lstbListProduct
            // 
            this.lstbListProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbListProduct.FormattingEnabled = true;
            this.lstbListProduct.ItemHeight = 20;
            this.lstbListProduct.Location = new System.Drawing.Point(55, 153);
            this.lstbListProduct.Name = "lstbListProduct";
            this.lstbListProduct.Size = new System.Drawing.Size(345, 224);
            this.lstbListProduct.TabIndex = 6;
            this.lstbListProduct.SelectedIndexChanged += new System.EventHandler(this.lstbListProduct_SelectedIndexChanged);
            this.lstbListProduct.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbListProduct_MouseDoubleClick);
            // 
            // lstbPurchasedGoods
            // 
            this.lstbPurchasedGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbPurchasedGoods.FormattingEnabled = true;
            this.lstbPurchasedGoods.ItemHeight = 20;
            this.lstbPurchasedGoods.Location = new System.Drawing.Point(537, 153);
            this.lstbPurchasedGoods.Name = "lstbPurchasedGoods";
            this.lstbPurchasedGoods.Size = new System.Drawing.Size(345, 224);
            this.lstbPurchasedGoods.TabIndex = 7;
            this.lstbPurchasedGoods.SelectedIndexChanged += new System.EventHandler(this.lstbPurchasedGoods_SelectedIndexChanged);
            this.lstbPurchasedGoods.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbPurchasedGoods_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCredit);
            this.groupBox1.Controls.Add(this.rdbSec);
            this.groupBox1.Controls.Add(this.rdbCash);
            this.groupBox1.Location = new System.Drawing.Point(55, 415);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 151);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương thức thanh toán";
            // 
            // rdbCredit
            // 
            this.rdbCredit.AutoSize = true;
            this.rdbCredit.Location = new System.Drawing.Point(34, 107);
            this.rdbCredit.Name = "rdbCredit";
            this.rdbCredit.Size = new System.Drawing.Size(101, 20);
            this.rdbCredit.TabIndex = 2;
            this.rdbCredit.TabStop = true;
            this.rdbCredit.Text = "Thẻ tín dụng";
            this.rdbCredit.UseVisualStyleBackColor = true;
            // 
            // rdbSec
            // 
            this.rdbSec.AutoSize = true;
            this.rdbSec.Location = new System.Drawing.Point(34, 71);
            this.rdbSec.Name = "rdbSec";
            this.rdbSec.Size = new System.Drawing.Size(52, 20);
            this.rdbSec.TabIndex = 1;
            this.rdbSec.TabStop = true;
            this.rdbSec.Text = "Sec";
            this.rdbSec.UseVisualStyleBackColor = true;
            // 
            // rdbCash
            // 
            this.rdbCash.AutoSize = true;
            this.rdbCash.Location = new System.Drawing.Point(34, 35);
            this.rdbCash.Name = "rdbCash";
            this.rdbCash.Size = new System.Drawing.Size(80, 20);
            this.rdbCash.TabIndex = 0;
            this.rdbCash.TabStop = true;
            this.rdbCash.Text = "Tiền mặt";
            this.rdbCash.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEmail);
            this.groupBox2.Controls.Add(this.cbFax);
            this.groupBox2.Controls.Add(this.cbPhoneNumber);
            this.groupBox2.Location = new System.Drawing.Point(537, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 151);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình thức liên lạc";
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(33, 107);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(63, 20);
            this.cbEmail.TabIndex = 2;
            this.cbEmail.Text = "Email";
            this.cbEmail.UseVisualStyleBackColor = true;
            // 
            // cbFax
            // 
            this.cbFax.AutoSize = true;
            this.cbFax.Location = new System.Drawing.Point(33, 71);
            this.cbFax.Name = "cbFax";
            this.cbFax.Size = new System.Drawing.Size(51, 20);
            this.cbFax.TabIndex = 1;
            this.cbFax.Text = "Fax";
            this.cbFax.UseVisualStyleBackColor = true;
            // 
            // cbPhoneNumber
            // 
            this.cbPhoneNumber.AutoSize = true;
            this.cbPhoneNumber.Location = new System.Drawing.Point(33, 34);
            this.cbPhoneNumber.Name = "cbPhoneNumber";
            this.cbPhoneNumber.Size = new System.Drawing.Size(88, 20);
            this.cbPhoneNumber.TabIndex = 0;
            this.cbPhoneNumber.Text = "Điện thoại";
            this.cbPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(202, 605);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 10;
            this.btnYes.Text = "Đồng ý";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(537, 605);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 659);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstbPurchasedGoods);
            this.Controls.Add(this.lstbListProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bán sách qua mạng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstbListProduct;
        private System.Windows.Forms.ListBox lstbPurchasedGoods;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCredit;
        private System.Windows.Forms.RadioButton rdbSec;
        private System.Windows.Forms.RadioButton rdbCash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.CheckBox cbFax;
        private System.Windows.Forms.CheckBox cbPhoneNumber;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnExit;
    }
}

