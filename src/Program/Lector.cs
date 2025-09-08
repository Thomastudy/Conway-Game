using System.IO;
namespace Ucu.Poo.GameOfLife;

public class Lector
{
    public Tablero Leer(string url)
    {
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');

        int filas = contentLines.Length;
        int columnas = contentLines[0].Length;

        Tablero board = new Tablero(filas, columnas);

        for (int y = 0; y < filas; y++)
        {
            for (int x = 0; x < columnas; x++)
            {               
                if (contentLines[y][x] == '1')
                {
                    board.Celdas[y, x] = true;
                }
            }
        }

        return board;
    }
}
