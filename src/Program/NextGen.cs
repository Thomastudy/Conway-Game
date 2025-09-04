namespace Ucu.Poo.GameOfLife;

public class NextGen
{
    public Tablero ActualizaTablero(Tablero tablero)
    {
        int boardWidth = tablero.GetLength(0);
        int boardHeight = tablero.GetLength(1);
        Tablero cloneboard = new Tablero[boardWidth, boardHeight];
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x-1; i<=x+1;i++)
                {
                    for (int j = y-1;j<=y+1;j++)
                    {
                        if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && tablero[i,j])
                        {
                            aliveNeighbors++;
                        }
                    }
                }
                if(tablero[x,y])
                {
                    aliveNeighbors--;
                }
                if (tablero[x,y] && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    cloneboard[x,y] = false;
                }
                else if (tablero[x,y] && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard[x,y] = false;
                }
                else if (!tablero[x,y] && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard[x,y] = true;
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneboard[x,y] = tablero[x,y];
                }
            }
        }
        tablero = cloneboard;
    } 
}

   