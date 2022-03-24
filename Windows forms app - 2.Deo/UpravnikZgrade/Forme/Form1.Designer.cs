namespace UpravnikZgrade.Forme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.upravniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vlasniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zgradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upravniciToolStripMenuItem,
            this.vlasniciToolStripMenuItem,
            this.zgradeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // upravniciToolStripMenuItem
            // 
            this.upravniciToolStripMenuItem.Name = "upravniciToolStripMenuItem";
            this.upravniciToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.upravniciToolStripMenuItem.Text = "Upravnici";
            this.upravniciToolStripMenuItem.Click += new System.EventHandler(this.upravniciToolStripMenuItem_Click);
            // 
            // vlasniciToolStripMenuItem
            // 
            this.vlasniciToolStripMenuItem.Name = "vlasniciToolStripMenuItem";
            this.vlasniciToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.vlasniciToolStripMenuItem.Text = "Vlasnici";
            this.vlasniciToolStripMenuItem.Click += new System.EventHandler(this.vlasniciToolStripMenuItem_Click);
            // 
            // zgradeToolStripMenuItem
            // 
            this.zgradeToolStripMenuItem.Name = "zgradeToolStripMenuItem";
            this.zgradeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.zgradeToolStripMenuItem.Text = "Zgrade";
            this.zgradeToolStripMenuItem.Click += new System.EventHandler(this.zgradeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Firma za stambene objekte";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem upravniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vlasniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zgradeToolStripMenuItem;
    }
}

