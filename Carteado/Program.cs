using System;
using System.Collections.Generic;


class Program
{

    static void Main()
    {

        /*List<int> cartas = new List<int>();

        for (int i = 1; i <=  100; i++) { 
        
            cartas.Add(i);
        
        
        }

        string numeroCartas = string.Join(",", cartas);

        Console.WriteLine($"numeroCartas  = {numeroCartas}");*/

        Random rnd = new Random();

        int sorteio1 = rnd.Next(1,101);
        int sorteio2 = 0;

        do
        {
            sorteio2 = rnd.Next(1, 101);
        } while (sorteio1 == sorteio2);

        Console.WriteLine($"Número sorteado  = {sorteio1}");
        Console.WriteLine($"Número sorteado  = {sorteio2}");

        if ( sorteio1 > sorteio2) { Console.WriteLine($" O Jogador 1 venceu o jogo!"); }else { Console.WriteLine($" O Jogador 2 venceu o jogo!"); }



        Console.ReadLine();
    }

}
