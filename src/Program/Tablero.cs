namespace Ucu.Poo.GameOfLife;

public class Tablero
{
    public bool[,] Board { get; set; } 
    public int Height { get; set; }
    public int Width { get; set; }
    
   public Tablero(bool[,] initialBoard)
    {
        this.Board = initialBoard;
        this.Width = initialBoard.GetLength(0);
        this.Height = initialBoard.GetLength(1);
    }
}