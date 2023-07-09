using System.Text;

namespace NaughtsAndCrosses;

public class GameGrid
{
    private const int ROWS = 3;
    private const int COLUMNS = 3;

    private char[][] _grid = new char[ROWS][]
    {
        new char[COLUMNS] { ' ',' ',' '},
        new char[COLUMNS] { ' ',' ',' '},
        new char[COLUMNS] { ' ',' ',' '}
    };

    /// <summary>
    /// Updates a location on the game grid.
    /// </summary>
    public void UpdateLocation(int column, int row, char player)
    {
        throw new NotImplementedException();
    }

    /// <returns>
    ///  Returns true if the game is over.
    ///  Additionally, 'winner' will contain 
    ///  the name of the winning player (X/O) 
    ///  or "TIE" if there are no more moves available.
    /// </returns>
    public bool IsGameOver(out string winner)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Loops through the game grid and writes each row to the console.
    /// </summary>
    public void PrintToConsole()
    {
        var stringBuilder = new StringBuilder("| ");
        for (int row = 0; row < ROWS; row++)
        {

            for (int column = 0; column < COLUMNS; column++)
            {
                stringBuilder.Append($"{_grid[row][column]} |");
            }

            stringBuilder.Append('\n');
        }

        Console.WriteLine(stringBuilder.ToString());
    }
}