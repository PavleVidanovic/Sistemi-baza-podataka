using DrugiDomaci.Entiteti;
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
using DrugiDomaci.Entiteti;
using DrugiDomaci;
using DrugiDomaci.Mapiranja;
using DrugiDomaci.Properties;
using DrugiDomaci.Forme;

namespace DrugiDomaci
{
    public partial class Form1 : Form
    {
        TurniriForma t;
        
        public Form1()
        {
            InitializeComponent();
        }

        

        //private void ucitajTurnirbtn_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        NHibernate.ISession s = DataLayer.GetSession();


        //        DrugiDomaci.Entiteti.Turnir zj = s.Load<DrugiDomaci.Entiteti.Turnir>(1);

        //        MessageBox.Show(zj.Naziv);

        //        s.Close();
        //    }
        //    catch (Exception ec)
        //    {
        //        MessageBox.Show(ec.Message + ec.InnerException);
        //    }
        //}

        //private void DodajSahistubtn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        NHibernate.ISession s = DataLayer.GetSession();
        //        Turnir t = s.Load<Turnir>(2);
        //        Sahista ss = s.Load<Sahista>(1);
        //        Sahista sss = s.Load<Sahista>(2);



        //        Entiteti.Sahista sah = s.Load<Sahista>(3);
        //        MK saah = new MK()
        //        {
        //            Ime = "Marko",
        //            Prezime = "Jankovic",
        //            Broj_pasosa = "22254566",
        //            Adresa = "aaaa",
        //            Zemlja = "zemljaaaa",
        //            Datum_rodjenja = new DateTime(1992, 11, 13),
        //            Datum_uclanjenja = new DateTime(2011, 12, 3),


        //            Broj_partija_do_majstora = 5,



        //        };
        //        s.Save(saah);
        //        MessageBox.Show("uspesno");

        //        s.Close();

        //    }
        //    catch (Exception ec)
        //    {
        //        MessageBox.Show(ec.Message);
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Form f = new proba();
        //    f.Show();
            


        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ISession s = DataLayer.GetSession();

        //        Sudija s1 = new Sudija();
        //        s1.ID_Sudije = 2;
        //        IEnumerable<Turnir> proizvodi = s.Query<Turnir>()
        //                                           .Where(p=>(p.Tip_turnira=="brzopotezni"))
        //                                            .OrderBy(p => p.ID_turnira)
        //                                            .Select(p => p);

        //        foreach (Turnir o in proizvodi)
        //        {
        //            MessageBox.Show(o.Naziv);
        //        }


        //        s.Close();

        //    }
        //    catch (Exception ec)
        //    {
        //        MessageBox.Show(ec.Message + ec.InnerException);
        //    }
        //}

        private void mnyTurniri_Click(object sender, EventArgs e)
        {
            TurniriForma tf = new TurniriForma();
            tf.MdiParent = this;
            tf.Show();
            
        }

        private void sahistiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SahistiForma tf = new SahistiForma();
            tf.MdiParent = this;
            tf.Show();
            
        }

        private void sponzoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SponzoriForma tf = new SponzoriForma();
            tf.MdiParent = this;
            tf.Show();
        }

       

        private void organizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrganizatorForma of = new OrganizatorForma();
            of.MdiParent = this;
            of.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
