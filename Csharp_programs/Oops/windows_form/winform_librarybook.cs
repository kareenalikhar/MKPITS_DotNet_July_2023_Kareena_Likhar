using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_librarybook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LibraryBook[] book=new LibraryBook[3];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            book[0] = new LibraryBook();
            book[1] = new LibraryBook();
            book[2] = new LibraryBook();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<3)
            {
                book[cnt].title=textBox1.Text;
                book[cnt].author = textBox2.Text ;
                if(checkBox1.Checked)
                {
                    book[cnt].isAvailable = true ;
                }
                cnt++;
                textBox1.Clear();
                textBox2 .Clear();                                                                                         
                textBox1 .Focus();
                if (cnt == 3)
                {
                    textBox1.Enabled = false ;
                    textBox2.Enabled = false ;
                    button1 .Enabled = false ;
                    MessageBox.Show("Click on Available button");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Avaible Books:\n");
            for (int i = 0; i < 3; i++)
            {
                if (book[i].isAvailable == true)
                {
                    sb.Append("___________________________\n");
                    sb.Append("Title: " + book[i].title + "\n");
                    sb.Append("Author: " + book[i].author+ "\n"); 
                    sb.Append("___________________________\n");
                }
            }
            label3.Text = sb.ToString();


            StringBuilder sb1 = new StringBuilder();
            sb1.Append("not Avaible Books:\n");
            for (int i = 0; i < 3; i++)
            {
                if (book[i].isAvailable == false)
                {
                    sb1.Append("___________________________\n");
                    sb1.Append("Title: " + book[i].title + "\n");
                    sb1.Append("Author: " + book[i].author + "\n");
                    sb1.Append("___________________________\n");
                }
            }
            label4.Text = sb1.ToString();
        }
    }
}
