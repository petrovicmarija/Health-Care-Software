

using IS_Bolnica.Model;
using System;

namespace Model
{
    public class Inventory
    {
        public String Name { get; set; }
        public int CurrentAmount { get; set; }
        public int Minimum { get; set; }
        public int Id { get; set; }
        public InventoryType InventoryType { get; set; }

    }
}