using System;
using System.Collections.Generic;

namespace ChewAndPhew.Lib
{
    public class BubblegumDispenserFactory
    {
        public BubblegumDispenser ProduceBubblegumDispenser()
        {
            BubblegumDispenser dispenser = new BubblegumDispenser(55);
            dispenser.AddBubblegums(ProduceAllBubblegumVariants(dispenser.MaxAmount));
            dispenser.ShakeMachine();

            return dispenser;
        }
        public List<Bubblegum> ProduceAllBubblegumVariants(int amount)
        {
            List<Bubblegum> bubblegums = new List<Bubblegum>(amount);
            bubblegums.AddRange(ProduceBubblegums(new Bubblegum("Blueberry", "Indigo"), amount, 25.0));
            bubblegums.AddRange(ProduceBubblegums(new Bubblegum("Blackberry", "Purple"), amount, 12.0));
            bubblegums.AddRange(ProduceBubblegums(new Bubblegum("Truttifrutti", "Yellow"), amount, 20.0));
            bubblegums.AddRange(ProduceBubblegums(new Bubblegum("Orange", "Orange"), amount, 19.0));
            bubblegums.AddRange(ProduceBubblegums(new Bubblegum("Strawberry", "Red"), amount, 14.0));
            bubblegums.AddRange(ProduceBubblegums(new Bubblegum("Apple", "Green"), amount, 10.0));
            return bubblegums;
        }

        private List<Bubblegum> ProduceBubblegums(Bubblegum bubblegumTemplate, int maxAmount, double procent)
        {
            int amount = (int)(Math.Round((maxAmount / 100.0) * procent));
            List<Bubblegum> bubblegums = new List<Bubblegum>(amount);

            for (int i = 0; i < amount; i++)
            {
                bubblegums.Add(new Bubblegum(bubblegumTemplate));
            }

            return bubblegums;
        }
    }
}
