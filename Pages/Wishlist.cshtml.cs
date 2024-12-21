using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ShiftToThrift.Pages
{
    public class WishlistModel : PageModel
    {
        // Define a property to hold the wishlist items
        public List<WishlistItem> WishlistItems { get; set; }

        // OnGet method that runs when the page is first loaded
        public void OnGet()
        {
            // Simulate fetching wishlist items from a database or session
            WishlistItems = new List<WishlistItem>
            {
                new WishlistItem { Name = "Item 1", Price = "$10", ImageUrl = "/images/item1.jpg" },
                new WishlistItem { Name = "Item 2", Price = "$15", ImageUrl = "/images/item2.jpg" }
            };
        }
    }

    // Create a class to represent a wishlist item
    public class WishlistItem
    {
        public int Id { get; set; }        // Unique Id for each item
        public string Name { get; set; }   // Name of the item
        public string ImageUrl { get; set; } // Image URL for the item
        public string Price { get; set; }  // Price of the item
        public int Quantity { get; set; }   // Quantity of the item in the wishlist
    }

}
