using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantAdvisor.Core;
using RestaurantAdvisor.Data;

namespace RestaurantAdvisor.Pages.Restaurants
{
    public class DeleteModel : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        private readonly IHtmlHelper _htmlHelp;

        public Restaurant restaurant { get; set; }
        public IEnumerable<SelectListItem> Cuisines { get; set; }

        public DeleteModel(IRestaurantData restaurantData, IHtmlHelper htmlHelp)
        {
            _restaurantData = restaurantData;
            _htmlHelp = htmlHelp;

        }

        public IActionResult OnGet(int? id)
        {
            
            if (id == null)
            {
                return RedirectToPage("./NotFound");
            }   
            else
            {
                restaurant = _restaurantData.GetSingle(id);
            }

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            var Restaurant = _restaurantData.Delete(id);
            
            _restaurantData.Save();
            if (Restaurant == null)
            {
                return RedirectToPage("/.NotFound");
            }

            
            return RedirectToPage("./List");
        }
    }
}
