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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GibddApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void PayPenaltyButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void AddPenaltyButtonClick(object sender, RoutedEventArgs e)
        {
            AddPenalty addPenalty = new AddPenalty();
            addPenalty.ShowDialog();
        }

        private void EditPenaltyButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
