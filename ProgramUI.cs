using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static Player;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Threading;

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
        PlayerData(player, mage);
        
        Stage1();
        
    }

    public static void Stage1()
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
        
        BattleOptions();


    }

    private static void BattleOptions()
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
                Attack1();
                
            }

            else if (NumberInput == 2)
            {
                Attack2();
            }

            else if (NumberInput == 3)
            {
                Attack3();
            }

            else if (NumberInput == 4)
            {
                Attack4();
            }

            else continue;                       
            
        }
    }

    public static void Attack1()
    {
        WriteAt("You Used: Reality Slash", 15, 21);
        Attack attack = new Attack("Reality Slash", 20, AttackType.Slashing);
        //Mage.TakeDamage(attack);
        WriteAt("Hero's Turn...  ", 15, 23);
        EnemyTurn();
        BattleOptions();
    }
    public static void Attack2()
    {
        WriteAt("You Used: Fallen Down  ", 15, 21);
        Attack attack = new Attack("Fallen Down", 20, AttackType.Bludgeoning);
        
        WriteAt("Hero's Turn...  ", 15, 23);
        EnemyTurn();
        BattleOptions();
    }
    public static void Attack3()
    {
        WriteAt("You Used: Grasp Heart  ", 15, 21);
        Attack attack = new Attack("Grasp Heart", 20, AttackType.Necrotic);
        WriteAt("Hero's Turn...  ", 15, 23);
        EnemyTurn();
        BattleOptions();
    }
    public static void Attack4()
    {
        WriteAt("You Used: World Break  ", 15, 21);
        Attack attack = new Attack("World Break", 1000000000, AttackType.Radiant);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;
        WriteAt("The World has been Destoryed  ", 15, 23);
        Thread.Sleep(6000);
        Exit();
    }

    public static void EnemyTurn()
    {
        Thread.Sleep(7000);
        
        WriteAt(Mage.Insults(), 15, 22);
        WriteAt(Mage.AttackName(), 50, 13); 
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