using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmBurgerApp.Models;

namespace MvvmBurgerApp.Models
{
    public class Burger
    {
        public string Title { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }
        public Additionally Salat { get; set; }
        public Additionally Tomat { get; set; }
        public Additionally Cucumber { get; set; }
        public Additionally Onion { get; set; }

    }
}
