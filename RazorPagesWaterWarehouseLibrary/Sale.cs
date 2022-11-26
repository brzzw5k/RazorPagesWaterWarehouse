using System;
using System.Collections.Generic;

namespace RazorPagesWaterWarehouseLibrary
{
    public class Sale: ITransaction
    {
        public int Id { get; set; }
        public Dictionary<Water, int> Waters { get; set; }
        public Person Person { get; set; }
        public DateTime Date { get; set; }
    }
}