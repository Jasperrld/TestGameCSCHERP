using Testapp.Characters;
using Testapp.Match;

namespace Testapp.Characters.Classes;

public class Katarina : Player
{
    public Katarina(string name) : base(name, 1)
    {
        MaxHealth = 25;
        CurrentHealth = 25;
        Strength = 10;
        Defense = 2;

        Moves.Add(new AttackMove());
        Moves.Add(new DaggerMove());
    }
}