namespace CheckListBox
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
            this.ckLstBox = new System.Windows.Forms.CheckedListBox();
            this.Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckLstBox
            // 
            this.ckLstBox.CheckOnClick = true;
            this.ckLstBox.FormattingEnabled = true;
            this.ckLstBox.Items.AddRange(new object[] {
            "ok"});
            this.ckLstBox.Location = new System.Drawing.Point(101, 76);
            this.ckLstBox.Name = "ckLstBox";
            this.ckLstBox.Size = new System.Drawing.Size(166, 174);
            this.ckLstBox.TabIndex = 0;
            this.ckLstBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(334, 138);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 1;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 287);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.ckLstBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ckLstBox;
        private System.Windows.Forms.Button Load;
    }
}

