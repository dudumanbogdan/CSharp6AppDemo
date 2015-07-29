using System.Windows;
using System.Windows.Controls;
using WpfApp1.Model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonViewModel2 _personViewModel;

        public MainWindow()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            _personViewModel = new PersonViewModel2();

            DataContext = _personViewModel;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TextBox textBoxText = GetTextBox(sender, "textBox");

            if (string.IsNullOrWhiteSpace(textBoxText.Text))
            {
                _personViewModel.Naaaaaame = "Empty text introduced.";
            }
            else
            {
                _personViewModel.Naaaaaame = textBoxText.Text;
            }
        }

        private static TextBox GetTextBox(object sender, string name)
        {
            var parent = (sender as Button)?.Parent as FrameworkElement;
            var textBoxText = parent.FindName(name) as TextBox;

            return textBoxText;
        }
    }
}
