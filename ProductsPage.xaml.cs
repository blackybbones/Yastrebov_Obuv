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

namespace Yastrebov_Obuv
{
    /// <summary>
    /// Логика взаимодействия для ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
       
        public ProductsPage()
        {
            InitializeComponent();
            var currentProducts = Yastrebov_ObuvEntities.GetContext().Products.ToList();
            ProductListView.ItemsSource = currentProducts;
        }

        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RButtonBiggist_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RbutttonSmallist_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
