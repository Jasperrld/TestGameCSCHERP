namespace Testapp.Characters;

public class Enemy : Character
{
    public Enemy(string name, int hp, int str, int def)
    {
        Name = name;
        MaxHealth = hp;
        CurrentHealth = hp;
        Strength = str;
        Defense = def;
    }
}