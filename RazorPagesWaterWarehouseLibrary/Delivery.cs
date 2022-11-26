using System;
using System.Collections;
using System.Collections.Generic;

namespace RazorPagesWaterWarehouseLibrary
{
    public class Delivery: ITransaction
    {
        public int Id { get; set; }
        public Dictionary<Water, int> Waters { get; set; }
        public int PaletteCapacity { get; set; }
        public Person Person { get; set; }
        public Company Company { get; set; }
        public DateTime Date { get; set; }

    }
}