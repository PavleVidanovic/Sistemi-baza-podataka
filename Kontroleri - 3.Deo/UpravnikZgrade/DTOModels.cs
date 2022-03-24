using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravnikZgrade
{
    public class OsobaViewModel
    {
        public long MaticniBroj { get; set; }
        public string LicnoIme { get; set; }
        public string ImeRoditelja { get; set; }
        public string Prezime { get; set; }
        public int BrojTelefona { get; set; }
        public string Mesto { get; set; }
        public string Ulica { get; set; }
    }

    public class ZaposleniViewModel : OsobaViewModel
    {
        public string MestoIzdavanjaLK { get; set; }
        public int BrojLicneKarte { get; set; }
    }

    public class RacunovodjaViewModel : ZaposleniViewModel
    {
    }

    public class SekretarViewModel : ZaposleniViewModel
    {
    }

    public class UpravnikViewModel : ZaposleniViewModel
    {
        public string Pozicija { get; set; }
        public string NazivInstitucije { get; set; }
        public DateTime DatumDiplomiranja { get; set; }
    }

    public class LicencaViewModel
    {
        public int BrojLicence { get; set; }
        public DateTime DatumSticanja { get; set; }
        public DateTime DatumObnove { get; set; }

        public long PravoNaLicencu { get; set; }
    }

    public class ZgradaViewModel
    {
        public int RedniBroj { get; set; }

        public long Zaduzen { get; set; }
    }

    public class VlasnikViewModel : OsobaViewModel
    {
    }

    public class ClanSavetaViewModel : VlasnikViewModel
    {
    }

    public class BlagajnikViewModel : VlasnikViewModel
    {
    }

    public class PredsednikViewModel : VlasnikViewModel
    {
    }

    public class UgovorViewModel
    {
        public int Sifra { get; set; }
        public DateTime DatumPotpisivanja { get; set; }
        public int PeriodVazenja { get; set; }

        public int Potpisuje { get; set; }
    }

    public class UlazViewModel
    {
        public int RedniBrojUlaza { get; set; }
        public string Kamera { get; set; }
        public string VremeOtvoren { get; set; }

        public int Pripada { get; set; }
    }

    public class LiftViewModel
    {
        public string NazivProizvodjaca { get; set; }
        public DateTime DatumPoslednjegKvara { get; set; }
        public DateTime DatumPoslednjegServisiranja { get; set; }
        public int SerijskiBroj { get; set; }
        public int BrojPokvarenihDana { get; set; }

        public int Pripada { get; set; }
    }

    public class SpratViewModel
    {
        public int Nivo { get; set; }

        public int Pripada { get; set; }
    }

    public class TeretniViewModel : LiftViewModel
    {
        public int Nosivost { get; set; }
    }

    public class PrevozniViewModel : LiftViewModel
    {
        public int MaxOsoba { get; set; }
    }

    public class SpratVisiViewModel : SpratViewModel
    {
    }

    public class SpratNiziViewModel : SpratViewModel
    {
        public int RedniBrojLokala { get; set; }
        public string ImeFirme { get; set; }
    }

    public class SpratPodzemniViewModel : SpratViewModel
    {
        public int BrojParkingMesta { get; set; }
        public string Registracija { get; set; }
    }

    public class StanViewModel
    {
        public int RedniBrojStana { get; set; }
        public string ImenaStanara { get; set; }

        public long Pripada { get; set; }

        public int Deo { get; set; }
    }
}
