using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using VietFood.Models;

namespace VietFood.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableRangeCollection<Category> Categories { get; set; }

        public ObservableRangeCollection<Item> Items { get; set; }

        public MainPageViewModel()
        {
            // create some dummy items
            Items = new ObservableRangeCollection<Item>()
            {
                new Item()
                {
                    Name = "Pho",
                    Description = "Phở or pho is a Vietnamese soup consisting of broth, rice noodles, herbs, and meat – usually beef, sometimes chicken. Pho is a popular street food in Vietnam and served in restaurants around the",
                    InStock = true,
                    Image = "pho",
                    Price = 15.50M
                },
                new Item()
                {
                    Name = "Bun Bo Hue",
                    Description = "Bún bò Huế or bún bò is a popular Vietnamese soup containing rice vermicelli and beef. Huế is a city in central Vietnam associated with the cooking style of the former royal court.",
                    InStock = true,
                    Image = "bunbohue",
                    Price = 16.00M
                }
            };
        }

    }
}
