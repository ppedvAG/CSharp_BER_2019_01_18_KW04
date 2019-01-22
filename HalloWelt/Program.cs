//Mittels der USING-Anweisungen kann ein vereinfachter Zugriff auf Programm-Externe Klassen ermöglicht werden. Es muss nun nicht mehr der
///vollständige Pfad angegeben werden, sondern es reicht der Klassenbezeichner
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NAMESPACE: Die Umgebung unseres aktuellen Programms: Alles innerhalb des Namespaces gehört zu dem Programm
namespace HalloWelt
{
    //Die PROGRAM-Klasse beinhaltet den Einstiegspunkt des Programms und muss in jedem C#-Programm vorhanden sein
    class Program
    {
        //Die MAIN()-Methode ist der Einstiegspunkt jedes C#-Programms: Hier beginnt das Programm IMMER
        static void Main(string[] args)
        {
            //Deklaration einer Integer-Variable 
            int alter;
            //Initialisierung der Integer-Variablen
            alter = 29;
            //Gleichzeitige Deklaration und Initialisierung einer String-Variablen
            string stadt = "Berlin";

            //Ausgabe eines String-Literals
            Console.WriteLine("Mein Name ist Klaas.");
            //Ausgabe einer Integer-Variablen
            Console.WriteLine(alter);
            
            ///Einfügen dynamischer Inhalte in Strings
            //'traditionell'
            Console.WriteLine("Mein Name ist Klaas, ich bin " + alter + " Jahre alt und wohne in " + stadt + ".");
            //Index
            Console.WriteLine("Mein Name ist Klaas, ich bin {0} Jahre alt und wohne in {1}.", alter, stadt);
            //$-Operator
            Console.WriteLine($"Mein Name ist Klaas, ich bin {alter} Jahre alt und wohne in {stadt}.");

            //Ausgabe einer Berchnung in Strings
            int a = 15;
            int b = 23;
            Console.WriteLine($"Das Ergebnis ist {a + b}");

            //String-Formatierung mittels Escape-Sequenzen
            Console.WriteLine("Dies ist ein \n Zeilenumbruch und dies ein \t horizontaler Tabulator.");

            //String-Formatierung mittels VerbaTim-String (Einleitung mittels @ / Escape-Sequenzen sind nicht möglich, 
            ///dynamische Inhalte mittels $ schon)
            Console.WriteLine($@"Dies ist ein
 Zeilenumbruch und dies ein     horizontaler Tabulator.");

            //Eingabe eines Strings durch den Benutzer und Abspeichern in einer String-Variablen
            Console.WriteLine("Bitte gib einen String ein: ");
            string input = Console.ReadLine();
            Console.WriteLine(input);

            //Eingabe eines Strings, Umwandlung in einen Integer (Parse()-Funktion) und Abspeichern in einer Integer-Variablen
            Console.WriteLine("Bitte gib eine Zahl ein: ");
            int inputInt = int.Parse(Console.ReadLine());
            Console.WriteLine(inputInt * 2);

            //Programmpause
            Console.ReadKey();
        }
    }
}
