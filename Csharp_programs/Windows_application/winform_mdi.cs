using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_mdiform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register();
            
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            account();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void register()
        {
            frmregister r = new frmregister();
            r.MdiParent = this;
            r.Show();
        }
        public void account()
        {
            frmaccount a = new frmaccount();
            a.MdiParent = this;
            a.Show();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            register();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            account();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            account();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text=="admin")
            {
                groupBox1.Visible = false;
               
                registerFormToolStripMenuItem.Enabled = true;
                eToolStripMenuItem.Enabled = true;
                toolStripButton1.Enabled = true;
                toolStripButton3.Enabled = true;

            }
            else
            {
                MessageBox.Show("Invalid Credential,try again!!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
