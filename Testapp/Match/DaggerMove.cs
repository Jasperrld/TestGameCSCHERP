using Testapp.Characters;

namespace Testapp.Match;

public class DaggerMove : Move
{
    public DaggerMove()
    {
        Name = "Dagger";
        Uses = int.MaxValue;
    }

    public override int Execute(Character player, Character target)
    {
        int damage = player.Strength - target.Defense;
        if (damage < 1) damage = 1;
        
        target.TakeDamage(damage);
        
        return damage;
    }
}