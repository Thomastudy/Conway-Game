using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class Impresor
{
    public void Print(Tablero tablero)
    {
        int width; //variabe que representa el ancho del tablero
        int height; //variabe que representa altura del tablero
        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (tablero[x, y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            NextGen.Calculo(tablero);
            Thread.Sleep(300);
        }
    }
}
