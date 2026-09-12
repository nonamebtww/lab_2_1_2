using System.Windows.Forms;
using lab_2_1_2.Models;

namespace lab_2_1_2.Pages {
public partial class Task5Page : UserControl {
  private House _house = new House {
    Country = "Россия",
    Region = "Воронежская область",
    City = "Воронеж",
    Street = "Плехановская",
    Number = 52,
    Floor = 4,
    ZipCode = 67
  };
  
  public Task5Page() {
    InitializeComponent();
    
    ShowHouseDetails(ref _house);
  }

  public void ShowHouseDetails(ref House house) {
    text_country.Text = house.Country;
    text_region.Text = house.Region;
    text_city.Text = house.City;
    text_street.Text = house.Street;
    text_number.Text = house.Number.ToString();
    text_floor.Text = house.Floor.ToString();
    text_zip.Text = house.ZipCode.ToString();
  }
}
}