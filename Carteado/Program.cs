namespace Carteado
{
    using Modelos;

    class Program
    {
        static void Main(string[] args)
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
                for (int i = 1; i <= 100; i++)
                {
                    for (int j = 1; j <= 4; j++) {
                        cartas.Add(new CartaComMultiplicador(i, j));
                    }
                }
                return cartas;
            }

            //Baralho baralho = new Baralho(CriarCartas());
            Baralho baralho = new Baralho(CriarCartasComMultiplicador());

            Jogo jogo = new Jogo(baralho);
            jogo.Jogar();
        }
    }
}
