namespace Carteado
{
    using Modelos;
    using static System.Net.Mime.MediaTypeNames;

    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.Title = "Sistema Cartas em Jogo - Acesso";

                Console.WriteLine("===================================================");
                Console.WriteLine("                    CARTAS EM JOGO                 ");
                Console.WriteLine("===================================================");
                Console.WriteLine();
                Console.WriteLine("1. Maior Carta");
                Console.WriteLine("2. Par ou Ímpar");
                Console.WriteLine("3. Batalha");
                Console.WriteLine("0. Sair");
                Console.WriteLine();
                Console.Write("Escolha um jogo: ");
                string opcao = Console.ReadLine();

                if (opcao == "1" || opcao == "2" || opcao == "3") 
                {
                    PreparaJogo(opcao);
                }
                else 
                { if (opcao == "0")
                    {
                        Console.WriteLine("\nObrigado por usar Cartas em Jogo. Até logo!");
                        Environment.Exit(0);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida. Pressione Enter para voltar ao Menu Principal.");
                        Console.ReadLine();
                    } 
                }


            }

        }

        static void PreparaJogo(string opcao)
        {


            List<Carta> CriarCartas()
            {
                List<Carta> cartas = new List<Carta>();
                for (int i = 1; i <= 100; i++)
                {
                    cartas.Add(new Carta(i));
                }
                return cartas;
            }

            List<Carta> CriarCartasComMultiplicador()
            {
                List<Carta> cartas = new List<Carta>();
                for (int i = 1; i <= 15; i++)
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        cartas.Add(new CartaComMultiplicador(i, j));
                    }
                }
                return cartas;
            }

            Baralho<Carta> baralho = new Baralho<Carta>(CriarCartasComMultiplicador());

            Jogo<Carta> jogo = new Jogo<Carta>(baralho, new Jogador<Carta>(), new Jogador<Carta>(), opcao);
            jogo.Jogar();

        }
    }
}
