using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmBurgerApp.Models
{
    public class Additionally
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public Additionally(string title, int price, int count)
        {
            Title = title;
            Price = price;
            Count = count;
        }
    }
}
