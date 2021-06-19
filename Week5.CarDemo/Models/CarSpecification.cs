using System;
using System.Windows.Forms;
using Week5.CarDemo.Models.Enums;

namespace Week5.CarDemo.Models
{
    public class CarSpecification
    {
        double curbWeight_;
        private DateTime productDate_;
        public short Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DoorNumber NumOfDoors { get; set; }
        public short EngineSize { get; set; }
        public CarType Type { get; set; }
        public int TopSpeed { get; set; }
        public EnginePosition EnginePos { get; set; }
        public double Acceleration { get; set; }
        public DateTime ProductDate
        {
            set => productDate_ = value;
        }

        public string DisplayProductDate
        {
            get => "" + productDate_.Month + "/" + productDate_.Year;
        }

        public double CurbWeight
        {
            set { curbWeight_ = value; }
        }

        public string DisplayCurbWeight
        {
            get => "" + curbWeight_ + " Kg";
        }
        public double MaximumPower { get; set; }
        public bool Gearbox { get; set; }
    }
}
