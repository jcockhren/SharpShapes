using System;
using System.Collections.Generic; // Stuff like List
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
//using System.Windows.Shapes;
using Shapes;
using System.Reflection;

namespace SharpShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetComboBoxItems();
        }

        private void SetComboBoxItems()
        {
            List<string> stuff = new List<string>();
            //stuff.Add("Square");
            //stuff.Add("Rectangle");
            var quadType = typeof(Quadrilateral);

            //combo1.ItemsSource = stuff; // combo1 came from <ComboBox x:Name="combo1" ...
            //combo1.ItemsSource = Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes();
            combo1.ItemsSource = Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes().Where(shapeType => shapeType.IsSubclassOf(typeof(Quadrilateral)));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked!");
        }
    }
}
