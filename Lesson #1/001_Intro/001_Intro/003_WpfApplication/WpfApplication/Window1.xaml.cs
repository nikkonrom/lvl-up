using System.Windows;

namespace WpfApplication
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        // Обработчик события нажатия на кнопку.
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "Hello world!";
        }
    }
}
