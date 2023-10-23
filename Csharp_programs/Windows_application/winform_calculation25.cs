using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_calculation25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, total, choice;
            n1 = Convert.ToInt32(textBox2.Text);

            n2 = Convert.ToInt32(textBox3.Text);

            Console.WriteLine("1.Addition\n2.Substract\n3.Multiply\n4.Divide\n5.Exit");
            choice = Convert.ToInt32(textBox1.Text);



            if (choice == 1)
            {
                total = n1 + n2;
                label4.Text=("Addition is " + total);
            }
            else if (choice == 2)
            {
                total = n1 - n2;
                label4.Text=("Substraction is " + total);
            }
            else if (choice == 3)
            {
                total = n1 * n2;
                label4.Text=("Multiplication is " + total);
            }
            else if (choice == 4)
            {
                total = n1 / n2;
                label4.Text=("Division is " + total);
            }
            else if (choice == 5)
            {
                label4.Text=("Exit");
            }
            else
            {
                label4.Text=("Invalid Number");
            }
        }
    }
}
