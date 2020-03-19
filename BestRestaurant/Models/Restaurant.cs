using System.Collections.Generic;
namespace BestRestaurant.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      this.Reviews = new HashSet<Review>();
    }
    public virtual ICollection<Review> Reviews { get; set; }
    public int RestaurantId { get; set; }
    public string Description { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}