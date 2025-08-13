namespace Modelos;

class Jogo
{
    private Baralho Baralho { get; set; }
    private Jogador Jogador1 { get; set; }
    private Jogador Jogador2 { get; set; }

    public Jogo()
    {
        Baralho = new Baralho();
        Jogador1 = new Jogador();
        Jogador2 = new Jogador();
    }

    public Jogo(Baralho baralho)
    {
        Baralho = baralho;
        Jogador1 = new Jogador();
        Jogador2 = new Jogador();
    }

    public Jogo(Baralho baralho, Jogador jogador1, Jogador jogador2)
    {
        Baralho = baralho;
        Jogador1 = jogador1;
        Jogador2 = jogador2;
    }

    public void Jogar()
    {
        Baralho.Embaralhar();
        Jogador1.Carta = Baralho.DarCarta();
        Jogador2.Carta = Baralho.DarCarta();

        VerificarGanhador();
    }

    private void VerificarGanhador()
    {

        if (Jogador1.Carta.Pontuacao() > Jogador2.Carta.Pontuacao())
        {
            Console.WriteLine($"Jogador 1 ganhou! Carta: {Jogador1.Carta.Pontuacao()} vs Carta: {Jogador2.Carta.Pontuacao()}");
        }
        else if (Jogador2.Carta.Pontuacao() > Jogador1.Carta.Pontuacao())
        {
            Console.WriteLine($"Jogador 2 ganhou! Carta: {Jogador1.Carta.Pontuacao()} vs Carta: {Jogador2.Carta.Pontuacao()}");
        }
        else
        {
            Console.WriteLine($"Empate! Carta: {Jogador1.Carta.Pontuacao()} vs Carta: {Jogador2.Carta.Pontuacao()}");
        }
    }
}