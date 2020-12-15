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

        public Restaurant restaurant {get; set;}
        public IEnumerable<SelectListItem> Cuisines { get; set; }

        public EditModel(IRestaurantData restaurantData, IHtmlHelper htmlHelp)
        {
            _restaurantData = restaurantData;
            _htmlHelp = htmlHelp;
        }

        public void OnGet(int id)
        {
            Cuisines = _htmlHelp.GetEnumSelectList<CuisineType>();
            restaurant = _restaurantData.GetSingle(id);
            
        }
    }
}
