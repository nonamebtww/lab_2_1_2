using System;
using System.Globalization;
using System.Windows.Forms;

namespace lab_2_1_2.Pages {
public partial class Task1Page : UserControl {
  private int _x = 0;
  private int _y = 0;
  private int _z = 0;
  
  public Task1Page() {
    InitializeComponent();
  }

  private static double FunctionA(int x, int y, int z) {
    return Math.Abs(5 - 2 * Math.E) / (1 + Math.Pow(x, 2) * (y - Math.Tan(z)));
  }

  private static double FunctionB(int x, int y) {
    return Math.Abs(y - 4) + (Math.Pow(y - x, 2) / 6) + (Math.Pow(x - y, 2) / 7);
  }

  private void UpdateAB(int x, int y, int z) {
    text_a.Text = FunctionA(x, y, z).ToString(CultureInfo.InvariantCulture);
    text_b.Text = FunctionB(x, y).ToString(CultureInfo.InvariantCulture);
  }

  private void KeyPressAllowDigits(object sender, KeyPressEventArgs e) {
    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
      e.Handled = true;
    }
  }
  
  private void text_x_TextChanged(object sender, EventArgs e) {
    var box = (TextBox)sender;

    if (string.IsNullOrEmpty(box.Text)) {
      return;
    }
    
    _x = int.Parse(box.Text);
    UpdateAB(_x, _y, _z);
  }
  
  private void text_y_TextChanged(object sender, EventArgs e) {
    var box = (TextBox)sender;

    if (string.IsNullOrEmpty(box.Text)) {
      return;
    }
    
    _y = int.Parse(box.Text);
    UpdateAB(_x, _y, _z);
  }
  
  private void text_z_TextChanged(object sender, EventArgs e) {
    var box = (TextBox)sender;

    if (string.IsNullOrEmpty(box.Text)) {
      return;
    }
    
    _z = int.Parse(box.Text);
    UpdateAB(_x, _y, _z);
  }
}
}