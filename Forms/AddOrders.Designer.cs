namespace Cafe.Forms {
  partial class AddOrders {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      comboBox1 = new ComboBox();
      label1 = new Label();
      checkedListBox1 = new CheckedListBox();
      label2 = new Label();
      button1 = new Button();
      SuspendLayout();
      // 
      // comboBox1
      // 
      comboBox1.FormattingEnabled = true;
      comboBox1.Location = new Point(138, 36);
      comboBox1.Name = "comboBox1";
      comboBox1.Size = new Size(275, 33);
      comboBox1.TabIndex = 0;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(65, 39);
      label1.Name = "label1";
      label1.Size = new Size(67, 25);
      label1.TabIndex = 1;
      label1.Text = "Клиент";
      // 
      // checkedListBox1
      // 
      checkedListBox1.FormattingEnabled = true;
      checkedListBox1.Location = new Point(138, 101);
      checkedListBox1.Name = "checkedListBox1";
      checkedListBox1.Size = new Size(275, 256);
      checkedListBox1.TabIndex = 2;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(65, 211);
      label2.Name = "label2";
      label2.Size = new Size(65, 25);
      label2.TabIndex = 3;
      label2.Text = "Блюда";
      // 
      // button1
      // 
      button1.Location = new Point(199, 415);
      button1.Name = "button1";
      button1.Size = new Size(112, 34);
      button1.TabIndex = 4;
      button1.Text = "Добавить";
      button1.UseVisualStyleBackColor = true;
      button1.Click += Button1_Click;
      // 
      // AddOrders
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(474, 490);
      Controls.Add(button1);
      Controls.Add(label2);
      Controls.Add(checkedListBox1);
      Controls.Add(label1);
      Controls.Add(comboBox1);
      Name = "AddOrders";
      Text = "AddOrders";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private ComboBox comboBox1;
    private Label label1;
    private CheckedListBox checkedListBox1;
    private Label label2;
    private Button button1;
  }
}