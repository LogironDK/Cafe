using Cafe.Services;
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

    public static Client GetClient(int id) {
      Client Client = new();
      List<Client> clients = CafeDatabase.GetClient();

      return clients.Find(c => c.Id == id);
    }

    public static List<Dish> GetDishes(string dishesId) {
      List<Dish> dishesForOrder = new();
      List<Dish> dishes = CafeDatabase.GetDishes();

      int[] disesIdInt = dishesId.Split(',').Select(d => Int32.Parse(d)).ToArray();
      dishesForOrder = dishes.Where(d => disesIdInt.Contains(d.Id)).ToList();

      return dishesForOrder;
    }
  }
}
