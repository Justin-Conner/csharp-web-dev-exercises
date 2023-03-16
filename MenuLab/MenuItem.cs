using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLab
{
 
        public class MenuItem
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }
            public bool IsNew { get; set; }
            public  DateTime PremierDate { get; set; }=  DateTime.Now;
            public MenuItem(string name, string description, double price, bool isNew)
            {
                Name = name;
                Description = description;
                Price = price;
                IsNew = isNew;
            }
        public override string ToString()
        {
            string NewItem = "New Item!";
            string printing = $"{Name}{Environment.NewLine}{Description}{Environment.NewLine}{Price}";
            if (IsNew) {
                Console.WriteLine(printing + NewItem);

            }
        }
        }
    
}
