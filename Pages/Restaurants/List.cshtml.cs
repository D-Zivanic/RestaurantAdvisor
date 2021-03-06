using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using RestaurantAdvisor.Core;
using RestaurantAdvisor.Data;

namespace RestaurantAdvisor.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration _config;
        private readonly IRestaurantData _restaurantData;
        
        [BindProperty (SupportsGet = true)]
        public string SearchTerm { get; set; }
        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            _config = config;
            _restaurantData = restaurantData;
        }

        public void OnGet()
        {
            Message = "Restaurants List";
            Restaurants = _restaurantData.GetAllByName(SearchTerm);
        }
    }
}
