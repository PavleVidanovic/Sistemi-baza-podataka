using NHibernate;
using NHibernate.Linq;
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



namespace DrugiDomaci.Forme
{

    public partial class MenjajORGForma : Form
    {
        void FillOrgAndSud()
        {
            ISession s = DataLayer.GetSession();


            IEnumerable<Organizator> organizatori = s.Query<Organizator>()
                                                .OrderBy(p => p.Ime)
                                                .Select(p => p);
            IEnumerable<Sudija> sudije = s.Query<Sudija>()
                                              .OrderBy(p => p.ID_Sudije)
                                              .Select(p => p);

            foreach (Organizator o in organizatori)
            {
                comboBox2.Items.Add(o.Ime);
            }
            foreach(Sudija ss in sudije)
            {
                comboBox1.Items.Add(ss.ID_Sudije);
            }
            s.Close();


        }

        public MenjajORGForma()
        {
            InitializeComponent();
            FillOrgAndSud();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            int selectedIndex2 = comboBox2.SelectedIndex;
            Object selectedItem2 = comboBox2.SelectedItem;
            try
            {
               
                ISession s = DataLayer.GetSession();

                IList<Organizator> organizatori = (from o in s.Query<Organizator>()
                                                   where (o.Ime == selectedItem2.ToString())
                                                   select o).ToList<Organizator>();
                Sudija sudac = s.Load<Sudija>(Convert.ToInt32(selectedItem));
                Organizator t = organizatori[0];
                s.Close();

                t.Prezime = textBox1.Text;
                t.Adresa = textBox2.Text;
                t.Sudija_ID = sudac;

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
