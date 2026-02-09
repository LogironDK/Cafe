using Cafe.Models;
using Cafe.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.Forms {
  public partial class AddDishes : Form {
    public Dish dish;
    public AddDishes() {
      InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e) {
      dish = new Dish {
        Name = textBox1.Text,
        Price = Decimal.Parse(textBox2.Text),
        Category = textBox3.Text
      };
      AddDataInBase.AddDish(dish);
      this.Close();
    }
  }
}
