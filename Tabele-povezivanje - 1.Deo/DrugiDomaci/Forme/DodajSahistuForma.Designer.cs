using System.Windows.Forms;

namespace DrugiDomaci
{
    partial class DodajSahistuForma
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblBrojPasos = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblZemlja = new System.Windows.Forms.Label();
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.tbxPrezime = new System.Windows.Forms.TextBox();
            this.tbxBrojPasosa = new System.Windows.Forms.TextBox();
            this.tbxAdresa = new System.Windows.Forms.TextBox();
            this.tbxZemlja = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(13, 13);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(13, 47);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblBrojPasos
            // 
            this.lblBrojPasos.AutoSize = true;
            this.lblBrojPasos.Location = new System.Drawing.Point(13, 80);
            this.lblBrojPasos.Name = "lblBrojPasos";
            this.lblBrojPasos.Size = new System.Drawing.Size(62, 13);
            this.lblBrojPasos.TabIndex = 2;
            this.lblBrojPasos.Text = "Broj pasosa";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(13, 116);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(40, 13);
            this.lblAdresa.TabIndex = 3;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblZemlja
            // 
            this.lblZemlja.AutoSize = true;
            this.lblZemlja.Location = new System.Drawing.Point(13, 151);
            this.lblZemlja.Name = "lblZemlja";
            this.lblZemlja.Size = new System.Drawing.Size(38, 13);
            this.lblZemlja.TabIndex = 4;
            this.lblZemlja.Text = "Zemlja";
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(90, 6);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(100, 20);
            this.tbxIme.TabIndex = 5;
            // 
            // tbxPrezime
            // 
            this.tbxPrezime.Location = new System.Drawing.Point(90, 44);
            this.tbxPrezime.Name = "tbxPrezime";
            this.tbxPrezime.Size = new System.Drawing.Size(100, 20);
            this.tbxPrezime.TabIndex = 6;
            // 
            // tbxBrojPasosa
            // 
            this.tbxBrojPasosa.Location = new System.Drawing.Point(90, 77);
            this.tbxBrojPasosa.Name = "tbxBrojPasosa";
            this.tbxBrojPasosa.Size = new System.Drawing.Size(100, 20);
            this.tbxBrojPasosa.TabIndex = 7;
            // 
            // tbxAdresa
            // 
            this.tbxAdresa.Location = new System.Drawing.Point(90, 113);
            this.tbxAdresa.Name = "tbxAdresa";
            this.tbxAdresa.Size = new System.Drawing.Size(100, 20);
            this.tbxAdresa.TabIndex = 8;
            // 
            // tbxZemlja
            // 
            this.tbxZemlja.Location = new System.Drawing.Point(90, 148);
            this.tbxZemlja.Name = "tbxZemlja";
            this.tbxZemlja.Size = new System.Drawing.Size(100, 20);
            this.tbxZemlja.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(13, 179);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(78, 13);
            this.lblDatumRodjenja.TabIndex = 11;
            this.lblDatumRodjenja.Text = "Datum rodjenja";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(16, 208);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(174, 41);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "DODAJ";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // DodajSahistuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbxZemlja);
            this.Controls.Add(this.tbxAdresa);
            this.Controls.Add(this.tbxBrojPasosa);
            this.Controls.Add(this.tbxPrezime);
            this.Controls.Add(this.tbxIme);
            this.Controls.Add(this.lblZemlja);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblBrojPasos);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "DodajSahistuForma";
            this.Text = "DODAJ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblBrojPasos;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblZemlja;
        private System.Windows.Forms.TextBox tbxIme;
        private System.Windows.Forms.TextBox tbxPrezime;
        private System.Windows.Forms.TextBox tbxBrojPasosa;
        private System.Windows.Forms.TextBox tbxAdresa;
        private System.Windows.Forms.TextBox tbxZemlja;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Button btnSubmit;

        public TextBox TbxPrezime
        {
            get
            {
                return tbxPrezime;
            }

            set
            {
                tbxPrezime = value;
            }
        }

        public TextBox TbxIme
        {
            get
            {
                return tbxIme;
            }

            set
            {
                tbxIme = value;
            }
        }

        public TextBox TbxBrojPasosa
        {
            get
            {
                return tbxBrojPasosa;
            }

            set
            {
                tbxBrojPasosa = value;
            }
        }

        public TextBox TbxAdresa
        {
            get
            {
                return tbxAdresa;
            }

            set
            {
                tbxAdresa = value;
            }
        }

        public TextBox TbxZemlja
        {
            get
            {
                return tbxZemlja;
            }

            set
            {
                tbxZemlja = value;
            }
        }

        public DateTimePicker DateTimePicker1
        {
            get
            {
                return dateTimePicker1;
            }

            set
            {
                dateTimePicker1 = value;
            }
        }

        public Label LblDatumRodjenja
        {
            get
            {
                return lblDatumRodjenja;
            }

            set
            {
                lblDatumRodjenja = value;
            }
        }
    }
}