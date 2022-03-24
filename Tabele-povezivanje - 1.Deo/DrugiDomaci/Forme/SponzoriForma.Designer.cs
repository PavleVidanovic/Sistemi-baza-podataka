using System.Windows.Forms;

namespace DrugiDomaci
{
    partial class SponzoriForma
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblImeSponzora = new System.Windows.Forms.Label();
            this.tbxSponzor = new System.Windows.Forms.TextBox();
            this.cbxTurnir = new System.Windows.Forms.ComboBox();
            this.lblTurnir = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "PRIKAZ SPONZORA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 106);
            this.listBox1.TabIndex = 2;
            // 
            // lblImeSponzora
            // 
            this.lblImeSponzora.AutoSize = true;
            this.lblImeSponzora.Location = new System.Drawing.Point(11, 37);
            this.lblImeSponzora.Name = "lblImeSponzora";
            this.lblImeSponzora.Size = new System.Drawing.Size(46, 13);
            this.lblImeSponzora.TabIndex = 3;
            this.lblImeSponzora.Text = "Sponzor";
            // 
            // tbxSponzor
            // 
            this.tbxSponzor.Location = new System.Drawing.Point(63, 34);
            this.tbxSponzor.Name = "tbxSponzor";
            this.tbxSponzor.Size = new System.Drawing.Size(121, 20);
            this.tbxSponzor.TabIndex = 4;
            // 
            // cbxTurnir
            // 
            this.cbxTurnir.FormattingEnabled = true;
            this.cbxTurnir.Location = new System.Drawing.Point(63, 72);
            this.cbxTurnir.Name = "cbxTurnir";
            this.cbxTurnir.Size = new System.Drawing.Size(121, 21);
            this.cbxTurnir.TabIndex = 5;
            // 
            // lblTurnir
            // 
            this.lblTurnir.AutoSize = true;
            this.lblTurnir.Location = new System.Drawing.Point(11, 75);
            this.lblTurnir.Name = "lblTurnir";
            this.lblTurnir.Size = new System.Drawing.Size(34, 13);
            this.lblTurnir.TabIndex = 6;
            this.lblTurnir.Text = "Turnir";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(193, 81);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "PRROMENITE SPONZORA";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cbxTurnir);
            this.groupBox1.Controls.Add(this.lblTurnir);
            this.groupBox1.Controls.Add(this.lblImeSponzora);
            this.groupBox1.Controls.Add(this.tbxSponzor);
            this.groupBox1.Location = new System.Drawing.Point(224, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 234);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DODAJTE SPONZORE TURNIRA";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.BackgroundImage = global::DrugiDomaci.Properties.Resources.Sponsor__1_;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(14, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 135);
            this.button2.TabIndex = 1;
            this.button2.Text = "DODAJ SPONZORA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SponzoriForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(416, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "SponzoriForma";
            this.Text = "SPONZORI";
            this.Load += new System.EventHandler(this.SponzoriForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblImeSponzora;
        private System.Windows.Forms.TextBox tbxSponzor;
        private System.Windows.Forms.ComboBox cbxTurnir;
        private System.Windows.Forms.Label lblTurnir;
        private System.Windows.Forms.Button btnUpdate;
        private GroupBox groupBox1;

        public ListBox ListBox1
        {
            get
            {
                return listBox1;
            }

            set
            {
                listBox1 = value;
            }
        }
    }
}