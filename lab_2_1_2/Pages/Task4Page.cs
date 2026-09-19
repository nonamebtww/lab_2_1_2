using System;
using System.Windows.Forms;

namespace lab_2_1_2.Pages {
public partial class Task4Page : UserControl {
  public Task4Page() {
    InitializeComponent();
  }

  private string GetTimeFromHours(double hours) {
    if (hours < 0 || hours > 24) {
      return string.Empty;
    }

    return hours <= 6 ? "ночь" :
      hours <= 12 ? "утро" :
      hours <= 18 ? "день" :
      hours <= 22 ? "вечер" :
      "ночь";
  }
  
  private void KeyPressAllowDigits(object sender, KeyPressEventArgs e) {
    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
      e.Handled = true;
    }
  }
  
  private void text_hours_TextChanged(object sender, EventArgs e) {
    var box = (TextBox)sender;

    if (string.IsNullOrEmpty(box.Text) || !double.TryParse(box.Text, out var hours)) {
      text_time.Text = string.Empty;
      return;
    }

    text_time.Text = GetTimeFromHours(hours);
  }
}
}