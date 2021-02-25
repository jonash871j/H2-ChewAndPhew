using System;
using System.Collections.Generic;
using System.Text;

namespace ChewAndPhew.Lib
{
    public class BubblegumDispenserFactory
    {
        public BubblegumDispenser CreateBubblegumDispenser()
        {
            BubblegumDispenser dispenser = new BubblegumDispenser(55);
            AddBubblegumsToDispenser(ref dispenser, new Bubblegum("Blueberry", "Indigo"), 25.0);
            AddBubblegumsToDispenser(ref dispenser, new Bubblegum("Blackberry", "Purple"), 12.0);
            AddBubblegumsToDispenser(ref dispenser, new Bubblegum("Truttifrutti", "Yellow"), 20.0);
            AddBubblegumsToDispenser(ref dispenser, new Bubblegum("Orange", "Orange"), 19.0);
            AddBubblegumsToDispenser(ref dispenser, new Bubblegum("Strawberry", "Red"), 14.0);
            AddBubblegumsToDispenser(ref dispenser, new Bubblegum("Apple", "Green"), 10.0);
            dispenser.ShakeMachine();

            return dispenser;
        }

        private void AddBubblegumsToDispenser(ref BubblegumDispenser dispenser, Bubblegum bubblegum, double procent)
        {
            int amount = (int)(Math.Round(dispenser.MaxAmount / 100.0) * procent);

            for (int i = 0; i < amount; i++)
            {
                dispenser.AddBubbleGum(new Bubblegum(bubblegum));
            }
        }
    }
}
