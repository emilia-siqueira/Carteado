namespace Modelos;

using Interfaces;

class Jogo<T>
{
    private IBaralho<T> Baralho { get; set; }
    private IJogador<T> Jogador1 { get; set; }
    private IJogador<T> Jogador2 { get; set; }

    private string TipoJogo { get; set; }


    public Jogo(IBaralho<T> baralho, IJogador<T> jogador1, IJogador<T> jogador2, string tipoJogo)
    {
        Baralho = baralho;
        Jogador1 = jogador1;
        Jogador2 = jogador2;
        TipoJogo = tipoJogo;
    }


    public void Jogar()
    {
        Baralho.Embaralhar();
        Jogador1.PegarNovoItem(Baralho.Entregar());
        Jogador2.PegarNovoItem(Baralho.Entregar());

        if (TipoJogo != null)
        {
            switch (TipoJogo)
            {
                case "1":
                    VerificarGanhadorMaiorCarta();
                    break;
                case "2":
                    VerificarGanhadorParImpar();
                    break;
                case "3":
                    VerificarGanhadorBatalha();
                    break;
                default:
                    Console.WriteLine("Tipo de Jogo Inválido.");
                    Console.ReadLine();
                    break;
            }
        }         
    }



    private void VerificarGanhadorMaiorCarta()
    {
        Console.Clear();
        Console.WriteLine("============================ Maior Carta ===========================");
        Console.WriteLine("== Cada jogador recebe uma carta. Quem tiver o maior valor vence. ==");
        Console.WriteLine("====================================================================");

        if (Jogador1.Pontos > Jogador2.Pontos)
        {
            Console.WriteLine($"\n\nParabéns Jogador 1 você é o vencedor!!");
        }
        else if (Jogador2.Pontos > Jogador1.Pontos)
        {
            Console.WriteLine($"\n\nParabéns Jogador 2 você é o vencedor!!");
        }
        else
        {
            Console.WriteLine($"\n\nEmpate!");
        }

        Console.WriteLine($"\n\nCarta Jogador1:   {Jogador1.Pontos} vs Carta Jogador2:   {Jogador2.Pontos}");
        Console.ReadLine() ;
    }

    private void VerificarGanhadorParImpar()
    {

        Console.Clear();
        Console.WriteLine("=========================== Par ou Ímpar ===========================");
        Console.WriteLine("== Cada jogador recebe uma carta. Soma-se os valores das cartas.  ==");
        Console.WriteLine("== Se a soma for par, o jogador 1 ganha.                          ==");
        Console.WriteLine("== Se a soma for ímpar, vence o jogador 2                         ==");
        Console.WriteLine("====================================================================");

        int soma = Jogador1.Pontos + Jogador2.Pontos;

        Console.WriteLine($"\nSoma dos valores:{soma}");

        if (soma%2 == 0)  Console.WriteLine($"\n\nParabéns Jogador 1 você é o vencedor!!");  else Console.WriteLine($"\n\nParabéns Jogador 2 você é o vencedor!!");

        Console.WriteLine($"\n\nCarta Jogador1:   {Jogador1.Pontos} vs Carta Jogador2:   {Jogador2.Pontos}");
        Console.ReadLine();
    }

    private void VerificarGanhadorBatalha()
    {
        Console.Clear();
        Console.WriteLine("============================== Batalha ==============================");
        Console.WriteLine("== Cada jogador recebe três cartas. Soma-se os valores das cartas. ==");
        Console.WriteLine("== Vence o jogador que tiver a maior soma.                          ==");
        Console.WriteLine("=====================================================================");

        var Carta1Jogador1 = Jogador1.Pontos;
        Jogador1.PegarNovoItem(Baralho.Entregar());
        var Carta2Jogador1 = Jogador1.Pontos;
        Jogador1.PegarNovoItem(Baralho.Entregar());
        var Carta3Jogador1 = Jogador1.Pontos;

        var Carta1Jogador2 = Jogador2.Pontos;
        Jogador2.PegarNovoItem(Baralho.Entregar());
        var Carta2Jogador2 = Jogador2.Pontos;
        Jogador2.PegarNovoItem(Baralho.Entregar());
        var Carta3Jogador2 = Jogador2.Pontos;

        var totalJogador1 = Carta1Jogador1 + Carta2Jogador1 + Carta3Jogador1;
        var totalJogador2 = Carta1Jogador2 + Carta2Jogador2 + Carta3Jogador2;


        if ((totalJogador1) > (totalJogador2))
        {
            Console.WriteLine($"\n\nParabéns Jogador 1 você é o vencedor!!");
        }
        else if (totalJogador2 > totalJogador1)
        {
            Console.WriteLine($"\n\nParabéns Jogador 2 você é o vencedor!!");
        }
        else
        {
            Console.WriteLine($"\n\nEmpate!");
        }

        Console.WriteLine($"\n\nTotal Cartas Jogador1:   {totalJogador1} vs Total Cartas Jogador2:   {totalJogador2}");
        Console.ReadLine();
    }
}