using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УгадайЧислоИлиЛох_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                MessageBox.Show("Hello"); // выключает пк
                Process.Start("shutdown", "/s /t 0");
            }
            if (textBox1.Text == "2")
            {
                MessageBox.Show("Hello");
                Process.Start("shutdown", "/s /t 0");
            }
            if (textBox1.Text == "3")
            {
                MessageBox.Show("Hello");
                Process.Start("shutdown", "/s /t 0");
            }
            if (textBox1.Text == "4")
            {
                MessageBox.Show("Hello");
                Process.Start("shutdown", "/s /t 0");
            }
            if (textBox1.Text == "5")
            {
                MessageBox.Show("Hello");
                Process.Start("shutdown", "/s /t 0");
            }
            if (textBox1.Text == "6")
            {
                MessageBox.Show("Hello");
                Process.Start("shutdown", "/s /t 0");
            }
            if (textBox1.Text == "7")
            {
                MessageBox.Show("Hello");
                Process.Start("shutdown", "/s /t 0");
            }
            if (textBox1.Text == "8")
            {
                MessageBox.Show("Hello");
                Process.Start("shutdown", "/s /t 0");
            }
            if (textBox1.Text == "9")
            {
                MessageBox.Show("Hello");
                Process.Start("shutdown", "/s /t 0");
            }
            if (textBox1.Text == "10")
            {
                Process.Start("shutdown", "/s /t 0");
                MessageBox.Show("Hello");
            }
            else
            {
                MessageBox.Show("Некоректный Ввод");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
