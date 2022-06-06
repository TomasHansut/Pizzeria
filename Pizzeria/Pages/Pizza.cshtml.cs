using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;

namespace Pizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita", PizzaName="Margerita", BasePrice=2, TomatoSauce = true, Cheese = true, FinalPrice = 4},
            new PizzasModel(){ImageTitle="Hawaiian", PizzaName="Hawaiian", BasePrice=2, TomatoSauce = true, Cheese = true, Ham = true, Pineapple = true, FinalPrice = 6},
            new PizzasModel(){ImageTitle="MeatFeast", PizzaName="MeatFeast", BasePrice=2, TomatoSauce = true, Cheese = true, Ham = true, Beef = true, Chicken = true, FinalPrice = 7},
            new PizzasModel(){ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice=2, TomatoSauce = true, Cheese = true, Ham = true, Mushrooms = true, FinalPrice = 6},
            new PizzasModel(){ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice=2, TomatoSauce = true, Cheese = true, Peperoni = true, FinalPrice = 5},
            new PizzasModel(){ImageTitle="Seafood", PizzaName="Seafood", BasePrice=2, TomatoSauce = true, Cheese = true, Tuna = true, FinalPrice = 5},
            new PizzasModel(){ImageTitle="Bolognese", PizzaName="Bolognese", BasePrice=2, TomatoSauce = true, Cheese = true, Beef = true, FinalPrice = 5}

        };
        public void OnGet()
        {
        }
    }
}
