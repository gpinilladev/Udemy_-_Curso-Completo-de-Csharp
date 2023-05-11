using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _55_Calculadora_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberAction_Click(object sender, EventArgs e)
        {
            // Conversion del objeto sender a objeto Button
            Button button = (Button)sender;
            // La forma de acumular valores de German Pinilla
            /*
            string buttonValue = button.Text;
            string currentValue = (txtValue.Text == "0") ? "" : txtValue.Text;
            Console.WriteLine(currentValue);
            txtValue.Text = currentValue + buttonValue;
            */

            // La forma del instructor de acumular valores
            int btnValue = int.Parse(button.Text);
            int currValue = int.Parse(txtValue.Text);
            currValue = currValue * 10 + btnValue;
            txtValue.Text = currValue.ToString();
        }
    }
}
