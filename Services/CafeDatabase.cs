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
  }
}
