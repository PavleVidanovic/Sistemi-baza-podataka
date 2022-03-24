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
    public partial class ZgradeForma : Form
    {
        public void FillCombo()
        {
            ISession s = DataLayer.GetSession();


            IEnumerable<Zgrada> zz = s.Query<Zgrada>()
                                                .OrderBy(p => p.RedniBroj)
                                                .Select(p => p);

            foreach (Zgrada o in zz)
            {
                comboBox1.Items.Add(o.RedniBroj);
            }
            s.Close();

        }

        public ZgradeForma()
        {
            InitializeComponent();
            FillCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;
            try
            {
                ISession s = DataLayer.GetSession();


                IList<Zgrada> zg = s.QueryOver<Zgrada>()
                                                .Where(p => p.RedniBroj == Convert.ToInt32(selectedItem))
                                                .List<Zgrada>();

                Zgrada z = (Zgrada)zg[0];
                foreach (Ulaz ss in z.Ulazi)
                {
                    listBox1.Items.Add("Broj ulaza:" + ss.RedniBrojUlaza + " Kamera: " + ss.Kamera + " Vreme otvoren: " + ss.VremeOtvoren);
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;
            try
            {
                ISession s = DataLayer.GetSession();


                IList<Zgrada> zg = s.QueryOver<Zgrada>()
                                                .Where(p => p.RedniBroj == Convert.ToInt32(selectedItem))
                                                .List<Zgrada>();

                Zgrada z = (Zgrada)zg[0];
                foreach (Sprat ss in z.Spratovi)
                {
                    listBox2.Items.Add("Sprat:" + ss.Nivo);
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;
            try
            {
                ISession s = DataLayer.GetSession();


                IList<Zgrada> zg = s.QueryOver<Zgrada>()
                                                .Where(p => p.RedniBroj == Convert.ToInt32(selectedItem))
                                                .List<Zgrada>();

                Zgrada z = (Zgrada)zg[0];
                foreach (Lift ss in z.Liftovi)
                {
                    listBox3.Items.Add("Serijski broj:" + ss.SerijskiBroj + " Naziv proizvodjaca: " + ss.NazivProizvodjaca + " Broj dana pokvaren: " + ss.BrojPokvarenihDana);
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            SpratNizi sp = new SpratNizi()
            {
                Nivo = Int32.Parse(textBox4.Text),
                RedniBrojLokala = Int32.Parse(textBox1.Text),
                ImeFirme = textBox2.Text
            };

            try
            {
                ISession s = DataLayer.GetSession();
                Zgrada zgrada = s.Load<Zgrada>(Int32.Parse(textBox5.Text));
                sp.PripadaZgradi = zgrada;
                zgrada.Spratovi.Add(sp);
                s.Update(zgrada);
                s.Save(sp);
                s.Flush();
                MessageBox.Show("Dodat sprat.");
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message + ec.InnerException);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zgrada zr = new Zgrada()
                {
                    RedniBroj = Int32.Parse(textBox3.Text),
                };
                s.Save(zr);
                s.Flush();
                MessageBox.Show("Uspesno kreirana nova zgrada.");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message + ec.InnerException);
            }
        }
    }
}
