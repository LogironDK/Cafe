namespace Cafe
{
    partial class MainFrom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
      toolStrip = new ToolStrip();
      toolStripDropDownButton1 = new ToolStripDropDownButton();
      AddOrderToolStripMenuItem = new ToolStripMenuItem();
      AddClientToolStripMenuItem = new ToolStripMenuItem();
      AddDishToolStripMenuItem = new ToolStripMenuItem();
      splitContainer = new SplitContainer();
      mainView = new DataGridView();
      tabControl = new TabControl();
      tabClients = new TabPage();
      clientsView = new DataGridView();
      tabDishes = new TabPage();
      dishesView = new DataGridView();
      toolStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
      splitContainer.Panel1.SuspendLayout();
      splitContainer.Panel2.SuspendLayout();
      splitContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)mainView).BeginInit();
      tabControl.SuspendLayout();
      tabClients.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)clientsView).BeginInit();
      tabDishes.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)dishesView).BeginInit();
      SuspendLayout();
      // 
      // toolStrip
      // 
      toolStrip.ImageScalingSize = new Size(24, 24);
      toolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
      toolStrip.Location = new Point(0, 0);
      toolStrip.Name = "toolStrip";
      toolStrip.Size = new Size(1167, 34);
      toolStrip.TabIndex = 1;
      toolStrip.Text = "toolStrip1";
      // 
      // toolStripDropDownButton1
      // 
      toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
      toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { AddOrderToolStripMenuItem, AddClientToolStripMenuItem, AddDishToolStripMenuItem });
      toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
      toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
      toolStripDropDownButton1.Name = "toolStripDropDownButton1";
      toolStripDropDownButton1.Size = new Size(80, 29);
      toolStripDropDownButton1.Text = "Меню";
      // 
      // AddOrderToolStripMenuItem
      // 
      AddOrderToolStripMenuItem.Name = "AddOrderToolStripMenuItem";
      AddOrderToolStripMenuItem.Size = new Size(260, 34);
      AddOrderToolStripMenuItem.Text = "Добавить заказ";
      AddOrderToolStripMenuItem.Click += AddOrderToolStripMenuItem_Click;
      // 
      // AddClientToolStripMenuItem
      // 
      AddClientToolStripMenuItem.Name = "AddClientToolStripMenuItem";
      AddClientToolStripMenuItem.Size = new Size(260, 34);
      AddClientToolStripMenuItem.Text = "Добавить клиента";
      AddClientToolStripMenuItem.Click += AddClientToolStripMenuItem_Click;
      // 
      // AddDishToolStripMenuItem
      // 
      AddDishToolStripMenuItem.Name = "AddDishToolStripMenuItem";
      AddDishToolStripMenuItem.Size = new Size(260, 34);
      AddDishToolStripMenuItem.Text = "Добавить блюдо";
      AddDishToolStripMenuItem.Click += AddDishToolStripMenuItem_Click;
      // 
      // splitContainer
      // 
      splitContainer.Dock = DockStyle.Fill;
      splitContainer.Location = new Point(0, 34);
      splitContainer.Name = "splitContainer";
      splitContainer.Orientation = Orientation.Horizontal;
      // 
      // splitContainer.Panel1
      // 
      splitContainer.Panel1.Controls.Add(mainView);
      // 
      // splitContainer.Panel2
      // 
      splitContainer.Panel2.Controls.Add(tabControl);
      splitContainer.Size = new Size(1167, 585);
      splitContainer.SplitterDistance = 388;
      splitContainer.TabIndex = 2;
      // 
      // mainView
      // 
      mainView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      mainView.Dock = DockStyle.Fill;
      mainView.Location = new Point(0, 0);
      mainView.Name = "mainView";
      mainView.RowHeadersWidth = 62;
      mainView.Size = new Size(1167, 388);
      mainView.TabIndex = 0;
      mainView.KeyDown += Table_KeyDown;
      // 
      // tabControl
      // 
      tabControl.Alignment = TabAlignment.Bottom;
      tabControl.Controls.Add(tabClients);
      tabControl.Controls.Add(tabDishes);
      tabControl.Dock = DockStyle.Fill;
      tabControl.Location = new Point(0, 0);
      tabControl.Name = "tabControl";
      tabControl.SelectedIndex = 0;
      tabControl.Size = new Size(1167, 193);
      tabControl.TabIndex = 0;
      // 
      // tabClients
      // 
      tabClients.Controls.Add(clientsView);
      tabClients.Location = new Point(4, 4);
      tabClients.Name = "tabClients";
      tabClients.Padding = new Padding(3);
      tabClients.Size = new Size(1159, 155);
      tabClients.TabIndex = 0;
      tabClients.Text = "Клиенты";
      tabClients.UseVisualStyleBackColor = true;
      // 
      // clientsView
      // 
      clientsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      clientsView.Dock = DockStyle.Fill;
      clientsView.Location = new Point(3, 3);
      clientsView.Name = "clientsView";
      clientsView.RowHeadersWidth = 62;
      clientsView.Size = new Size(1153, 149);
      clientsView.TabIndex = 0;
      clientsView.KeyDown += Table_KeyDown;
      // 
      // tabDishes
      // 
      tabDishes.Controls.Add(dishesView);
      tabDishes.Location = new Point(4, 4);
      tabDishes.Name = "tabDishes";
      tabDishes.Padding = new Padding(3);
      tabDishes.Size = new Size(1159, 155);
      tabDishes.TabIndex = 1;
      tabDishes.Text = "Блюда";
      tabDishes.UseVisualStyleBackColor = true;
      // 
      // dishesView
      // 
      dishesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dishesView.Dock = DockStyle.Fill;
      dishesView.Location = new Point(3, 3);
      dishesView.Name = "dishesView";
      dishesView.RowHeadersWidth = 62;
      dishesView.Size = new Size(1153, 149);
      dishesView.TabIndex = 0;
      // 
      // MainFrom
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1167, 619);
      Controls.Add(splitContainer);
      Controls.Add(toolStrip);
      Name = "MainFrom";
      toolStrip.ResumeLayout(false);
      toolStrip.PerformLayout();
      splitContainer.Panel1.ResumeLayout(false);
      splitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
      splitContainer.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)mainView).EndInit();
      tabControl.ResumeLayout(false);
      tabClients.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)clientsView).EndInit();
      tabDishes.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)dishesView).EndInit();
      ResumeLayout(false);
      PerformLayout();

    }

    #endregion
    private ToolStrip toolStrip;
    private SplitContainer splitContainer;
    private ToolStripDropDownButton toolStripDropDownButton1;
    private ToolStripMenuItem AddOrderToolStripMenuItem;
    private ToolStripMenuItem AddClientToolStripMenuItem;
    private ToolStripMenuItem AddDishToolStripMenuItem;
    private DataGridView mainView;
    private TabControl tabControl;
    private TabPage tabClients;
    private TabPage tabDishes;
    private DataGridView clientsView;
    private DataGridView dishesView;
  }
}
