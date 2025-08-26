using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Carteado.Modelos.Jogos
{

    abstract class JogoBase<T> where T : IPontuacao
    {
        protected IBaralho<T> Baralho;
        protected IJogador<T> Jogador1;
        protected IJogador<T> Jogador2;

        protected JogoBase(IBaralho<T> baralho, IJogador<T> jogador1, IJogador<T> jogador2)
        {
            Baralho = baralho;
            Jogador1 = jogador1;
            Jogador2 = jogador2;
        }

        public abstract void Jogar();
    }


}
