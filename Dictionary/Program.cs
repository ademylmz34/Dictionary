using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ögrenciler = new MyDictionary<int, string>();
            ögrenciler.Add(61, "Adem");
            ögrenciler.Add(28, "Arif");
            ögrenciler.Add(34, "Bora");
            ögrenciler.Add(54, "Şakir");

            Console.WriteLine(ögrenciler.Length);
            Console.ReadKey();
        }
    }
}
