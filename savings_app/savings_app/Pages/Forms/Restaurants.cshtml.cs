using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using savings_app.Models;

namespace savings_app.Pages.Forms
{
    public class RestaurantsModel : PageModel
    {
        [BindProperty]
        public RestautantsModel Restautant { get; set; }
        public void OnGet()
        {
        }
    }
}
