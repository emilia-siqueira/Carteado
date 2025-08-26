using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteado.Modelos.Jogos
{

    class JogoParOuImpar<T> : JogoBase<T> where T : IPontuacao
    {
        public JogoParOuImpar(IBaralho<T> baralho, IJogador<T> jogador1, IJogador<T> jogador2)
            : base(baralho, jogador1, jogador2) { }

        public override void Jogar()
        {

            Console.Clear();
            Console.WriteLine("=========================== Par ou Ímpar ===========================");
            Console.WriteLine("== Cada jogador recebe uma carta. Soma-se os valores das cartas.  ==");
            Console.WriteLine("== Se a soma for par, o jogador 1 ganha.                          ==");
            Console.WriteLine("== Se a soma for ímpar, vence o jogador 2                         ==");
            Console.WriteLine("====================================================================");

            Baralho.Embaralhar();
            Jogador1.PegarNovoItem(Baralho.Entregar());
            Jogador2.PegarNovoItem(Baralho.Entregar());

            int soma = Jogador1.Pontos + Jogador2.Pontos;



            if (soma % 2 == 0)
            {
                Console.WriteLine($"\n\nO valor da soma é par: {soma}");
                Console.WriteLine("\nParabéns Jogador 1 você é o vencedor!!");
            }
            else
            {
                Console.WriteLine($"\n\nO valor da soma é impar: {soma}");
                Console.WriteLine("\nParabéns Jogador 2 você é o vencedor!!");
            }

            Console.WriteLine($"\n\nCarta Jogador1: {Jogador1.Pontos} \nCarta Jogador2: {Jogador2.Pontos}");
            Console.ReadLine();
        }
    }




}
