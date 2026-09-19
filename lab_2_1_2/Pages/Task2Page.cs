using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace lab_2_1_2.Pages {
public partial class Task2Page : UserControl {
  private int _x_x = 0;
  private int _x_y = 0;
  private int _y_x = 0;
  private int _y_y = 0;
  private int _z_x = 0;
  private int _z_y = 0;
  
  public Task2Page() {
    InitializeComponent();
  }

  private static double FunctionResult(Point x, Point y, Point z) {
    var a = Math.Sqrt(
      Math.Pow(z.X - y.X, 2) +
      Math.Pow(z.Y - y.Y, 2)
    );

    var b = Math.Sqrt(
      Math.Pow(z.X - x.X, 2) +
      Math.Pow(z.Y - x.Y, 2)
    );

    var c = Math.Sqrt(
      Math.Pow(y.X - x.X, 2) +
      Math.Pow(y.Y - x.Y, 2)
    );

    var s = 0.5 * Math.Abs(
      x.X * (y.Y - z.Y) +
      y.X * (z.Y - x.Y) +
      z.X * (x.Y - y.Y)
    );

    return (a * b * c) / (4 * s);
  }

  private void UpdateResult() {
    var x = new Point(_x_x, _x_y);
    var y = new Point(_y_x, _y_y);
    var z = new Point(_z_x, _z_y);

    if (x == y || x == z || y == z) {
      text_result.Text = "Неверные значения!";
      return;
    }
    
    text_result.Text = FunctionResult(
      x, y, z
    ).ToString(CultureInfo.InvariantCulture);
  }

  private void KeyPressAllowDigits(object sender, KeyPressEventArgs e) {
    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
      e.Handled = true;
    }
  }
  
  #region X

  private void text_x_x_TextChanged(object sender, EventArgs e) {
    var box = (TextBox)sender;

    if (string.IsNullOrEmpty(box.Text)) {
      return;
    }
    
    _x_x = int.Parse(box.Text);
    UpdateResult();
  }
  
  private void text_x_y_TextChanged(object sender, EventArgs e) {
    var box = (TextBox)sender;

    if (string.IsNullOrEmpty(box.Text)) {
      return;
    }
    
    _x_y = int.Parse(box.Text);
    UpdateResult();
  }

  #endregion
  
  #region Y

  private void text_y_x_TextChanged(object sender, EventArgs e) {
    var box = (TextBox)sender;

    if (string.IsNullOrEmpty(box.Text)) {
      return;
    }
    
    _y_x = int.Parse(box.Text);
    UpdateResult();
  }
  
  private void text_y_y_TextChanged(object sender, EventArgs e) {
    var box = (TextBox)sender;

    if (string.IsNullOrEmpty(box.Text)) {
      return;
    }
    
    _y_y = int.Parse(box.Text);
    UpdateResult();
  }

  #endregion
  
  #region Z

  private void text_z_x_TextChanged(object sender, EventArgs e) {
    var box = (TextBox)sender;

    if (string.IsNullOrEmpty(box.Text)) {
      return;
    }
    
    _z_x = int.Parse(box.Text);
    UpdateResult();
  }
  
  private void text_z_y_TextChanged(object sender, EventArgs e) {
    var box = (TextBox)sender;

    if (string.IsNullOrEmpty(box.Text)) {
      return;
    }
    
    _z_y = int.Parse(box.Text);
    UpdateResult();
  }

  #endregion
}
}