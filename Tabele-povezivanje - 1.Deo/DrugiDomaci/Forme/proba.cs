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
    public partial class proba : Form
    {
        void FillCombo()
        {
            try
            {
                ISession s = DataLayer.GetSession();


                IEnumerable<SponzoriTurnira> sponzori = s.Query<SponzoriTurnira>()
                                                    .OrderBy(p => p.ID_turnira)
                                                    .Select(p => p);

                foreach (SponzoriTurnira o in sponzori)
                {
                    comboBox1.Items.Add(o.Sponzor);
                }
                s.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public proba()
        {
            InitializeComponent();
            FillCombo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = comboBox1.SelectedIndex;
                Object selectedItem = comboBox1.SelectedItem;
                ISession s = DataLayer.GetSession();

                IList<SponzoriTurnira> sponzori = (from o in s.Query<SponzoriTurnira>()
                                         where (o.Sponzor == selectedItem.ToString())
                                         select o).ToList<SponzoriTurnira>();

                SponzoriTurnira t = sponzori[0];
                s.Close();

                t.Sponzor = textBox1.Text;

                ISession s1 = DataLayer.GetSession();

                s1.Update(t);

                s1.Flush();
                s1.Close();
                

                MessageBox.Show("uspesno");
                this.Close();
                

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message + ec.InnerException);
            }

        }
    }
}
