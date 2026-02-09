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
  public partial class AddOrders : Form {
    public Order order;
    public AddOrders() {
      InitializeComponent();

      comboBox1.Items.AddRange(CafeDatabase.GetClient().ToArray());
      checkedListBox1.Items.AddRange(CafeDatabase.GetDishes().ToArray());
    }

    private void Button1_Click(object sender, EventArgs e) {
      order = new Order {
        Client = (Client)comboBox1.SelectedItem,
        Dishes = checkedListBox1.CheckedItems.Cast<Dish>().ToList()
      };
      AddDataInBase.AddOrder(order);
      this.Close();
    }
  }
}
