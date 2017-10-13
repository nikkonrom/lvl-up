using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон byte - от 0 до 255");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон sbyte - от -128 до +127");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон ushort - от 0 до 65535");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон short - от -32768 до +32767");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон uint - от 0 до 4294967295");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон int - от -2147483648 до +2147483647");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон ulong - от 0 до 18446744073709551615");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диапазон long - от -9223372036854775808 до +9223372036854775807");
        }
    }
}
