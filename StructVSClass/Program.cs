using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVSClass
{
    //vgl. Modul 4 -> Fahrzeug
    public class KlassenPerson
    {
        public string Name;
        public int Alter;

        public KlassenPerson(string name, int alter)
        {
            this.Name = name;
            this.Alter = alter;
        }
    }

    //STRUCTS sind Klassenähnliche Konstrukte, welche nicht, wie Klassen, als Referenztypen behandelt werden, sondern ein Wertetyp sind. D.h
    //bei Übergabe eines Structs an eine Methode oder Variable wird eine Kopie dieses Objekts erstellt
    public struct StructPerson
    {
        public string Name;
        public int Alter;

        public StructPerson(string name, int alter)
        {
            this.Name = name;
            this.Alter = alter;
        }
    }

    class Program
    {
        public static void Altern(KlassenPerson person)
        {
            person.Alter++;
        }

        public static void Altern(StructPerson person)
        {
            person.Alter++;
        }

        //Mittels des REF-Stichworts können Wertetypen als Referenz an Methoden übergeben werden. D.h. die übergebene Speicherstelle selbst 
        ///wird manipuliert und nicht, wie normalerweise bei Wertetypen, eine Kopie des Werts.
        public static void Altern(ref StructPerson person)
        {
            person.Alter++;
        }

        static void Main(string[] args)
        {
            //Erstellung von Objekten
            KlassenPerson kPerson = new KlassenPerson("Otto", 30);
            StructPerson sPerson = new StructPerson("Anna", 30);

            //Ausgabe
            Console.WriteLine(kPerson.Alter);
            Console.WriteLine(sPerson.Alter);

            //Funktionsaufruf
            Altern(kPerson);
            Altern(sPerson);

            //Erneute Ausgabe: Nur das Klassenobjekt (Referenztyp) hat sich verändert
            Console.WriteLine(kPerson.Alter);
            Console.WriteLine(sPerson.Alter);

            //Übergabe des Wertetyps als Refernz mittels Ref-Stichwort
            Altern(ref sPerson);
            Console.WriteLine(sPerson.Alter);

            Console.ReadKey();
        }
    }
}
