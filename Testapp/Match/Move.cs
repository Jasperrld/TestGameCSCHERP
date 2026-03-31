using Testapp.Characters;

namespace Testapp.Match;

public abstract class Move
{
    public string Name { get; set; }
    public int Uses { get; set; }

    public abstract int Execute(Character player, Character target);

}