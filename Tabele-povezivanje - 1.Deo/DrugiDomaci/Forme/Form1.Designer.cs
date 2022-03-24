namespace DrugiDomaci
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnyTurniri = new System.Windows.Forms.ToolStripMenuItem();
            this.sahistiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sponzoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnyTurniri,
            this.sahistiToolStripMenuItem,
            this.sponzoriToolStripMenuItem,
            this.organizatoriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnyTurniri
            // 
            this.mnyTurniri.Name = "mnyTurniri";
            this.mnyTurniri.Size = new System.Drawing.Size(54, 20);
            this.mnyTurniri.Text = "Turniri";
            this.mnyTurniri.Click += new System.EventHandler(this.mnyTurniri_Click);
            // 
            // sahistiToolStripMenuItem
            // 
            this.sahistiToolStripMenuItem.Name = "sahistiToolStripMenuItem";
            this.sahistiToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sahistiToolStripMenuItem.Text = "Sahisti";
            this.sahistiToolStripMenuItem.Click += new System.EventHandler(this.sahistiToolStripMenuItem_Click);
            // 
            // sponzoriToolStripMenuItem
            // 
            this.sponzoriToolStripMenuItem.Name = "sponzoriToolStripMenuItem";
            this.sponzoriToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sponzoriToolStripMenuItem.Text = "Sponzori";
            this.sponzoriToolStripMenuItem.Click += new System.EventHandler(this.sponzoriToolStripMenuItem_Click);
            // 
            // organizatoriToolStripMenuItem
            // 
            this.organizatoriToolStripMenuItem.Name = "organizatoriToolStripMenuItem";
            this.organizatoriToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.organizatoriToolStripMenuItem.Text = "Organizatori";
            this.organizatoriToolStripMenuItem.Click += new System.EventHandler(this.organizatoriToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DrugiDomaci.Properties.Resources.banner_chess;
            this.ClientSize = new System.Drawing.Size(807, 455);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SAHOVSKA FEDERACIJA WELCOME!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnyTurniri;
        private System.Windows.Forms.ToolStripMenuItem sahistiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sponzoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizatoriToolStripMenuItem;
    }
}

