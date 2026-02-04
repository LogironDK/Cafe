using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Models {
  public class Order {
    public int Id { get; set; }
    public Client Client { get; set; } = new();
    public List<Dish> Dishes { get; set; } = [];
    public DateTime DateTime { get; set; } = DateTime.Now;
    public decimal TotalPrice => Dishes.Sum(d => d.Price);

    public void AddDish(Dish dish) {
      Dishes.Add(dish);
    }

    public void DeleteDish(Dish dish) {
      Dishes.Remove(dish);
    }
  }
}
