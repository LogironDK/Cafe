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

      client.Id = GetId();

      return client;
    }


    public static int GetId() {
      using var conn = new SqliteConnection($"Data Source={CafeDatabase.ConnectionString}");
      conn.Open();

      using var cmd = new SqliteCommand("SELECT last_insert_rowid();", conn);
      int id = Convert.ToInt32(cmd.ExecuteScalar());

      return id;
    }
  }
}