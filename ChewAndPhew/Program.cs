using ChewAndPhew.Lib;
using System;

namespace ChewAndPhew
{
    class Program
    {
        static void Main(string[] args)
        {
            BubblegumDispenserFactory factory = new BubblegumDispenserFactory();
            BubblegumDispenser dispenser = factory.ProduceBubblegumDispenser();
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
}
