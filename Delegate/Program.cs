using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //Ein DELEGATE ist eine Variable, in welcher man Funktionen mit einem gleichen Methodenkopf speichern kann. Eigene Delegate-Typen müssen
    ///vorher definiert werden.
    public delegate int MyDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            //Zuweisung der Addiere()-Methode zur einer Variablen vom Typ MyDelegate
            MyDelegate delegateVariable = new MyDelegate(Addiere);

            //Ausführung der Delegate-Variablen
            int ergebnis = delegateVariable(12, 45);
            Console.WriteLine(ergebnis);

            //Neuzuweisung der Variable (Kurzschreibweise)
            delegateVariable = Subtrahiere;

            ergebnis = delegateVariable(12, 45);
            Console.WriteLine(ergebnis);

            //Zuweisung einer zweiten Methode zur Delegate-Variablen
            delegateVariable += Addiere;

            //Bei Ausführung einer Delegate-Variablen werden alle referenzierten Methoden in der Reihenfolge ihrer Zuweisung ausgeführt.
            ///Nur die letzte Methode gibt einen Rückgabewert zurück
            ergebnis = delegateVariable(12, 45);
            Console.WriteLine(ergebnis);

            //Erstellen und Ausgabe einer Liste der in der Variablen gespeicherten Methode
            var MethodenListe = delegateVariable.GetInvocationList().ToList();
            foreach (var item in MethodenListe)
            {
                Console.WriteLine(item.Method);
            }

            //Löschen einer Referenz aus der Variablen
            delegateVariable -= Subtrahiere;

            delegateVariable = null;

            //FUNC<> / ACTION<> /PREDICATE<> sind die von C# vordefinierten Delegate-Typen
            Func<int, int, int> meinFunc = Addiere;

            Console.WriteLine(meinFunc(12, 45));

            FühreAus(meinFunc);
            FühreAus(Subtrahiere);

            List<string> städteListe = new List<string>() { "Berlin", "München", "Köln", "Bonn" };

            //ANONYME METHODEN sind Methoden, welche nicht mit Kopf und Körper geschrieben stehen, sondern nur innerhalb von Delegate-Variablen
            ///existieren

            //Übergabe einer Methode an eine andere Methode
            string gesuchteStadt = städteListe.Find(SucheStadtMitM);

            //Übergabe der Methode als anonyme Methode
            gesuchteStadt = städteListe.Find(
                delegate (string stadt)
                {
                    return stadt.StartsWith("M");
                });

            //Übergabe der anonymen Methode in LAMBDA-Schreibweise (Lang und Kurz)
            gesuchteStadt = städteListe.Find((string stadt) => { return stadt.StartsWith("M"); });
            gesuchteStadt = städteListe.Find(stadt => stadt.StartsWith("M"));

            Console.WriteLine(gesuchteStadt);

            //Weiteres Bsp für die Übergabe einer anonymen Methode in Lambda (Sortierung der Einträge nach dem ersten Buchstaben)
            städteListe = städteListe.OrderBy(stadt => stadt[0]).ToList();
            foreach (var item in städteListe)
            {
                Console.WriteLine(item);
            }

            //weiteres Bsp der Lambda-Schreibweise (Methode empfängt zwei int und gibt deren Summe als String zurück)
            Func<int, int, string> funky = (x, y) => (x + y).ToString();


            Console.ReadKey();

        }

        //Bsp-Methode zur Übergabe an eine Liste
        public static bool SucheStadtMitM(string stadt)
        {
            return stadt.StartsWith("M");
        }

        //Funktion mit Delegate-Übergabeparameter
        public static void FühreAus(Func<int, int, int> methode)
        {
            methode(23, 89);
        }

        //Funktion mit Delegate-Rückgabewert
        public static Func<int, int, int> BaueFunc()
        {
            return Addiere;
        }

        //Bsp-Methoden zur Demonstration der Delegate-Funktionalität
        public static int Addiere(int a, int b)
        {
            Console.WriteLine("Addiere");
            return a + b;
        }

        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("Subtrahiere");
            return a - b;
        }
    }
}
