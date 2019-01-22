using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeratoren
{
    //ENUMERATOREN sind spezialisierte selbst-definierte Datentypen mit festgelegten möglichen Zuständen.
    ///Dabei ist jeder Zustand an einen Integer-Wert gekoppelt, wodurch eine explizite Umwandlung (Cast) möglich ist.
    enum Wochentag { Montag=1, Dienstag, Mittwoch, Donnertag, Freitag, Samstag, Sonntag}

    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung einer Variablen vom Enumerator-Typ
            Wochentag heute = Wochentag.Dienstag;
            Console.WriteLine(heute);

            //Cast: Int -> Wochentag
            heute = (Wochentag)4545;
            Console.WriteLine(heute);

            //For-Schleife über die möglichen Zustande des Enumerators
            Console.WriteLine("Wähle den heutigen Wochentag:");
            for (int i = 1; i <= Enum.GetValues(typeof(Wochentag)).Length; i++)
            {
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }
            //Speichern einer Benutzereingabe (Int) als Enumerator
            heute = (Wochentag)int.Parse(Console.ReadLine());
            Console.WriteLine(heute);

            //SWITCHs sind eine verkürzte Schreibweise für IF-ELSE-Blöcke. Mögliche Zustände der übergebenen Variablen werden 
            //in den CASES definiert
            switch (heute)
            {
                case Wochentag.Montag:
                    Console.WriteLine("Einen schönen Wochenanfang");
                    //Jeder speziell definierte CASE muss mit einer BREAK-Anweisung beendet werden
                    break;
                //Wenn in einem CASE keine Anweisungen geschrieben stehen kann auf den BREAK-Befehl verzichtet werden. In diesem Fall
                //springt das Programm in diesem CASE zum Nachfolgenden
                case Wochentag.Dienstag:
                case Wochentag.Mittwoch:
                case Wochentag.Donnertag:
                    Console.WriteLine("Schöne Woche");
                    break;
                //Wenn die übergebene Variable keinen der vordefinierten Zustände erreicht, wird der DEFAULT-Fall ausgeführt
                default:
                    Console.WriteLine("Schönes Wochenende");
                    break;
            }

            //Mittels des WHEN-Stichworts kann auf Eigenschaften des betrachteten Objekts näher eingegangen werden
            string a = "Hallo";
            switch (a)
            {
                case string b when b.Length > 4:
                    Console.WriteLine(b);
                    break;
                default:
                    break;
            }

            //Programmpause
            Console.ReadKey();
        }
    }
}
