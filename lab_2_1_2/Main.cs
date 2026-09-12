using System;
using System.Windows.Forms;
using lab_2_1_2.Pages;

namespace lab_2_1_2 {
public partial class Main : Form {
  public Main() {
    InitializeComponent();
    
    box_mods.Items.AddRange(new object [] {
      "Задание 1.1",
      "Задание 1.2",
      "Задание 1.3",
      "Задание 1.4",
      "Задание 2.1"
    });
    
    ShowPage(new HomePage());
  }
  
  private void box_mods_SelectedIndexChanged(object sender, EventArgs e) {
    var box = (ComboBox)sender;
    
    switch (box.SelectedIndex) {
      case 0:
        ShowPage(new Task1Page());
        break;
      case 1:
        ShowPage(new Task2Page());
        break;
      case 2:
        ShowPage(new Task3Page());
        break;
      case 3:
        ShowPage(new Task4Page());
        break;
      case 4:
        ShowPage(new Task5Page());
        break;
    }
  }

  #region Helpers

  private void ShowPage(UserControl page) {
    panel_content.Controls.Clear();
    panel_content.Controls.Add(page);
    page.Dock = DockStyle.Fill;
  }

  #endregion
}
}