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

namespace lab14zadachaWpfApp1
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
                Name = "Mouse",
                Cost = 100,
                Image = "Data/mouse.jpg",
                Category = ProductsTypes.Tech

            });
            products.Add(new Product()
            {
                Name = "Computer",
                Cost = 10000,
                Image = "Data/comp.jpg",
                Category = ProductsTypes.Tech

            });
            products.Add(new Product()
            {
                Name = "Laptop",
                Cost = 8000,
                Image = "Data/laptop.jpg",
                Category = ProductsTypes.Tech

            });
            products.Add(new Product()
            {
                Name = "Music",
                Cost = 100,
                Image = "Data/music.jpg",
                Category = ProductsTypes.Media

            });
            products.Add(new Product()
            {
                Name = "Kino",
                Cost = 200,
                Image = "Data/kino.jpg",
                Category = ProductsTypes.Media

            });
            listBox.ItemsSource = products;
        }
    }
}
