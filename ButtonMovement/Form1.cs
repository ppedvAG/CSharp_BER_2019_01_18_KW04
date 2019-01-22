using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonMovement
{
    public partial class Form1 : Form
    {
        //Properties zum Abspreichern der Startpositionen der Buttons
        public int BtnLeftStart { get; set; }
        public int BtnRightStart { get; set; }

        public Form1()
        {
            //Zeichnen der Designer-Komponenten
            InitializeComponent();

            //Speichern der Startpositionen der Buttons
            this.BtnLeftStart = BtnLeft.Left;
            this.BtnRightStart = BtnRight.Left;

            //Abonieren der drei Click-Methoden durch das Click-Event der dritten Buttons
            BtnStart.Click += BtnLeft_Click;
            BtnStart.Click += BtnRight_Click;
            BtnStart.Click += BtnStart_Click;
        }

        //Methoden wurden im Designer von den Click-Events der Buttons btnLeft und btnRight abboniert
        private void BtnLeft_Click(object sender, EventArgs e)
        {
            //Bewegt des Buttons um 10 Pixel nach rechts
            BtnLeft.Left += 10;
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            //Bewegt des Buttons um 10 Pixel nach links
            BtnRight.Left -= 10;
        }

        //Methode wird im Konstruktor durch das Click-Event des Buttons btnStart abboniert
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //Test, ob Kollision vorhanden
            if (BtnLeft.Right >= BtnRight.Left)
                //Aufruf einer MessageBox, mit Abfrage, ob der Button 'Ja' geklickt wurde
                if (MessageBox.Show("Die Buttons berühren sich.\nZurücksetzen?", "Berührung", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    //Zurücksetzen der Buttons auf ihre Startposition
                    BtnLeft.Left = this.BtnLeftStart;
                    BtnRight.Left = this.BtnRightStart;
                }
        }
    }
}
