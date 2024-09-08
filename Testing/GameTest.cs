using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinesweeprGame.Model;


namespace MinesweeprGame.Testing
{
    [TestClass]
    public class GameTest
    {

        [TestMethod]
        public void Number_Of_Mines_Equals_five()
        {
            var game = new Minesweeper();
            Assert.AreEqual(5, game.mines);
        }

        [TestMethod]
        public void Correct_Solutions_Setup()
        {
            var game = new Minesweeper();
            var positions = game.GetPosition();
            var solution = game.GetSolutionMatrix();
            var positionX = positions[0];
            var positionY = positions[1];


            Assert.AreEqual(solution[positionY, positionX], 0);
        }

        [TestMethod]
        public void Test_First_Step()
        {
            var game = new Minesweeper();
            game.StartGame();
            var matrix = game.getMatrix();

            int step = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i == 0 || i == 7)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 1)
                        {
                            step = 1;
                            break;
                        }
                    }


                }
                else
                {
                    if (matrix[i, 0] == 1 || matrix[i, 7] == 1)
                    {
                        step = 1;
                        break;
                    }
                }


            }

            Assert.AreEqual(1, step);


        }
    }
}
