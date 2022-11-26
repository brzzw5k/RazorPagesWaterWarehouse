using System;
using System.Collections.Generic;

namespace RazorPagesWaterWarehouseLibrary
{
    public interface ITransaction
    {
        int Id { get; set; }
        Dictionary<Water, int> Waters { get; set; }
        public Person Person { get; set; }
        public DateTime Date { get; set; }
    }
}