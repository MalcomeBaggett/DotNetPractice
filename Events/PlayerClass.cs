using System;
using System.Collections.Generic;
namespace Events
{
    public class PlayerClass
    {

        private List<string> InventoryList = new List<string>();
        public string PlayerName { get; private set; }
        public int InvetoryMax { get; private set; }
        public event EventHandler<string> InventoryFull;

        public PlayerClass(string pName)
        {
            PlayerName = pName;
            InvetoryMax = 2;
        }
        public void AddInvetory(string itemName)
        {
            if (InventoryList.Count < this.InvetoryMax)
            {
                InventoryList.Add(itemName);
                InventoryFull?.Invoke(this, $"{itemName} was discarded");
            }
        }

    }
}