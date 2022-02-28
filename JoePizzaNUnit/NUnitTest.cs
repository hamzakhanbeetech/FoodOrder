using NUnit.Framework;
using System.Collections.Generic;
using JoePizza;
using JoePizza.Models;

namespace JoePizzaNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        PizzaModel _context = new PizzaModel();
        [Test]
        public void GetAllPizzas()
        {
            List<Pizza> ExpectedPizzaList = new List<Pizza>
            {
                new Pizza{Id=01, PizzaType="Margherita", price=3, Toppings=false, Quantity=50, Description="Tomato Sauce And Two Layers Of Mozzarella Cheese.", ImageUrl="https://static.phdvasia.com/kw/menu/single/desktop_thumbnail_3f62936b-e5ca-4135-b0bf-472a2c7b40f0.jpg"},
                new Pizza{Id=02, PizzaType="Classic Pepperoni", price=4, Toppings=false, Quantity=35,  Description="One Of Our All-Time Specialties. A Meaty Feast Of Double Pepperoni, Mozzarella Cheese And Tomato Sauce.", ImageUrl="https://static.phdvasia.com/kw/menu/single/desktop_thumbnail_e8621d75-40ff-4649-935d-21f13b9a04e1.jpg"},
                new Pizza{Id=03, PizzaType="Spicy Chicken Ranch", price=6, Toppings=false, Quantity=20,  Description="Introducing our all New Spicy Ranch Pizza for those among us that like a spicy twist to your favorite chicken pizza. A delicious combination of succulent grilled chicken, fresh tomatoes, mushrooms and Green Jalepeno peppers.", ImageUrl="https://static.phdvasia.com/kw/menu/single/desktop_thumbnail_71f8836a-6b14-449e-9cf6-28a7900fd02b.jpg"},
                new Pizza{Id=04, PizzaType="Super Supreme", price=5, Toppings=false, Quantity=20,  Description="Our Famous Combination Of Beef Pepperoni, Juicy Beef, Mushrooms, Green Peppers, Onions, Black Olives And Melting Mozzarella Cheese.", ImageUrl="https://static.phdvasia.com/kw/menu/single/desktop_thumbnail_5c212d5c-ea46-44cf-9350-78d14e98ae42.jpg"},
            };
            List<Pizza> acutalPizzaList = _context.getAllPizza();
            Assert.AreEqual(acutalPizzaList, ExpectedPizzaList);
            Assert.Pass();
        }
        [Test]
        public void GetPizzaById()
        {
            Pizza ExpectedPizza = new Pizza { Id = 01, PizzaType = "Margherita", price = 3, Toppings = false, Quantity = 50, Description = "Tomato Sauce And Two Layers Of Mozzarella Cheese.", ImageUrl = "https://static.phdvasia.com/kw/menu/single/desktop_thumbnail_3f62936b-e5ca-4135-b0bf-472a2c7b40f0.jpg" };
            Pizza acutalPizza = _context.getPizzaById(01);
            Assert.AreEqual(acutalPizza, ExpectedPizza);
            Assert.Pass();
        }
        [Test]
        public void Order()
        {
            Pizza ExpectedPizza = new Pizza { Id = 01, PizzaType = "Margherita", price = 3, Toppings = false, Quantity = 50, Description = "Tomato Sauce And Two Layers Of Mozzarella Cheese.", ImageUrl = "https://static.phdvasia.com/kw/menu/single/desktop_thumbnail_3f62936b-e5ca-4135-b0bf-472a2c7b40f0.jpg" };
            _context.order(ExpectedPizza);
            Pizza acutalPizza = _context.getPizzaById(01);
            Assert.AreEqual(acutalPizza, ExpectedPizza);
            Assert.Pass();
        }
    }
}