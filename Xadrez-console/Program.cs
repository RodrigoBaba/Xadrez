using System;
using Xadrez_console.tabuleiro;
using Xadrez_console.xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
        }
    }
}
