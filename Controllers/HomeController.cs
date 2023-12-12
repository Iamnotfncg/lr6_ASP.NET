using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    [HttpPost]
    public IActionResult Order(User user)
    {
        if (user.Age > 16)
            return View("Order", user.ProductQuantity);
        throw new Exception("You must be over 16 to place an order");
    }

    [HttpPost]
    public IActionResult ConfirmOrder(Product[] products) => View("ConfirmOrder");
 
}
