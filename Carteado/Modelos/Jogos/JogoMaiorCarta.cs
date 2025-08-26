using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteado.Modelos.Jogos
{
    class JogoMaiorCarta<T> : JogoBase<T> where T : IPontuacao
    {
        public JogoMaiorCarta(IBaralho<T> baralho, IJogador<T> jogador1, IJogador<T> jogador2)
            : base(baralho, jogador1, jogador2) { }

        public override void Jogar()
        {
            Console.Clear();
            Console.WriteLine("============================ Maior Carta ===========================");
            Console.WriteLine("== Cada jogador recebe uma carta. Quem tiver o maior valor vence. ==");
            Console.WriteLine("====================================================================");

            Baralho.Embaralhar();
            Jogador1.PegarNovoItem(Baralho.Entregar());
            Jogador2.PegarNovoItem(Baralho.Entregar());

            if (Jogador1.Pontos > Jogador2.Pontos)
                Console.WriteLine("\n\nParabéns Jogador 1 você é o vencedor!!");
            else if (Jogador2.Pontos > Jogador1.Pontos)
                Console.WriteLine("\n\nParabéns Jogador 2 você é o vencedor!!");
            else
                Console.WriteLine("\n\nEmpate!");

            Console.WriteLine($"\n\nCarta Jogador1: {Jogador1.Pontos} \nCarta Jogador2: {Jogador2.Pontos}");
            Console.ReadLine();
        }
    }
}
