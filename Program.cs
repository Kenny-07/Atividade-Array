using System;

namespace Atividade_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string bolo;
            string acompanhamento;

            string[] produtos = {"Bolo de Chocolate", "Bolo de Abacaxi", "Bolo de Baunilha", "Bolo de Cenoura", "Bolo de Laranja"};
            string[] recheios = {"Brigadeiro", "Beijinho", "Frutas Vermelhas", "Mousse"};

            Console.WriteLine("================================");
            Console.WriteLine("Bem vindo a Confeitaria do Back!");
            Console.WriteLine("================================");

            Console.WriteLine("Qual Bolo você vai querer hoje ?");
            Console.WriteLine("================================");

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine(produtos[i]);
            }

            bolo = Console.ReadLine();

            Console.WriteLine("=================================================================");
            Console.WriteLine($"Para acompanhar seu {bolo} qual Recheio você deseja ?");
            Console.WriteLine("=================================================================");

            for (int i = 0; i < recheios.Length; i++)
            {
                Console.WriteLine(recheios[i]);
            }

            acompanhamento = Console.ReadLine();

            Console.WriteLine("============================================================================");
            Console.WriteLine($"Aproveite seu {bolo} com Recheio de {acompanhamento} !! <3");
            Console.WriteLine("============================================================================");
        }
    }
}
