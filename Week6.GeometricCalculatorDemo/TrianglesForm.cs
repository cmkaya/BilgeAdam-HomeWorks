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
using InterfacesDemo3.GeometricShapes.Interfaces;

namespace InterfacesDemo3
{
    public partial class TrianglesForm : Form
    {
        private StraightTriangle straightTriangle = new StraightTriangle();
        private EquilateralTriangle equilateralTriangle = new EquilateralTriangle();
        public TrianglesForm()
        {
            InitializeComponent();
        }

        private void TrianglesForm_Load(object sender, EventArgs e)
        {
            rbStraightTriangle.Checked = Enabled;
        }
        private void rbEquilateralTriangle_CheckedChanged(object sender, EventArgs e)
        {
            // Since we do not use first and second edges, do them deactivate. In addition, set default values to 1 for numericupdown controls because the zero gives error message.
            if (rbEquilateralTriangle.Checked)
            {
                nudFirstEdge.Enabled = false;
                nudSecondEdge.Enabled = false;
                nudFirstEdge.Value = 1;
                nudSecondEdge.Value = 1;
                nudThirdEdge.Value = 1;
            }
        }
        private void rbStraightTriangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStraightTriangle.Checked)
            {
                nudFirstEdge.Enabled = Enabled;
                nudSecondEdge.Enabled = Enabled;
            }
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            // The method will calculate perimeter and field based on the triangle type.
            Calculate();
        }

        private void Calculate()
        {// Check if inputs are equal to zero
            if (nudFirstEdge.Value == 0 || nudSecondEdge.Value == 0 || nudThirdEdge.Value == 0)
            {
                MessageBox.Show("You cannot enter 0.", "Error!", MessageBoxButtons.RetryCancel);
                nudFirstEdge.Value = 1;
                nudSecondEdge.Value = 1;
                nudThirdEdge.Value = 1;
            }
            else
            {
                // Since rbStraightriangle is enable by default, consider calculation for straight triangle.
                straightTriangle.FirstEdge = Convert.ToDouble(nudFirstEdge.Value);
                straightTriangle.SecondEdge = Convert.ToDouble(nudSecondEdge.Value);
                straightTriangle.BaseEdge = Convert.ToDouble(nudThirdEdge.Value);
                // Calculation of perimeter and field
                tbPerimeterResult.Text = straightTriangle.CalculatePerimeter().ToString();
                tbFieldResult.Text = straightTriangle.CalculateField().ToString();

                // However, if equilateral triangle button is enabled, make a calculation for it
                if (rbEquilateralTriangle.Checked)
                {
                    equilateralTriangle.BaseEdge = Convert.ToDouble(nudThirdEdge.Value);
                    // Calculation of perimeter and field
                    tbPerimeterResult.Text = equilateralTriangle.CalculatePerimeter().ToString();
                    tbFieldResult.Text = equilateralTriangle.CalculateField().ToString();
                }
            }
        }


        private void btClear_Click(object sender, EventArgs e)
        {
            nudFirstEdge.Value = 1;
            nudSecondEdge.Value = 1;
            nudThirdEdge.Value = 1;
            tbPerimeterResult.Clear();
            tbFieldResult.Clear();
        }
    }
}
