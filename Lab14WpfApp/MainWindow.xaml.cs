using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab14WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Products> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Products>();
            products.Add(new Products()
            {
                NameProduct = "Яблоко",
                PriceProduct = 30,
                PictureProduct="1",
                CategoryProduct= CategoryProducts.Food
            });
            products.Add(new Products()
            {
                NameProduct = "Компьютер",
                PriceProduct = 40000,
                PictureProduct = "2",
                CategoryProduct = CategoryProducts.Householdappliances
            });
            products.Add(new Products()
            {
                NameProduct = "Картошка",
                PriceProduct = 20,
                PictureProduct = "3",
                CategoryProduct = CategoryProducts.Food
            });
            products.Add(new Products()
            {
                NameProduct = "Принтер",
                PriceProduct = 34000,
                PictureProduct = "4",
                CategoryProduct = CategoryProducts.Householdappliances
            });
            lstBox.ItemsSource = products;
        }
    }
}
