using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Models {
  public class Client {
    [Browsable(false)]
    public int Id { get; set; }
    [DisplayName("Имя")]
    public string Name { get; set; }
    [DisplayName("Номер стола")]
    public int TableNumber { get; set; }

    public override string ToString() => $"Номер стола: {TableNumber}";
  }
}
