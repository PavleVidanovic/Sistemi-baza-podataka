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
    public partial class OrganizatorForma : Form
    {
        public void FillCombo()
        {
            ISession s = DataLayer.GetSession();


            IEnumerable<Turnir> turniri = s.Query<Turnir>()
                                                .OrderBy(p => p.ID_turnira)
                                                .Select(p => p);

            foreach (Turnir o in turniri)
            {
                comboBox1.Items.Add(o.Naziv);
            }
            s.Close();

        }

        public OrganizatorForma()
        {
            InitializeComponent();
            FillCombo();
        }

        private void btnPregledOrganizatora_Click(object sender, EventArgs e)
        {
            lbxOrganizatori.Items.Clear();
            try
            {
                //int selectedIndex = comboBox1.SelectedIndex;
                //Object selectedItem = comboBox1.SelectedItem;
                ISession s = DataLayer.GetSession();

                IList<Organizator> organizators = (from o in s.Query<Organizator>()
                                                   select o).ToList<Organizator>();

                foreach (Organizator org in organizators)
                {


                    lbxOrganizatori.Items.Add("Ime: " + org.Ime + " Prez: " + org.Prezime + " MBR: " + org.MBR);


                }
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message + ec.InnerException);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;
            try
            {
                ISession s = DataLayer.GetSession();


                IList<Turnir> turniri = s.QueryOver<Turnir>()
                                                .Where(p => p.Naziv == selectedItem.ToString())
                                                .List<Turnir>();

                Turnir t = (Turnir)turniri[0];
                foreach (Organizator ss in t.Organizatori)
                {
                    listBox1.Items.Add(ss.Ime + " " + ss.Prezime + " ");
                }
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajORGForma dof = new DodajORGForma();
            dof.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenjajORGForma mof = new MenjajORGForma();
            mof.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BrisiORGForma bof = new BrisiORGForma();
            bof.Show();
        }
    }
}