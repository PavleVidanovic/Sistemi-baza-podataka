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
    public partial class VlasniciForma : Form
    {
        public void FillCombo()
        {
            ISession s = DataLayer.GetSession();


            IEnumerable<Vlasnik> vl = s.Query<Vlasnik>()
                                                .OrderBy(p => p.MaticniBroj)
                                                .Select(p => p);

            foreach (Vlasnik v in vl)
            {
                comboBox1.Items.Add(v.MaticniBroj);
            }
            s.Close();

        }
        public VlasniciForma()
        {
            InitializeComponent();
            FillCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vlasnik> vlasnici = s.Query<Vlasnik>()
                                                    .OrderBy(p => p.LicnoIme)
                                                    .Select(p => p);

                foreach (Vlasnik v in vlasnici)
                {
                    listBox1.Items.Add(v.LicnoIme + " " + v.Prezime + " " + "Mbr:" + v.MaticniBroj);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message + ec.InnerException);
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


                IList<Vlasnik> vk = s.QueryOver<Vlasnik>()
                                                .Where(p => p.MaticniBroj == Convert.ToInt64(selectedItem))
                                                .List<Vlasnik>();

                Vlasnik v = (Vlasnik)vk[0];
                foreach (Stan ss in v.Stanovi)
                {
                    listBox2.Items.Add("Broj stana:" + ss.RedniBrojStana + " Stanari: " + ss.ImenaStanara);
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message + ec.InnerException);
            }
        }
    }
}
