using System;
using System.Globalization;
using System.Numerics;

namespace Resolvente
{
    class Program
    {
        static void Main()
        {
            Resolvente();
        }

        public static void Resolvente()
        {
            string valor1;
            string valor2;
            string valor3;
            double discriminante;
            double resultado1;
            double resultado2;
            Console.Write("Ingrese a:");
            valor1 = Console.ReadLine();
            Console.Write("Ingrese b:");
            valor2 = Console.ReadLine();
            Console.Write("Ingrerse c:");
            valor3 = Console.ReadLine();
            if (IsNumber(valor1) && IsNumber(valor2) && IsNumber(valor3))
            {
                double a = Convert.ToDouble(valor1);
                double b = Convert.ToDouble(valor2);
                double c = Convert.ToDouble(valor3);
                discriminante = Math.Sqrt((b * b) - (4 * a * c));
                //Complex imaginario = Math.Sqrt(-1);
                //Complex discriminantei = discriminante * imaginario;
                
                if (discriminante >= 0)
                {
                    resultado1 = ((-1 * b) + discriminante) / (2 * a);
                    resultado2 = ((-1 * b) - discriminante) / (2 * a);
                    Console.Write("Los resultados son x1={0} y x2={1}", resultado1, resultado2);
                }
                if (double.IsNaN(discriminante))
                {
                    Console.Write("Los resultados son números complejos");
                }
             }
            else
            {
                Console.WriteLine("ingrese números");
                Main(); 
            }
        }

        public static bool IsNumber(string numer1) //es para asegurar que se introzca un número.
        {
            bool isnumber;
            CultureInfo culture = new CultureInfo("en-US");
            try
            {
                Convert.ToDouble(numer1, culture);
                isnumber = true;
            }
            catch
            {
                isnumber = false;
            }
            return isnumber;
        }

        //if (discriminante < 0)
                //{
                    //resultado1 = ((-1 * b) + discriminantei) / (2 * a);
                    //resultado2 = ((-1 * b) - discriminantei) / (2 * a);
                    //Console.Write("Los resultados son x1={0} y x2={1}", resultado1, resultado2);
                //}
}
}
