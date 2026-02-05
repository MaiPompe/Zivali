using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZivalLibrary
{
    abstract public class Zival
    {
        private double teza;
        private string naravniHabitat;
        private string hrana;
        private string oglasanje;
        private readonly string latinskoIme;

        public Zival(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme)
        {
            Teza = teza;
            NaravniHabitat = naravniHabitat;
            Hrana = hrana;
            Oglasanje = oglasanje;
            this.latinskoIme = latinskoIme;
        }

        public double Teza
        {
            get { return teza; }
            set { teza = value; }
        }

        public string NaravniHabitat
        {
            get { return naravniHabitat; }
            set { naravniHabitat = value; }
        }
        public string Hrana
        {
            get { return hrana; }
            set { hrana = value; }
        }

        public string Oglasanje
        {
            get { return oglasanje; }
            set { oglasanje = value; }
        }

        public string LatinskoIme
        {
            get { return latinskoIme; }
        }

        public static void OglasiSe(Zival z)
        {
            Console.WriteLine(z.Oglasanje);
        }

        public override string ToString()
        {
            string info = "Teza: " + teza + " kg\n" + "Naravni habitat: " + naravniHabitat + "\n" + "Hrana: " + hrana + "\n" + "Oglasanje: " + oglasanje + "\n" + "Latinsko ime: " + latinskoIme+ "\n";
            return info;
        }

        ~Zival()
        {
            Console.WriteLine("Žival je bil(a) odstranjena.");
        }

        public static string PrimerjajTezo(Zival z1, Zival z2)
        {
            if (z1.Teza < z2.Teza) return "Žival " + z2.LatinskoIme + " je težja.";
            else if (z1.Teza > z2.Teza) return "Žival " + z1.LatinskoIme + " je težja.";
            else return "Živali sta težki enako.";
        }

    }

    public class Sesalec : Zival
    {
        public Sesalec(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme) : base(teza, naravniHabitat, hrana, oglasanje, latinskoIme)
        {
            //enako kot base
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class KopenskiSesalec : Sesalec
    {
        private int steviloNog;
        private bool imaDlako;

        public int SteviloNog
        {
            get { return steviloNog; }
            set { steviloNog = value; }
        }

        public bool ImaDlako
        {
            get { return imaDlako; }
            set { imaDlako = value; }
        }

        public KopenskiSesalec(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme, int steviloNog, bool imaDlako) : base(teza, naravniHabitat, hrana, oglasanje, latinskoIme)
        {
            SteviloNog = steviloNog;
            ImaDlako = imaDlako;
        }

        public override string ToString()
        {
            return base.ToString() + "Stevilo nog: " + steviloNog + "\n" + "Ima dlako: " + (imaDlako ? "Da" : "Ne") + "\n";
        }
    }

    public class VodniSesalec : Sesalec
    {
        private double dolzinaPlavuti;
        private int steviloPlavuti;
        private double globinaPotopa;

        public double DolzinaPlavuti
        {
            get { return dolzinaPlavuti; }
            set { dolzinaPlavuti = value; }
        }

        public int SteviloPlavuti
        {
            get { return steviloPlavuti; }
            set { steviloPlavuti = value; }
        }

        public double GlobinaPotopa
        {
            get { return globinaPotopa; }
            set { globinaPotopa = value; }
        }

        public VodniSesalec(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme, double dolzinaPlavuti, int steviloPlavuti, double globinaPotopa) : base(teza, naravniHabitat, hrana, oglasanje, latinskoIme)
        {
            DolzinaPlavuti = dolzinaPlavuti;
            SteviloPlavuti = steviloPlavuti;
            GlobinaPotopa = globinaPotopa;
        }

        public override string ToString()
        {
            return base.ToString() + "Dolzina plavuti: " + dolzinaPlavuti + " cm\n" + "Stevilo plavuti: " + steviloPlavuti + "\n" + "Globina potopa: " + globinaPotopa + " cm\n";
        }
    }

    public class LeteciSesalec : Sesalec
    {
        private double razponKril;
        private double maxRazdaljaLeta;

        public double RazponKril
        {
            get { return razponKril; }
            set { razponKril = value; }
        }

        public double MaxRazdaljaLeta
        {
            get { return maxRazdaljaLeta; }
            set { maxRazdaljaLeta = value; }
        }

        public LeteciSesalec(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme, double razponKril, double maxRazdaljaLeta) : base(teza, naravniHabitat, hrana, oglasanje, latinskoIme)
        {
            RazponKril = razponKril;
            MaxRazdaljaLeta = maxRazdaljaLeta;
        }

        public override string ToString()
        {
            return base.ToString() + "Razpon kril: " + razponKril + " cm\n" + "Max razdalja leta: " + maxRazdaljaLeta + " km\n";
        }
    }

    public class Clenonozci : Zival
    {
        private int steviloNog;

        public int SteviloNog
        {
            get { return steviloNog; }
            set { steviloNog = value; }
        }

        public Clenonozci(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme, int steviloNog) :base(teza, naravniHabitat, hrana, oglasanje, latinskoIme)
        {
            SteviloNog = steviloNog;
        }

        public override string ToString()
        {
            return base.ToString() + "Stevilo nog: " + steviloNog + "\n";
        }
    }

    public class Zuzelke : Clenonozci
    {
        private bool leti;
        public bool Leti
        {
            get { return leti; }
            set { leti = value; }
        }
        public Zuzelke(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme, int steviloNog, bool leti) : base(teza, naravniHabitat, hrana, oglasanje, latinskoIme, steviloNog)
        {
            Leti = leti;
        }

        public override string ToString()
        {
            return base.ToString() + "Leti: " + (leti ? "Da" : "Ne") + "\n";
        }
    }

    public class Pajkovci : Clenonozci
    {
        private bool strupen;
        private bool pleteMrezo;

        public bool Strupen
        {
            get { return strupen; }
            set { strupen = value; }
        }

        public bool PleteMrezo
        {
            get { return pleteMrezo; }
            set { pleteMrezo = value; }
        }

        public Pajkovci(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme, int steviloNog, bool strupen, bool pleteMrezo) : base(teza, naravniHabitat, hrana, oglasanje, latinskoIme, steviloNog)
        {
            Strupen = strupen;
            PleteMrezo = pleteMrezo;
        }

        public override string ToString()
        {
            return base.ToString() + "Strupen: " + (strupen ? "Da" : "Ne") + "\n" + "Plete mrezo: " + (pleteMrezo ? "Da" : "Ne") + "\n";
        }
    }

    public class Raki : Clenonozci
    {
        private bool ziviVSlaniVodi;
        private double velikostKlesc;

        public bool ZiviVSlaniVodi
        {
            get { return ziviVSlaniVodi; }
            set { ziviVSlaniVodi = value; }
        }

        public double VelikostKlesc
        {
            get { return velikostKlesc; }
            set { velikostKlesc = value; }
        }

        public Raki(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme, int steviloNog, bool ziviVSlaniVodi, double velikostKlesc) : base(teza, naravniHabitat, hrana, oglasanje, latinskoIme, steviloNog)
        {
            ZiviVSlaniVodi = ziviVSlaniVodi;
            VelikostKlesc = velikostKlesc;
        }

        public override string ToString()
        {
            return base.ToString() + "Zivi v slani vodi: " + (ziviVSlaniVodi ? "Da" : "Ne") + "\n" + "Velikost klesc: " + velikostKlesc + " cm\n";
        }
    }
}