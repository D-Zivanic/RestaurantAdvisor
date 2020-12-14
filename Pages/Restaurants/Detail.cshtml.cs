using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantAdvisor.Core;

namespace RestaurantAdvisor.Pages.Restaurants
{
    public class DetailModel : PageModel
    {

        public Restaurant Restaurants { get; set; }

        public void OnGet()
        {
        }
    }
}
