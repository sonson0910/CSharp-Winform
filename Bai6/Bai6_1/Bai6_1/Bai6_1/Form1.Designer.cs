namespace Bai6_1
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
            this.lstvProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbProCode = new System.Windows.Forms.TextBox();
            this.txbProName = new System.Windows.Forms.TextBox();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvProduct
            // 
            this.lstvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvProduct.FullRowSelect = true;
            this.lstvProduct.GridLines = true;
            this.lstvProduct.HideSelection = false;
            this.lstvProduct.Location = new System.Drawing.Point(12, 12);
            this.lstvProduct.Name = "lstvProduct";
            this.lstvProduct.Size = new System.Drawing.Size(554, 426);
            this.lstvProduct.TabIndex = 0;
            this.lstvProduct.UseCompatibleStateImageBehavior = false;
            this.lstvProduct.View = System.Windows.Forms.View.Details;
            this.lstvProduct.SelectedIndexChanged += new System.EventHandler(this.lstvProduct_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Code";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Number";
            this.columnHeader3.Width = 100;
            // 
            // txbProCode
            // 
            this.txbProCode.Location = new System.Drawing.Point(599, 25);
            this.txbProCode.Multiline = true;
            this.txbProCode.Name = "txbProCode";
            this.txbProCode.Size = new System.Drawing.Size(169, 28);
            this.txbProCode.TabIndex = 1;
            // 
            // txbProName
            // 
            this.txbProName.Location = new System.Drawing.Point(599, 83);
            this.txbProName.Multiline = true;
            this.txbProName.Name = "txbProName";
            this.txbProName.Size = new System.Drawing.Size(169, 28);
            this.txbProName.TabIndex = 1;
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(599, 140);
            this.txbNum.Multiline = true;
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(169, 28);
            this.txbNum.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(651, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(651, 276);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(651, 318);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(107, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(651, 360);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(107, 23);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.txbProName);
            this.Controls.Add(this.txbProCode);
            this.Controls.Add(this.lstvProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvProduct;
        private System.Windows.Forms.TextBox txbProCode;
        private System.Windows.Forms.TextBox txbProName;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSum;
    }
}

