using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLibrary;
namespace FormTest
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Test t = new Test();
            //lbltest.Text = t.TestFunction();
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            //lbltest.Text = "";
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
            lbltest.Text = Test.TestFunction().ToString();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lbltest.Text = "";
        }
    }
}
