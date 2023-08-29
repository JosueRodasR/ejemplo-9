using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresar el primer numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingresar el segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingresar el tercer numero: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            int mayor = numero1;

            if (numero2 > mayor)
            {
                mayor = numero2;
            }

            if (numero3 > mayor)
            {
                mayor = numero2;
            }

            if (numero3 > mayor)
            {
                mayor = numero3;
            }
            
            Console.WriteLine($"El mayor de los tres numeros es: {mayor}");
            Console.ReadKey();
        }
    }
}
