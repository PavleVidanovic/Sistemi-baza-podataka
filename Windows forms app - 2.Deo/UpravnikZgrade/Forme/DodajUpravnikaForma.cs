using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpravnikZgrade.Entiteti;
using UpravnikZgrade.Mapiranja;
using NHibernate;

namespace UpravnikZgrade.Forme
{
    public partial class DodajUpravnikaForma : Form
    {
        public DodajUpravnikaForma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Upravnik up = new Upravnik()
                {
                    LicnoIme = tbxIme.Text,
                    Prezime = tbxPrezime.Text,
                    ImeRoditelja = tbxRoditelj.Text,
                    MaticniBroj = Int64.Parse(tbxMbr.Text),
                    Mesto = tbxMesto.Text,
                    Ulica = tbxUlica.Text,
                    BrojTelefona = Int32.Parse(tbxTel.Text),
                    BrojLicneKarte = Int32.Parse(tbxBLK.Text),
                    MestoIzdavanjaLK = tbxMILK.Text,
                    NazivInstitucije = tbxNI.Text,
                    Pozicija = tbxPozicija.Text,
                    DatumDiplomiranja = new DateTime(),
                };
                s.Save(up);
                s.Flush();
                MessageBox.Show("Uspesno kreiran upravnik.");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message + ec.InnerException);
            }
        }
    }
}
