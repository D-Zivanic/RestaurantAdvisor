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
    public class EditModel : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        private readonly IHtmlHelper _htmlHelp;

        [BindProperty]
        public Restaurant restaurant {get; set;}
        public IEnumerable<SelectListItem> Cuisines { get; set; }

        public EditModel(IRestaurantData restaurantData, IHtmlHelper htmlHelp)
        {
            _restaurantData = restaurantData;
            _htmlHelp = htmlHelp;
        }

        public IActionResult OnGet(int? id)
        {
            Cuisines = _htmlHelp.GetEnumSelectList<CuisineType>();
            if (id.HasValue)
            {
                restaurant = _restaurantData.GetSingle(id.Value);
            }
            else
            {
                restaurant = new Restaurant();
            }
            
            if (restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
            
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Cuisines = _htmlHelp.GetEnumSelectList<CuisineType>();
                return Page();
            }

            if (restaurant.Id > 0)
            {
                _restaurantData.Update(restaurant);
            }
            else
            {
                _restaurantData.Create(restaurant);
            }

            _restaurantData.Save();
            return RedirectToPage("./Detail", new { restaurant.Id });
        }
    }
}
