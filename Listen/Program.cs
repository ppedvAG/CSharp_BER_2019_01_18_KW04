using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Objekte> liste1 = new List<Objekte>();
            List<Objekte> liste2 = new List<Objekte>();

            for (int i = 0; i < 30; i++)
            {
                liste1.Add(new Objekte($"1: {i}",i));
                liste2.Add(new Objekte($"2: {i}",i));
            }

            List<Objekte> kombinierteListe = liste1.Concat(liste2).ToList();

            liste1.AddRange(liste2);

            kombinierteListe = kombinierteListe.OrderBy(obj => obj.Zeitstempel).ToList();


            foreach (var item in kombinierteListe)
            {
                Console.WriteLine(item.ID + ": " + item.Zeitstempel.ToLongDateString());
            }

            Console.ReadKey();
        }
    }

    public class Objekte
    {
        public string ID { get; set; }
        public DateTime Zeitstempel { get; set; }

        public Objekte(string id, int i)
        {
            this.ID = id;
            this.Zeitstempel = new DateTime(2019, 1, 31 - i);
        }
    }
}
