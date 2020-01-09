using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
 struct Notebook
    {
        public double price;
        public string model;
        public string produktion;
        public Notebook(string model, string produktion, double price)
        {
            this.model = model;
            this.price = price;
            this.produktion = produktion;
        }
        public void ShowNotebook()
        {
            Console.WriteLine($"модель-{model}, производитель - {produktion}, стоимость - {price}$");
        }
    }
}
