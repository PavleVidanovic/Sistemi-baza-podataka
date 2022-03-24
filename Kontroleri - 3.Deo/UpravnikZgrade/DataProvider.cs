using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpravnikZgrade.Entiteti;
using NHibernate;

namespace UpravnikZgrade
{
    public class DataProvider
    {
        public IList<OsobaViewModel> GetOsobe()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Osoba> lista = (from x in s.Query<Osoba>()
                                     select x).ToList<Osoba>();
                List<OsobaViewModel> rez = new List<OsobaViewModel>();
                foreach (Osoba o in lista)
                {
                    rez.Add(new OsobaViewModel()
                    {
                        MaticniBroj = o.MaticniBroj,
                        LicnoIme = o.LicnoIme,
                        ImeRoditelja = o.ImeRoditelja,
                        Prezime = o.Prezime,
                        BrojTelefona = o.BrojTelefona,
                        Mesto = o.Mesto,
                        Ulica = o.Ulica
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public OsobaViewModel GetOsoba(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Osoba osoba = s.Load<Osoba>(mbr);
                OsobaViewModel x = new OsobaViewModel()
                {
                    MaticniBroj = osoba.MaticniBroj,
                    LicnoIme = osoba.LicnoIme,
                    ImeRoditelja = osoba.ImeRoditelja,
                    Prezime = osoba.Prezime,
                    BrojTelefona = osoba.BrojTelefona,
                    Mesto = osoba.Mesto,
                    Ulica = osoba.Ulica
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public ZaposleniViewModel GetZaposleni(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zaposleni zap = s.Load<Zaposleni>(mbr);
                ZaposleniViewModel x = new ZaposleniViewModel()
                {
                    MaticniBroj = zap.MaticniBroj,
                    LicnoIme = zap.LicnoIme,
                    ImeRoditelja = zap.ImeRoditelja,
                    Prezime = zap.Prezime,
                    BrojTelefona = zap.BrojTelefona,
                    Mesto = zap.Mesto,
                    Ulica = zap.Ulica,
                    BrojLicneKarte = zap.BrojLicneKarte,
                    MestoIzdavanjaLK = zap.MestoIzdavanjaLK
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public IList<ZaposleniViewModel> GetZaposlene()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Zaposleni> lista = (from x in s.Query<Zaposleni>()
                                     select x).ToList<Zaposleni>();
                List<ZaposleniViewModel> rez = new List<ZaposleniViewModel>();
                foreach (Zaposleni z in lista)
                {
                    rez.Add(new ZaposleniViewModel()
                    {
                        MaticniBroj = z.MaticniBroj,
                        LicnoIme = z.LicnoIme,
                        ImeRoditelja = z.ImeRoditelja,
                        Prezime = z.Prezime,
                        BrojTelefona = z.BrojTelefona,
                        Mesto = z.Mesto,
                        Ulica = z.Ulica,
                        BrojLicneKarte = z.BrojLicneKarte,
                        MestoIzdavanjaLK = z.MestoIzdavanjaLK
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public IList<UpravnikViewModel> GetUpravnici()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Upravnik> lista = (from x in s.Query<Upravnik>()
                                     select x).ToList<Upravnik>();
                List<UpravnikViewModel> rez = new List<UpravnikViewModel>();
                foreach (Upravnik o in lista)
                {
                    rez.Add(new UpravnikViewModel()
                    {
                        MaticniBroj = o.MaticniBroj,
                        LicnoIme = o.LicnoIme,
                        ImeRoditelja = o.ImeRoditelja,
                        Prezime = o.Prezime,
                        BrojTelefona = o.BrojTelefona,
                        Mesto = o.Mesto,
                        Ulica = o.Ulica,
                        BrojLicneKarte = o.BrojLicneKarte,
                        MestoIzdavanjaLK = o.MestoIzdavanjaLK,
                        NazivInstitucije = o.NazivInstitucije,
                        Pozicija = o.Pozicija,
                        DatumDiplomiranja = o.DatumDiplomiranja
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public UpravnikViewModel GetUpravnik(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Upravnik zap = s.Load<Upravnik>(mbr);
                UpravnikViewModel x = new UpravnikViewModel()
                {
                    MaticniBroj = zap.MaticniBroj,
                    LicnoIme = zap.LicnoIme,
                    ImeRoditelja = zap.ImeRoditelja,
                    Prezime = zap.Prezime,
                    BrojTelefona = zap.BrojTelefona,
                    Mesto = zap.Mesto,
                    Ulica = zap.Ulica,
                    BrojLicneKarte = zap.BrojLicneKarte,
                    MestoIzdavanjaLK = zap.MestoIzdavanjaLK,
                    NazivInstitucije = zap.NazivInstitucije,
                    Pozicija = zap.Pozicija,
                    DatumDiplomiranja = zap.DatumDiplomiranja
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddUpravnik(UpravnikViewModel upravnik)
        {
            Upravnik up = new Upravnik()
            {
                MaticniBroj = upravnik.MaticniBroj,
                LicnoIme = upravnik.LicnoIme,
                ImeRoditelja = upravnik.ImeRoditelja,
                Prezime = upravnik.Prezime,
                BrojTelefona = upravnik.BrojTelefona,
                Mesto = upravnik.Mesto,
                Ulica = upravnik.Ulica,
                BrojLicneKarte = upravnik.BrojLicneKarte,
                MestoIzdavanjaLK = upravnik.MestoIzdavanjaLK,
                NazivInstitucije = upravnik.NazivInstitucije,
                Pozicija = upravnik.Pozicija,
                DatumDiplomiranja = upravnik.DatumDiplomiranja
            };
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(up);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateUpravnik(long mbr, UpravnikViewModel uvm)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Upravnik up = s.Load<Upravnik>(mbr);
                up.MaticniBroj = uvm.MaticniBroj;
                up.LicnoIme = uvm.LicnoIme;
                up.ImeRoditelja = uvm.ImeRoditelja;
                up.Prezime = uvm.Prezime;
                up.BrojTelefona = uvm.BrojTelefona;
                up.Mesto = uvm.Mesto;
                up.Ulica = uvm.Ulica;
                up.BrojLicneKarte = uvm.BrojLicneKarte;
                up.MestoIzdavanjaLK = uvm.MestoIzdavanjaLK;
                up.NazivInstitucije = uvm.NazivInstitucije;
                up.Pozicija = uvm.Pozicija;
                up.DatumDiplomiranja = uvm.DatumDiplomiranja;
                s.Update(up);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeleteUpravnik(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Upravnik u = s.Load<Upravnik>(mbr);
                s.Delete(u);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<LicencaViewModel> GetLicence()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Licenca> lista = (from x in s.Query<Licenca>()
                                        select x).ToList<Licenca>();
                List<LicencaViewModel> rez = new List<LicencaViewModel>();
                foreach (Licenca l in lista)
                {
                    rez.Add(new LicencaViewModel()
                    {
                        BrojLicence = l.BrojLicence,
                        DatumSticanja = l.DatumSticanja,
                        DatumObnove = l.DatumObnove,
                        PravoNaLicencu = l.JeStekao.MaticniBroj
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public LicencaViewModel GetLicenca(int brojlicence)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Licenca licenca = s.Load<Licenca>(brojlicence);
                LicencaViewModel x = new LicencaViewModel()
                {
                    BrojLicence = licenca.BrojLicence,
                    DatumSticanja = licenca.DatumSticanja,
                    DatumObnove = licenca.DatumObnove,
                    PravoNaLicencu = licenca.JeStekao.MaticniBroj
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddLicenca(LicencaViewModel c)
        {
            Licenca licenca = new Licenca()
            {
                BrojLicence = c.BrojLicence,
                DatumSticanja = c.DatumSticanja,
                DatumObnove = c.DatumObnove
            };
            try
            {
                ISession s = DataLayer.GetSession();
                Upravnik upravnik = s.Load<Upravnik>(c.PravoNaLicencu);
                licenca.JeStekao = upravnik;
                upravnik.Licence.Add(licenca);
                s.Update(upravnik);
                s.Save(licenca);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateLicenca(int brojlicence, LicencaViewModel c)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Licenca licenca = s.Load<Licenca>(brojlicence);
                licenca.BrojLicence = c.BrojLicence;
                licenca.DatumObnove = c.DatumObnove;
                licenca.DatumSticanja = c.DatumSticanja;
                if (licenca.JeStekao.MaticniBroj != c.PravoNaLicencu)
                {
                    Upravnik upravnik = s.Load<Upravnik>(c.PravoNaLicencu);
                    licenca.JeStekao.Licence.Remove(licenca);
                    s.Update(licenca.JeStekao);
                    licenca.JeStekao = upravnik;
                    upravnik.Licence.Add(licenca);
                    s.Update(upravnik);
                }
                s.Update(licenca);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeleteLicenca(int brojlicence)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Licenca licenca = s.Load<Licenca>(brojlicence);
                licenca.JeStekao.Licence.Remove(licenca);
                s.Update(licenca.JeStekao);
                s.Delete(licenca);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<ZgradaViewModel> GetZgrade()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Zgrada> lista = (from x in s.Query<Zgrada>()
                                       select x).ToList<Zgrada>();
                List<ZgradaViewModel> rez = new List<ZgradaViewModel>();
                foreach (Zgrada z in lista)
                {
                    rez.Add(new ZgradaViewModel()
                    {
                        RedniBroj = z.RedniBroj,
                        Zaduzen = z.ZaduzenZaZgradu.MaticniBroj
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public ZgradaViewModel GetZgrada(int rednibroj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zgrada z = s.Load<Zgrada>(rednibroj);
                ZgradaViewModel x = new ZgradaViewModel()
                {
                    RedniBroj = z.RedniBroj,
                    Zaduzen = z.ZaduzenZaZgradu.MaticniBroj
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddZgrada(ZgradaViewModel c)
        {
            Zgrada z = new Zgrada()
            {
                RedniBroj = c.RedniBroj
            };
            try
            {
                ISession s = DataLayer.GetSession();
                Upravnik upravnik = s.Load<Upravnik>(c.Zaduzen);
                z.ZaduzenZaZgradu = upravnik;
                upravnik.Zgrade.Add(z);
                s.Update(upravnik);
                s.Save(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateZgrada(int rednibroj, ZgradaViewModel c)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zgrada z = s.Load<Zgrada>(rednibroj);
                z.RedniBroj = c.RedniBroj;
                if (z.ZaduzenZaZgradu.MaticniBroj != c.Zaduzen)
                {
                    Upravnik upravnik = s.Load<Upravnik>(c.Zaduzen);
                    z.ZaduzenZaZgradu.Zgrade.Remove(z);
                    s.Update(z.ZaduzenZaZgradu);
                    z.ZaduzenZaZgradu = upravnik;
                    upravnik.Zgrade.Add(z);
                    s.Update(upravnik);
                }
                s.Update(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeleteZgrada(int rednibroj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zgrada z = s.Load<Zgrada>(rednibroj);
                z.ZaduzenZaZgradu.Zgrade.Remove(z);
                s.Update(z.ZaduzenZaZgradu);
                s.Delete(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<RacunovodjaViewModel> GetRacunovodje()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Racunovodja> lista = (from x in s.Query<Racunovodja>()
                                        select x).ToList<Racunovodja>();
                List<RacunovodjaViewModel> rez = new List<RacunovodjaViewModel>();
                foreach (Racunovodja o in lista)
                {
                    rez.Add(new RacunovodjaViewModel()
                    {
                        MaticniBroj = o.MaticniBroj,
                        LicnoIme = o.LicnoIme,
                        ImeRoditelja = o.ImeRoditelja,
                        Prezime = o.Prezime,
                        BrojTelefona = o.BrojTelefona,
                        Mesto = o.Mesto,
                        Ulica = o.Ulica,
                        BrojLicneKarte = o.BrojLicneKarte,
                        MestoIzdavanjaLK = o.MestoIzdavanjaLK
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public RacunovodjaViewModel GetRacunovodja(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Racunovodja o = s.Load<Racunovodja>(mbr);
                RacunovodjaViewModel x = new RacunovodjaViewModel()
                {
                    MaticniBroj = o.MaticniBroj,
                    LicnoIme = o.LicnoIme,
                    ImeRoditelja = o.ImeRoditelja,
                    Prezime = o.Prezime,
                    BrojTelefona = o.BrojTelefona,
                    Mesto = o.Mesto,
                    Ulica = o.Ulica,
                    BrojLicneKarte = o.BrojLicneKarte,
                    MestoIzdavanjaLK = o.MestoIzdavanjaLK
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddRacunovodja(RacunovodjaViewModel racunovodja)
        {
            Racunovodja r = new Racunovodja()
            {
                MaticniBroj = racunovodja.MaticniBroj,
                LicnoIme = racunovodja.LicnoIme,
                ImeRoditelja = racunovodja.ImeRoditelja,
                Prezime = racunovodja.Prezime,
                BrojTelefona = racunovodja.BrojTelefona,
                Mesto = racunovodja.Mesto,
                Ulica = racunovodja.Ulica,
                BrojLicneKarte = racunovodja.BrojLicneKarte,
                MestoIzdavanjaLK = racunovodja.MestoIzdavanjaLK
            };
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(r);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateRacunovodja(long mbr, RacunovodjaViewModel rvm)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Racunovodja r = s.Load<Racunovodja>(mbr);
                r.MaticniBroj = rvm.MaticniBroj;
                r.LicnoIme = rvm.LicnoIme;
                r.ImeRoditelja = rvm.ImeRoditelja;
                r.Prezime = rvm.Prezime;
                r.BrojTelefona = rvm.BrojTelefona;
                r.Mesto = rvm.Mesto;
                r.Ulica = rvm.Ulica;
                r.BrojLicneKarte = rvm.BrojLicneKarte;
                r.MestoIzdavanjaLK = rvm.MestoIzdavanjaLK;
                s.Update(r);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeleteRacunovodja(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Racunovodja r = s.Load<Racunovodja>(mbr);
                s.Delete(r);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<SekretarViewModel> GetSekretari()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Sekretar> lista = (from x in s.Query<Sekretar>()
                                           select x).ToList<Sekretar>();
                List<SekretarViewModel> rez = new List<SekretarViewModel>();
                foreach (Sekretar o in lista)
                {
                    rez.Add(new SekretarViewModel()
                    {
                        MaticniBroj = o.MaticniBroj,
                        LicnoIme = o.LicnoIme,
                        ImeRoditelja = o.ImeRoditelja,
                        Prezime = o.Prezime,
                        BrojTelefona = o.BrojTelefona,
                        Mesto = o.Mesto,
                        Ulica = o.Ulica,
                        BrojLicneKarte = o.BrojLicneKarte,
                        MestoIzdavanjaLK = o.MestoIzdavanjaLK
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public SekretarViewModel GetSekretar(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Sekretar o = s.Load<Sekretar>(mbr);
                SekretarViewModel x = new SekretarViewModel()
                {
                    MaticniBroj = o.MaticniBroj,
                    LicnoIme = o.LicnoIme,
                    ImeRoditelja = o.ImeRoditelja,
                    Prezime = o.Prezime,
                    BrojTelefona = o.BrojTelefona,
                    Mesto = o.Mesto,
                    Ulica = o.Ulica,
                    BrojLicneKarte = o.BrojLicneKarte,
                    MestoIzdavanjaLK = o.MestoIzdavanjaLK
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddSekretar(SekretarViewModel sekretar)
        {
            Sekretar r = new Sekretar()
            {
                MaticniBroj = sekretar.MaticniBroj,
                LicnoIme = sekretar.LicnoIme,
                ImeRoditelja = sekretar.ImeRoditelja,
                Prezime = sekretar.Prezime,
                BrojTelefona = sekretar.BrojTelefona,
                Mesto = sekretar.Mesto,
                Ulica = sekretar.Ulica,
                BrojLicneKarte = sekretar.BrojLicneKarte,
                MestoIzdavanjaLK = sekretar.MestoIzdavanjaLK
            };
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(r);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateSekretar(long mbr, SekretarViewModel svm)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Sekretar r = s.Load<Sekretar>(mbr);
                r.MaticniBroj = svm.MaticniBroj;
                r.LicnoIme = svm.LicnoIme;
                r.ImeRoditelja = svm.ImeRoditelja;
                r.Prezime = svm.Prezime;
                r.BrojTelefona = svm.BrojTelefona;
                r.Mesto = svm.Mesto;
                r.Ulica = svm.Ulica;
                r.BrojLicneKarte = svm.BrojLicneKarte;
                r.MestoIzdavanjaLK = svm.MestoIzdavanjaLK;
                s.Update(r);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeleteSekretar(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Sekretar r = s.Load<Sekretar>(mbr);
                s.Delete(r);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<VlasnikViewModel> GetVlasnici()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Vlasnik> lista = (from x in s.Query<Vlasnik>()
                                     select x).ToList<Vlasnik>();
                List<VlasnikViewModel> rez = new List<VlasnikViewModel>();
                foreach (Vlasnik o in lista)
                {
                    rez.Add(new VlasnikViewModel()
                    {
                        MaticniBroj = o.MaticniBroj,
                        LicnoIme = o.LicnoIme,
                        ImeRoditelja = o.ImeRoditelja,
                        Prezime = o.Prezime,
                        BrojTelefona = o.BrojTelefona,
                        Mesto = o.Mesto,
                        Ulica = o.Ulica
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public VlasnikViewModel GetVlasnik(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Vlasnik vlasnik = s.Load<Vlasnik>(mbr);
                VlasnikViewModel x = new VlasnikViewModel()
                {
                    MaticniBroj = vlasnik.MaticniBroj,
                    LicnoIme = vlasnik.LicnoIme,
                    ImeRoditelja = vlasnik.ImeRoditelja,
                    Prezime = vlasnik.Prezime,
                    BrojTelefona = vlasnik.BrojTelefona,
                    Mesto = vlasnik.Mesto,
                    Ulica = vlasnik.Ulica
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public IList<ClanSavetaViewModel> GetClanoviSaveta()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<ClanSaveta> lista = (from x in s.Query<ClanSaveta>()
                                        select x).ToList<ClanSaveta>();
                List<ClanSavetaViewModel> rez = new List<ClanSavetaViewModel>();
                foreach (ClanSaveta o in lista)
                {
                    rez.Add(new ClanSavetaViewModel()
                    {
                        MaticniBroj = o.MaticniBroj,
                        LicnoIme = o.LicnoIme,
                        ImeRoditelja = o.ImeRoditelja,
                        Prezime = o.Prezime,
                        BrojTelefona = o.BrojTelefona,
                        Mesto = o.Mesto,
                        Ulica = o.Ulica
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public ClanSavetaViewModel GetClanSaveta(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ClanSaveta zap = s.Load<ClanSaveta>(mbr);
                ClanSavetaViewModel x = new ClanSavetaViewModel()
                {
                    MaticniBroj = zap.MaticniBroj,
                    LicnoIme = zap.LicnoIme,
                    ImeRoditelja = zap.ImeRoditelja,
                    Prezime = zap.Prezime,
                    BrojTelefona = zap.BrojTelefona,
                    Mesto = zap.Mesto,
                    Ulica = zap.Ulica
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddClanSaveta(ClanSavetaViewModel clansaveta)
        {
            ClanSaveta cs = new ClanSaveta()
            {
                MaticniBroj = clansaveta.MaticniBroj,
                LicnoIme = clansaveta.LicnoIme,
                ImeRoditelja = clansaveta.ImeRoditelja,
                Prezime = clansaveta.Prezime,
                BrojTelefona = clansaveta.BrojTelefona,
                Mesto = clansaveta.Mesto,
                Ulica = clansaveta.Ulica
            };
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(cs);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateClanSaveta(long mbr, ClanSavetaViewModel csvm)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ClanSaveta cs = s.Load<ClanSaveta>(mbr);
                cs.MaticniBroj = csvm.MaticniBroj;
                cs.LicnoIme = csvm.LicnoIme;
                cs.ImeRoditelja = csvm.ImeRoditelja;
                cs.Prezime = csvm.Prezime;
                cs.BrojTelefona = csvm.BrojTelefona;
                cs.Mesto = csvm.Mesto;
                cs.Ulica = csvm.Ulica;
                s.Update(cs);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeleteClanSaveta(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ClanSaveta cs = s.Load<ClanSaveta>(mbr);
                s.Delete(cs);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<BlagajnikViewModel> GetBlagajnici()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Blagajnik> lista = (from x in s.Query<Blagajnik>()
                                        select x).ToList<Blagajnik>();
                List<BlagajnikViewModel> rez = new List<BlagajnikViewModel>();
                foreach (Blagajnik o in lista)
                {
                    rez.Add(new BlagajnikViewModel()
                    {
                        MaticniBroj = o.MaticniBroj,
                        LicnoIme = o.LicnoIme,
                        ImeRoditelja = o.ImeRoditelja,
                        Prezime = o.Prezime,
                        BrojTelefona = o.BrojTelefona,
                        Mesto = o.Mesto,
                        Ulica = o.Ulica
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public BlagajnikViewModel GetBlagajnik(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Blagajnik zap = s.Load<Blagajnik>(mbr);
                BlagajnikViewModel x = new BlagajnikViewModel()
                {
                    MaticniBroj = zap.MaticniBroj,
                    LicnoIme = zap.LicnoIme,
                    ImeRoditelja = zap.ImeRoditelja,
                    Prezime = zap.Prezime,
                    BrojTelefona = zap.BrojTelefona,
                    Mesto = zap.Mesto,
                    Ulica = zap.Ulica
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddBlagajnik(BlagajnikViewModel blagajnik)
        {
            Blagajnik b = new Blagajnik()
            {
                MaticniBroj = blagajnik.MaticniBroj,
                LicnoIme = blagajnik.LicnoIme,
                ImeRoditelja = blagajnik.ImeRoditelja,
                Prezime = blagajnik.Prezime,
                BrojTelefona = blagajnik.BrojTelefona,
                Mesto = blagajnik.Mesto,
                Ulica = blagajnik.Ulica
            };
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(b);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateBlagajnik(long mbr, BlagajnikViewModel bvm)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Blagajnik b = s.Load<Blagajnik>(mbr);
                b.MaticniBroj = bvm.MaticniBroj;
                b.LicnoIme = bvm.LicnoIme;
                b.ImeRoditelja = bvm.ImeRoditelja;
                b.Prezime = bvm.Prezime;
                b.BrojTelefona = bvm.BrojTelefona;
                b.Mesto = bvm.Mesto;
                b.Ulica = bvm.Ulica;
                s.Update(b);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeleteBlagajnik(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Blagajnik b = s.Load<Blagajnik>(mbr);
                s.Delete(b);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<PredsednikViewModel> GetPredsednici()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Predsednik> lista = (from x in s.Query<Predsednik>()
                                        select x).ToList<Predsednik>();
                List<PredsednikViewModel> rez = new List<PredsednikViewModel>();
                foreach (Predsednik o in lista)
                {
                    rez.Add(new PredsednikViewModel()
                    {
                        MaticniBroj = o.MaticniBroj,
                        LicnoIme = o.LicnoIme,
                        ImeRoditelja = o.ImeRoditelja,
                        Prezime = o.Prezime,
                        BrojTelefona = o.BrojTelefona,
                        Mesto = o.Mesto,
                        Ulica = o.Ulica
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public PredsednikViewModel GetPredsednik(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predsednik zap = s.Load<Predsednik>(mbr);
                PredsednikViewModel x = new PredsednikViewModel()
                {
                    MaticniBroj = zap.MaticniBroj,
                    LicnoIme = zap.LicnoIme,
                    ImeRoditelja = zap.ImeRoditelja,
                    Prezime = zap.Prezime,
                    BrojTelefona = zap.BrojTelefona,
                    Mesto = zap.Mesto,
                    Ulica = zap.Ulica
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddPredsednik(PredsednikViewModel predsednik)
        {
            Predsednik up = new Predsednik()
            {
                MaticniBroj = predsednik.MaticniBroj,
                LicnoIme = predsednik.LicnoIme,
                ImeRoditelja = predsednik.ImeRoditelja,
                Prezime = predsednik.Prezime,
                BrojTelefona = predsednik.BrojTelefona,
                Mesto = predsednik.Mesto,
                Ulica = predsednik.Ulica
            };
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(up);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdatePredsednik(long mbr, PredsednikViewModel pvm)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predsednik up = s.Load<Predsednik>(mbr);
                up.MaticniBroj = pvm.MaticniBroj;
                up.LicnoIme = pvm.LicnoIme;
                up.ImeRoditelja = pvm.ImeRoditelja;
                up.Prezime = pvm.Prezime;
                up.BrojTelefona = pvm.BrojTelefona;
                up.Mesto = pvm.Mesto;
                up.Ulica = pvm.Ulica;
                s.Update(up);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeletePredsednik(long mbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predsednik u = s.Load<Predsednik>(mbr);
                s.Delete(u);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<UgovorViewModel> GetUgovori()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Ugovor> lista = (from x in s.Query<Ugovor>()
                                      select x).ToList<Ugovor>();
                List<UgovorViewModel> rez = new List<UgovorViewModel>();
                foreach (Ugovor z in lista)
                {
                    rez.Add(new UgovorViewModel()
                    {
                        Sifra = z.Sifra,
                        DatumPotpisivanja = z.DatumPotpisivanja,
                        PeriodVazenja = z.PeriodVazenja,
                        Potpisuje = z.PotpisujeZgrada.RedniBroj
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public UgovorViewModel GetUgovor(int sifra)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ugovor z = s.Load<Ugovor>(sifra);
                UgovorViewModel x = new UgovorViewModel()
                {
                    Sifra = z.Sifra,
                    DatumPotpisivanja = z.DatumPotpisivanja,
                    PeriodVazenja = z.PeriodVazenja,
                    Potpisuje = z.PotpisujeZgrada.RedniBroj
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddUgovor(UgovorViewModel c)
        {
            Ugovor z = new Ugovor()
            {
                Sifra = c.Sifra,
                DatumPotpisivanja = c.DatumPotpisivanja,
                PeriodVazenja = c.PeriodVazenja
            };
            try
            {
                ISession s = DataLayer.GetSession();
                Zgrada zgrada = s.Load<Zgrada>(c.Potpisuje);
                z.PotpisujeZgrada = zgrada;
                zgrada.Ugovori.Add(z);
                s.Update(zgrada);
                s.Save(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateUgovor(int sifra, UgovorViewModel c)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ugovor z = s.Load<Ugovor>(sifra);
                z.Sifra = c.Sifra;
                z.DatumPotpisivanja = c.DatumPotpisivanja;
                z.PeriodVazenja = c.PeriodVazenja;
                if (z.PotpisujeZgrada.RedniBroj != c.Potpisuje)
                {
                    Zgrada zgrada = s.Load<Zgrada>(c.Potpisuje);
                    z.PotpisujeZgrada.Ugovori.Remove(z);
                    s.Update(z.PotpisujeZgrada);
                    z.PotpisujeZgrada = zgrada;
                    zgrada.Ugovori.Add(z);
                    s.Update(zgrada);
                }
                s.Update(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeleteUgovor(int sifra)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ugovor z = s.Load<Ugovor>(sifra);
                z.PotpisujeZgrada.Ugovori.Remove(z);
                s.Update(z.PotpisujeZgrada);
                s.Delete(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<UlazViewModel> GetUlazi()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Ulaz> lista = (from x in s.Query<Ulaz>()
                                      select x).ToList<Ulaz>();
                List<UlazViewModel> rez = new List<UlazViewModel>();
                foreach (Ulaz z in lista)
                {
                    rez.Add(new UlazViewModel()
                    {
                        RedniBrojUlaza = z.RedniBrojUlaza,
                        VremeOtvoren = z.VremeOtvoren,
                        Kamera = z.Kamera,
                        Pripada = z.PripadaZgradi.RedniBroj
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public UlazViewModel GetUlaz(int rednibrojulaza)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ulaz z = s.Load<Ulaz>(rednibrojulaza);
                UlazViewModel x = new UlazViewModel()
                {
                    RedniBrojUlaza = z.RedniBrojUlaza,
                    VremeOtvoren = z.VremeOtvoren,
                    Kamera = z.Kamera,
                    Pripada = z.PripadaZgradi.RedniBroj
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddUlaz(UlazViewModel c)
        {
            Ulaz z = new Ulaz()
            {
                RedniBrojUlaza = c.RedniBrojUlaza,
                VremeOtvoren = c.VremeOtvoren,
                Kamera = c.Kamera
            };
            try
            {
                ISession s = DataLayer.GetSession();
                Zgrada zgrada = s.Load<Zgrada>(c.Pripada);
                z.PripadaZgradi = zgrada;
                zgrada.Ulazi.Add(z);
                s.Update(zgrada);
                s.Save(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateUlaz(int rednibrojulaza, UlazViewModel c)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ulaz z = s.Load<Ulaz>(rednibrojulaza);
                z.RedniBrojUlaza = c.RedniBrojUlaza;
                z.VremeOtvoren = c.VremeOtvoren;
                z.Kamera = c.Kamera;
                if (z.PripadaZgradi.RedniBroj != c.Pripada)
                {
                    Zgrada zgrada = s.Load<Zgrada>(c.Pripada);
                    z.PripadaZgradi.Ulazi.Remove(z);
                    s.Update(z.PripadaZgradi);
                    z.PripadaZgradi = zgrada;
                    zgrada.Ulazi.Add(z);
                    s.Update(zgrada);
                }
                s.Update(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeleteUlaz(int rednibrojulaza)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ulaz z = s.Load<Ulaz>(rednibrojulaza);
                z.PripadaZgradi.Ulazi.Remove(z);
                s.Update(z.PripadaZgradi);
                s.Delete(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<LiftViewModel> GetLiftovi()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Lift> lista = (from x in s.Query<Lift>()
                                    select x).ToList<Lift>();
                List<LiftViewModel> rez = new List<LiftViewModel>();
                foreach (Lift z in lista)
                {
                    rez.Add(new LiftViewModel()
                    {
                        NazivProizvodjaca = z.NazivProizvodjaca,
                        DatumPoslednjegKvara = z.DatumPoslednjegKvara,
                        DatumPoslednjegServisiranja = z.DatumPoslednjegServisiranja,
                        SerijskiBroj = z.SerijskiBroj,
                        BrojPokvarenihDana = z.BrojPokvarenihDana,
                        Pripada = z.PripadaZgradi.RedniBroj
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public LiftViewModel GetLift(int serijskibroj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Lift z = s.Load<Lift>(serijskibroj);
                LiftViewModel x = new LiftViewModel()
                {
                    NazivProizvodjaca = z.NazivProizvodjaca,
                    DatumPoslednjegKvara = z.DatumPoslednjegKvara,
                    DatumPoslednjegServisiranja = z.DatumPoslednjegServisiranja,
                    SerijskiBroj = z.SerijskiBroj,
                    BrojPokvarenihDana = z.BrojPokvarenihDana,
                    Pripada = z.PripadaZgradi.RedniBroj
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public IList<SpratViewModel> GetSpratovi()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Sprat> lista = (from x in s.Query<Sprat>()
                                    select x).ToList<Sprat>();
                List<SpratViewModel> rez = new List<SpratViewModel>();
                foreach (Sprat z in lista)
                {
                    rez.Add(new SpratViewModel()
                    {
                        Nivo = z.Nivo,
                        Pripada = z.PripadaZgradi.RedniBroj
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public SpratViewModel GetSprat(int nivo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Sprat z = s.Load<Sprat>(nivo);
                SpratViewModel x = new SpratViewModel()
                {
                    Nivo = z.Nivo,
                    Pripada = z.PripadaZgradi.RedniBroj
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public IList<TeretniViewModel> GetTeretne()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Teretni> lista = (from x in s.Query<Teretni>()
                                           select x).ToList<Teretni>();
                List<TeretniViewModel> rez = new List<TeretniViewModel>();
                foreach (Teretni o in lista)
                {
                    rez.Add(new TeretniViewModel()
                    {
                        NazivProizvodjaca = o.NazivProizvodjaca,
                        DatumPoslednjegKvara = o.DatumPoslednjegKvara,
                        DatumPoslednjegServisiranja = o.DatumPoslednjegServisiranja,
                        SerijskiBroj = o.SerijskiBroj,
                        BrojPokvarenihDana = o.BrojPokvarenihDana,
                        Nosivost = o.Nosivost,
                        Pripada = o.PripadaZgradi.RedniBroj
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public TeretniViewModel GetTeretni(int serijskibroj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Teretni o = s.Load<Teretni>(serijskibroj);
                TeretniViewModel x = new TeretniViewModel()
                {
                    NazivProizvodjaca = o.NazivProizvodjaca,
                    DatumPoslednjegKvara = o.DatumPoslednjegKvara,
                    DatumPoslednjegServisiranja = o.DatumPoslednjegServisiranja,
                    SerijskiBroj = o.SerijskiBroj,
                    BrojPokvarenihDana = o.BrojPokvarenihDana,
                    Nosivost = o.Nosivost,
                    Pripada = o.PripadaZgradi.RedniBroj
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddTeretni(TeretniViewModel c)
        {
            Teretni z = new Teretni()
            {
                NazivProizvodjaca = c.NazivProizvodjaca,
                DatumPoslednjegKvara = c.DatumPoslednjegKvara,
                DatumPoslednjegServisiranja = c.DatumPoslednjegServisiranja,
                SerijskiBroj = c.SerijskiBroj,
                BrojPokvarenihDana = c.BrojPokvarenihDana,
                Nosivost = c.Nosivost
            };
            try
            {
                ISession s = DataLayer.GetSession();
                Zgrada zgrada = s.Load<Zgrada>(c.Pripada);
                z.PripadaZgradi = zgrada;
                zgrada.Liftovi.Add(z);
                s.Update(zgrada);
                s.Save(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateTeretni(int serijskibroj, TeretniViewModel c)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Teretni z = s.Load<Teretni>(serijskibroj);
                z.NazivProizvodjaca = c.NazivProizvodjaca;
                z.DatumPoslednjegKvara = c.DatumPoslednjegKvara;
                z.DatumPoslednjegServisiranja = c.DatumPoslednjegServisiranja;
                z.SerijskiBroj = c.SerijskiBroj;
                z.BrojPokvarenihDana = c.BrojPokvarenihDana;
                z.Nosivost = c.Nosivost;
                if (z.PripadaZgradi.RedniBroj != c.Pripada)
                {
                    Zgrada zgrada = s.Load<Zgrada>(c.Pripada);
                    z.PripadaZgradi.Liftovi.Remove(z);
                    s.Update(z.PripadaZgradi);
                    z.PripadaZgradi = zgrada;
                    zgrada.Liftovi.Add(z);
                    s.Update(zgrada);
                }
                s.Update(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeleteTeretni(int serijskibroj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Teretni z = s.Load<Teretni>(serijskibroj);
                z.PripadaZgradi.Liftovi.Remove(z);
                s.Update(z.PripadaZgradi);
                s.Delete(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<PrevozniViewModel> GetPrevozne()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Prevozni> lista = (from x in s.Query<Prevozni>()
                                       select x).ToList<Prevozni>();
                List<PrevozniViewModel> rez = new List<PrevozniViewModel>();
                foreach (Prevozni o in lista)
                {
                    rez.Add(new PrevozniViewModel()
                    {
                        NazivProizvodjaca = o.NazivProizvodjaca,
                        DatumPoslednjegKvara = o.DatumPoslednjegKvara,
                        DatumPoslednjegServisiranja = o.DatumPoslednjegServisiranja,
                        SerijskiBroj = o.SerijskiBroj,
                        BrojPokvarenihDana = o.BrojPokvarenihDana,
                        MaxOsoba = o.MaxOsoba,
                        Pripada = o.PripadaZgradi.RedniBroj
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public PrevozniViewModel GetPrevozni(int serijskibroj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Prevozni o = s.Load<Prevozni>(serijskibroj);
                PrevozniViewModel x = new PrevozniViewModel()
                {
                    NazivProizvodjaca = o.NazivProizvodjaca,
                    DatumPoslednjegKvara = o.DatumPoslednjegKvara,
                    DatumPoslednjegServisiranja = o.DatumPoslednjegServisiranja,
                    SerijskiBroj = o.SerijskiBroj,
                    BrojPokvarenihDana = o.BrojPokvarenihDana,
                    MaxOsoba = o.MaxOsoba,
                    Pripada = o.PripadaZgradi.RedniBroj
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddPrevozni(PrevozniViewModel c)
        {
            Prevozni z = new Prevozni()
            {
                NazivProizvodjaca = c.NazivProizvodjaca,
                DatumPoslednjegKvara = c.DatumPoslednjegKvara,
                DatumPoslednjegServisiranja = c.DatumPoslednjegServisiranja,
                SerijskiBroj = c.SerijskiBroj,
                BrojPokvarenihDana = c.BrojPokvarenihDana,
                MaxOsoba = c.MaxOsoba
            };
            try
            {
                ISession s = DataLayer.GetSession();
                Zgrada zgrada = s.Load<Zgrada>(c.Pripada);
                z.PripadaZgradi = zgrada;
                zgrada.Liftovi.Add(z);
                s.Update(zgrada);
                s.Save(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdatePrevozni(int serijskibroj, PrevozniViewModel c)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Prevozni z = s.Load<Prevozni>(serijskibroj);
                z.NazivProizvodjaca = c.NazivProizvodjaca;
                z.DatumPoslednjegKvara = c.DatumPoslednjegKvara;
                z.DatumPoslednjegServisiranja = c.DatumPoslednjegServisiranja;
                z.SerijskiBroj = c.SerijskiBroj;
                z.BrojPokvarenihDana = c.BrojPokvarenihDana;
                z.MaxOsoba = c.MaxOsoba;
                if (z.PripadaZgradi.RedniBroj != c.Pripada)
                {
                    Zgrada zgrada = s.Load<Zgrada>(c.Pripada);
                    z.PripadaZgradi.Liftovi.Remove(z);
                    s.Update(z.PripadaZgradi);
                    z.PripadaZgradi = zgrada;
                    zgrada.Liftovi.Add(z);
                    s.Update(zgrada);
                }
                s.Update(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeletePrevozni(int serijskibroj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Prevozni z = s.Load<Prevozni>(serijskibroj);
                z.PripadaZgradi.Liftovi.Remove(z);
                s.Update(z.PripadaZgradi);
                s.Delete(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<SpratPodzemniViewModel> GetPodzemne()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<SpratPodzemni> lista = (from x in s.Query<SpratPodzemni>()
                                        select x).ToList<SpratPodzemni>();
                List<SpratPodzemniViewModel> rez = new List<SpratPodzemniViewModel>();
                foreach (SpratPodzemni o in lista)
                {
                    rez.Add(new SpratPodzemniViewModel()
                    {
                        Nivo = o.Nivo,
                        BrojParkingMesta = o.BrojParkingMesta,
                        Registracija = o.Registracija,
                        Pripada = o.PripadaZgradi.RedniBroj
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public SpratPodzemniViewModel GetPodzemni(int nivo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpratPodzemni o = s.Load<SpratPodzemni>(nivo);
                SpratPodzemniViewModel x = new SpratPodzemniViewModel()
                {
                    Nivo = o.Nivo,
                    BrojParkingMesta = o.BrojParkingMesta,
                    Registracija = o.Registracija,
                    Pripada = o.PripadaZgradi.RedniBroj
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddPodzemni(SpratPodzemniViewModel c)
        {
            SpratPodzemni z = new SpratPodzemni()
            {
                Nivo = c.Nivo,
                BrojParkingMesta = c.BrojParkingMesta,
                Registracija = c.Registracija
            };
            try
            {
                ISession s = DataLayer.GetSession();
                Zgrada zgrada = s.Load<Zgrada>(c.Pripada);
                z.PripadaZgradi = zgrada;
                zgrada.Spratovi.Add(z);
                s.Update(zgrada);
                s.Save(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdatePodzemni(int nivo, SpratPodzemniViewModel c)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpratPodzemni z = s.Load<SpratPodzemni>(nivo);
                z.Nivo = c.Nivo;
                z.BrojParkingMesta = c.BrojParkingMesta;
                z.Registracija = c.Registracija;
                if (z.PripadaZgradi.RedniBroj != c.Pripada)
                {
                    Zgrada zgrada = s.Load<Zgrada>(c.Pripada);
                    z.PripadaZgradi.Spratovi.Remove(z);
                    s.Update(z.PripadaZgradi);
                    z.PripadaZgradi = zgrada;
                    zgrada.Spratovi.Add(z);
                    s.Update(zgrada);
                }
                s.Update(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeletePodzemni(int nivo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpratPodzemni z = s.Load<SpratPodzemni>(nivo);
                z.PripadaZgradi.Spratovi.Remove(z);
                s.Update(z.PripadaZgradi);
                s.Delete(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<SpratNiziViewModel> GetNize()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<SpratNizi> lista = (from x in s.Query<SpratNizi>()
                                             select x).ToList<SpratNizi>();
                List<SpratNiziViewModel> rez = new List<SpratNiziViewModel>();
                foreach (SpratNizi o in lista)
                {
                    rez.Add(new SpratNiziViewModel()
                    {
                        Nivo = o.Nivo,
                        RedniBrojLokala = o.RedniBrojLokala,
                        ImeFirme = o.ImeFirme,
                        Pripada = o.PripadaZgradi.RedniBroj
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public SpratNiziViewModel GetNizi(int nivo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpratNizi o = s.Load<SpratNizi>(nivo);
                SpratNiziViewModel x = new SpratNiziViewModel()
                {
                    Nivo = o.Nivo,
                    RedniBrojLokala = o.RedniBrojLokala,
                    ImeFirme = o.ImeFirme,
                    Pripada = o.PripadaZgradi.RedniBroj
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddNizi(SpratNiziViewModel c)
        {
            SpratNizi z = new SpratNizi()
            {
                Nivo = c.Nivo,
                RedniBrojLokala = c.RedniBrojLokala,
                ImeFirme = c.ImeFirme
            };
            try
            {
                ISession s = DataLayer.GetSession();
                Zgrada zgrada = s.Load<Zgrada>(c.Pripada);
                z.PripadaZgradi = zgrada;
                zgrada.Spratovi.Add(z);
                s.Update(zgrada);
                s.Save(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateNizi(int nivo, SpratNiziViewModel c)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpratNizi z = s.Load<SpratNizi>(nivo);
                z.Nivo = c.Nivo;
                z.RedniBrojLokala = c.RedniBrojLokala;
                z.ImeFirme = c.ImeFirme;
                if (z.PripadaZgradi.RedniBroj != c.Pripada)
                {
                    Zgrada zgrada = s.Load<Zgrada>(c.Pripada);
                    z.PripadaZgradi.Spratovi.Remove(z);
                    s.Update(z.PripadaZgradi);
                    z.PripadaZgradi = zgrada;
                    zgrada.Spratovi.Add(z);
                    s.Update(zgrada);
                }
                s.Update(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeleteNizi(int nivo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpratNizi z = s.Load<SpratNizi>(nivo);
                z.PripadaZgradi.Spratovi.Remove(z);
                s.Update(z.PripadaZgradi);
                s.Delete(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<SpratVisiViewModel> GetVise()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<SpratVisi> lista = (from x in s.Query<SpratVisi>()
                                         select x).ToList<SpratVisi>();
                List<SpratVisiViewModel> rez = new List<SpratVisiViewModel>();
                foreach (SpratVisi o in lista)
                {
                    rez.Add(new SpratVisiViewModel()
                    {
                        Nivo = o.Nivo,
                        Pripada = o.PripadaZgradi.RedniBroj
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public SpratVisiViewModel GetVisi(int nivo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpratVisi o = s.Load<SpratVisi>(nivo);
                SpratVisiViewModel x = new SpratVisiViewModel()
                {
                    Nivo = o.Nivo,
                    Pripada = o.PripadaZgradi.RedniBroj
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddVisi(SpratVisiViewModel c)
        {
            SpratVisi z = new SpratVisi()
            {
                Nivo = c.Nivo
            };
            try
            {
                ISession s = DataLayer.GetSession();
                Zgrada zgrada = s.Load<Zgrada>(c.Pripada);
                z.PripadaZgradi = zgrada;
                zgrada.Spratovi.Add(z);
                s.Update(zgrada);
                s.Save(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateVisi(int nivo, SpratVisiViewModel c)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpratVisi z = s.Load<SpratVisi>(nivo);
                z.Nivo = c.Nivo;
                if (z.PripadaZgradi.RedniBroj != c.Pripada)
                {
                    Zgrada zgrada = s.Load<Zgrada>(c.Pripada);
                    z.PripadaZgradi.Spratovi.Remove(z);
                    s.Update(z.PripadaZgradi);
                    z.PripadaZgradi = zgrada;
                    zgrada.Spratovi.Add(z);
                    s.Update(zgrada);
                }
                s.Update(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeleteVisi(int nivo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpratVisi z = s.Load<SpratVisi>(nivo);
                z.PripadaZgradi.Spratovi.Remove(z);
                s.Update(z.PripadaZgradi);
                s.Delete(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public IList<StanViewModel> GetStanovi()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                List<Stan> lista = (from x in s.Query<Stan>()
                                         select x).ToList<Stan>();
                List<StanViewModel> rez = new List<StanViewModel>();
                foreach (Stan o in lista)
                {
                    rez.Add(new StanViewModel()
                    {
                        ImenaStanara = o.ImenaStanara,
                        RedniBrojStana = o.RedniBrojStana,
                        Pripada = o.PripadaVlasniku.MaticniBroj,
                        Deo = o.JeDeo.Nivo
                    });
                }
                return rez;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public StanViewModel GetStan(int rednibrojstana)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Stan o = s.Load<Stan>(rednibrojstana);
                StanViewModel x = new StanViewModel()
                {
                    ImenaStanara = o.ImenaStanara,
                    RedniBrojStana = o.RedniBrojStana,
                    Pripada = o.PripadaVlasniku.MaticniBroj,
                    Deo = o.JeDeo.Nivo
                };
                return x;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public int AddStan(StanViewModel c)
        {
            Stan z = new Stan()
            {
                ImenaStanara = c.ImenaStanara,
                RedniBrojStana = c.RedniBrojStana
            };
            try
            {
                ISession s = DataLayer.GetSession();
                SpratVisi sprat = s.Load<SpratVisi>(c.Deo);
                z.JeDeo = sprat;
                sprat.Stanovi.Add(z);
                Vlasnik vlasnik = s.Load<Vlasnik>(c.Pripada);
                z.PripadaVlasniku = vlasnik;
                vlasnik.StanoviVlasnik.Add(z);
                s.Update(sprat);
                s.Save(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateStan(int rednibrojstana, StanViewModel c)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Stan z = s.Load<Stan>(rednibrojstana);
                z.ImenaStanara = c.ImenaStanara;
                z.RedniBrojStana = c.RedniBrojStana;
                if (z.PripadaVlasniku.MaticniBroj != c.Pripada)
                {
                    Vlasnik vlasnik = s.Load<Vlasnik>(c.Pripada);
                    z.PripadaVlasniku.StanoviVlasnik.Remove(z);
                    s.Update(z.PripadaVlasniku);
                    z.PripadaVlasniku = vlasnik;
                    vlasnik.StanoviVlasnik.Add(z);
                    s.Update(vlasnik);
                }
                if (z.JeDeo.Nivo != c.Deo)
                {
                    SpratVisi visi = s.Load<SpratVisi>(c.Pripada);
                    z.JeDeo.Stanovi.Remove(z);
                    s.Update(z.JeDeo);
                    z.JeDeo = visi;
                    visi.Stanovi.Add(z);
                    s.Update(visi);
                }
                s.Update(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int DeleteStan(int rednibrojstana)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Stan z = s.Load<Stan>(rednibrojstana);
                z.PripadaVlasniku.StanoviVlasnik.Remove(z);
                z.JeDeo.Stanovi.Remove(z);
                s.Update(z.PripadaVlasniku);
                s.Update(z.JeDeo);
                s.Delete(z);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
    }
}
