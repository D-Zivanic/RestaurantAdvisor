using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantAdvisor.Core;
using RestaurantAdvisor.Data;

namespace RestaurantAdvisor.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private readonly IRestaurantData _restaurantData;

        public Restaurant restaurant {get; set; }

        public EditModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public void OnGet(int id)
        {
            restaurant = _restaurantData.GetSingle(id);

        }
    }
}
