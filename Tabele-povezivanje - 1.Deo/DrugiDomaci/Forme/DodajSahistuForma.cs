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

namespace DrugiDomaci
{
    public partial class DodajSahistuForma : Form
    {
        public DodajSahistuForma()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Obican saah = new Obican()
            {
                Ime = TbxIme.Text,
                Prezime = tbxPrezime.Text,
                Broj_pasosa =TbxBrojPasosa.Text,
                Adresa = TbxAdresa.Text,
                Zemlja = tbxZemlja.Text,
                Datum_rodjenja = new DateTime(1982, 11, 13),
                Datum_uclanjenja =  DateTime.Now,


                Kategorija = "obican",



            };
            s.Save(saah);
            MessageBox.Show("uspesno");

            s.Close();
        }
    }
}
