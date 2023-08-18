using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle="Margerita",
                PizzaName="Margerita",
                BasePrice=3,
                TomatoSauce=true,
                Cheese=true,
                finalPrice=6 },

            new PizzasModel(){
                ImageTitle="Cheese",
                PizzaName="Cheese",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                finalPrice=5 },

            new PizzasModel(){
                ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=3,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                finalPrice=10 },

            new PizzasModel(){
                ImageTitle="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=3,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                finalPrice=7 },

            new PizzasModel(){
                ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=3,
                TomatoSauce=true,
                Cheese=true,
                Pineapple=true,
                Ham=true,
                finalPrice=12 },

            new PizzasModel(){
                ImageTitle="Tuna",
                PizzaName="Tuna",
                BasePrice=3,
                TomatoSauce=true,
                Cheese=true,
                Tuna=true,
                finalPrice=8 },
        };
        public void OnGet()
        {
        }
    }
}
