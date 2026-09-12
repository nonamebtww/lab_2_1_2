using System;
using System.Windows.Forms;

namespace lab_2_1_2.Pages {
public partial class Task3Page : UserControl {
  private int _a = 0;
  private int _b = 0;
  
  public Task3Page() {
    InitializeComponent();
  }

  private void UpdateResult() {
    if (_a == _b) {
      lbl_result.Text = "Числа равны";
      text_sum.Text = string.Empty;
      text_mult.Text = string.Empty;
      return;
    }

    lbl_result.Text = "Числа не равны";
    text_sum.Text = (_a + _b).ToString();
    text_mult.Text = (_a * _b).ToString();
  }
  
  private void KeyPressAllowDigits(object sender, KeyPressEventArgs e) {
    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
      e.Handled = true;
    }
  }
  
  private void text_a_TextChanged(object sender, EventArgs e) {
    var box = (TextBox)sender;

    if (string.IsNullOrEmpty(box.Text)) {
      return;
    }
    
    _a = int.Parse(box.Text);
    UpdateResult();
  }
  
  private void text_b_TextChanged(object sender, EventArgs e) {
    var box = (TextBox)sender;

    if (string.IsNullOrEmpty(box.Text)) {
      return;
    }
    
    _b = int.Parse(box.Text);
    UpdateResult();
  }
}
}