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

namespace plusmaaltabel
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
        
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            maximumTextBox.Clear();
            maximumTextBox.Focus();
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
           if (int.TryParse(maximumTextBox.Text, out int maximum))
            {
                if (maximum > 20)
                {
                    maximum = 10;
                }
            }
            StringBuilder sb = new StringBuilder();
            
            for (int row = 0; row <= maximum; row++)
            {
                for (int col = 0; col <= maximum; col++)
                {
                    if (col == 0)

                        sb.Append($"{row}\t");
                    else
                        sb.Append($"{row + col}\t");
                }
                sb.AppendLine();
            }
            resultTextBox.Text = sb.ToString();
            
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(maximumTextBox.Text, out int maximum))
            {
                if (maximum > 20)
                {
                    maximum = 10;
                }
            }
            StringBuilder sb = new StringBuilder();

            for (int row = 0; row <= maximum; row++)
            {
                for (int col = 0; col <= maximum; col++)
                {
                    if (col == 0)

                        sb.Append($"{row}\t");
                    else
                        sb.Append($"{row * col}\t");
                }
                sb.AppendLine();
            }
            resultTextBox.Text = sb.ToString();
        }
    }
}