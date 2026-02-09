using Cafe.Forms;
using Cafe.Models;
using Cafe.Services;
using System.Security.Policy;

namespace Cafe {
  public partial class MainFrom : Form {
    public MainFrom() {
      InitializeComponent();

      GetData();

    }

    private void GetData() {
      //CafeDatabase.GetDishes();
      mainView.DataSource = CafeDatabase.GetOrder();
      clientsView.DataSource = CafeDatabase.GetClient();
      dishesView.DataSource = CafeDatabase.GetDishes();

    }

    private void AddOrderToolStripMenuItem_Click(object sender, EventArgs e) {
      AddOrders addOrders = new AddOrders();
      addOrders.FormClosing += AddOrders_FormClosing;
      addOrders.ShowDialog();
    }

    private void AddOrders_FormClosing(object? sender, FormClosingEventArgs e) {
      List<Order>? orders = mainView.DataSource as List<Order>;
      orders.Add(((AddOrders)sender).order);
      mainView.DataSource = null;
      mainView.DataSource = orders;
    }

    #region ДобавлениеКлиента
    private void AddClientToolStripMenuItem_Click(object sender, EventArgs e) {
      AddClients addClients = new AddClients();
      addClients.FormClosing += AddClients_FormClosing;
      addClients.ShowDialog();

    }

    private void AddClients_FormClosing(object? sender, FormClosingEventArgs e) {
      List<Client>? clients = clientsView.DataSource as List<Client>;
      clients.Add(((AddClients)sender).client);
      clientsView.DataSource = null;
      clientsView.DataSource = clients;
    }
    #endregion

    private void AddDishToolStripMenuItem_Click(object sender, EventArgs e) {
      AddDishes addDishes = new AddDishes();
      addDishes.FormClosing += AddDishes_FormClosing;
      addDishes.ShowDialog();
    }

    private void AddDishes_FormClosing(object? sender, FormClosingEventArgs e) {
      List<Dish>? dishes = dishesView.DataSource as List<Dish>;
      dishes.Add(((AddDishes)sender).dish);
      dishesView.DataSource = null;
      dishesView.DataSource = dishes;
    }

    private void Table_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case Keys.Delete:
          RowDelete(sender as DataGridView);
          break;
      }
    }

    private void RowDelete(DataGridView dataGrid) {
      int rowIndx = dataGrid.SelectedCells[0].RowIndex;
      var row = dataGrid.Rows[rowIndx];
      var data = row.DataBoundItem;

      if (data is Order order) {
        DeleteDataInBase.RemoveOrder(order.Id);
        dataGrid.DataSource = CafeDatabase.GetOrder();
      }
      else if (data is Client client) {
        DeleteDataInBase.RemoveClient(client.Id);
        dataGrid.DataSource = CafeDatabase.GetClient();
      }
        

      //List<Order>? orders = dataGrid.DataSource as List<Order>;
      //orders.Remove((Order)row.DataBoundItem);
      //dataGrid.DataSource = null;
      //dataGrid.DataSource = orders;

      
    }
  }
}
