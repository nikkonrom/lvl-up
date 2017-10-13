using System;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) % Convert.ToInt32(textBox2.Text));
            }
            if (radioButton2.Checked == true)
            {
                textBox3.Text = Convert.ToString(Math.Pow(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
            }
            if (radioButton3.Checked == true)
            {
                textBox3.Text = textBox1.Text + textBox2.Text;
            }
            if (radioButton4.Checked == true)
            {
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
            }
        }
    }
}
