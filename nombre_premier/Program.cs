using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombre_premier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer un nombre");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (i < x)
            {
                if ((x % i) == 0)
                {
                    i = x + 1;
                }

                else
                {
                    i++;
                }
            }
            if (i == x)
            {
                Console.WriteLine(+x + " est un nombre Premier ");
            }
            else
            {
                Console.WriteLine(+x + "  n'est pas un nombre  premier ");
            }
        }
    }
}
