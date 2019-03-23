using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体练习
{
      public partial class Form1 : Form
      {
            public Form1()
            {
                  InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                  //MessageBox.Show(“There are something wrong!”,“ERROR”);
                  MessageBox.Show(textBox1.Text);

            }
      }
}
