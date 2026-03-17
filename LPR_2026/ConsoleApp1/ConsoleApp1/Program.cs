using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosquinha
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            string o;

            Console.WriteLine("digite seu primeiro numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite seu segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite qual operação você deseja (+,-,*,/): ");
            o = Console.ReadLine();

            if (o == "+")
            {
                Console.WriteLine("resultado: " + (n1 + n2));
            }
            else if (o == "-")
            {
                Console.WriteLine("resultado: " + (n1 - n2));
            }
            else if (o == "*")
            {
                Console.WriteLine("resultado: " + (n1 * n2));
            }


            else if (n2 == 0)
            {
                Console.WriteLine("não da certo de resolver");
            }

            else if (o == "/")
            {
                Console.WriteLine("resultado: " + (n1 / n2));
            }






        }
    }
}
