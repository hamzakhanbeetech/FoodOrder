using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoePizza.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string PizzaType { get; set; }
        public int price { get; set; }
        public bool Toppings { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public override bool Equals(object obj)
        {
            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Pizza))
            {
                return false;
            }
            return (this.Id == ((Pizza)obj).Id)
                && (this.PizzaType == ((Pizza)obj).PizzaType) && (this.Quantity == ((Pizza)obj).Quantity) && (this.Toppings == ((Pizza)obj).Toppings)
                && (this.price == ((Pizza)obj).price);
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ PizzaType.GetHashCode() ^ Quantity.GetHashCode() ^ Toppings.GetHashCode() ^ price.GetHashCode();
        }
    }
}
