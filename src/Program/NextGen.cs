namespace Ucu.Poo.GameOfLife;

public class NextGen
{
    public static Tablero ActualizaTablero(Tablero tablero)
    {
        int boardWidth = tablero.Width;
        int boardHeight = tablero.Height;
        Tablero cloneboard = new Tablero(boardWidth, boardHeight);
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x-1; i<=x+1;i++)
                {
                    for (int j = y-1;j<=y+1;j++)
                    {
                        if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && tablero.State(i,j))
                        {
                            aliveNeighbors++;
                        }
                    }
                }
                if(tablero.State(x,y))
                {
                    aliveNeighbors--;
                }
                if (tablero.State(x,y) && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    
                    cloneboard.IsAlive(x, y, false);
                }
                else if (tablero.State(x,y) && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard.IsAlive(x,y,false); 
                }
                else if (!tablero.State(x,y) && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard.IsAlive(x,y,true);
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneboard.IsAlive(x,y,tablero.State(x,y)); 
                }
            }
        }
        tablero = cloneboard;
        return tablero;
    } 
}

   