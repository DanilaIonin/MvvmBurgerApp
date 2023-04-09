using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmBurgerApp.Models
{
    public class TypeOfMeet
    {
        public string Title { get; set; }
        public int Price { get; set; }

        public TypeOfMeet(string title, int price)
        {
            Title = title;
            Price = price;
        }
    }
}
