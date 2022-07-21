using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPizzeria.Models;

namespace MyPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice{ get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSause) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Pepperoni) PizzaPrice += 2;
            if (Pizza.Mushroom) PizzaPrice += 1;
            if (Pizza.Tuna) PizzaPrice += 3;
            if (Pizza.Pineapple) PizzaPrice += 5;
            if (Pizza.Chicken) PizzaPrice += 2;
            if (Pizza.Beef) PizzaPrice += 2;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});
        }
    }
}
