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
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Page
    {
        public Reg()
        {
            InitializeComponent();
            //RCB.ItemsSource = dom_texnikiEntities.GetContext().Users1.ToList();
        }
        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
          try
            {
                StringBuilder errors = new StringBuilder();
                if (string.IsNullOrEmpty(FName.Text))
                {
                    errors.AppendLine("Заполните поле имя");
                }
                if (string.IsNullOrEmpty(LName.Text))
                {
                    errors.AppendLine("Заполните поле с фамилией");
                }
                if (string.IsNullOrEmpty(Login.Text))
                {
                    errors.AppendLine("Заполните поле с логином");
                }
                if (string.IsNullOrEmpty(Pass.Password))
                {
                    errors.AppendLine("Заполните поле для пароля");
                } 
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString(), "Ошибка!",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            catch (Exception ex) 
            {
            MessageBox.Show(ex.ToString(), "Ошибка!",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }
            }
        }
}
