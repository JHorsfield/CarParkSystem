using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkSystem
{
    public partial class Form1 : Form
    {
        Carpark carpark = new Carpark();
        int currentFloor = 0;
        Car currentCar;
        public Form1()
        {
            InitializeComponent();
            lblErrorText.Text = "";
            lblParkingError.Text = "";
            lblCurrentCar.Text = "";
            updateFloors();
        }
        public void updateCarListBox()
        {
            lbxCarList.Items.Clear();
            foreach (Car car in carpark.returnCarList())
            {

                lbxCarList.Items.Add(car.licenseString());
            }
        }
        public void updateFloors()
        {
            lbxFloors.Items.Clear();
            for (int i = 0; i < carpark.returnNumOfFloor(); i++)
            {
                if (i == currentFloor)
                {
                    int tempI = i + 1;
                    Floor floor = carpark.returnFloorArray()[i];
                    lbxFloors.Items.Add("Floor " + tempI + " has " + floor.spacesLeft() + " spaces left : Current");
                }
                else
                {
                    int tempI = i + 1;
                    Floor floor = carpark.returnFloorArray()[i];
                    lbxFloors.Items.Add("Floor " + tempI + " has " + floor.spacesLeft() + " spaces left");
                }
            }
        }

        private void btnNewCar_Click(object sender, EventArgs e)
        {
            if ((tbxLicense.Text != "") &&(tbxPassCode.Text != ""))
            {
                string license = tbxLicense.Text;
                string passcode = tbxPassCode.Text;
                carpark.newCar(license,passcode);
                lblErrorText.Text = "";
                tbxLicense.Text = "";
                tbxPassCode.Text = "";
                updateCarListBox();
                currentCar = carpark.getCar(license);
                lblCurrentCar.Text = "Current cars license plate:"+license;

            }
            else
            {
                lblErrorText.Text = "Enter information";
            }
        }

        private void btnUpFloor_Click(object sender, EventArgs e)
        {
            if (currentFloor < carpark.returnNumOfFloor()-1)
            {
                currentFloor++;
                lblParkingError.Text = "";                
            }
            else
            {
                lblParkingError.Text = "Already at highest floor";
            }
            updateFloors();
        }

        private void btnDownFloor_Click(object sender, EventArgs e)
        {
            if (currentFloor > 0)
            {
                currentFloor--;
                lblParkingError.Text = "";
            }
            else
            {
                lblParkingError.Text = "Already at lowest floor";
            }
            updateFloors();


        }

        private void BtnPark_Click(object sender, EventArgs e)
        {
            if ((carpark.returnFloorArray()[currentFloor].spacesLeft() > 0)&&(currentCar != null))
            {
                lblParkingError.Text = "";
                carpark.returnFloorArray()[currentFloor].addCar();
                carpark.getCar(currentCar.licenseString()).changeFloor(currentFloor);
                currentCar = null;
                updateFloors();
                updateCarListBox();
            }
            else
            {
                lblParkingError.Text = "Cannot park";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }

}
