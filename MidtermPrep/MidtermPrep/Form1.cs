using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermPrep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double cost = 0.00;
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (comboBox1.SelectedIndex == 0)
                cost = 1000;
            if (comboBox1.SelectedIndex == 1)
                cost = 1500;
            if (comboBox1.SelectedIndex == 2)
                cost = 2000;
            else if(comboBox1.SelectedIndex == -1)
                MessageBox.Show("Select a Laptop!");

            if (checkBox1.Checked)
                cost += 100;
            if (checkBox2.Checked)
                cost += 150;
            if (checkBox3.Checked)
                cost += 50;
            else
                cost += 0;

            textBox1.Text = cost.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double installmentCost = 000.00;
            if (comboBox2.SelectedIndex == 0)
                installmentCost = cost / 2;
            if (comboBox2.SelectedIndex == 1)
                installmentCost = cost / 3;
            if (comboBox2.SelectedIndex == 2)
                installmentCost = cost / 4;

            textBox2.Text = installmentCost.ToString();
        }

        
    }
}
