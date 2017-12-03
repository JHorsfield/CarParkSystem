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
        PaymentChip currentChip;
        int timeDilation;

        public Form1()
        {
            InitializeComponent();
            lblErrorText.Text = "";
            lblParkingError.Text = "";
            lblCurrentCar.Text = "";
            btnNewCar.Enabled = false;
            updateFloors();
        }
        public void updateCarListBox()
        {
            lbxCarList.Items.Clear();
            foreach (Car car in carpark.returnCarList())
            {              
                if (car.getCoinId() == 0)
                {
                    lbxCarList.Items.Add(car.licenseString()+" : unpaid Coin");
                }
                else
                {
                    lbxCarList.Items.Add(car.licenseString() + " : paided");
                }
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
            if (currentChip != null)
            {

                if ((tbxLicense.Text != "") && (tbxPassCode.Text != ""))
                {
                    string license = tbxLicense.Text;
                    string passcode = tbxPassCode.Text;
                    carpark.newCar(license, passcode,currentChip.getId());
                    lblErrorText.Text = "";
                    tbxLicense.Text = "";
                    tbxPassCode.Text = "";
                    updateCarListBox();
                    currentCar = carpark.getCar(license);
                    lblCurrentCar.Text = "Current cars license plate:" + license;

                }
                else
                {
                    lblErrorText.Text = "Enter information";
                }
            }
            else
            {
                lblErrorText.Text = "Get a chip please";

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
                btnDownFloor.Enabled = false;
                btnUpFloor.Enabled = false;
            }
            else
            {
                lblParkingError.Text = "Cannot park";

            }
        }

        private void button2_Click(object sender, EventArgs e) // get coin button
        {
            int currentId = carpark.GetChipMachine().generateChip();
            currentChip = carpark.GetChipMachine().getTicketChip()[currentId];
            button2.Enabled = false;
            btnNewCar.Enabled = true;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            string licenseInput = lbxCarList.SelectedItem.ToString();
            string licensePlate = licenseInput.Substring(0, licenseInput.IndexOf(" "));
            lblpayneeded.Text = licensePlate;

            int coinId = carpark.getCar(licensePlate).getCoinId();
            DateTime techincallyNow = DateTime.Now.AddHours(timeDilation);
            TimeSpan timeSpent = techincallyNow - carpark.GetChipMachine().getTicketChip()[coinId].returnStartTime();
            int hoursSpent = timeSpent.Hours;
            //lblToPay.Text = hoursSpent.ToString();

            float payment;
            float discount = carpark.GetChipMachine().getTicketChip()[coinId].returnDiscount() +1;
            payment = hoursSpent * 2 * discount;

            DialogResult YesOrNo = MessageBox.Show("£" + payment + " due would you like to pay now?", "Payment", MessageBoxButtons.YesNo);
            if (YesOrNo == DialogResult.Yes)
            {
                carpark.getCar(licensePlate).removeCoin();
                
            }



            updateCarListBox();

        }

        private void btnBackTime_Click(object sender, EventArgs e)
        {

        }

        private void btnFowardTime_Click(object sender, EventArgs e)
        {

        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {

            
        }

        private void discountBtn_Click(object sender, EventArgs e)
        {
        //    //int discount = int.Parse(discountTxt.Text);
        //    string licenseInput = lbxCarList.SelectedItem.ToString();
        //    string licensePlate = licenseInput.Substring(0, licenseInput.IndexOf(" "));
        //    carpark.getDiscountMachine().addDiscount(discount, (carpark.getCar(licensePlate).getCoinId()));
        }

        private void btnHourFoward_Click(object sender, EventArgs e)
        {
            timeDilation++;

        }

        private void btnHourBackwards_Click(object sender, EventArgs e)
        {
            timeDilation--;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.AddHours(timeDilation);
            lblTimer.Text = currentDate.ToString("HH:mm");
        }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            int discount = int.Parse(nudDiscountAmount.Text);
            string licenseInput = lbxCarList.SelectedItem.ToString();
            string licensePlate = licenseInput.Substring(0, licenseInput.IndexOf(" "));
            carpark.getDiscountMachine().addDiscount(discount, (carpark.getCar(licensePlate).getCoinId()));
        }
    }

}
