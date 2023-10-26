using System;

namespace Aula_26_10_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorFinanciado, valorParcela;
            int qtdeParcela;
            int contador = 1;

            Console.Write("Informe o valor Financiado: ");
            valorFinanciado = float.Parse(Console.ReadLine());

            Console.Write("Informe a Quantidade de Parcelas: ");
            qtdeParcela = int.Parse(Console.ReadLine());

            valorParcela = valorFinanciado / qtdeParcela;

            DateTime data = DateTime.Now.Date;

            while (contador <= qtdeParcela)
            {
                // Console.WriteLine($"O valor da parcela {contador} é de {valorParcelas");
                Console.WriteLine($"{contador}ª parcela: ({data}){valorParcela:0.00}");
                //Console.WriteLine($"{contador}ª parcela: {valorFinanciado / valorParcela:0.00}");
                contador++;
                data = data.AddMonths(1);

            }
        }
    }
}
