using hr_3.pr1poCCCDataSetTableAdapters;
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

namespace hr_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        table_222TableAdapter table_111Adapter = new table_222TableAdapter();
        private pr1poCCCEntities table = new pr1poCCCEntities();
        List<Car> cars = new List<Car>();
        public MainWindow()
           
        {
            InitializeComponent();
            table_2.ItemsSource = table.table_222.ToList(); // Для способа с привязкаии
            foreach (var item in table.table_222.ToList())  // Для способа с классом
            {
                cars.Add(new Car(item));
            }
            table_1.ItemsSource = cars; // Конец способа с классом
            table_3.ItemsSource = table_111Adapter.GetFullinfo(); // Способ для DataSet
            
        }
            private void Window_Loaded(object sender , RoutedEventArgs e)
            {

                table_3.Columns[0].Visibility = Visibility.Collapsed; //Убираем 1 и 3 столбец
                table_3.Columns[2].Visibility = Visibility.Collapsed;   
            }//Конец способа для DataGrid
    }
}
