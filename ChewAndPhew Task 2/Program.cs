using ChewAndPhew.Lib;
using System;

class Program
{
    static void Main(string[] args)
    {
        BubblegumDispenser dispenser = BubblegumDispenser.Instance;
        dispenser.BubblegumDispensetion += OnBubblegumDispensetion;

        for (int i = 0; i < 60; i++)
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