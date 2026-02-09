using Cafe.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Services {
  internal class DeleteDataInBase {
    public static void RemoveOrder(int id) {
      using var conn = new SqliteConnection($"Data Source={CafeDatabase.ConnectionString}");
      conn.Open();

      using var cmd = new SqliteCommand($"DELETE FROM ORDERS WHERE id = {id}", conn);
      cmd.ExecuteNonQuery();
      conn.Close();
    }

    public static void RemoveClient(int id) {
      using var conn = new SqliteConnection($"Data Source={CafeDatabase.ConnectionString}");
      conn.Open();

      using var cmd = new SqliteCommand($"DELETE FROM Clients WHERE id = {id}", conn);
      cmd.ExecuteNonQuery();
      conn.Close();
    }
  }
}
