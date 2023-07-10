using System.Text;

namespace NaughtsAndCrosses;

public class GameGrid
{
    private char[] _grid = new char[9]{
        'X', ' ', ' ',
        'O', 'X', 'O',
        ' ', 'O', 'X'
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
    /// Writes each row of the game grid to the console.
    /// </summary>
    public void PrintToConsole()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine();
        stringBuilder.AppendLine($"| {_grid[0]} | {_grid[1]} | {_grid[2]} |");
        stringBuilder.AppendLine($"| {_grid[3]} | {_grid[4]} | {_grid[5]} |");
        stringBuilder.AppendLine($"| {_grid[6]} | {_grid[7]} | {_grid[8]} |");
        stringBuilder.AppendLine();

        Console.Write(stringBuilder.ToString());
    }
}