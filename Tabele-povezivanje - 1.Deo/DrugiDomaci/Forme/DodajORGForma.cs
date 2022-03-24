using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrugiDomaci.Entiteti;
using DrugiDomaci.Mapiranja;
using NHibernate;
using NHibernate.Linq;
using DrugiDomaci.Forme;

namespace DrugiDomaci.Forme
{
    public partial class DodajORGForma : Form
    {
        public DodajORGForma()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Organizator org = new Organizator()
            {
                Ime = textBox1.Text,
                Prezime = textBox2.Text,
                Adresa = textBox3.Text,
                MBR=textBox4.Text
            };
            s.Save(org);
            MessageBox.Show("uspesno");
            this.Close();

            s.Close();
        }
    }
}
