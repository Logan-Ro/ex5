using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Entrez votre âge : ");
            age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("majeur");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("mineur");
                Console.ReadLine();
            }
        }
    }
}
