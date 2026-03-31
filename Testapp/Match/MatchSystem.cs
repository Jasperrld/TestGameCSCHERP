namespace Testapp.Match;
using Testapp.Characters;
public class MatchSystem
{
    private BattleSystem battleSystem = new BattleSystem();

    public void Start(Player player)
    {
        while (player.IsAlive)
        {
            Enemy enemy = GenerateEnemy();

            battleSystem.StartBattle(player, enemy);
            
            if (player.IsAlive)
            {
                Console.WriteLine("\n easy game");
                player.LevelUp();
            }
        }
    }

    private Enemy GenerateEnemy()
    {
        Random random = new Random();

        int roll = random.Next(1, 4);

        return roll switch
        {
            1 => new Enemy("Gideon", 15, 4, 1),
            2 => new Enemy("Bert", 25, 6, 2),
            3 => new Enemy("Nick", 40, 8, 4),
            4 => new Enemy("Jan", 15, 4, 1)
        };
    } 

}