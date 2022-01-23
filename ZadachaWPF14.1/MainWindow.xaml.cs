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

namespace ZadachaWPF14._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Приставка PlayStation 5",
                Cost = 50000,
                Image = "Data/ps5.png",
                Category = ProductCategories.Appliances
            });

            products.Add(new Product()
            {
                Name = "Телевизор SONY",
                Cost = 80000,
                Image = "Data/tv.png",
                Category = ProductCategories.Appliances
            });

            products.Add(new Product()
            {
                Name = "Вятский квас",
                Cost = 100,
                Image = "Data/kvas.png",
                Category = ProductCategories.Food
            });

            listBox.ItemsSource = products;
        }
    }
}
