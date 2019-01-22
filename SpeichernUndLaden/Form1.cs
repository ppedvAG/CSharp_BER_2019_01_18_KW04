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

namespace SpeichernUndLaden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Methode zum Laden einer Textdatei
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //Instanzierung eines Open-Dialogfensters 
            OpenFileDialog openDialog = new OpenFileDialog();

            //Einstellung diverser Parameter des Dialogfensters
            ///Standart-Dateiname
            openDialog.FileName = "textdatei.txt";
            ///Standart-Ordner (kann z.B. ein Pfad als String sein oder (wie hier) ein Windows-'SpecialFolder')
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ///Übergabe des Windows-Arbeitsplatzes als GUID
            openDialog.InitialDirectory = "::{20d04fe0-3aea-1069-a2d8-08002b30309d}";
            ///Mögliche Dateiformate
            openDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*";

            //Öffnen des Dialogfensters und Überprüfung der Benutzerwahl
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //Deklarierung und Null-Initialisierung einer Streamreader-Variablen
                StreamReader reader = null;

                try
                {
                    //Löschen des Inhalts der Textbox
                    TbxMain.Clear();

                    //Instanzierung des Streamreaders mit Übergabe des vopm Benutzer gewählten Dateipfades
                    reader = new StreamReader(openDialog.FileName);

                    //Schleife, welche über die geöffnete Datei läuft
                    while (!reader.EndOfStream)
                        //Hinzufügen der aktuell betrachteten Zeile in der Datei zu der Textbox
                        TbxMain.Text += reader.ReadLine() + "\r\n";

                    //Erfolgsmeldung für User
                    MessageBox.Show("Laden erfolgreich");
                }
                catch
                {
                    //Misserfolgsmeldung für User bei Aufkommen einer Exception
                    MessageBox.Show("Laden fehlgeschlagen");
                }
                finally
                {
                    //Schließen der Datei innerhalb des Finally-Blocks, damit andere Programme auf die Datei zugreifen können (? = Nullprüfung des vorhergehenden Bezeichners)
                    reader?.Close();
                }
            }
        }

        //Methode zum Speichern einer Textdatei (vgl. auch BtnLoad_Click())
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.FileName = "textdatei.txt";

            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveDialog.InitialDirectory = "::{20d04fe0-3aea-1069-a2d8-08002b30309d}";

            saveDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    //Verwendung des USING-Blocks (erlaubt durch die Verwendung des IDisposible-INterfaces in der StreamWriter-Klasse.
                    //Hierdurch wird durch verlassen des Using-Blocks automatisch der Dateizugriff beenden (statt writer.Close())
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        //StreamWriter schreibt einen String in die Datei
                        writer.WriteLine(TbxMain.Text);

                        MessageBox.Show("Speichern erfolgreich");

                    }
                }
                catch
                {
                    MessageBox.Show("Speichern fehlgeschlagen");
                }
            }
        }
    }
}
