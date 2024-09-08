using MinesweeprGame.Model;

namespace MinesweeprGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Minesweeper minesweeper = new Minesweeper();
           minesweeper.StartGame();
           minesweeper.PlayGame();

        }
    }
}
