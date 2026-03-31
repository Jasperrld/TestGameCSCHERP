using Testapp.Characters;

namespace Testapp.Match;

public class BattleSystem
{
    public void StartBattle(Player player, Enemy enemy)
    {
        Console.WriteLine("Battle begonnen");

        while (player.IsAlive && enemy.IsAlive)
        {
            ShowStatus(player, enemy);
            PlayerTurn(player, enemy);
            
            if (!enemy.IsAlive)  break;
            
            EnemyTurn(player ,enemy);
        }

        if (!player.IsAlive)
        {
            Console.WriteLine($"{player.Name} is dood");
        }
        else
        {
            Console.WriteLine("je hebt gewonnen");
        }
    }

    private void ShowStatus(Player player, Enemy enemy)
    {
        Console.WriteLine($"{player.Name} heeft {player.CurrentHealth} hp");
        Console.WriteLine($"{enemy.Name} heeft {enemy.CurrentHealth} hp");
    }

    private void PlayerTurn(Player player, Enemy enemy)
    {
        Console.WriteLine("jouw keuze");

        for (int i = 0; i < player.Moves.Count; i++)
        {
            var moves = player.Moves[i];
            
            Console.WriteLine($"{i + 1}: {moves.Name} heeft {moves.Uses} uses");
        }

        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Invalid choice");
            return;
        }

        choice--;

        if (choice < 0 || choice >= player.Moves.Count)
        {
            Console.WriteLine("Invalid choice");
            return;
        }
        
        var move = player.Moves[choice];

        if (move.Uses <= 0)
        {
            Console.WriteLine("Invalid move");
            return;
        }

        move.Uses--;
        
        int damage = move.Execute(player, enemy);

        Console.WriteLine($"{player.Name} doet {damage} damage aan {enemy.Name}");
    }

    private void EnemyTurn(Player player, Enemy enemy)
    {
        int damage = enemy.Strength - player.Defense;
        if (damage < 1) damage = 1;
        
        player.TakeDamage(damage);
        
        Console.WriteLine($"{player.Name} heeft {damage} damage gepakt");
    }
}