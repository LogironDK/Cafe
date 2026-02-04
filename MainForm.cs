using Cafe.Models;
using Cafe.Services;

namespace Cafe {
  public partial class MainFrom : Form {
    public MainFrom() {
      InitializeComponent();
      dataGridView1.DataSource = CafeDatabase.GetDishes();
    }
  }
}
