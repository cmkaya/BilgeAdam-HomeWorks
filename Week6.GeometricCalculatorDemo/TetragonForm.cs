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
using Rectangle = InterfacesDemo3.GeometricShapes.Rectangle;

namespace InterfacesDemo3
{
    public partial class TetragonForm : Form
    {
        private Square square = new Square();
        private Rectangle rectangle = new Rectangle();
        public TetragonForm()
        {
            InitializeComponent();
        }
        private void rbSquare_CheckedChanged(object sender, EventArgs e)
        {
            // Since we do not need short side, do it deactivate. In addition, set default value to 1 for numericupdown control because the zero gives error message.
            if (rbSquare.Checked)
            {
                nudShortSide.Enabled = false;
                nudShortSide.Value = 1;
            }
        }
        private void rbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRectangle.Checked) 
                nudShortSide.Enabled = true;
        }
        private void btCalculate_Click(object sender, EventArgs e)
        {
            // The below method calculates the perimeter and field of rectangle and square based on user selection
            CalculateIt();
        }

        private void CalculateIt()
        {
            // Check if inputs are equal to zero
            if (nudShortSide.Value == 0 || nudLongSide.Value == 0 )
            {
                MessageBox.Show("You cannot enter 0.", "Error!", MessageBoxButtons.RetryCancel);
            }
            else
            {
                // If square button is enable, calculate for it, otherwise for rectangle
                if (rbSquare.Checked)
                {
                    square.LongSide = Convert.ToDouble(nudLongSide.Value);
                    // Calculation of perimeter and field
                    tbPerimeter.Text = square.CalculatePerimeter().ToString();
                    tbField.Text = square.CalculateField().ToString();
                }
                else
                {
                    rectangle.LongSide = Convert.ToDouble(nudLongSide.Value);
                    rectangle.ShortSide = Convert.ToDouble(nudShortSide.Value);
                    // Calculation of perimeter and field
                    tbPerimeter.Text = rectangle.CalculatePerimeter().ToString();
                    tbField.Text = rectangle.CalculateField().ToString();
                } 
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            nudShortSide.Value = 1;
            nudLongSide.Value = 1;
            tbPerimeter.Clear();
            tbField.Clear();
        }
    }
}
