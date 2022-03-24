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
using NHibernate;
using NHibernate.Linq;

namespace DrugiDomaci
{
    public partial class SponzoriForma : Form
    {
        void FillCombo()
        {
            ISession s = DataLayer.GetSession();


            IEnumerable<Turnir> turniri = s.Query<Turnir>()
                                                .OrderBy(p => p.ID_turnira)
                                                .Select(p => p);

            foreach (Turnir o in turniri)
            {
                cbxTurnir.Items.Add(o.Naziv);
            }
            s.Close();

        }
        public SponzoriForma()
        {
            InitializeComponent();
            FillCombo();
        }

        private void SponzoriForma_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<SponzoriTurnira> sponzori = s.Query<SponzoriTurnira>()
                                                    .OrderBy(p => p.Id_Sponzora)
                                                    .Select(p => p);

                foreach (SponzoriTurnira o in sponzori)
                {
                    listBox1.Items.Add(o.Sponzor + " " + o.ID_turnira.Naziv);
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
            try
            {
                int selectedIndex = cbxTurnir.SelectedIndex;
                Object selectedItem = cbxTurnir.SelectedItem;
                ISession s = DataLayer.GetSession();

                IList<Turnir> turniri = (from o in s.Query<Turnir>()
                                         where (o.Naziv == selectedItem.ToString())
                                         select o).ToList<Turnir>();
                Turnir t = turniri[0];

                SponzoriTurnira spolzor = new SponzoriTurnira()
                {
                    Sponzor = tbxSponzor.Text,
                    ID_turnira = t

                };
                s.Save(spolzor);
                MessageBox.Show("uspesno");
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message + ec.InnerException);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form F = new proba();
            F.Show();
            listBox1.Items.Clear();
        }

      
    }
}

