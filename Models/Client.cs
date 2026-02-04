using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Models {
  public class Client {
    public int Id { get; set; }
    public string Name { get; set; }
    public int TableNumber { get; set; }

    public override string ToString() => $"Номер стола: {TableNumber}";
  }
}
