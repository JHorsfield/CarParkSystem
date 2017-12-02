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
        public Form1()
        {
            InitializeComponent();
            lblErrorText.Text = "";
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
                int tempI = i + 1;
                Floor floor = carpark.returnFloorArray()[i];
                lbxFloors.Items.Add("Floor " + tempI + " has " + floor.spacesLeft() + " spaces left");
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
            }
            else
            {
                lblErrorText.Text = "Enter information";
            }
        }
    }

}
