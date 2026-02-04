using Cafe.Models;
using Cafe.Services;

namespace Cafe {
  public partial class MainFrom : Form {
    public MainFrom() {
      InitializeComponent();

      GetData();
      
    }

    private void GetData() {
      //CafeDatabase.GetDishes();
      dataGridView1.DataSource = CafeDatabase.GetOrder();


    }
  }
}
