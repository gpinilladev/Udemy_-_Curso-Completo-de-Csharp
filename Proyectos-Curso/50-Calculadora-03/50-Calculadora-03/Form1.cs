using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _50_Calculadora_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtValue.Text = "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtValue.Text = "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtValue.Text = "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtValue.Text = "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtValue.Text = "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtValue.Text = "5";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtValue.Text = "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtValue.Text = "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtValue.Text = "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
        }
    }
}
