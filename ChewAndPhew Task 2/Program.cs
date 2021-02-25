using ChewAndPhew.Lib;
using System;

class Program
{
    static void Main(string[] args)
    {
        BubblegumDispenserFactory factory = new BubblegumDispenserFactory();
        BubblegumDispenser dispenser = BubblegumDispenser.Instance;
        dispenser.BubblegumDispensetion += OnBubblegumDispensetion;

        for (int i = 0; i < 60; i++)
        {
            Console.WriteLine(dispenser.ToString());
            dispenser.Dispense();
            Console.WriteLine(dispenser.ToString());
        }
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Some kids buys new bubblegums from factory");

        Console.ReadKey();
        Console.Clear();

        dispenser.AddBubblegums(factory.ProduceAllBubblegumVariants(20));

        for (int i = 0; i < 30; i++)
        {
            Console.WriteLine(dispenser.ToString());
            dispenser.Dispense();
            Console.WriteLine(dispenser.ToString());
        }
    }

    private static void OnBubblegumDispensetion(Bubblegum bubblegum)
    {
        Console.WriteLine("A bubble gum was dispensed!");
        Console.WriteLine(bubblegum.ToString());
    }
}