using Cafe.Models;
using Microsoft.Data.Sqlite;

namespace Cafe.Services {
  public class CafeDatabase {
    private static readonly string ConnectionString = Path.Combine(AppContext.BaseDirectory, @"..\..\..\cafe.db");

    public static List<Dish> GetDishes() {
      using var conn = new SqliteConnection($"Data Source={ConnectionString}");
      conn.Open();

      List<Dish> dishes = new();
      using var cmd = new SqliteCommand("SELECT * FROM Dishes", conn);

      using var reader = cmd.ExecuteReader();

      //var table = new DataTable();
      //table.Load(reader);

      while (reader.Read()) {
        dishes.Add(new Dish {
          Id = reader.GetInt32(0),
          Name = reader.GetString(1),
          Price = Convert.ToDecimal(reader.GetDouble(2)),
          Category = reader.GetString(3)
        }); // Маппинг
      }

      return dishes;
    }

    public static List<Client> GetClient() {
      using var conn = new SqliteConnection($"Data Source={ConnectionString}");
      conn.Open();

      List<Client> clients = new();
      using var cmd = new SqliteCommand("SELECT * from Clients", conn);

      using var reader = cmd.ExecuteReader();

      while (reader.Read()) {
        clients.Add(new Client {
          Id = reader.GetInt32(0),
          Name = reader.IsDBNull(1) ? null : reader.GetString(1),
          TableNumber = reader.GetInt32(2),
        }); 
      }

      return clients;
    }

    public static List<Order> GetOrder() {
      using var conn = new SqliteConnection($"Data Source={ConnectionString}");
      conn.Open();

      List<Order> orders = new();
      using var cmd = new SqliteCommand("SELECT * from Orders", conn);

      using var reader = cmd.ExecuteReader();

      while (reader.Read()) {
        orders.Add(new Order {
          Id = reader.GetInt32(0),
          Client = Order.GetClient(reader.GetInt32(1)),
          Dishes = Order.GetDishes(reader.GetString(2)),
          DateTime = reader.GetDateTime(3)
        });
      }

      return orders;
    }
  }
}
