using dom_texniki.Pages;
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

namespace dom_texniki
{
    /// <summary>
    /// Логика взаимодействия для Tovary.xaml
    /// </summary>
    public partial class Tovary : Page
    {
        public Tovary()
        {
            InitializeComponent();
            TeknikaBD.ItemsSource = dom_texnikiEntities.GetContext().Tovar.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cart());
        }

        private void TeknikaBD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
