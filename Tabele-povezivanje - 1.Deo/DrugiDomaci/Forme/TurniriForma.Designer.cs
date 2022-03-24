using System.Windows.Forms;

namespace DrugiDomaci
{
    partial class TurniriForma
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
            System.Windows.Forms.Button btnUcesnici;
            this.lbxTurniri = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbxUcesnici = new System.Windows.Forms.ListBox();
            btnUcesnici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcesnici
            // 
            btnUcesnici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            btnUcesnici.Location = new System.Drawing.Point(269, -4);
            btnUcesnici.Name = "btnUcesnici";
            btnUcesnici.Size = new System.Drawing.Size(75, 53);
            btnUcesnici.TabIndex = 2;
            btnUcesnici.Text = "Prikazite detaljnije turnir";
            btnUcesnici.UseVisualStyleBackColor = false;
            btnUcesnici.Click += new System.EventHandler(this.btnUcesnici_Click);
            // 
            // lbxTurniri
            // 
            this.lbxTurniri.FormattingEnabled = true;
            this.lbxTurniri.Location = new System.Drawing.Point(2, 35);
            this.lbxTurniri.Name = "lbxTurniri";
            this.lbxTurniri.Size = new System.Drawing.Size(261, 173);
            this.lbxTurniri.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Prikazi turnire";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(270, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 43);
            this.listBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(350, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(269, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 105);
            this.button2.TabIndex = 5;
            this.button2.Text = "PRIKAZI UCESNIKE TURNIRA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(270, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(225, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "Izaberite turnir za koji zelite ucenike";
            // 
            // lbxUcesnici
            // 
            this.lbxUcesnici.FormattingEnabled = true;
            this.lbxUcesnici.Location = new System.Drawing.Point(379, 128);
            this.lbxUcesnici.Name = "lbxUcesnici";
            this.lbxUcesnici.Size = new System.Drawing.Size(116, 160);
            this.lbxUcesnici.TabIndex = 7;
            // 
            // TurniriForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DrugiDomaci.Properties.Resources.Chess_game;
            this.ClientSize = new System.Drawing.Size(504, 344);
            this.Controls.Add(this.lbxUcesnici);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(btnUcesnici);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxTurniri);
            this.Name = "TurniriForma";
            this.Text = "TURNIRI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTurniri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private ListBox lbxUcesnici;

        public ComboBox ComboBox2
        {
            get
            {
                return comboBox2;
            }

            set
            {
                comboBox2 = value;
            }
        }
    }
}