using System;
using System.Collections.Generic;
using System.Text;

namespace VietFood.Models
{
    public class Item
    {
        public string ItemNumber { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool InStock { get; set; }
        public List<Variation> Variations { get; set; }
        public string Category { get; internal set; }
        public string Image { get; set; }
    }
}
