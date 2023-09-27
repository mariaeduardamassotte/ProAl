using System;

namespace Aula_26_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {

            float nota1, nota2, nota3, nota4, soma, media, percentualFrequencia;

            Console.Write("informe a primeira Nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("informe a segunda Nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("informe a terceira Nota: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("informe a quarta Nota: ");
            nota4 = float.Parse(Console.ReadLine());

            Console.Write("Informe o % Frequencia: ");
            percentualFrequencia = float.Parse(Console.ReadLine());

            soma = nota1 + nota2 + nota3 + nota4;

            media = soma / 4;

            //0.00 a 4.99 e % Frequencia <= 40 - Reprovado
            //5.00 a 6.99 e % Frequencia <= 60 - Recuperação
            //7.00 a 10   e % Frequencia > 60 - Aprovado

            if (media < 5 && percentualFrequencia <= 40)
            {
                Console.WriteLine("Aluno Reprovado");
            } else if (media < 7 && percentualFrequencia <= 60)
            {
                Console.WriteLine("Aluno em Recuperação");
            }else if(media >=7 && percentualFrequencia > 60)
               
            {
                Console.Write("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Será  analisado pela secretaria acadêmica");
            }
        }        
    }
}
