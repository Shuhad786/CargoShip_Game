using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShip_Game
{
    class CargoShip
    {

        // Constant values
        const int MotorBikeCount_weight = 10;
        const int CarCount_weight = 20;
        const int TruckCount_weight = 30;
        const int TrainCount_weight = 40;
        const int Max_weight = 10;

        public int ShipCapacity { get; set; }
        public int MotorBikeCount { get; set; }
        public int CarCount { get; set; }
        public int TruckCount { get; set; }
        public int TrainCount { get; set; }

        Random random = new Random();

        // Methods

        public int getCargoLoad()
        {
            return MotorBikeCount * MotorBikeCount_weight +
                CarCount * CarCount_weight +
                TruckCount * TruckCount_weight +
                TrainCount * TrainCount_weight;
        }

        public CargoShip()
        {
            MotorBikeCount = 0;
            CarCount = 0;
            TruckCount = 0;
            TrainCount = 0;

            ShipCapacity = random.Next(Max_weight) * MotorBikeCount_weight + random.Next(Max_weight) * CarCount_weight + random.Next(Max_weight) * TruckCount_weight + random.Next(Max_weight) * TrainCount_weight;
        }

        public int CargoOverLoad()
        {
            return ShipCapacity - getCargoLoad();
        }

        public override string ToString()
        {
            return "Capacity = " + ShipCapacity + ", Current load aboard: " + getCargoLoad();
        }
    }

}

