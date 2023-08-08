using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static Player;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Threading;
using System.Net.Security;

public class ProgramUI
{

    protected static int origRow;
    protected static int origCol;
    
    protected static void WriteAt(string s, int x, int y)
    {
        try
        {
            Console.SetCursorPosition(origCol + x, origRow + y);
            Console.Write(s);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
        }
    }
    public void Run()
    {
        Console.WriteLine("Loading New Persona...");
        Thread.Sleep(2000);

        Console.WriteLine(Sprites.Intro);
        Continue();
        main();
    }
    public static void main()
    {
        Console.Clear();
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;
        Player player = new Player();
        Mage mage = new Mage();
        Console.WriteLine(Sprites.map_01);
        UpdateHealth(player, mage);
        PlayerData(player, mage);
        
        Stage1(player, mage);
        
    }

    public static void Stage1(Player player, Mage mage)
    {
        //Render text
        int x = 60; // X coordinate
        int y = 5;  // Y coordinate

        // Split the string into individual lines
        string[] lines = Sprites.NPCmage.Split('\n');

        // Print each line at the specified position
        foreach (string line in lines)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(line);
            y++;
        }
        
        BattleOptions(player, mage);


    }

    private static void BattleOptions(Player player, Mage mage)
    {
        ConsoleKeyInfo cki;
        int x = 80; // X coordinate
        int y = 25;  // Y coordinate

        // Split the string into individual lines
        string[] lines = Sprites.AttackOptions.Split('\n');

        // Print each line at the specified position
        foreach (string line in lines)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(line);
            y++;
        }

        bool continueToRun = true;
        while (continueToRun)
        {
            cki = Console.ReadKey(true);
            int NumberInput = int.Parse(cki.KeyChar.ToString());

            if (NumberInput == 1)
            {
                Attack1(player, mage);
                
            }

            else if (NumberInput == 2)
            {
                Attack2(player, mage);
            }

            else if (NumberInput == 3)
            {
                Attack3(player, mage);
            }

            else if (NumberInput == 4)
            {
                Attack4(player, mage);
            }

            else continue;

            if (player.Health <= 000 || mage.Health <= 000)
            {
                continueToRun = false;
                Console.Clear();
                Console.WriteLine("THANKS FOR PLAYING!");
            }

        }
        
    }

    public static void Attack1(Player player, Mage mage)
    {
        
        WriteAt("You Used: Reality Slash", 15, 21);
        Attack attack = new Attack("Reality Slash", 20, AttackType.Slashing);
        mage.TakeDamage(attack);
        PlayerData(player, mage);
        if (mage.Health <= 0)
        {
            Console.WriteLine("You have defeated the enemy mage!");
            return;
        }
        WriteAt("Hero's Turn...  ", 15, 23);
        EnemyTurn(player, mage);
        BattleOptions(player, mage);
    }
    public static void Attack2(Player player, Mage mage)
    {
        WriteAt("You Used: Fallen Down  ", 15, 21);
        Attack attack = new Attack("Fallen Down", 25, AttackType.Bludgeoning);
        mage.TakeDamage(attack);
        PlayerData(player, mage);
        if (mage.Health <= 0)
        {
            Console.WriteLine("You have defeated the enemy mage!");
            return;
        }
        WriteAt("Hero's Turn...  ", 15, 23);
        EnemyTurn(player, mage);
        BattleOptions(player, mage);
    }
    public static void Attack3(Player player, Mage mage)
    {
        WriteAt("You Used: Grasp Heart  ", 15, 21);
        Attack attack = new Attack("Grasp Heart", 30, AttackType.Necrotic);
        mage.TakeDamage(attack);
        PlayerData(player, mage);
        if (mage.Health <= 0)
        {
            Console.WriteLine("You have defeated the enemy mage!");
            return;
        }
        WriteAt("Hero's Turn...  ", 15, 23);
        EnemyTurn(player, mage);
        BattleOptions(player, mage);
    }
    public static void Attack4(Player player, Mage mage)
    {
        WriteAt("You Used: World Break  ", 15, 21);
        Attack attack = new Attack("World Break", 1000000000, AttackType.Radiant);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;
        WriteAt("The World has been Destoryed  ", 15, 23);
        Thread.Sleep(6000);
        Exit();
    }

    public static void EnemyTurn(Player player, Mage mage)
    {
        Mage enemyMage = new Mage();
        Attack attack = mage.Attack();
        player.TakeDamage(attack);
        Thread.Sleep(7000);
        
        WriteAt(Mage.Insults(), 15, 22);
        WriteAt(Mage.AttackName(), 50, 13);

        
        PlayerData(player, mage);
    }

    static void PlayerData(Player player, Mage mage)
    {
        
        int playerHealth = player.Health;
        int mageHealth = mage.Health;

        string health1 = ($"Your Health: {playerHealth}\n");
        string health2 = ($"Hero's Health: {mageHealth}");



        // Print each line at the specified position
        WriteAt(health1, 23, 27);

        WriteAt(health2, 23, 28);
        if (player.Health <= 000 || mage.Health <= 000)
        {
            Console.Clear();
            Console.WriteLine("THANKS FOR PLAYING!");
            Exit();
        }

    }
    private static void UpdateHealth(Player player, Mage mage)
    {
        // Update health before the battle starts
        player.Health = 500;
        mage.Health = 200;
    }
    private static void Exit()
    {
        Console.Clear();
        Console.WriteLine("\n\n            Goodbye!\n\n");
        Thread.Sleep(2000);
    }

    private static void Continue()
    {
        System.Console.WriteLine("Press Enter to continue...");
        while (Console.ReadKey().Key != ConsoleKey.Enter);
    }
}