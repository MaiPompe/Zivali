using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZivalLibrary;

namespace Zival
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Pripravi vrstico v tabeli podatkiZivali za vnos podatkov in postavi fokus na polje imeZivali.
        /// </summary>
        public void PodatkiZivali()
        {
            podatkiZivali.Rows.Add();
            imeZivali.Focus();
        }

        /// <summary>
        /// Izvozi podatke o živalih v datoteko zivali.txt v mapi Downloads, glede na izbrani radio gumb.
        /// </summary>
        public void Izvoz()
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string downloads = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string pot = Path.Combine(downloads, $"zivali{timestamp}.txt");
            StreamWriter sw = new StreamWriter(pot);

            if (radioVse.Checked)
            {
                sw.WriteLine("=== SESALCI ===");
                for (int i = 0; i < ns; i++)
                {
                    sw.WriteLine("Ime: " + seznamImen[0, i]);
                    sw.WriteLine(seznamSesalcev[i]);
                    sw.WriteLine("--------------------");
                }

                sw.WriteLine("=== ČLENONOŽCI ===");
                for (int i = 0; i < nc; i++)
                {
                    sw.WriteLine("Ime: " + seznamImen[1, i]);
                    sw.WriteLine(seznamClenonozcev[i]);
                    sw.WriteLine("--------------------");
                }
            }
            else if(radioSesalec.Checked)
            {
                sw.WriteLine("=== SESALCI ===");
                for (int i = 0; i < ns; i++)
                {
                    sw.WriteLine("Ime: " + seznamImen[0, i]);
                    sw.WriteLine(seznamSesalcev[i]);
                    sw.WriteLine("--------------------");
                }
            }
            else if (radioČlenonožec.Checked)
            {
                sw.WriteLine("=== ČLENONOŽCI ===");
                for (int i = 0; i < nc; i++)
                {
                    sw.WriteLine("Ime: " + seznamImen[1, i]);
                    sw.WriteLine(seznamClenonozcev[i]);
                    sw.WriteLine("--------------------");
                }
            }

            sw.Close();
        }

        const int maxZivali = 100;
        static int stZivali = 0;

        string[,] seznamImen = new string[maxZivali, maxZivali];
        Sesalec[] seznamSesalcev = new Sesalec[maxZivali];
        Clenonozci[] seznamClenonozcev = new Clenonozci[maxZivali];
        int ns = 0;
        int nc = 0;

        /// <summary>
        /// Glede na izbrano vrsto živali doda ustrezne stolpce v tabelo podatkiZivali in aktivira gumb za ustvarjanje živali.
        /// </summary>
        private void vrstaZivali_SelectedIndexChanged(object sender, EventArgs e)
        {
            ustvariZival.Enabled = true;
            vrstaZivali.Enabled = false;

            if (vrstaZivali.SelectedItem.ToString() == "Sesalec")
            {
                vrstaZivali.Text = "Sesalec";

                podatkiZivali.Columns.Add("colTeza","Teza (kg)");
                podatkiZivali.Columns.Add("colHabitat", "Naravni habitat");
                podatkiZivali.Columns.Add("colHrana", "Hrana");
                podatkiZivali.Columns.Add("colOglasanje", "Oglašanje");
                podatkiZivali.Columns.Add("colLatinskoIme", "Latinsko ime");
            }
            else if (vrstaZivali.SelectedItem.ToString() == "Kopenski sesalec")
            {
                vrstaZivali.Text = "Kopenski sesalec";

                podatkiZivali.Columns.Add("colTeza", "Teza (kg)");
                podatkiZivali.Columns.Add("colHabitat", "Naravni habitat");
                podatkiZivali.Columns.Add("colHrana", "Hrana");
                podatkiZivali.Columns.Add("colOglasanje", "Oglašanje");
                podatkiZivali.Columns.Add("colLatinskoIme", "Latinsko ime");
                podatkiZivali.Columns.Add("colSteviloNog", "Število nog");
                podatkiZivali.Columns.Add("colImaDlako", "Ima dlako (true/false)");
            }
            else if (vrstaZivali.SelectedItem.ToString() == "Vodni sesalec")
            {
                vrstaZivali.Text = "Vodni sesalec";

                podatkiZivali.Columns.Add("colTeza", "Teza (kg)");
                podatkiZivali.Columns.Add("colHabitat", "Naravni habitat");
                podatkiZivali.Columns.Add("colHrana", "Hrana");
                podatkiZivali.Columns.Add("colOglasanje", "Oglašanje");
                podatkiZivali.Columns.Add("colLatinskoIme", "Latinsko ime");
                podatkiZivali.Columns.Add("colDolzinaPlavuti", "Dolžina plavuti (cm)");
                podatkiZivali.Columns.Add("colSteviloPlavuti", "Število plavuti");
                podatkiZivali.Columns.Add("colGlobinaPotopa", "Globina potopa (m)");
            }
            else if (vrstaZivali.SelectedItem.ToString() == "Leteči sesalec")
            {
                vrstaZivali.Text = "Leteči sesalec";

                podatkiZivali.Columns.Add("colTeza", "Teza (kg)");
                podatkiZivali.Columns.Add("colHabitat", "Naravni habitat");
                podatkiZivali.Columns.Add("colHrana", "Hrana");
                podatkiZivali.Columns.Add("colOglasanje", "Oglašanje");
                podatkiZivali.Columns.Add("colLatinskoIme", "Latinsko ime");
                podatkiZivali.Columns.Add("colRazponKril", "Razpon kril (cm)");
                podatkiZivali.Columns.Add("colMaxRazdaljaLeta", "Max razdalja leta (km)");
            }
            else if(vrstaZivali.SelectedItem.ToString() == "Členonožec")
            {
                vrstaZivali.Text = "Členonožec";

                podatkiZivali.Columns.Add("colTeza", "Teza (kg)");
                podatkiZivali.Columns.Add("colHabitat", "Naravni habitat");
                podatkiZivali.Columns.Add("colHrana", "Hrana");
                podatkiZivali.Columns.Add("colOglasanje", "Oglašanje");
                podatkiZivali.Columns.Add("colLatinskoIme", "Latinsko ime");
                podatkiZivali.Columns.Add("colSteviloNog", "Število nog");
            }
            else if(vrstaZivali.SelectedItem.ToString() == "Žuželka")
            {
                vrstaZivali.Text = "Žuželka";

                podatkiZivali.Columns.Add("colTeza", "Teza (kg)");
                podatkiZivali.Columns.Add("colHabitat", "Naravni habitat");
                podatkiZivali.Columns.Add("colHrana", "Hrana");
                podatkiZivali.Columns.Add("colOglasanje", "Oglašanje");
                podatkiZivali.Columns.Add("colLatinskoIme", "Latinsko ime");
                podatkiZivali.Columns.Add("colSteviloNog", "Število nog");
                podatkiZivali.Columns.Add("colLeti", "Leti? (true/false)");
            }
            else if(vrstaZivali.SelectedItem.ToString() == "Pajkovec")
            {
                vrstaZivali.Text = "Pajkovec";

                podatkiZivali.Columns.Add("colTeza", "Teza (kg)");
                podatkiZivali.Columns.Add("colHabitat", "Naravni habitat");
                podatkiZivali.Columns.Add("colHrana", "Hrana");
                podatkiZivali.Columns.Add("colOglasanje", "Oglašanje");
                podatkiZivali.Columns.Add("colLatinskoIme", "Latinsko ime");
                podatkiZivali.Columns.Add("colSteviloNog", "Število nog");
                podatkiZivali.Columns.Add("colStrupen", "Strupen? (true/false)");
                podatkiZivali.Columns.Add("colPleteMrezo", "Plete mrežo? (true/false)");
            }
            else if(vrstaZivali.SelectedItem.ToString() == "Rak")
            {
                vrstaZivali.Text = "Rak";

                podatkiZivali.Columns.Add("colTeza", "Teza (kg)");
                podatkiZivali.Columns.Add("colHabitat", "Naravni habitat");
                podatkiZivali.Columns.Add("colHrana", "Hrana");
                podatkiZivali.Columns.Add("colOglasanje", "Oglašanje");
                podatkiZivali.Columns.Add("colLatinskoIme", "Latinsko ime");
                podatkiZivali.Columns.Add("colSteviloNog", "Število nog");
                podatkiZivali.Columns.Add("colZiviVSlaniVodi", "Živi v slani vodi? (true/false)");
                podatkiZivali.Columns.Add("colVelikostKlesc", "Velikost klešč (cm)");
            }

            PodatkiZivali();
        }

        /// <summary>
        /// Metoda dogodka ZivalUstvarjena. Ob ustvaritvi živali prikaže Message Box z imenom in podatki ustvarjene živali.
        /// </summary>
        /// <param name="z">Ustvarjena žival.</param>
        /// <param name="ime">Ime ustvarjene živali.</param>
        private void ZivalUstvarjenaHandler(ZivalLibrary.Zival z, string ime)
        {
            MessageBox.Show("Ustvarili ste žival: " + ime + "\n" + z.ToString(), "Ustvarili ste žival!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Prebere podatke iz tabele podatkiZivali in ustvari ustrezeno živali glede na izbrano vrsto, nato jo doda v 
        /// ustrezna polja ter sproži dogodek ZivalUstvarjena.
        /// Po uspešnem ustvarjanju ponastavi obrazec za naslednji vnos.
        /// </summary>
        private void ustvariZival_Click(object sender, EventArgs e)
        {
            if (stZivali == maxZivali)
            {
                MessageBox.Show("Dosegli ste maksimalno število živali!", "Napaka!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (vrstaZivali.SelectedItem.ToString() == "Sesalec")
            {
                try
                {
                    double Teza = Convert.ToDouble(podatkiZivali.Rows[0].Cells["colTeza"].Value);
                    string NaravniHabitat = podatkiZivali.Rows[0].Cells["colHabitat"].Value.ToString();
                    string Hrana = podatkiZivali.Rows[0].Cells["colHrana"].Value.ToString();
                    string Oglasanje = podatkiZivali.Rows[0].Cells["colOglasanje"].Value.ToString();
                    string LatinskoIme = podatkiZivali.Rows[0].Cells["colLatinskoIme"].Value.ToString();

                    string ime = imeZivali.Text;
                    zivali.Items.Add(ime);
                    zival1.Items.Add(ime);
                    zival2.Items.Add(ime);
                    comboBoxPremakniZival.Items.Add(ime);
                    comboBoxIzberiPodatek.Items.Add(ime);

                    Sesalec s = new Sesalec(Teza, NaravniHabitat, Hrana, Oglasanje, LatinskoIme);
                    s.ZivalUstvarjena += ZivalUstvarjenaHandler;
                    s.KoJeZivalUstvarjena(ime);

                    seznamSesalcev[ns] = s;
                    seznamImen[0, ns] = ime;
                    ns++;
                    stZivali++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Prosimo, vnesite pravilne podatke za žival!", "Napaka pri vnosu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ustvariZival.Enabled = false;
                    vrstaZivali.Enabled = true;
                    podatkiZivali.Columns.Clear();
                    imeZivali.Clear();
                    vrstaZivali.Text = "";
                }
            }
            else if (vrstaZivali.SelectedItem.ToString() == "Kopenski sesalec")
            {
                try
                {
                    double Teza = Convert.ToDouble(podatkiZivali.Rows[0].Cells["colTeza"].Value);
                    string NaravniHabitat = podatkiZivali.Rows[0].Cells["colHabitat"].Value.ToString();
                    string Hrana = podatkiZivali.Rows[0].Cells["colHrana"].Value.ToString();
                    string Oglasanje = podatkiZivali.Rows[0].Cells["colOglasanje"].Value.ToString();
                    string LatinskoIme = podatkiZivali.Rows[0].Cells["colLatinskoIme"].Value.ToString();
                    int SteviloNog = Convert.ToInt32(podatkiZivali.Rows[0].Cells["colSteviloNog"].Value);
                    bool ImaDlako = Convert.ToBoolean(podatkiZivali.Rows[0].Cells["colImaDlako"].Value);

                    string ime = imeZivali.Text;
                    zivali.Items.Add(ime);
                    zival1.Items.Add(ime);
                    zival2.Items.Add(ime);
                    comboBoxPremakniZival.Items.Add(ime);
                    comboBoxIzberiPodatek.Items.Add(ime);

                    KopenskiSesalec ks = new KopenskiSesalec(Teza, NaravniHabitat, Hrana, Oglasanje, LatinskoIme, SteviloNog, ImaDlako);
                    ks.ZivalUstvarjena += ZivalUstvarjenaHandler;
                    ks.KoJeZivalUstvarjena(ime);

                    seznamSesalcev[ns] = ks;
                    seznamImen[0, ns] = ime;
                    ns++;
                    stZivali++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Prosimo, vnesite pravilne podatke za žival!", "Napaka pri vnosu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ustvariZival.Enabled = false;
                    vrstaZivali.Enabled = true;
                    podatkiZivali.Columns.Clear();
                    imeZivali.Clear();
                    vrstaZivali.Text = "";
                }

            }
            else if (vrstaZivali.SelectedItem.ToString() == "Vodni sesalec")
            {
                try
                {
                    double Teza = Convert.ToDouble(podatkiZivali.Rows[0].Cells["colTeza"].Value);
                    string NaravniHabitat = podatkiZivali.Rows[0].Cells["colHabitat"].Value.ToString();
                    string Hrana = podatkiZivali.Rows[0].Cells["colHrana"].Value.ToString();
                    string Oglasanje = podatkiZivali.Rows[0].Cells["colOglasanje"].Value.ToString();
                    string LatinskoIme = podatkiZivali.Rows[0].Cells["colLatinskoIme"].Value.ToString();
                    double DolzinaPlavuti = Convert.ToDouble(podatkiZivali.Rows[0].Cells["colDolzinaPlavuti"].Value);
                    int SteviloPlavuti = Convert.ToInt32(podatkiZivali.Rows[0].Cells["colSteviloPlavuti"].Value);
                    double GlobinaPotopa = Convert.ToDouble(podatkiZivali.Rows[0].Cells["colGlobinaPotopa"].Value);

                    string ime = imeZivali.Text;
                    zivali.Items.Add(ime);
                    zival1.Items.Add(ime);
                    zival2.Items.Add(ime);
                    comboBoxPremakniZival.Items.Add(ime);
                    comboBoxIzberiPodatek.Items.Add(ime);

                    VodniSesalec vs = new VodniSesalec(Teza, NaravniHabitat, Hrana, Oglasanje, LatinskoIme, DolzinaPlavuti, SteviloPlavuti, GlobinaPotopa);
                    vs.ZivalUstvarjena += ZivalUstvarjenaHandler;
                    vs.KoJeZivalUstvarjena(ime);

                    seznamSesalcev[ns] = vs;
                    seznamImen[0, ns] = ime;
                    ns++;
                    stZivali++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Prosimo, vnesite pravilne podatke za žival!", "Napaka pri vnosu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ustvariZival.Enabled = false;
                    vrstaZivali.Enabled = true;
                    podatkiZivali.Columns.Clear();
                    imeZivali.Clear();
                    vrstaZivali.Text = "";
                }

            }
            else if (vrstaZivali.SelectedItem.ToString() == "Leteči sesalec")
            {
                try
                {
                    double Teza = Convert.ToDouble(podatkiZivali.Rows[0].Cells["colTeza"].Value);
                    string NaravniHabitat = podatkiZivali.Rows[0].Cells["colHabitat"].Value.ToString();
                    string Hrana = podatkiZivali.Rows[0].Cells["colHrana"].Value.ToString();
                    string Oglasanje = podatkiZivali.Rows[0].Cells["colOglasanje"].Value.ToString();
                    string LatinskoIme = podatkiZivali.Rows[0].Cells["colLatinskoIme"].Value.ToString();
                    double RazponKril = Convert.ToDouble(podatkiZivali.Rows[0].Cells["colRazponKril"].Value);
                    double MaxRazdaljaLeta = Convert.ToDouble(podatkiZivali.Rows[0].Cells["colMaxRazdaljaLeta"].Value);

                    string ime = imeZivali.Text;
                    zivali.Items.Add(ime);
                    zival1.Items.Add(ime);
                    zival2.Items.Add(ime);
                    comboBoxPremakniZival.Items.Add(ime);
                    comboBoxIzberiPodatek.Items.Add(ime);

                    LeteciSesalec ls = new LeteciSesalec(Teza, NaravniHabitat, Hrana, Oglasanje, LatinskoIme, RazponKril, MaxRazdaljaLeta);
                    ls.ZivalUstvarjena += ZivalUstvarjenaHandler;
                    ls.KoJeZivalUstvarjena(ime);

                    seznamSesalcev[ns] = ls;
                    seznamImen[0, ns] = ime;
                    ns++;
                    stZivali++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Prosimo, vnesite pravilne podatke za žival!", "Napaka pri vnosu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ustvariZival.Enabled = false;
                    vrstaZivali.Enabled = true;
                    podatkiZivali.Columns.Clear();
                    imeZivali.Clear();
                    vrstaZivali.Text = "";
                }

            }
            else if (vrstaZivali.SelectedItem.ToString() == "Členonožec")
            {
                try
                {
                    double Teza = Convert.ToDouble(podatkiZivali.Rows[0].Cells["colTeza"].Value);
                    string NaravniHabitat = podatkiZivali.Rows[0].Cells["colHabitat"].Value.ToString();
                    string Hrana = podatkiZivali.Rows[0].Cells["colHrana"].Value.ToString();
                    string Oglasanje = podatkiZivali.Rows[0].Cells["colOglasanje"].Value.ToString();
                    string LatinskoIme = podatkiZivali.Rows[0].Cells["colLatinskoIme"].Value.ToString();
                    int SteviloNog = Convert.ToInt32(podatkiZivali.Rows[0].Cells["colSteviloNog"].Value);

                    string ime = imeZivali.Text;
                    zivali.Items.Add(ime);
                    zival1.Items.Add(ime);
                    zival2.Items.Add(ime);
                    comboBoxPremakniZival.Items.Add(ime);
                    comboBoxIzberiPodatek.Items.Add(ime);

                    Clenonozci c = new Clenonozci(Teza, NaravniHabitat, Hrana, Oglasanje, LatinskoIme, SteviloNog);
                    c.ZivalUstvarjena += ZivalUstvarjenaHandler;
                    c.KoJeZivalUstvarjena(ime);

                    seznamClenonozcev[nc] = c;
                    seznamImen[1, nc] = ime;
                    nc++;
                    stZivali++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Prosimo, vnesite pravilne podatke za žival!", "Napaka pri vnosu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ustvariZival.Enabled = false;
                    vrstaZivali.Enabled = true;
                    podatkiZivali.Columns.Clear();
                    imeZivali.Clear();
                    vrstaZivali.Text = "";
                }

            }
            else if (vrstaZivali.SelectedItem.ToString() == "Žuželka")
            {
                try
                {
                    double Teza = Convert.ToDouble(podatkiZivali.Rows[0].Cells["colTeza"].Value);
                    string NaravniHabitat = podatkiZivali.Rows[0].Cells["colHabitat"].Value.ToString();
                    string Hrana = podatkiZivali.Rows[0].Cells["colHrana"].Value.ToString();
                    string Oglasanje = podatkiZivali.Rows[0].Cells["colOglasanje"].Value.ToString();
                    string LatinskoIme = podatkiZivali.Rows[0].Cells["colLatinskoIme"].Value.ToString();
                    int SteviloNog = Convert.ToInt32(podatkiZivali.Rows[0].Cells["colSteviloNog"].Value);
                    bool Leti = Convert.ToBoolean(podatkiZivali.Rows[0].Cells["colLeti"].Value);

                    string ime = imeZivali.Text;
                    zivali.Items.Add(ime);
                    zival1.Items.Add(ime);
                    zival2.Items.Add(ime);
                    comboBoxPremakniZival.Items.Add(ime);
                    comboBoxIzberiPodatek.Items.Add(ime);

                    Zuzelke z = new Zuzelke(Teza, NaravniHabitat, Hrana, Oglasanje, LatinskoIme, SteviloNog, Leti);
                    z.ZivalUstvarjena += ZivalUstvarjenaHandler;
                    z.KoJeZivalUstvarjena(ime);

                    seznamClenonozcev[nc] = z;
                    seznamImen[1, nc] = ime;
                    nc++;
                    stZivali++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Prosimo, vnesite pravilne podatke za žival!", "Napaka pri vnosu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ustvariZival.Enabled = false;
                    vrstaZivali.Enabled = true;
                    podatkiZivali.Columns.Clear();
                    imeZivali.Clear();
                    vrstaZivali.Text = "";
                }

            }
            else if (vrstaZivali.SelectedItem.ToString() == "Pajkovec")
            {
                try
                {
                    double Teza = Convert.ToDouble(podatkiZivali.Rows[0].Cells["colTeza"].Value);
                    string NaravniHabitat = podatkiZivali.Rows[0].Cells["colHabitat"].Value.ToString();
                    string Hrana = podatkiZivali.Rows[0].Cells["colHrana"].Value.ToString();
                    string Oglasanje = podatkiZivali.Rows[0].Cells["colOglasanje"].Value.ToString();
                    string LatinskoIme = podatkiZivali.Rows[0].Cells["colLatinskoIme"].Value.ToString();
                    int SteviloNog = Convert.ToInt32(podatkiZivali.Rows[0].Cells["colSteviloNog"].Value);
                    bool Strupen = Convert.ToBoolean(podatkiZivali.Rows[0].Cells["colStrupen"].Value);
                    bool PleteMrezo = Convert.ToBoolean(podatkiZivali.Rows[0].Cells["colPleteMrezo"].Value);

                    string ime = imeZivali.Text;
                    zivali.Items.Add(ime);
                    zival1.Items.Add(ime);
                    zival2.Items.Add(ime);
                    comboBoxPremakniZival.Items.Add(ime);
                    comboBoxIzberiPodatek.Items.Add(ime);

                    Pajkovci p = new Pajkovci(Teza, NaravniHabitat, Hrana, Oglasanje, LatinskoIme, SteviloNog, Strupen, PleteMrezo);
                    p.ZivalUstvarjena += ZivalUstvarjenaHandler;
                    p.KoJeZivalUstvarjena(ime);

                    seznamClenonozcev[nc] = p;
                    seznamImen[1, nc] = ime;
                    nc++;
                    stZivali++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Prosimo, vnesite pravilne podatke za žival!", "Napaka pri vnosu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ustvariZival.Enabled = false;
                    vrstaZivali.Enabled = true;
                    podatkiZivali.Columns.Clear();
                    imeZivali.Clear();
                    vrstaZivali.Text = "";
                }
            }
            else if (vrstaZivali.SelectedItem.ToString() == "Rak")
            {
                try
                {
                    double Teza = Convert.ToDouble(podatkiZivali.Rows[0].Cells["colTeza"].Value);
                    string NaravniHabitat = podatkiZivali.Rows[0].Cells["colHabitat"].Value.ToString();
                    string Hrana = podatkiZivali.Rows[0].Cells["colHrana"].Value.ToString();
                    string Oglasanje = podatkiZivali.Rows[0].Cells["colOglasanje"].Value.ToString();
                    string LatinskoIme = podatkiZivali.Rows[0].Cells["colLatinskoIme"].Value.ToString();
                    int SteviloNog = Convert.ToInt32(podatkiZivali.Rows[0].Cells["colSteviloNog"].Value);
                    bool ZiviVSlaniVodi = Convert.ToBoolean(podatkiZivali.Rows[0].Cells["colZiviVSlaniVodi"].Value);
                    double VelikostKlesc = Convert.ToDouble(podatkiZivali.Rows[0].Cells["colVelikostKlesc"].Value);

                    string ime = imeZivali.Text;
                    zivali.Items.Add(ime);
                    zival1.Items.Add(ime);
                    zival2.Items.Add(ime);
                    comboBoxPremakniZival.Items.Add(ime);
                    comboBoxIzberiPodatek.Items.Add(ime);

                    Raki r = new Raki(Teza, NaravniHabitat, Hrana, Oglasanje, LatinskoIme, SteviloNog, ZiviVSlaniVodi, VelikostKlesc);
                    r.ZivalUstvarjena += ZivalUstvarjenaHandler;
                    r.KoJeZivalUstvarjena(ime);

                    seznamClenonozcev[nc] = r;
                    seznamImen[1, nc] = ime;
                    nc++;
                    stZivali++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Prosimo, vnesite pravilne podatke za žival!", "Napaka pri vnosu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ustvariZival.Enabled = false;
                    vrstaZivali.Enabled = true;
                    podatkiZivali.Columns.Clear();
                    imeZivali.Clear();
                    vrstaZivali.Text = "";
                }

            }
        }

        /// <summary>
        /// Aktivira gumb izpisZivali in onemogoči spustni seznam med izpisom.
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            izpisZivali.Enabled = true;
            vrstaZivali2.Enabled = false;
        }

        /// <summary>
        /// Izpiše vse živali in podatke izbrane vrste v listBox1.
        /// </summary>
        private void izpisZivali_Click(object sender, EventArgs e)
        {
            izpisZivali.Enabled = false;
            vrstaZivali2.Enabled = true;
            listBox1.Items.Clear();

            if (vrstaZivali2.SelectedItem.ToString() == "Sesalec")
            {
                for (int i = 0; i < ns; i++)
                {
                    listBox1.Items.Add("Ime: " + seznamImen[0, i]);
                    listBox1.Items.Add(seznamSesalcev[i]);
                    listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
            }
            else if (vrstaZivali2.SelectedItem.ToString() == "Kopenski sesalec")
            {
                for (int i = 0; i < ns; i++)
                {
                    if (seznamSesalcev[i] is KopenskiSesalec)
                    {
                        listBox1.Items.Add("Ime: " + seznamImen[0, i]);
                        listBox1.Items.Add(seznamSesalcev[i]);
                        listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                }
            }
            else if (vrstaZivali2.SelectedItem.ToString() == "Vodni sesalec")
            {
                for (int i = 0; i < ns; i++)
                {
                    if (seznamSesalcev[i] is VodniSesalec)
                    {
                        listBox1.Items.Add("Ime: " + seznamImen[0, i]);
                        listBox1.Items.Add(seznamSesalcev[i]);
                        listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                }
            }
            else if (vrstaZivali2.SelectedItem.ToString() == "Leteči sesalec")
            {
                for (int i = 0; i < ns; i++)
                {
                    if (seznamSesalcev[i] is LeteciSesalec)
                    {
                        listBox1.Items.Add("Ime: " + seznamImen[0, i]);
                        listBox1.Items.Add(seznamSesalcev[i]);
                        listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                }
            }
            else if (vrstaZivali2.SelectedItem.ToString() == "Členonožec")
            {
                for (int i = 0; i < nc; i++)
                {
                    listBox1.Items.Add("Ime: " + seznamImen[1, i]);
                    listBox1.Items.Add(seznamClenonozcev[i]);
                    listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
            }
            else if (vrstaZivali2.SelectedItem.ToString() == "Žuželka")
            {
                for (int i = 0; i < nc; i++)
                {
                    if (seznamClenonozcev[i] is Zuzelke)
                    {
                        listBox1.Items.Add("Ime: " + seznamImen[1, i]);
                        listBox1.Items.Add(seznamClenonozcev[i]);
                        listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                }
            }
            else if (vrstaZivali2.SelectedItem.ToString() == "Pajkovec")
            {
                for (int i = 0; i < nc; i++)
                {
                    if (seznamClenonozcev[i] is Pajkovci)
                    {
                        listBox1.Items.Add("Ime: " + seznamImen[1, i]);
                        listBox1.Items.Add(seznamClenonozcev[i]);
                        listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                }
            }
            else if (vrstaZivali2.SelectedItem.ToString() == "Rak")
            {
                for (int i = 0; i < nc; i++)
                {
                    if (seznamClenonozcev[i] is Raki)
                    {
                        listBox1.Items.Add("Ime: " + seznamImen[1, i]);
                        listBox1.Items.Add(seznamClenonozcev[i]);
                        listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    }
                }
            }
        }

        /// <summary>
        /// Aktivira gumb oglasanjeZivali in onemogoči seznam med izvajanjem.
        /// </summary>
        private void zivali_SelectedIndexChanged(object sender, EventArgs e)
        {
            oglasanjeZivali.Enabled = true;
            zivali.Enabled = false;
        }

        /// <summary>
        /// Poišče izbrano žival v poljih in s pomočjo delegata OglasanjeZivali izpiše njeno oglašanje v polju glasZivali.
        /// </summary>
        private void oglasanjeZivali_Click(object sender, EventArgs e)
        {
            oglasanjeZivali.Enabled = false;
            zivali.Enabled = true;

            string izbranaZival = zivali.SelectedItem.ToString();
            bool preverjanje = false;
            int pozicijaImena = 0;

            for (int i = 0; i < seznamImen.GetLength(0); i++)
            {
                if (seznamImen[0, i] == izbranaZival)
                {
                    pozicijaImena = i;
                    preverjanje = true;
                    break;
                }
            }

            if (preverjanje == false)
            {
                for (int i = 0; i < seznamImen.GetLength(1); i++)
                {
                    if (seznamImen[1, i] == izbranaZival)
                    {
                        pozicijaImena = i;
                        break;
                    }
                }
            }

            OglasanjeZivali delegat;
            delegat = z => z.Oglasanje;

            if (preverjanje) glasZivali.Text = delegat(seznamSesalcev[pozicijaImena]);
            else glasZivali.Text = delegat(seznamClenonozcev[pozicijaImena]);
        }

        /// <summary>
        /// Pokliče metodo Izvoz() in prikaže Message Box ob uspešnem izvozu.
        /// </summary>
        private void btnIzvoz_Click(object sender, EventArgs e)
        {
            Izvoz();
            MessageBox.Show("Podatki o živalih so bili uspešno izvoženi", "Izvoz uspešen",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Poišče obe izbrani živali v poljih in primerja njuni teži.
        /// Rezultat primerjave prikaže v Message Box-u.
        /// </summary>
        private void btnPrimerjaj_Click(object sender, EventArgs e)
        {
            if (zival1.SelectedItem == null || zival2.SelectedItem == null)
            {
                MessageBox.Show("Niste izbrali vseh potrebnih živali.", "Napaka pri izbiri!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string izbranaZival1 = zival1.SelectedItem.ToString();
                bool preverjanje1 = false;
                int pozicijaImena1 = 0;

                for (int i = 0; i < seznamImen.GetLength(0); i++)
                {
                    if (seznamImen[0, i] == izbranaZival1)
                    {
                        pozicijaImena1 = i;
                        preverjanje1 = true;
                        break;
                    }
                }

                if (preverjanje1 == false)
                {
                    for (int i = 0; i < seznamImen.GetLength(1); i++)
                    {
                        if (seznamImen[1, i] == izbranaZival1)
                        {
                            pozicijaImena1 = i;
                            break;
                        }
                    }
                }

                string izbranaZival2 = zival2.SelectedItem.ToString();
                bool preverjanje2 = false;
                int pozicijaImena2 = 0;

                for (int i = 0; i < seznamImen.GetLength(0); i++)
                {
                    if (seznamImen[0, i] == izbranaZival2)
                    {
                        pozicijaImena2 = i;
                        preverjanje2 = true;
                        break;
                    }
                }

                if (preverjanje2 == false)
                {
                    for (int i = 0; i < seznamImen.GetLength(1); i++)
                    {
                        if (seznamImen[1, i] == izbranaZival2)
                        {
                            pozicijaImena2 = i;
                            break;
                        }
                    }
                }

                bool rezultat = false;

                if (preverjanje1 == true && preverjanje2 == true) if (seznamSesalcev[pozicijaImena1].Teza > seznamSesalcev[pozicijaImena2].Teza) rezultat = true;
                    else if (preverjanje1 == false && preverjanje2 == true) if (seznamClenonozcev[pozicijaImena1].Teza > seznamSesalcev[pozicijaImena2].Teza) rezultat = true;
                        else if (preverjanje1 == true && preverjanje2 == false) if (seznamSesalcev[pozicijaImena1].Teza > seznamClenonozcev[pozicijaImena2].Teza) rezultat = true;
                            else { if (seznamClenonozcev[pozicijaImena1].Teza > seznamClenonozcev[pozicijaImena2].Teza) rezultat = true; }

                if (rezultat == true) MessageBox.Show("Žival " + izbranaZival1 + " je težja od živali " + izbranaZival2, "Primerjava teže", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Žival " + izbranaZival1 + " ni težja od živali " + izbranaZival2, "Primerjava teže", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Poišče izbrano žival v poljih in v polje txtPremakniSe izpiše rezultat klica metode PremakniSe() za to žival.
        /// </summary>
        private void btnPremakniZival_Click(object sender, EventArgs e)
        {
            if (comboBoxPremakniZival.SelectedItem == null)
            {
                MessageBox.Show("Niste izbrali vseh potrebnih živali.", "Napaka pri izbiri!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string izbranaZival = comboBoxPremakniZival.SelectedItem.ToString();
                bool preverjanje = false;
                int pozicijaImena = 0;

                for (int i = 0; i < seznamImen.GetLength(0); i++)
                {
                    if (seznamImen[0, i] == izbranaZival)
                    {
                        pozicijaImena = i;
                        preverjanje = true;
                        break;
                    }
                }

                if (preverjanje == false)
                {
                    for (int i = 0; i < seznamImen.GetLength(1); i++)
                    {
                        if (seznamImen[1, i] == izbranaZival)
                        {
                            pozicijaImena = i;
                            break;
                        }
                    }
                }

                if (preverjanje == true) txtPremakniSe.Text = seznamSesalcev[pozicijaImena].PremakniSe();
                else txtPremakniSe.Text = seznamClenonozcev[pozicijaImena].PremakniSe();
            }
        }

        /// <summary>
        /// Poišče izbrano žival in s pomočjo indekserja prikaže ustrezen podatek živali v polju txtPodatek.
        /// Če podatka ni se v polje txtPodatek izpiše "Ta podatek ne obstaja. Izberite drugega.".
        /// </summary>
        private void btnIzpisPodatka_Click(object sender, EventArgs e)
        {
            if (comboBoxIzberiPodatek.SelectedItem == null)
            {
                MessageBox.Show("Niste izbrali vseh potrebnih živali.", "Napaka pri izbiri!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string izbranaZival = comboBoxIzberiPodatek.SelectedItem.ToString();
                bool preverjanje = false;
                int pozicijaImena = 0;

                for (int i = 0; i < seznamImen.GetLength(0); i++)
                {
                    if (seznamImen[0, i] == izbranaZival)
                    {
                        pozicijaImena = i;
                        preverjanje = true;
                        break;
                    }
                }

                if (preverjanje == false)
                {
                    for (int i = 0; i < seznamImen.GetLength(1); i++)
                    {
                        if (seznamImen[1, i] == izbranaZival)
                        {
                            pozicijaImena = i;
                            break;
                        }
                    }
                }

                int index = comboBoxPodatekZivali.SelectedIndex;

                if (preverjanje == true) txtPodatek.Text = seznamSesalcev[pozicijaImena][index];
                else txtPodatek.Text = seznamClenonozcev[pozicijaImena][index];
            }
        }
    }
}
