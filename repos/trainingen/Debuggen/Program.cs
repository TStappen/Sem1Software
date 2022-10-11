using System;

class Program
{

    // Main Method
    static public void Main()
    {
        // Fit to seperate version for git
        /*string[] namen = { "naam1", "naam2", "naam3", "naam4", "naam5", "naam6" };

        foreach (string naam in namen)
            Console.WriteLine(naam);

        int temp = 4;
        for (int i = 0; i < 10; i++)
        {
            if (i > 5)
                temp = 5;
            Console.WriteLine(temp);
        }

        Console.ReadLine();*/
        Methode1();
    }
    public static void Methode1()
    {
        Console.WriteLine("Dit is methode1");
        Methode2();
    }

    public static void Methode2()
    {
        Console.WriteLine("Dit is methode2");
        Methode3();
    }

    public static void Methode3()
    {
        Console.WriteLine("En dit is methode3");
        Console.ReadLine();
    }

}