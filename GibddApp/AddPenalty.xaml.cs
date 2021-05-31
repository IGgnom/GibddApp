using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static GibddApp.EFAppData;

namespace GibddApp
{
    public partial class AddPenalty : Window
    {
        public AddPenalty()
        {
            InitializeComponent();
            violationComboBox.ItemsSource = AppDataEntities.Violation.ToList();
            TPUComboBox.ItemsSource = AppDataEntities.TPU.ToList();
            violationComboBox.SelectedItem = violationComboBox.Items[0];
            TPUComboBox.SelectedItem = TPUComboBox.Items[0];
        }

        private void AddPenaltyButtonClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(VINTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show($"Необходимо заполнить поля: {(string.IsNullOrEmpty(VINTextBox.Text) ? "\"VIN автомобиля\"" : "")}{(string.IsNullOrEmpty(addressTextBox.Text) ? "," : "")}{(string.IsNullOrEmpty(addressTextBox.Text) ? " \"Адрес совершенного правонарушения\"" : "")}{(string.IsNullOrEmpty(priceTextBox.Text) ? "," : "")}{(string.IsNullOrEmpty(priceTextBox.Text) ? " \"Стоимость\"" : "")}.", "Необходимо заполнить все поля!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void RejectPenaltyButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
