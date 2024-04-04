using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void onDisplayClick(object sender, RoutedEventArgs e)
        {
            if (HelloButton.IsChecked == true)
            {
                DisplayBlock.Text = "Hello World!";
            }

            if (GoodbyeButton.IsChecked == true)
            {
                DisplayBlock.Text = "Goodbye World!";
            }
        }
    }
}