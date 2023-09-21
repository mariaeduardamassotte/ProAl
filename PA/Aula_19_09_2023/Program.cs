using System;

namespace Aula_19_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, soma, media;

            Console.Write("informe a primeira Nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("informe a segunda Nota: ");
             nota2 = float.Parse(Console.ReadLine());

            Console.Write("informe a terceira Nota: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("informe a quarta Nota: ");
            nota4 = float.Parse(Console.ReadLine());

            soma = nota1 + nota2 + nota3 + nota4;

            media = soma / 4;

            //0.00 a 4.99 - Reprovado
            //5.00 a 6.99 - Recuperação
            //7.00 a 10.00- Aprovado

            if (media < 5)
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Poxa que Pena!!!");
            }
            else if (media < 7)
            {
                Console.WriteLine("Recuperção");
                Console.WriteLine("Coragem!!!");
            }

            else
            { 
                Console.WriteLine("Aprovado");
                Console.WriteLine("Parabens!!!");


            }


            Console.WriteLine("Hello World!");
        }
    }
}
