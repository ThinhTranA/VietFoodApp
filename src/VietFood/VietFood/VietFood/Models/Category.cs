using System;
using System.Collections.Generic;
using System.Text;

namespace VietFood.Models
{
    public class Category
    {
        public string Name { get; set; }
        public List<Item> Items { get; set; }

    }
}
