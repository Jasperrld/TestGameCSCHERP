using Testapp.Match;

namespace Testapp.Characters;

public abstract class Player : Character
{
    public int Level { get; set; }
    
    public Player(string name,  int level)
    {
        Name = name;
        Level = level;
    }
    
    public List<Move> Moves { get; set; } = new();
    
    public void LevelUp()   
    {
        Level++;

        MaxHealth += 2;
        Strength += 2;
        Defense += 1;
        
        CurrentHealth = MaxHealth;
        
        Console.WriteLine($"{Name} has Leveled up to {Level}");
    }
}