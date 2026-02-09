using Cafe.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Services {
  public class AddDataInBase {
    public static Client AddClient(Client client) {
      using var conn = new SqliteConnection($"Data Source={CafeDatabase.ConnectionString}");
      conn.Open();

      using var cmd = new SqliteCommand("INSERT INTO Clients (name, TableNumber) VALUES (@name, @tablenumber)", conn);
      cmd.Parameters.AddWithValue("@name", client.Name);
      cmd.Parameters.AddWithValue("@tablenumber", client.TableNumber);
      cmd.ExecuteNonQuery();

      client.Id = GetId(conn);

      return client;
    }

    public static Dish AddDish(Dish dish) {
      using var conn = new SqliteConnection($"Data Source={CafeDatabase.ConnectionString}");
      conn.Open();

      using var cmd = new SqliteCommand("INSERT INTO Dishes (Name, Price, Category) VALUES (@name, @price, @category)", conn);
      cmd.Parameters.AddWithValue("@name", dish.Name);
      cmd.Parameters.AddWithValue("@price", dish.Price);  
      cmd.Parameters.AddWithValue("@category", dish.Category);
      cmd.ExecuteNonQuery();

      dish.Id = GetId(conn);

      return dish;
    }

    public static Order AddOrder(Order order) {
      using var conn = new SqliteConnection($"Data Source={CafeDatabase.ConnectionString}");
      conn.Open();

      using var cmd = new SqliteCommand("INSERT INTO Orders (ClientId, DishId, DateTime) VALUES (@clientId, @dishId, @dateTime)", conn);
      cmd.Parameters.AddWithValue("@clientId", order.Client.Id);
      cmd.Parameters.AddWithValue("@dishId", string.Join(',', order.Dishes.Select(d => d.Id)));
      cmd.Parameters.AddWithValue("@dateTime", order.DateTime);
      cmd.ExecuteNonQuery();

      order.Id = GetId(conn);

      return order;
    }


    public static int GetId(SqliteConnection conn) {
      using var cmd = new SqliteCommand("SELECT last_insert_rowid()", conn);
      int id = Convert.ToInt32(cmd.ExecuteScalar());

      return id;
    }
  }
}