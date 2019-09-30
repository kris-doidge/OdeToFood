using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Data;
using OdeToFood.Domain;

namespace OdeToFood.Pages.Restaurants
{
    public class EditModel  : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        private readonly IHtmlHelper _htmlHelper;

        [BindProperty]
        public Restaurant Restaurant { get; set; }
        public IEnumerable<SelectListItem> Cuisines { get; set; }
        
        public EditModel(IRestaurantData restaurantData, IHtmlHelper htmlHelper)
        {
            _restaurantData = restaurantData;
            _htmlHelper = htmlHelper;
        }
        
        public IActionResult OnGet(int? id)
        {
            Cuisines = _htmlHelper.GetEnumSelectList<CuisineType>();
            if (id.HasValue)
            {
                Restaurant = _restaurantData.GetRestaurantById(id.Value);
            }
            else
            {
                Restaurant = new Restaurant();
            }
            
            if (Restaurant == null)
                return RedirectToPage("./NotFound");

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Cuisines = _htmlHelper.GetEnumSelectList<CuisineType>();
                return Page();
            }

            if (Restaurant.Id > 0)
                _restaurantData.Update(Restaurant);
            else
                _restaurantData.Add(Restaurant);
            
            _restaurantData.Commit();
            TempData["Message"] = "Restaurant saved!";
            return RedirectToPage("./Detail/", new {id = Restaurant.Id});
        }
    }
}