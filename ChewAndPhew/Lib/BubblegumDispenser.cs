using System;
using System.Collections.Generic;
using System.Linq;

namespace ChewAndPhew.Lib
{
    public delegate void BubblegumDispensetion(Bubblegum bubblegum);

    public class BubblegumDispenser
    {
        internal BubblegumDispenser(int maxAmount)
        {
            MaxAmount = maxAmount;
            Bubblegums = new List<Bubblegum>();
        }

        private static BubblegumDispenser instance = null;

        /// <summary>
        /// Singleton instance
        /// </summary>
        public static BubblegumDispenser Instance
        {
            get
            {
                if (instance == null)
                {
                    BubblegumDispenserFactory factory = new BubblegumDispenserFactory();
                    instance = factory.ProduceBubblegumDispenser();
                }
                return instance;
            }
        }
        public List<Bubblegum> Bubblegums { get; private set; }
        public int MaxAmount { get; private set; }
        public BubblegumDispensetion BubblegumDispensetion { get; set; }


        /// <summary>
        /// Used to add a bubble gum to dispenser
        /// </summary>
        /// <returns>True if bubblegum was added</returns>
        public bool AddBubblegum(Bubblegum bubblegum)
        {
            if (Bubblegums.Count < MaxAmount)
            {
                Bubblegums.Add(bubblegum);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Used to add a bubbles gum to dispenser
        /// </summary>
        public void AddBubblegums(List<Bubblegum> bubblegums)
        {
            Bubblegum bubblegum = bubblegums.LastOrDefault();
            while (bubblegum != null)
            {
                if (AddBubblegum(bubblegum))
                {
                    bubblegums.Remove(bubblegum);
                }
                else
                {
                    return;
                }
                bubblegum = bubblegums.LastOrDefault();
            }
        }

        /// <summary>
        /// Used to randomize bubblegums in dispenser
        /// </summary>
        public void ShakeMachine()
        {
            Bubblegums = Bubblegums.OrderBy(a => Guid.NewGuid()).ToList();
        }

        /// <summary>
        /// Used to dispense bubblegum
        /// </summary>
        public void Dispense()
        {
            Bubblegum bubblegum = Bubblegums.LastOrDefault();
            if (Bubblegums.Count > 0)
            {
                Bubblegums.Remove(bubblegum);
                BubblegumDispensetion.Invoke(bubblegum);
            }
        }

        public override string ToString()
        {
            return $"Amount of bubblegums in dispenser is {Bubblegums.Count}/{MaxAmount}";
        }
    }
}
