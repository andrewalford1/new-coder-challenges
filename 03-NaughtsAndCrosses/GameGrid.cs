using System.Text;

namespace NaughtsAndCrosses;

public class GameGrid
{
    private char[] _grid = new char[9]{
        'X', ' ', ' ',
        'O', 'X', 'O',
        ' ', 'O', 'X'
    };

    private readonly string[] _winStates = new string[]
    {
        "012",
        "345",
        "678",

        "036",
        "147",
        "258",

        "048",
        "247"
    };

    /// <summary>
    /// Updates a location on the game grid.
    /// </summary>
    public void UpdateLocation(int position, char player)
    {
        _grid[position] = player;
    }

    /// <returns>
    ///  Returns true if the game is over.
    ///  Additionally, 'winner' will contain 
    ///  the name of the winning player (X/O) 
    ///  or "TIE" if there are no more moves available.
    /// </returns>
    public bool IsGameOver(out string winner)
    {
        var values = _grid.Select(x => {
            if (x == 'X') return 1;
            
            if (x == 'O') return 2;

            return 0;
        }).ToList();

        if (!values.Any(x => x == 0))
        {
            winner = "TIE";
            return false;
        }

        foreach (string combo in _winStates)
        {
            var positionOne = int.Parse(combo[0].ToString());
            var positionTwo = int.Parse(combo[1].ToString());
            var positionThree = int.Parse(combo[2].ToString());

            if (values[positionOne] == values[positionTwo] && values[positionOne] == values[positionThree])
            {
                winner = _grid[positionOne].ToString();
                return true;
            }
        }

        winner = "TIE";
        return true;
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