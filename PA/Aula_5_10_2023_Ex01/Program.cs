using System;

namespace Aula_5_10_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
          
            float valor1, valor2;
            string operador;

            Console.Write("Informe o 1º valor");
            valor1 = float.Parse(Console.ReadLine()); 

            Console.Write("Informe o 2º valor");
            valor2 = float.Parse(Console.ReadLine());

            Console.Write("Informe o operador");
            operador = (Console.ReadLine());

            if (operador == "+")
            {

                Console.WriteLine($"valor da Soma é {valor1 + valor2}");
            }

            else if (operador == "-")
            {
                Console.WriteLine($"valor da Subtração é {valor1 - valor2}");
            }
            else if (operador == "*")
            {
                Console.WriteLine($"valor da Multiplicação é {valor1 * valor2}");
            }
            else
            {
                Console.WriteLine($"valor da subtração é {valor1 / valor2}");
            }
        }
    }
}
