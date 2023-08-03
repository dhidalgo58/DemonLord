using System.Security.Cryptography.X509Certificates;

public class ProgramUI
{
    private Mage mageclass;
    protected static int origRow;
    protected static int origCol;

    public ProgramUI(Mage mageclass)
    {
        this.mageclass = mageclass;
    }
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
        Console.WriteLine(Sprites.map_01);
        Stage1();
        
    }

    public static void Stage1()
    {
        //Render Enemy
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
        
        
    }

    public static void Stage2()
    {
        int x = 60; // X coordinate
        int y = 5;  // Y coordinate

        // Split the string into individual lines
        string[] lines = Sprites.NPCwarrior.Split('\n');

        // Print each line at the specified position
        foreach (string line in lines)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(line);
            y++;
        }
    }

    public static void Stage3()
    {
        int x = 60; // X coordinate
        int y = 5;  // Y coordinate

        // Split the string into individual lines
        string[] lines = Sprites.NPCpriest.Split('\n');

        // Print each line at the specified position
        foreach (string line in lines)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(line);
            y++;
        }
    }

    private void Rounds()
    {

    }
    private void Continue()
    {
        System.Console.WriteLine("Press Enter to continue...");
        while (Console.ReadKey().Key != ConsoleKey.Enter);
    }
}