using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week5.CarDemo.Models;
using Week5.CarDemo.Models.Enums;

namespace Week5.CarDemo
{
    public partial class SpecificationForm : Form
    {
        CarSpecification carSpecification;
        public SpecificationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Changing forum color
            BackColor = Color.Gold;
            pbEngine.BackColor = Color.White;
            pbSize.BackColor = Color.White;

            // Transferring CarType's items to a combo box
            ddlCarType.Items.AddRange(Enum.GetNames(typeof(CarType)));
            // Setting default value of Car Type combo box
            ddlCarType.SelectedIndex = 0;
            ddlCarType.Text = ddlCarType.SelectedItem.ToString();

            // Setting max, minimum and default value of the Top Speed numeric up down
            nudTopSpeed.Minimum = 180;
            nudTopSpeed.Maximum = 300;
            nudTopSpeed.Value = 225;
            // Setting max, minimum and default value of the Engine Size numeric up down
            nudAcceleration.Value = 10;
            nudEngineSize.Minimum = 1100;
            nudEngineSize.Maximum = 2500;
            nudEngineSize.Value = 2000;
            // Setting max, minimum and default value of the Max Power numeric up down
            nudMaxPower.Minimum = 90;
            nudMaxPower.Maximum = 250;
            nudMaxPower.Value = 170;
            // Setting max, minimum and default value of the Cur Weight numeric up down
            nudCurbWeight.Minimum = 900;
            nudCurbWeight.Maximum = 1500;
            nudCurbWeight.Value = 1300;
            nudCurbWeight.Increment = 30;
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            // Initializing a new instance from the CarSpecification class
            carSpecification = new CarSpecification()
            {
                Id = 2,
                Brand = tbBrand.Text,
                Model = tbModel.Text,
                Gearbox = cbManual.Checked,
                NumOfDoors = rbTwoDoor.Checked ? DoorNumber.Two : (rbFourDoor.Checked ? DoorNumber.Four : DoorNumber.Five),
                CurbWeight = Convert.ToDouble(nudCurbWeight.Text),
                EnginePos = rbFwd.Checked ? EnginePosition.FrontWheelDrive : (rbRwd.Checked ? EnginePosition.RearWheelDrive : EnginePosition.AllWheelDrive),
                MaximumPower = Convert.ToDouble(nudMaxPower.Value),
                EngineSize = Convert.ToInt16(nudEngineSize.Value),
                Acceleration = Convert.ToDouble(nudAcceleration.Text),
                ProductDate = dtpProductYear.Value.Date,
                TopSpeed = Convert.ToInt32(nudTopSpeed.Value),
                Type = (CarType)ddlCarType.SelectedIndex
            };

            MessageBox.Show("Specifications are created!");
        }

        private void btDisplay_Click(object sender, EventArgs e)
        {
            string specs = "";
            string modifiedGear = carSpecification.Gearbox ? "Manual" : "Automatic";

            specs += "Brand: " + carSpecification.Brand + "\n";
            specs += "Model: " + carSpecification.Model.Trim() + "\n";
            specs += "Car Type: " + carSpecification.Type + "\n";
            specs += "Product Date: " + carSpecification.DisplayProductDate + " \n";
            specs += "Top Speed: " + carSpecification.TopSpeed + " km/h \n";
            specs += "Acceleration: " + carSpecification.Acceleration + " s\n";
            specs += "Engine Size: " + carSpecification.EngineSize + " cubic centimeter\n";
            specs += "Maximum Power: " + carSpecification.MaximumPower + " PS\n";
            specs += "Gearbox: " + modifiedGear + " \n";
            specs += "Engine Position: " + carSpecification.EnginePos + " \n";
            specs += "Curb Weight: " + carSpecification.DisplayCurbWeight + " \n";
            specs += "Num. Of Doors: " + carSpecification.NumOfDoors + "\n";
            
            // Displaying the CarSpecification instance in the rich text box
            rtbDisplay.Text = specs;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            // Exit from the form
            Close();
        }
    }
}
