using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
                label1.Text = "Enter Numbers";
            int count = 0, sum = 0, num;
            foreach (var s in textBox1.Text.Split(','))
            {
                if (int.TryParse(s, out num))
                {
                    count++;
                    sum += num;

                }
            }
            label1.Text = "" + sum / count;
        }
    }
}
