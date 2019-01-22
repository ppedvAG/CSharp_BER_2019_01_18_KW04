using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Fahrzeugpark;
//Json ist eine Serialisierungs-Methode, welche über den NuGet-Marketspace installiert und dem Projekt hinzugefügt wurde
using Newtonsoft.Json;

namespace Serialisierung
{
    public partial class Form1 : Form
    {
        public List<Fahrzeug> FzListe { get; set; }
        public Random generator { get; set; }

        public Form1()
        {
            InitializeComponent();

            //Initialisierung der Properties
            this.FzListe = new List<Fahrzeug>();
            this.generator = new Random();

            //Bsp für Darstellung eines Unicode-Zeichens
            LblMain.Text = "200\u20AC kosten die Schuhe";
        }

        //Click-Methoden der Buttons
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ErstelleNeuesFz();
            ZeigeFz();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            LöscheFz();
            ZeigeFz();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SpeichereFz();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LadeFz();
            ZeigeFz();
        }

        //Methode zum Laden einer 'Fahrzeug'-Datei (vgl. auch SpeichernUndLaden.Form1.BtnLoad_Click())
        private void LadeFz()
        {
            StreamReader sr = null;

            //Mittels der TypeNameHandling-Property des JsonSerializerSettings-Objekts kann dem Serialisierer aufgegeben werden, dass er den expliziten Objekt-Type der 
            //zu ladenden/speichernden Objekte mit abspeichert
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Objects;

            try
            {
                sr = new StreamReader("fahrzeugListe.txt");

                while (!sr.EndOfStream)
                {
                    //Lesen einer Textzeile aus der Datei
                    string fzAlsString = sr.ReadLine();
                    //Umwandlung der Textzeile in ein Fahrzeug (Beachte die Übergabe des Settings-Objekts)
                    Fahrzeug fz = JsonConvert.DeserializeObject<Fahrzeug>(fzAlsString, settings);
                    //Hinzufügen des Fahrzeugs zur Liste
                    FzListe.Add(fz);
                }

                MessageBox.Show("Laden erfolgreich");
            }
            catch { }
            finally
            {
                sr?.Close();
            }
        }

        //Methode zum Abspeichern von Fahrzeugen (vgl. auch LadeFZ)
        private void SpeichereFz()
        {
            StreamWriter sw = null;

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Objects;

            try
            {
                sw = new StreamWriter("fahrzeugListe.txt");

                //Iteration über die ListBox
                for (int i = 0; i < LbxFahrzeuge.Items.Count; i++)
                {
                    //Überprüfung, ob der aktuelle Eintrag vom Benutzer ausgewählt wurde
                    if (LbxFahrzeuge.GetSelected(i))
                    {
                        string fzAlsString = JsonConvert.SerializeObject(FzListe[i], settings);

                        sw.WriteLine(fzAlsString);
                    }
                }

                MessageBox.Show("Speichern erfolgreich");
            }
            catch { }
            finally
            {
                sw?.Close();
            }
        }

        //Methode zum Löschen von Fahrzeugen
        private void LöscheFz()
        {
            for (int i = LbxFahrzeuge.Items.Count - 1; i >= 0; i--)
            {
                if (LbxFahrzeuge.GetSelected(i))
                    FzListe.RemoveAt(i);
            }
        }

        //Methode zur Darstellung der Fahrzeuge aus der Liste in der ListBox der GUI
        private void ZeigeFz()
        {
            LbxFahrzeuge.Items.Clear();

            foreach (var item in FzListe)
            {
                LbxFahrzeuge.Items.Add(item.Name);
            }
        }

        //Methode zur zufälligen Erstellung von Fahrzeugen
        private void ErstelleNeuesFz()
        {
            switch (generator.Next(1, 4))
            {
                case 1:
                    FzListe.Add(new Flugzeug($"Boing", 800, 3600000, 9999));
                    break;
                case 2:
                    FzListe.Add(new Schiff($"Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));
                    break;
                case 3:
                    FzListe.Add(PKW.ErzeugeZufälligenPKW());
                    break;
            }
        }

        private void BtnSaveXml_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSeri = new XmlSerializer(typeof(PKW));

            FileStream file = File.Create("xmlFahrzeuge.xml");

            xmlSeri.Serialize(file, new PKW("Audi", 350, 41000, 3));

            file?.Close();
        }

        private void BtnLoadXml_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSeri = new XmlSerializer(typeof(PKW));

            FileStream file = File.Open("xmlFahrzeuge.xml", FileMode.Open);

            PKW pkw1 = (PKW)xmlSeri.Deserialize(file);

            MessageBox.Show(pkw1.ToString());

            file?.Close();
        }
    }
}
