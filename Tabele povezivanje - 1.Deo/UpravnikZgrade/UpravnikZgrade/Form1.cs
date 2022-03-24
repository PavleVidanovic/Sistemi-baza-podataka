using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using UpravnikZgrade.Entiteti;

namespace UpravnikZgrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try	

            {
                ISession s = DataLayer.GetSession();

                UpravnikZgrade.Entiteti.Upravnik u = s.Load<UpravnikZgrade.Entiteti.Upravnik>(129752025546);

                MessageBox.Show(u.LicnoIme);
                MessageBox.Show(u.Zgrade[0].Ulazi[0].RedniBrojUlaza.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message + ec.InnerException);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Osoba o = new Entiteti.Osoba();

                o.LicnoIme = "Milan";
                o.ImeRoditelja = "Veljko";
                o.Prezime = "Majstorovic";
                o.BrojTelefona = 0904682404;
                o.Mesto = "Nis";
                o.Ulica = "Mirisnih Vrba 5";
                o.MaticniBroj = 309463307856;

                s.SaveOrUpdate(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();

            //    Stan ss = s.Load<Stan>(5);

            //    MessageBox.Show(ss.ImenaStanara);

            //    s.Close();
            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                UpravnikZgrade.Entiteti.Zaposleni z = s.Load<UpravnikZgrade.Entiteti.Zaposleni>(3908239058253);

                MessageBox.Show(z.LicnoIme);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }


        }
    }
}
