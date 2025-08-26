using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteado.Modelos.Jogos
{
    class JogoBatalha<T> : JogoBase<T> where T : IPontuacao
    {
        public JogoBatalha(IBaralho<T> baralho, IJogador<T> jogador1, IJogador<T> jogador2)
            : base(baralho, jogador1, jogador2) { }

        public override void Jogar()
        {
            Console.Clear();
            Console.WriteLine("============================== Batalha ==============================");
            Console.WriteLine("== Cada jogador recebe três cartas. Soma-se os valores das cartas. ==");
            Console.WriteLine("== Vence o jogador que tiver a maior soma.                         ==");
            Console.WriteLine("=====================================================================");

            Baralho.Embaralhar();

            var cartasJogador1 = new List<T>();
            var cartasJogador2 = new List<T>();

            for (int i = 0; i < 3; i++)
            {
                cartasJogador1.Add(Baralho.Entregar());
                cartasJogador2.Add(Baralho.Entregar());
            }

            int totalJogador1 = cartasJogador1.Sum(c => c.Pontos);
            int totalJogador2 = cartasJogador2.Sum(c => c.Pontos);

            if (totalJogador1 > totalJogador2)
                Console.WriteLine("\n\nParabéns Jogador 1 você é o vencedor!!");
            else if (totalJogador2 > totalJogador1)
                Console.WriteLine("\n\nParabéns Jogador 2 você é o vencedor!!");
            else
                Console.WriteLine("\n\nEmpate!");


            Console.WriteLine("\nCartas Jogador 1: " + string.Join(", ", cartasJogador1.Select(c => c.Pontos)) + $" Total: {totalJogador1}");
            Console.WriteLine("\nCartas Jogador 2: " + string.Join(", ", cartasJogador2.Select(c => c.Pontos)) + $" Total: {totalJogador2}");
            Console.ReadLine();
        }
    }
}
