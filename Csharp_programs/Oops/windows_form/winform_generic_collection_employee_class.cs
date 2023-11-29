using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generic_collection_employee_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int,Employee> emp=new Dictionary<int,Employee>();
        private void button1_Click(object sender, EventArgs e)
        {
            Employee e1=new Employee(Convert.ToInt32(textBox1.Text),textBox2.Text);
            Employee e2=new Employee(Convert.ToInt32(textBox3.Text),textBox4.Text);
            emp.Add(e1.empno, e1);
            emp.Add(e2.empno, e2);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb =new StringBuilder();
            foreach(KeyValuePair<int, Employee> kvp in emp)
            {
                sb.Append(kvp.Key + " : " + kvp.Value.name + "\n");
            }
            label5.Text = sb.ToString();
        }
    }
}
