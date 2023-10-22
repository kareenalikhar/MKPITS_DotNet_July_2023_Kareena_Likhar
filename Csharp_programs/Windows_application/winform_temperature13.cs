//13. Write a C# Sharp program to read temperature in centigrade and
//display a suitable message according to the temperature state below:

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_temperature13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            temp = Convert.ToInt32(textBox1.Text);
            if (temp <= 0)
            {
                label2.Text=("Freezing weather");
            }
            else if (temp > 0 && temp <= 10)
            {
                label2.Text=("Very Cold weather");
            }
            else if (temp > 10 && temp <= 20)
            {
                label2.Text=(" Cold weather");
            }
            else if (temp > 20 && temp <= 30)
            {
                label2.Text=("Normal in Temp");
            }
            else if (temp > 30 && temp <= 40)
            {
                label2.Text=("Its Hot");
            }
            else if (temp >= 40)
            {
                label2.Text=("Its Very Hot");
            }
        }
    }
}
