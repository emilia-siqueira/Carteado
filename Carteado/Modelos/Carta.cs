using Interfaces;

namespace Modelos;


public class Carta : IPontuacao
{
    private int Valor;

    public Carta(int valor)
    {
        Valor = valor;
    }

    public Carta(string valorComoTexto)
    {
        Valor = int.Parse(valorComoTexto);
    }

    public virtual int Pontos { get { return Valor; } }



}

public class CartaComMultiplicador : Carta
{
    public int Multiplicador { get; private set; }

    public CartaComMultiplicador(int valor, int multiplicador) : base(valor)
    {
        Multiplicador = multiplicador;
    }

    public override int Pontos { get { return base.Pontos * Multiplicador; } }
}
