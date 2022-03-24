using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrugiDomaci;
using DrugiDomaci.Entiteti;
using DrugiDomaci.Forme;
using NHibernate;
using NHibernate.Linq;

namespace DrugiDomaci.Forme
{
    public partial class BrisiORGForma : Form
    {
        void Fill()
        {
           
                ISession s = DataLayer.GetSession();


                IEnumerable<Organizator> organizatori = s.Query<Organizator>()
                                                    .OrderBy(p => p.Ime)
                                                    .Select(p => p);
                

                foreach (Organizator o in organizatori)
                {
                    comboBox1.Items.Add(o.Ime);
                }
                
                s.Close();


            }
        
        public BrisiORGForma()
        {
            InitializeComponent();
            Fill();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            try
            {
                ISession s = DataLayer.GetSession();
                IList<Organizator> organizatori = (from o in s.Query<Organizator>()
                                          where (o.Ime == selectedItem.ToString())
                                          select o).ToList<Organizator>();

                //brise se objekat iz baze ali ne i instanca objekta u memroiji
                Organizator organiz = organizatori[0];
                s.Delete(organiz);
                MessageBox.Show("Izbrisan organizator: " + organiz.Ime + " " + organiz.Prezime + " " );

                s.Flush();
                s.Close();
                Fill();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }
    }
}
