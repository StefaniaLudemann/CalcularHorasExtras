using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_horas_extras
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal horas = 0m;
            decimal sueldo = 0m;
            decimal categoria = 0m;
            decimal horaTrabajada = 0m;
            decimal totalSueldo = 0m;

            Console.WriteLine("Categoría 1 hasta 30 hs extras cobra $10 la hs.");
            Console.WriteLine("Categoría 2 hasta 30 hs extras cobra $14 la hs.");
            Console.WriteLine("Categoría 1 mas de 30 hs extras cobra $11 la hs.");
            Console.WriteLine("Categoría 2 mas de 30 hs extras cobra $20 la hs.");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("por favor ingrese las horas trabajadas: ");
            horas = decimal.Parse(Console.ReadLine());
            Console.WriteLine("por favor ingrese su sueldo: ");
            sueldo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("por favor ingrese su categoria: ");
            categoria = decimal.Parse(Console.ReadLine());

            if(categoria==1 && horas <= 30)
            {
                horaTrabajada = horas * 10;
                totalSueldo = sueldo + horaTrabajada;
                Console.WriteLine("usted cobrará "+totalSueldo + " pesos.");
            }else if(categoria==1 && horas > 30)
            {
                horaTrabajada = horas * 11;
                totalSueldo = sueldo + horaTrabajada;
                Console.WriteLine("usted cobrará " + totalSueldo + " pesos.");
            }else if(categoria==2 && horas <= 30)
            {
                horaTrabajada = horas * 14;
                totalSueldo = sueldo + horaTrabajada;
                Console.WriteLine("usted cobrará " + totalSueldo + " pesos.");
            }else if(categoria==2 && horas > 30)
            {
                horaTrabajada = horas * 20;
                totalSueldo = sueldo + horaTrabajada;
                Console.WriteLine("usted cobrará " + totalSueldo+ " pesos.");
            }


            Console.ReadKey();


        }
    }
}
