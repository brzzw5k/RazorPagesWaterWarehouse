using System.Collections.Generic;
using System.Linq;

namespace RazorPagesWaterWarehouseLibrary
{
    public class Water
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WaterType Type { get; set; }
        public Company Producer { get; set; }
        public float Ph { get; set; }
        public IEnumerable<Ion> Ions { get; set; }
        public MineralizationType Mineralization
        {
            get
            {
                return Ions.Sum(x => x.Concentration) switch
                {
                    var x when x <= 0.05 => MineralizationType.VeryLow,
                    var x when x <= 0.5 => MineralizationType.Low,
                    var x when x <= 1.5 => MineralizationType.Medium,
                    _ => MineralizationType.High
                };
            }
        }
        public Packaging Packaging { get; set; }
        
        // TODO: Add image

    }
}