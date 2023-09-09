namespace MenuStrip
{
    partial class mnu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mnu1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meoMeoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mâyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.julyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoàngThượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngChúaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thọ100NămToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.băngHàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meoMeoToolStripMenuItem,
            this.mâyToolStripMenuItem,
            this.julyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meoMeoToolStripMenuItem
            // 
            this.meoMeoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoàngThượngToolStripMenuItem,
            this.côngChúaToolStripMenuItem,
            this.côngCôngToolStripMenuItem});
            this.meoMeoToolStripMenuItem.Name = "meoMeoToolStripMenuItem";
            this.meoMeoToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.meoMeoToolStripMenuItem.Text = "Meo meo";
            this.meoMeoToolStripMenuItem.Click += new System.EventHandler(this.meoMeoToolStripMenuItem_Click);
            // 
            // mâyToolStripMenuItem
            // 
            this.mâyToolStripMenuItem.Enabled = false;
            this.mâyToolStripMenuItem.Name = "mâyToolStripMenuItem";
            this.mâyToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.mâyToolStripMenuItem.Text = "Mây";
            // 
            // julyToolStripMenuItem
            // 
            this.julyToolStripMenuItem.Name = "julyToolStripMenuItem";
            this.julyToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.julyToolStripMenuItem.Text = "July";
            this.julyToolStripMenuItem.Visible = false;
            // 
            // hoàngThượngToolStripMenuItem
            // 
            this.hoàngThượngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thọ100NămToolStripMenuItem,
            this.băngHàToolStripMenuItem});
            this.hoàngThượngToolStripMenuItem.Image = global::MenuStrip.Properties.Resources._3bf0a7d6_96d7_4e6b_8101_cb59e86a37ff;
            this.hoàngThượngToolStripMenuItem.Name = "hoàngThượngToolStripMenuItem";
            this.hoàngThượngToolStripMenuItem.ShortcutKeyDisplayString = "shortcut";
            this.hoàngThượngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.hoàngThượngToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.hoàngThượngToolStripMenuItem.Text = "Hoàng thượng";
            // 
            // côngChúaToolStripMenuItem
            // 
            this.côngChúaToolStripMenuItem.Name = "côngChúaToolStripMenuItem";
            this.côngChúaToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.côngChúaToolStripMenuItem.Text = "Công chúa";
            this.côngChúaToolStripMenuItem.ToolTipText = "okok";
            // 
            // côngCôngToolStripMenuItem
            // 
            this.côngCôngToolStripMenuItem.Name = "côngCôngToolStripMenuItem";
            this.côngCôngToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.côngCôngToolStripMenuItem.Text = "Công Công";
            // 
            // thọ100NămToolStripMenuItem
            // 
            this.thọ100NămToolStripMenuItem.Name = "thọ100NămToolStripMenuItem";
            this.thọ100NămToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thọ100NămToolStripMenuItem.Text = "Thọ 100 năm";
            // 
            // băngHàToolStripMenuItem
            // 
            this.băngHàToolStripMenuItem.Name = "băngHàToolStripMenuItem";
            this.băngHàToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.băngHàToolStripMenuItem.Text = "Băng hà";
            // 
            // mnu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mnu1";
            this.Text = "Menu Strip";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meoMeoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoàngThượngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngChúaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mâyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem julyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thọ100NămToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem băngHàToolStripMenuItem;
    }
}

