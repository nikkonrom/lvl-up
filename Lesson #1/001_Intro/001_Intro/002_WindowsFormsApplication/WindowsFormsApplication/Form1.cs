using System;

// Программа выводит в textBox1 строку "Hello World"

namespace WindowsFormsApplication
{
    public partial class Form1 
    {
        // Обработчик события нажатия на кнопку (Handler).
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello World!";
        }
    }
}
