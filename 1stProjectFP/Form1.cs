using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1stProjectFP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select one choice","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Please accept the terms and conditions", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else 
            {
                MessageBox.Show("username and passsword saved successfully!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox1.MaxLength = 14;
        }
    }
}
