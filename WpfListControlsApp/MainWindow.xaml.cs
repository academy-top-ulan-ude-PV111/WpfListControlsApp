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

namespace WpfListControlsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class User
    {
        public string? Name { set; get; }
        public int Age { set; get; }
        public string? Company { set; get; }
        public string? Address { set; get; }
        public override string ToString()
        {
            return $"{Name} ({Age}) - {Company}";
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //lstBox.Items.Add(new ListBoxItem() { Content = "Элемент 6" });
            //String[] cities = { "Москва", "Воронеж", "Калуга", "Новгород", "Казань" };
            //lstBox.ItemsSource = cities;

            List<User> users = new List<User>()
            {
                new(){ Name = "Sam", Age = 22, Company = "Google", Address = "/1.jpg" },
                new(){ Name = "Leo", Age = 33, Company = "Microsoft", Address = "/2.jpg" },
                new(){ Name = "Jim", Age = 44, Company = "Amazone", Address = "/3.jpg" },
            };

            //lstBox.Items.Clear();
            //lstBox.ItemsSource = users;
            //lstBox.SelectionMode = SelectionMode.Extended;

            //comboBox.Items.Clear();
            //comboBox.ItemsSource = cities;

            //listView.ItemsSource = users;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string str = "";
            //foreach(User item in lstBox.SelectedItems) 
            //{
            //    str += item.Name + " \n";
            //}
            //MessageBox.Show(str);
        }
    }
}
