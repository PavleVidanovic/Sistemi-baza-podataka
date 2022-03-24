using UpravnikZgrade.Entiteti;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravnikZgrade.Forme
{
    public partial class UpravniciForma : Form
    {
        public void FillCombo()
        {
            ISession s = DataLayer.GetSession();


            IEnumerable<Upravnik> osobe = s.Query<Upravnik>()
                                                .OrderBy(p => p.MaticniBroj)
                                                .Select(p => p);

            foreach (Upravnik o in osobe)
            {
                comboBox1.Items.Add(o.MaticniBroj);
                comboBox2.Items.Add(o.MaticniBroj);
                comboBox3.Items.Add(o.MaticniBroj);
            }
            s.Close();

        }
        public UpravniciForma()
        {
            InitializeComponent();
            FillCombo();
        }
        private void UpravniciForma_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new DodajUpravnikaForma();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Upravnik> upravnici = s.Query<Upravnik>()
                                                    .OrderBy(p => p.LicnoIme)
                                                    .Select(p => p);

                foreach (Upravnik o in upravnici)
                {
                    listBox1.Items.Add(o.LicnoIme + " " + o.Prezime + " " + "Mbr:" + o.MaticniBroj);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message + ec.InnerException);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;
            try
            {
                ISession s = DataLayer.GetSession();

                Upravnik o = s.Load<Upravnik>(Convert.ToInt64(selectedItem));

                s.Delete(o);
                MessageBox.Show("Odabrani upravnik je izbrisan.");

                s.Flush();
                s.Close();
                FillCombo();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox2.SelectedIndex;
            Object selectedItem = comboBox2.SelectedItem;
            try
            {
                ISession s = DataLayer.GetSession();

                Upravnik u = s.Load<Upravnik>(Convert.ToInt64(selectedItem));

                u.Mesto = textBox1.Text;
                u.Ulica = textBox3.Text;
                u.Pozicija = textBox2.Text;
                u.BrojTelefona = Convert.ToInt32(textBox4.Text);
                MessageBox.Show("Odabrani upravnik je azuriran.");

                s.Update(u);
                s.Flush();
                s.Close();
                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            int selectedIndex = comboBox3.SelectedIndex;
            Object selectedItem = comboBox3.SelectedItem;

            try
            {
                ISession s = DataLayer.GetSession();

                Upravnik u = s.Load<Upravnik>(Convert.ToInt64(selectedItem));

                listBox2.Items.Add("Mesto:" + u.Mesto + " Ulica: " + u.Ulica + " Broj Telefona: " + u.BrojTelefona + " Broj licne karte i mesto izdavanja: " 
                    + u.BrojLicneKarte + " " + u.MestoIzdavanjaLK + " Pozicija: " + u.Pozicija + " Naziv institucije: " + u.NazivInstitucije);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message + ec.InnerException);
            }
        }
    }
}
