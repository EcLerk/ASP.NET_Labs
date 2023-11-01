using Microsoft.AspNetCore.Mvc;

namespace Web_153503_Kachanovskaya.ViewComponents
{
    public class Cart :ViewComponent
    {
        public IViewComponentResult Invoke() => View();


    }
}
