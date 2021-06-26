using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfacesDemo3.GeometricShapes;

namespace InterfacesDemo3
{
    public partial class CircleForm : Form
    {
        // Initializing an instance of Circle Class
        private Circle circle = new Circle();

        public CircleForm()
        {
            InitializeComponent();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            if (nudRadius.Value == 0)
            {
                MessageBox.Show("Radius must be greater than zero.", "Error!", MessageBoxButtons.OK);
                nudRadius.Value = 1;
            }

            circle.Radius = Convert.ToDouble(nudRadius.Value);

            // The method calculates the perimeter and field of the circle
            Calculate();
        }

        private void Calculate()
        {
            lPerimeterResult.Text = circle.CalculatePerimeter().ToString();
            lFieldResult.Text = circle.CalculateField().ToString();
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            nudRadius.Value = 1;
            lPerimeterResult.Text = "";
            lFieldResult.Text = "";
        }
    }
}
