using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoShip_Game
{
    public partial class CargoShip_Load_Game : Form
    {
        CargoShip NewShip = new CargoShip();

        public CargoShip_Load_Game()
        {
            InitializeComponent();
        }

        private void CargoShip_Load_Game_Load(object sender, EventArgs e)
        {
           
            Ship_progressBar.Style = ProgressBarStyle.Continuous;
        }

        private void Motorbike_trackBar_Scroll(object sender, EventArgs e)
        {
            NewShip.MotorBikeCount = Motorbike_trackBar.Value;
            ControlUI();
        }

        private void Car_trackBar_Scroll(object sender, EventArgs e)
        {
            NewShip.CarCount = Car_trackBar.Value;
            ControlUI();
        }

        private void Truck_trackBar_Scroll(object sender, EventArgs e)
        {
            NewShip.TruckCount = Truck_trackBar.Value;
            ControlUI();
        }

        private void Train_trackBar_Scroll(object sender, EventArgs e)
        {
            NewShip.TrainCount = Train_trackBar.Value;
            ControlUI();
        }

        private void New_game_button_Click(object sender, EventArgs e)
        {
            NewShip = new CargoShip();
            ControlUI();
        }

        private void ControlUI() // Controls all the properties of the CargoShip class 
        {
            Ship_progressBar.Maximum = NewShip.ShipCapacity;

            if (NewShip.getCargoLoad() <= NewShip.ShipCapacity)
                
                Ship_progressBar.Value = NewShip.getCargoLoad();
                Ship_label.Text = NewShip.ToString();
                MotorBikeCount_label.Text = NewShip.ToString();
                CarCount_label.Text = NewShip.ToString();
                TruckCount_label.Text = NewShip.ToString();
                TrainCount_label.Text = NewShip.ToString();
            

            if (NewShip.CargoOverLoad() == 0)
            {
                Ship_progressBar.ForeColor = Color.Purple;
                Progress_label.Text = "Boat is fully loaded";

            }

            if (NewShip.CargoOverLoad() > 0)
                Ship_progressBar.ForeColor = Color.Blue;
                


            if (NewShip.CargoOverLoad() < 0)
                Ship_progressBar.ForeColor = Color.Red;
                

        }
    }











   
    


}
