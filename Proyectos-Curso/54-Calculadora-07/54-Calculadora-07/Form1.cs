using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _54_Calculadora_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtValue.Text = button.Text;
        }
    }
}
