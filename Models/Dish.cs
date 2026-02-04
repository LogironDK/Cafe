using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Models {
  public class Dish {
    [Browsable(false)]
    public int Id { get; set; }

    [DisplayName("Имя")]
    public string Name { get; set; }

    [DisplayName("Цена, руб.")]
    public decimal Price { get; set; }

    [DisplayName("Категория")]
    public string Category { get; set; }

    public override string ToString() {
      return $"{Name} - {Price}";
    }
  }
}
