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
  public partial class AddClients : Form {
    public Client client;
    public AddClients() {
      InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e) {
      client = new Client() {
        Name = textBox1.Text,
        TableNumber = Int32.Parse(textBox2.Text)
      };
      AddDataInBase.AddClient(client);
      this.Close();
    }
  }
}
