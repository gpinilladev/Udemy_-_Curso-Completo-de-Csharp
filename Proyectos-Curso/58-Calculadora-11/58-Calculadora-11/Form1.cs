using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _58_Calculadora_11
{
    public partial class Form1 : Form
    {
        string selectedOperator;
        int acumulatedValue;
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

        private void OperationAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            this.selectedOperator = button.Text;
            this.acumulatedValue = int.Parse(txtValue.Text);
            txtValue.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
        }
    }
}
