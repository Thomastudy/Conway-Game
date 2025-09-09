namespace Ucu.Poo.GameOfLife;

public class Tablero
{
    private bool[,] board; 
    public int Height { get; private set; }
    public int Width { get; private set; }
    
    public Tablero (int height, int width)
    {
        this.board = new bool [width, height];
        this.Width = width;
        this.Height = height;
    }

    public void IsAlive(int x, int y, bool live)
    {
        this.board[x, y] = live;
    }

    public bool State(int  x, int y)
    {
        return this.board[x, y];
    }
}