using DrugiDomaci.Entiteti;
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

namespace DrugiDomaci
{
    public partial class SahistiForma : Form
    {
        public void FillCombo()
        {
            ISession s = DataLayer.GetSession();


            IEnumerable<Sahista> turniri = s.Query<Sahista>()
                                                .OrderBy(p => p.Registracioni_broj)
                                                .Select(p => p);

            foreach (Sahista o in turniri)
            {
                comboBox1.Items.Add(o.Registracioni_broj);
            }
            s.Close();

        }
        public SahistiForma()
        {
            InitializeComponent();
            FillCombo();
        }

        private void SahistiForma_Load(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Sahista> sahisti = s.Query<Sahista>()
                                                    .OrderBy(p => p.Ime)
                                                    .Select(p => p);

                foreach (Sahista o in sahisti)
                {
                    listBox1.Items.Add(o.Ime + " " + o.Prezime + " " + o.Registracioni_broj);
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
            try
            {
                int selectedIndex = comboBox1.SelectedIndex;
                Object selectedItem = comboBox1.SelectedItem;

                ISession s = DataLayer.GetSession();

                IList<Sahista> sahisti = (from o in s.Query<Sahista>()
                                         where (o.Registracioni_broj == Convert.ToInt32(selectedItem))
                                         select o).ToList<Sahista>();

                foreach (Sahista t in sahisti)
                {


                    listBox2.Items.Add(t.Zemlja + " " +t.Ime + " " +t.Prezime + " " +t.Broj_pasosa + " " +t.Datum_rodjenja.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));



                }
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message + ec.InnerException);
            }
        }

        private void btnDodajSahistu_Click(object sender, EventArgs e)
        {
            Form f = new DodajSahistuForma();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            try
            {
                ISession s = DataLayer.GetSession();

                Sahista o = s.Load<Sahista>(Convert.ToInt32(selectedItem));

                //brise se objekat iz baze ali ne i instanca objekta u memroiji
                s.Delete(o);
                MessageBox.Show("Izbrisan sahista: " + o.Ime + " " + o.Prezime + " " + o.Registracioni_broj);
            
                s.Flush();
                s.Close();
                FillCombo();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
