using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human ömo = new Human("Ömo", "Aydin", "black", 7);
            ömo.setAge(1);
            ömo.IntroduceMyself();

            Human zera = new Human("Zehra", "Miller", "brown", 19);
            zera.IntroduceMyself();
            zera.EyeColor = "orange";
            zera.IntroduceMyself();
            zera.Number = 12;

            Console.WriteLine("Ömo: " + ömo.getAge());
            Console.WriteLine("Zehra number: " + zera.Number);
            Console.ReadKey();
        }
    }
}
