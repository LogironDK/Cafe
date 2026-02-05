using Cafe.Forms;
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
      mainView.DataSource = CafeDatabase.GetOrder();
      clientsView.DataSource = CafeDatabase.GetClient();
      dishesView.DataSource = CafeDatabase.GetDishes();

    }

    private void AddOrderToolStripMenuItem_Click(object sender, EventArgs e) {

    }

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
  }
}
