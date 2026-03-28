using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZivalLibrary
{
    /// <summary>
    /// Osnoven vmesnik za vse živali. Določa skupne lastnosti, ki jih mora implementirati vsaka žival.
    /// </summary>
    interface IZival
    {
        double Teza { get; set; }
        string NaravniHabitat { get; set; }
        string Hrana { get; set; }
        string Oglasanje { get; set; }
        string LatinskoIme { get; }
    }

    /// <summary>
    /// Vmesnik za sesalce. Deduje vse lastnosti vmesnika IZival.
    /// </summary>
    interface ISesalec : IZival
    {
        //Isto kot IZival
    }

    /// <summary>
    /// Vmesnik za kopenske sesalce z dodanimi lastnostmi, ki jih deduje od ISesalec.
    /// </summary>
    interface IKopenskiSesalec : ISesalec
    {
        int SteviloNog { get; set; }
        bool ImaDlako { get; set; }
    }

    /// <summary>
    /// Vmesnik za vodne sesalce z dodanimi lastnostmi, ki jih deduje od ISesalec.
    /// </summary>
    interface IVodniSesalec : ISesalec
    {
        double DolzinaPlavuti { get; set; }
        int SteviloPlavuti { get; set; }
        double GlobinaPotopa { get; set; }
    }

    /// <summary>
    /// Vmesnik za leteče sesalce z dodanimi lastnostmi, ki jih deduje od ISesalec.
    /// </summary>
    interface ILeteciSesalec : ISesalec
    {
        double RazponKril { get; set; }
        double MaxRazdaljaLeta { get; set; }
    }

    /// <summary>
    /// Vmesnik za členonožce. Deduje lastnosti vmesnika IZival.
    /// </summary>
    interface IClenonozci : IZival
    {
        int SteviloNog { get; set; }
    }

    /// <summary>
    /// Vmesnik za žuželke z dodanimi lastnostmi, ki jih deduje od IClenonozci.
    /// </summary>
    interface IZuzelke : IClenonozci
    {
        bool Leti { get; set; }
    }

    /// <summary>
    /// Vmesnik za pajkovce z dodanimi lastnostmi, ki jih deduje od IClenonozci.
    /// </summary>
    interface IPajkovci : IClenonozci
    {
        bool Strupen { get; set; }
        bool PleteMrezo { get; set; }
    }

    /// <summary>
    /// Vmesnik za rake z dodanimi lastnostmi, ki jih deduje od IClenonozci.
    /// </summary>
    interface IRaki : IClenonozci
    {
        bool ZiviVSlaniVodi { get; set; }
        double VelikostKlesc { get; set; }
    }

    /// <summary>
    /// Delegat za metodo, ki vrne oglašanje živali.
    /// </summary>
    /// <param name="z">Žival, ki se oglaša.</param>
    /// <returns>Niz z oglašanjem živali.</returns>
    public delegate string OglasanjeZivali(Zival z);

    /// <summary>
    /// Delegat za dogodek, ki se sproži ob ustvarjanju nove živali.
    /// </summary>
    /// <param name="z">Ustvarjena žival.</param>
    /// <param name="ime">Ime ustvarjene živali.</param>
    public delegate void ZivalUstvarjenaEventHandler(Zival z, string ime);


    abstract public class Zival : IZival
    {
        /// <summary>
        /// Dogodek, ki se sproži, ko je žival ustvarjena.
        /// </summary>
        public event ZivalUstvarjenaEventHandler ZivalUstvarjena;

        /// <summary>
        /// Sproži dogodek ZivalUstvarjena z imenom živali.
        /// </summary>
        /// <param name="ime">Ime ustvarjene živali.</param>
        public void KoJeZivalUstvarjena(string ime)
        {
            ZivalUstvarjena(this, ime);
        }

        private double teza;
        private string naravniHabitat;
        private string hrana;
        private string oglasanje;
        private readonly string latinskoIme;

        /// <summary>
        /// Indekser, ki omogoča dostop do podatkov živali po indeksu.
        /// </summary>
        /// <param name="index">Indeks podatka živali</param>
        /// <returns>Podatek na indeksu ali sporočilo o napaki za neveljaven indeks.</returns>
        public string this[int index]
        {
            get 
            {
                if(index == 0) return teza.ToString();
                else if (index == 1) return naravniHabitat;
                else if (index == 2) return hrana;
                else if (index == 3) return oglasanje;
                else if (index == 4) return latinskoIme;
                else return "Ta podatek ne obstaja. Izberite drugega.";
            }
        }

        /// <summary>
        /// Ustvari nov primerek razreda Zival.
        /// </summary>
        /// <param name="teza">Teža živali v kg.</param>
        /// <param name="naravniHabitat">Naravni habitat živali.</param>
        /// <param name="hrana">Vrsta hrane živali.</param>
        /// <param name="oglasanje">Oglašanje živali.</param>
        /// <param name="latinskoIme">Latinsko ime živali.</param>
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

        /// <summary>
        /// Izpiše oglašanje živali.
        /// </summary>
        /// <param name="z">Žival, katere oglašanje se izpiše.</param>
        public static void OglasiSe(Zival z)
        {
            Console.WriteLine(z.Oglasanje);
        }

        /// <summary>
        /// Metoda, ki omogoča premikanje živali.
        /// </summary>
        /// <returns>"Žival se premika"</returns>
        public virtual string PremakniSe()
        {
            return "Žival se premika.";
        }

        /// <summary>
        /// Vrne vse podatke živali v oblikovanem nizu.
        /// </summary>
        /// <returns>Oblikovan niz z vsemi podatki živali.</returns>
        public override string ToString()
        {
            string info = "Teza: " + teza + " kg\n" + "Naravni habitat: " + naravniHabitat + "\n" + "Hrana: " + hrana + "\n" + "Oglasanje: " + oglasanje + "\n" + "Latinsko ime: " + latinskoIme+ "\n";
            return info;
        }

        /// <summary>
        /// Destruktor razreda Zival.
        /// </summary>
        ~Zival()
        {
            Console.WriteLine("Žival je bil(a) odstranjena.");
        }
    }

    public class Sesalec : Zival, ISesalec
    {
        /// <summary>
        /// Ustvari nov primerek razreda Sesalec.
        /// </summary>
        /// <param name="teza">Teža sesalca v kg.</param>
        /// <param name="naravniHabitat">Naravni habitat sesalca.</param>
        /// <param name="hrana">Vrsta hrane sesalca.</param>
        /// <param name="oglasanje">Oglašanje sesalca.</param>
        /// <param name="latinskoIme">Latinsko ime sesalca.</param>
        public Sesalec(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme) : base(teza, naravniHabitat, hrana, oglasanje, latinskoIme)
        {
            //enako kot base
        }

        /// <summary>
        /// Indekser, ki omogoča dostop do podatkov sesalca po indeksu.
        /// </summary>
        /// <param name="index">Indeks podatka</param>
        /// <returns>Podatek sesalca na tem indeksu</returns>
        public new string this[int index]
        {
            get
            {
                if (index == 0) return base[index];
                else if (index == 1) return base[index];
                else if (index == 2) return base[index];
                else if (index == 3) return base[index];
                else if (index == 4) return base[index];
                else return "Ta podatek ne obstaja. Izberite drugega.";
            }
        }

        /// <summary>
        /// Vrne oblikovan niz s podatki sesalca.
        /// </summary>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// Primerja dva sesalca po teži.
        /// </summary>
        /// <param name="s1">Prvi sesalec.</param>
        /// <param name="s2">Drugi sesalec.</param>
        /// <returns>True če je prvi sesalec težji od drugega, drugače false</returns>
        public static bool operator >(Sesalec s1, Sesalec s2)
        {
            if (s1.Teza > s2.Teza) return true;
            else return false;
        }

        public static bool operator <(Sesalec s1, Sesalec s2)
        {
            if (s1.Teza < s1.Teza) return false;
            else return false;
        }

        /// <summary>
        /// Metoda, ki omogoča premikanje sesalca.
        /// </summary>
        /// <returns>"Sesalec + latinsko ime sesalce + se premika"</returns>
        public override string PremakniSe()
        {
            return "Sesalec " + LatinskoIme + " se premika.";
        }
    }

    public class KopenskiSesalec : Sesalec, IKopenskiSesalec
    {
        private int steviloNog;
        private bool imaDlako;

        /// <summary>
        /// Indekser za dostop do podatkov kopenskega sesalca po indeksu.
        /// </summary>
        /// <param name="index">Indeks podatka</param>
        /// <returns>Podatek na indeksu</returns>
        public new string this[int index]
        {
            get
            {
                if (index == 0) return base[index];
                else if (index == 1) return base[index];
                else if (index == 2) return base[index];
                else if (index == 3) return base[index];
                else if (index == 4) return base[index];
                else if (index == 5) return steviloNog.ToString();
                else if (index == 6) return imaDlako ? "Da" : "Ne";
                else return "Ta podatek ne obstaja. Izberite drugega.";
            }
        }

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

        /// <summary>
        /// Ustvari nov primerek razreda KopenskiSesalec.
        /// </summary>
        /// <param name="teza">Teža v kg.</param>
        /// <param name="naravniHabitat">Naravni habitat.</param>
        /// <param name="hrana">Vrsta hrane.</param>
        /// <param name="oglasanje">Oglašanje.</param>
        /// <param name="latinskoIme">Latinsko ime.</param>
        /// <param name="steviloNog">Število nog.</param>
        /// <param name="imaDlako">Ali ima žival dlako (true/false).</param>
        public KopenskiSesalec(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme, int steviloNog, bool imaDlako) : base(teza, naravniHabitat, hrana, oglasanje, latinskoIme)
        {
            SteviloNog = steviloNog;
            ImaDlako = imaDlako;
        }

        /// <summary>
        /// Vrne oblikovan niz podatkov kopenskega sesalca
        /// </summary>
        /// <returns>Oblikovan niz s podatki kopenskega sesalca</returns>
        public override string ToString()
        {
            return base.ToString() + "Stevilo nog: " + steviloNog + "\n" + "Ima dlako: " + (imaDlako ? "Da" : "Ne") + "\n";
        }

        /// <summary>
        /// Metoda, ki omogoča premikanje kopenskega sesalca.
        /// </summary>
        /// <returns>Kopenski sesalec + latinsko ime kopenskega sesalca + hodi</returns>
        public override string PremakniSe()
        {
            return "Kopenski sesalec " + LatinskoIme + " hodi.";
        }
    }

    public class VodniSesalec : Sesalec, IVodniSesalec
    {
        private double dolzinaPlavuti;
        private int steviloPlavuti;
        private double globinaPotopa;

        /// <summary>
        /// Indekser za dostop do podatkov vodnega sesalca po indeksu.
        /// </summary>
        /// <param name="index">Indeks podatka</param>
        /// <returns>Podatek na indeksu</returns>
        public new string this[int index]
        {
            get
            {
                if (index == 0) return base[index];
                else if (index == 1) return base[index];
                else if (index == 2) return base[index];
                else if (index == 3) return base[index];
                else if (index == 4) return base[index];
                else if (index == 5) return dolzinaPlavuti.ToString();
                else if (index == 6) return steviloPlavuti.ToString();
                else if (index == 7) return globinaPotopa.ToString();
                else return "Ta podatek ne obstaja. Izberite drugega.";
            }
        }

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

        /// <summary>
        /// Inicializira nov primerek razreda VodniSesalec.
        /// </summary>
        /// <param name="teza">Teža v kg.</param>
        /// <param name="naravniHabitat">Naravni habitat.</param>
        /// <param name="hrana">Vrsta hrane.</param>
        /// <param name="oglasanje">Oglkašanje živali.</param>
        /// <param name="latinskoIme">Latinsko ime.</param>
        /// <param name="dolzinaPlavuti">Dolžina plavuti v cm.</param>
        /// <param name="steviloPlavuti">Število plavuti.</param>
        /// <param name="globinaPotopa">Globina potopa v cm.</param>
        public VodniSesalec(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme, double dolzinaPlavuti, int steviloPlavuti, double globinaPotopa) : base(teza, naravniHabitat, hrana, oglasanje, latinskoIme)
        {
            DolzinaPlavuti = dolzinaPlavuti;
            SteviloPlavuti = steviloPlavuti;
            GlobinaPotopa = globinaPotopa;
        }

        /// <summary>
        /// Vrne oblikovan niz podatkov vodnega sesalca.
        /// </summary>
        /// <returns>Oblikovan niz s podatki vodnega sesalca.</returns>
        public override string ToString()
        {
            return base.ToString() + "Dolzina plavuti: " + dolzinaPlavuti + " cm\n" + "Stevilo plavuti: " + steviloPlavuti + "\n" + "Globina potopa: " + globinaPotopa + " cm\n";
        }

        /// <summary>
        /// Metoda, ki omogoča premikanje vodnega sesalca.
        /// </summary>
        /// <returns>Vodni sesalec + latinsko ime vodnega sesalce + plava</returns>
        public override string PremakniSe()
        {
            return "Vodni sesalec " + LatinskoIme + " plava.";
        }
    }

    public class LeteciSesalec : Sesalec, ILeteciSesalec
    {
        private double razponKril;
        private double maxRazdaljaLeta;

        /// <summary>
        /// Indekser, ki omogoča dostop do podatkov letečega sesalca po indeksu.
        /// </summary>
        /// <param name="index">Indeks podatka</param>
        /// <returns>Podatek na indeksu</returns>
        public new string this[int index]
        {
            get
            {
                if (index == 0) return base[index];
                else if (index == 1) return base[index];
                else if (index == 2) return base[index];
                else if (index == 3) return base[index];
                else if (index == 4) return base[index];
                else if (index == 5) return razponKril.ToString();
                else if (index == 6) return maxRazdaljaLeta.ToString();
                else return "Ta podatek ne obstaja. Izberite drugega.";
            }
        }

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


        /// <summary>
        /// Ustvari nov primerek razreda LeteciSesalec.
        /// </summary>
        /// <param name="teza">Teža v kg.</param>
        /// <param name="naravniHabitat">Naravni habitat.</param>
        /// <param name="hrana">Vrsta hrane.</param>
        /// <param name="oglasanje">Oglašanje.</param>
        /// <param name="latinskoIme">Latinsko ime.</param>
        /// <param name="razponKril">Razpon kril v cm.</param>
        /// <param name="maxRazdaljaLeta">Maksimalna razdalja leta v km.</param>
        public LeteciSesalec(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme, double razponKril, double maxRazdaljaLeta) : base(teza, naravniHabitat, hrana, oglasanje, latinskoIme)
        {
            RazponKril = razponKril;
            MaxRazdaljaLeta = maxRazdaljaLeta;
        }

        /// <summary>
        /// Vrne oblikovan niz podatkov letečega sesalca.
        /// </summary>
        /// <returns>Oblikovan niz podatkov</returns>
        public override string ToString()
        {
            return base.ToString() + "Razpon kril: " + razponKril + " cm\n" + "Max razdalja leta: " + maxRazdaljaLeta + " km\n";
        }


        /// <summary>
        /// Metoda, ki omogoča premikanje letečega sesalca.
        /// </summary>
        /// <returns>Leteci sesalec + latinsko ime letecega sesalca + leti</returns>
        public override string PremakniSe()
        {
            return "Leteci sesalec " + LatinskoIme + " leti.";
        }
    }

    public class Clenonozci : Zival, IClenonozci
    {
        private int steviloNog;


        /// <summary>
        /// Indekser, ki omogoča dostop do podatkov členonožca po indeksu.
        /// </summary>
        /// <param name="index">Indeks podatka</param>
        /// <returns>Podatek na ustreznem indeksu</returns>
        public new string this[int index]
        {
            get
            {
                if (index == 0) return base[index];
                else if (index == 1) return base[index];
                else if (index == 2) return base[index];
                else if (index == 3) return base[index];
                else if (index == 4) return base[index];
                else if (index == 5) return steviloNog.ToString();
                else return "Ta podatek ne obstaja. Izberite drugega.";
            }
        }

        public int SteviloNog
        {
            get { return steviloNog; }
            set { steviloNog = value; }
        }

        /// <summary>
        /// Ustvari nov primerek razreda Clenonozci.
        /// </summary>
        /// <param name="teza">Teža v kg.</param>
        /// <param name="naravniHabitat">Naravni habitat.</param>
        /// <param name="hrana">Vrsta hrane.</param>
        /// <param name="oglasanje">Oglašanje</param>
        /// <param name="latinskoIme">Latinsko ime.</param>
        /// <param name="steviloNog">Število nog.</param>
        public Clenonozci(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme, int steviloNog) :base(teza, naravniHabitat, hrana, oglasanje, latinskoIme)
        {
            SteviloNog = steviloNog;
        }


        /// <summary>
        /// Vrne oblikovan niz podatkov členonožca.
        /// </summary>
        /// <returns>Oblikovan nit podatkov členonozca</returns>
        public override string ToString()
        {
            return base.ToString() + "Stevilo nog: " + steviloNog + "\n";
        }

        /// <summary>
        /// Primerja težo dveh členonožcev.
        /// </summary>
        /// <param name="c1">Členonožec 1</param>
        /// <param name="c2">Členonožec 2</param>
        /// <returns>True, če je prvi členonožec težji od drugega, drugače false</returns>
        public static bool operator >(Clenonozci c1, Clenonozci c2)
        {
            if (c1.Teza > c2.Teza) return true;
            else return false;
        }

        public static bool operator <(Clenonozci c1, Clenonozci c2)
        {
            if (c1.Teza < c2.Teza) return true;
            else return false;
        }

        /// <summary>
        /// Metoda, ki omogoča premikanje členonožca.
        /// </summary>
        /// <returns>Členonožec + latinsko ime členonožca + se premika</returns>
        public override string PremakniSe()
        {
            return "Členonožec " + LatinskoIme + " se premika.";
        }
    }

    public class Zuzelke : Clenonozci, IZuzelke
    {
        private bool leti;


        /// <summary>
        /// Indekser, ki omogoča dostop do podatkov žuželke po indeksu.
        /// </summary>
        /// <param name="index">Indeks podatka</param>
        /// <returns>Podatek na indeksu</returns>
        public new string this[int index]
        {
            get
            {
                if (index == 0) return base[index];
                else if (index == 1) return base[index];
                else if (index == 2) return base[index];
                else if (index == 3) return base[index];
                else if (index == 4) return base[index];
                else if (index == 5) return base[index];
                else if (index == 6) return leti ? "Da" : "Ne";
                else return "Ta podatek ne obstaja. Izberite drugega.";
            }
        }

        public bool Leti
        {
            get { return leti; }
            set { leti = value; }
        }

        /// <summary>
        /// Ustvari nov primerek razreda Zuzelke.
        /// </summary>
        /// <param name="teza">Teža v kg.</param>
        /// <param name="naravniHabitat">Naravni habitat.</param>
        /// <param name="hrana">Vrsta hrane.</param>
        /// <param name="oglasanje">Oglašanje</param>
        /// <param name="latinskoIme">Latinsko ime.</param>
        /// <param name="steviloNog">Število nog.</param>
        /// <param name="leti">Ali žuželka leti.</param>
        public Zuzelke(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme, int steviloNog, bool leti) : base(teza, naravniHabitat, hrana, oglasanje, latinskoIme, steviloNog)
        {
            Leti = leti;
        }

        /// <summary>
        /// Vrne oblikovan niz podatkov žuželke.
        /// </summary>
        /// <returns>Oblikovan niz podatkov žuželke</returns>
        public override string ToString()
        {
            return base.ToString() + "Leti: " + (leti ? "Da" : "Ne") + "\n";
        }

        /// <summary>
        /// Metoda, ki omogoča premikanje žuželke.
        /// </summary>
        /// <returns>Če žuželka leti "Žuželka  + latinsko ime žuželke + leti", drugače "-=- se plazi"</returns>
        public override string PremakniSe()
        {
            if (leti)
            {
                return "Žuželka " + LatinskoIme + " leti.";
            }
            else
            {
                return "Žuželka " + LatinskoIme + " se plazi.";
            }
        }
    }

    public class Pajkovci : Clenonozci, IPajkovci
    {
        private bool strupen;
        private bool pleteMrezo;


        /// <summary>
        /// Indekser, ki omogoča dostop do podatkov pajkovca po indeksu.
        /// </summary>
        /// <param name="index">Indeks podatka</param>
        /// <returns>Podatek na indeksu</returns>
        public new string this[int index]
        {
            get
            {
                if (index == 0) return base[index];
                else if (index == 1) return base[index];
                else if (index == 2) return base[index];
                else if (index == 3) return base[index];
                else if (index == 4) return base[index];
                else if (index == 5) return base[index];
                else if (index == 6) return strupen ? "Da" : "Ne";
                else if (index == 7) return pleteMrezo ? "Da" : "Ne";
                else return "Ta podatek ne obstaja. Izberite drugega.";
            }
        }

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

        /// <summary>
        /// Ustvari nov primerek razreda Pajkovci.
        /// </summary>
        /// <param name="teza">Teža v kg.</param>
        /// <param name="naravniHabitat">Naravni habitat.</param>
        /// <param name="hrana">Vrsta hrane.</param>
        /// <param name="oglasanje">Oglašanje.</param>
        /// <param name="latinskoIme">Latinsko ime.</param>
        /// <param name="steviloNog">Število nog.</param>
        /// <param name="strupen">Ali je pajkovec strupen.</param>
        /// <param name="pleteMrezo">Ali pajkovec plete mrežo.</param>
        public Pajkovci(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme, int steviloNog, bool strupen, bool pleteMrezo) : base(teza, naravniHabitat, hrana, oglasanje, latinskoIme, steviloNog)
        {
            Strupen = strupen;
            PleteMrezo = pleteMrezo;
        }

        /// <summary>
        /// Vrne oblikovan niz podatkov pajkovca.
        /// </summary>
        /// <returns>Oblikovan niz podatkov pajkovca</returns>
        public override string ToString()
        {
            return base.ToString() + "Strupen: " + (strupen ? "Da" : "Ne") + "\n" + "Plete mrezo: " + (pleteMrezo ? "Da" : "Ne") + "\n";
        }


        /// <summary>
        /// Metoda, ki omogoča premikanje pajkovca.
        /// </summary>
        /// <returns>Pajkovec + latinsko ime pajkovca + se plazi</returns>
        public override string PremakniSe()
        {
            return "Pajkovec " + LatinskoIme + " se plazi.";
        }
    }

    public class Raki : Clenonozci, IRaki
    {
        private bool ziviVSlaniVodi;
        private double velikostKlesc;


        /// <summary>
        /// Indekser, ki omogoča dostop do podatkov raka po indeksu.
        /// </summary>
        /// <param name="index">Indeks podatka</param>
        /// <returns>Podatek na indeksu</returns>
        public new string this[int index]
        {
            get
            {
                if (index == 0) return base[index];
                else if (index == 1) return base[index];
                else if (index == 2) return base[index];
                else if (index == 3) return base[index];
                else if (index == 4) return base[index];
                else if (index == 5) return base[index];
                else if (index == 6) return ziviVSlaniVodi ? "Da" : "Ne";
                else if (index == 7) return velikostKlesc.ToString() + " cm";
                else return "Ta podatek ne obstaja. Izberite drugega.";
            }
        }

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


        /// <summary>
        /// Ustvari nov primerek razreda Raki.
        /// </summary>
        /// <param name="teza">Teža v kg.</param>
        /// <param name="naravniHabitat">Naravni habitat.</param>
        /// <param name="hrana">Vrsta hrane.</param>
        /// <param name="oglasanje">Oglašanje.</param>
        /// <param name="latinskoIme">Latinsko ime.</param>
        /// <param name="steviloNog">Število nog.</param>
        /// <param name="ziviVSlaniVodi">Ali rak živi v slani vodi.</param>
        /// <param name="velikostKlesc">Velikost klešč v cm.</param>
        public Raki(double teza, string naravniHabitat, string hrana, string oglasanje, string latinskoIme, int steviloNog, bool ziviVSlaniVodi, double velikostKlesc) : base(teza, naravniHabitat, hrana, oglasanje, latinskoIme, steviloNog)
        {
            ZiviVSlaniVodi = ziviVSlaniVodi;
            VelikostKlesc = velikostKlesc;
        }

        /// <summary>
        /// Vrne oblikovan niz podatkov raka.
        /// </summary>
        /// <returns>Oblikovan niz podatkov raka</returns>
        public override string ToString()
        {
            return base.ToString() + "Zivi v slani vodi: " + (ziviVSlaniVodi ? "Da" : "Ne") + "\n" + "Velikost klesc: " + velikostKlesc + " cm\n";
        }

        /// <summary>
        /// Metoda, ki omogoča premikanje raka.
        /// </summary>
        /// <returns>Rak + latinsko ime raka + se plazi</returns>
        public override string PremakniSe()
        {
            return "Rak " + LatinskoIme + " se plazi.";
        }
    }
}