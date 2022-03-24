
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

using NHibernate.Criterion;

namespace DrugiDomaci
{
    public partial class TurniriForma : Form
    {
       // TurniriForma t;
        public TurniriForma()
        {
            // this.t = t;
            InitializeComponent();
            FillCombo();
        }
        public void FillCombo()
        {
            ISession s = DataLayer.GetSession();


            IEnumerable<Turnir> turniri = s.Query<Turnir>()
                                                .OrderBy(p => p.ID_turnira)
                                                .Select(p => p);

            foreach (Turnir o in turniri)
            {
                comboBox1.Items.Add(o.Naziv);
                comboBox2.Items.Add(o.Naziv);
            }
            s.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                IEnumerable<Turnir> proizvodi = s.Query<Turnir>()
                                                    .OrderBy(p => p.ID_turnira)
                                                    .Select(p => p);

                foreach (Turnir o in proizvodi)
                {
                    lbxTurniri.Items.Add(o.Zemlja + "   " + o.Naziv + "   " + o.Tip_poteza);
                }


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message + ec.InnerException);
            }
        }

        private void btnUcesnici_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = comboBox1.SelectedIndex;
                Object selectedItem = comboBox1.SelectedItem;
                ISession s = DataLayer.GetSession();

                IList<Turnir> turniri = (from o in s.Query<Turnir>()
                                         where (o.Naziv== selectedItem.ToString())
                                         select o).ToList<Turnir>();

                foreach (Turnir t in turniri)
                {


                    listBox1.Items.Add(t.Naziv + " " + t.Zemlja + " " + t.Grad + " " + t.Trajanje);

                     
                  
                }
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message + ec.InnerException);
            }
        }

      
        public  List<Sahista> VratiSahiste()
        {
            List<Sahista> sahisti = new List<Sahista>();

            try
            {
                int selectedIndex = comboBox2.SelectedIndex;
                Object selectedItem = comboBox2.SelectedItem;
                ISession s = DataLayer.GetSession();

                IList<Turnir> turniri = (from o in s.Query<Turnir>()
                                         where (o.Naziv == selectedItem.ToString())
                                         select o).ToList<Turnir>();
                Turnir t = turniri[0];
                if (turniri != null)
                {
                    foreach (Sahista r in t.Sahisti)
                    {
                        sahisti.Add(new Sahista());
                    }
                }
                else
                {
                    MessageBox.Show("Ne postoji turnir.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    turniri = null;
                }

                s.Close();
            }
            catch (NHibernate.ObjectNotFoundException)
            {
                MessageBox.Show("Ne postoji park sa zadatim nazivom.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return null;
            }

            return sahisti;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox2.SelectedIndex;
            Object selectedItem = comboBox2.SelectedItem;
            try
            {
                ISession s = DataLayer.GetSession();


                IList<Turnir> turniri = s.QueryOver<Turnir>()
                                                .Where(p => p.Naziv== selectedItem.ToString())
                                                .List<Turnir>();

                Turnir t = (Turnir)turniri[0];
                foreach(Sahista ss in t.Sahisti)
                {
                    lbxUcesnici.Items.Add(ss.Ime+ " " + ss.Prezime+ " " + ss.Zemlja);
                }
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}


