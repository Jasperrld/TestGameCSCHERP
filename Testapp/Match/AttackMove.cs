using Testapp.Characters;

namespace Testapp.Match;

public class AttackMove : Move
{
    public AttackMove()
    {
        Name = "Attack";
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