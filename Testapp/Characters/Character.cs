namespace Testapp.Characters;
public abstract class Character
{
    public string Name { get; set; }
    public int MaxHealth  { get; set; }
    public int CurrentHealth  { get; set; }
    public int Strength  { get; set; }
    public int Defense   { get; set; }
    
    public bool IsAlive => CurrentHealth > 0;
        
    public bool IsDead => CurrentHealth <= 0;

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth <= 0)
        {
            CurrentHealth = 0;
        }
    }
}