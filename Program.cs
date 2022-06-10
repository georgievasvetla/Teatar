using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TeatarCompear
{
    class Program
    {
        static void Main(string[] args)
        {
            Teatar obj1 = new Teatar("T", "Plovdiv", 12, 170);
            Teatar obj2 = new Teatar("TT", "Stara Zagora", 10, 200);
            Console.WriteLine(obj1.Print());
            Console.WriteLine(obj2.Print());
            List<Teatar> teatar = new List<Teatar>()
            {
                obj1,
                obj2
            };

            var compare = new IPriceComperator();
            teatar.Sort(compare);
            teatar.Sort();
            Console.WriteLine(string.Join(" ", teatar.Select(p => p.Price)));
            Console.WriteLine(string.Join(" ", teatar.Select(p => p.Name)));

            StreamWriter writer = new StreamWriter(@"Text.txt");
            for (int i = 0; i < teatar.Count-1; i++)
            {
                writer.WriteLine(teatar[i]);

            }
            writer.Close();


 
        }
    }
}
