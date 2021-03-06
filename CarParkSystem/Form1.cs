﻿using System;
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
        List<String> prepaidedLicences = new List<String>();
        bool[,] carGridArray = new bool[4, 10]{ { true, true, true, true, true, true, true, true, true, true },
            { true, true, true, true, true, true, true, true, true, true },
            { true, true, true, true, true, true, true, true, true, true },
            { true, true, true, true, true, true, true, true, true, true }};
        PictureBox[] carGridBoxes; 

        public Form1()
        {
            InitializeComponent();
            lblErrorText.Text = "";
            lblParkingError.Text = "";
            lblCurrentCar.Text = "";
            btnNewCar.Enabled = false;
            btnDownFloor.Enabled = false;
            btnUpFloor.Enabled = false;
            BtnPark.Enabled = false;
            btnExit.Enabled = false;
            btnPaymentneeded.Enabled = false;
            btnApplyDiscount.Enabled = false;

            updateFloors();

            pbxEntranceClosed.BackColor = Color.Transparent;
            pbxEntranceOpen.BackColor = Color.Transparent;

            pbxEntranceOpen.Visible = false;
            btnNewCar.Visible = false;

            carGridBoxes = new PictureBox[10]{ carGrid1, carGrid2, carGrid3, carGrid4, carGrid5, carGrid6, carGrid7, carGrid8, carGrid9 ,carGrid10};

        }
        public void updateCarListBox()
        {
            lbxCarList.Items.Clear();
            foreach (Car car in carpark.returnCarList())
            {              
                if (car.getCoinId() != -1)
                {
                    lbxCarList.Items.Add(car.licenseString()+" : unpaid Coin");
                }
                else
                {
                    lbxCarList.Items.Add(car.licenseString() + " : paid");
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
                    lblCurrentCar.Text = "Current car's license plate:" + license;
                    button2.Enabled = true;
                    btnNewCar.Enabled = false;
                    btnDownFloor.Enabled = true;
                    btnUpFloor.Enabled = true;
                    BtnPark.Enabled = true;
                    btnExit.Enabled = true;
                    btnPaymentneeded.Enabled = true;
                    btnApplyDiscount.Enabled = true;
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
                for(int count=0; count<10; count++)
                {
                    if (carGridArray[currentFloor, count])
                    {
                        carGridBoxes[count].BackColor = Color.Green;
                    }
                    else
                    {
                        carGridBoxes[count].BackColor = Color.Red;
                    }
                }
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
for(int count=0; count<10; count++)
                    {
                        if (carGridArray[currentFloor, count])
                        {
                            carGridBoxes[count].BackColor = Color.Green;
                        }
                        else
                        {
                            carGridBoxes[count].BackColor = Color.Red;
                        }
                    }
            }
            else
            {
                lblParkingError.Text = "Already at lowest floor";
            }
            updateFloors();


        }

        private void BtnPark_Click(object sender, EventArgs e)
        {
            if ((carpark.returnFloorArray()[currentFloor].spacesLeft() > 0) && (currentCar != null))
            {
                lblParkingError.Text = "";
                carpark.returnFloorArray()[currentFloor].addCar();
                carpark.getCar(currentCar.licenseString()).changeFloor(currentFloor);
                currentCar = null;
                updateFloors();
                updateCarListBox();

                Random rng = new Random();
                int space = rng.Next(10);
                while (!carGridArray[currentFloor, space])
                {
                    space = rng.Next(10);
                }
                carGridArray[currentFloor, space] = false;
                carGridBoxes[space].BackColor = Color.Red;

                pbxEntranceOpen.Visible = false;
                btnNewCar.Visible = false;
                pbxEntranceClosed.Visible = true;

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

            pbxEntranceOpen.Visible = true;
            pbxEntranceClosed.Visible = false;
            btnNewCar.Visible = true;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (lbxCarList.SelectedItem != null)
            {
                string licenseInput = lbxCarList.SelectedItem.ToString();
                string licensePlate = licenseInput.Substring(0, licenseInput.IndexOf(" "));

                bool paid = false;

                foreach (var paidLicence in prepaidedLicences)
                {
                    if (licensePlate == paidLicence)
                        paid = true;
                }
                if (paid)
                {

                    int coinId = carpark.getCar(licensePlate).getCoinId();
                    carpark.getDiscountMachine().getTicketChip().Remove(coinId);
                    carpark.getCar(licensePlate).removeCoin();
                    prepaidedLicences.Remove(licensePlate);
                }
                else
                {
                    lblpayneeded.Text = licensePlate;
                    int coinId = carpark.getCar(licensePlate).getCoinId();
                    DateTime techincallyNow = DateTime.Now.AddHours(timeDilation);
                    TimeSpan timeSpent = techincallyNow - carpark.GetChipMachine().getTicketChip()[coinId].returnStartTime();
                    int hoursSpent = timeSpent.Hours;
                    //lblToPay.Text = hoursSpent.ToString();

                    float payment;
                    float discount = carpark.GetChipMachine().getTicketChip()[coinId].returnDiscount() + 1;
                    payment = hoursSpent * 2 * discount;

                    DialogResult YesOrNo = MessageBox.Show("£" + payment + " due would you like to pay now?", "Payment", MessageBoxButtons.YesNo);
                    if (YesOrNo == DialogResult.Yes)
                    {
                        carpark.getDiscountMachine().getTicketChip().Remove(coinId);
                        carpark.getCar(licensePlate).removeCoin();
                    }
                }
                updateCarListBox();
            }

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
            int coinId = carpark.getCar(licensePlate).getCoinId();

            carpark.getDiscountMachine().addDiscount(discount, coinId);
            float dcTmp = 100*carpark.getDiscountMachine().getTicketChip()[coinId].returnDiscount();
            dcLbl.Text = dcTmp.ToString();
        }

        private void dcLbl_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string licenseInput = lbxCarList.SelectedItem.ToString();
            string licensePlate = licenseInput.Substring(0, licenseInput.IndexOf(" "));

            string neededPassCode = carpark.getCar(licensePlate).returnPassCode();
            string givenPassCode = tbxExitPass.Text;

            if (neededPassCode == givenPassCode)
            {
                int coinId = carpark.getCar(licensePlate).getCoinId();
                if (coinId == -1)
                {

                    Random rng = new Random();
                    int space = rng.Next(10);
                    int floor = carpark.getCar(licensePlate).returnFloor();
                    while(carGridArray[floor, space])
                    {
                        space = rng.Next(10);
                    }
                    carGridArray[floor, space] = true;
                    carGridBoxes[space].BackColor = Color.Green;

                    carpark.returnFloorArray()[floor].removeCar();
                    carpark.killCar(licensePlate);

                    updateCarListBox();
                    updateFloors();

                }
                else
                {
                    MessageBox.Show("Please pay for your ticket");
                }
            }
            else
            {
                MessageBox.Show("Wrong Passcode");
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCardScan_Click(object sender, EventArgs e)
        {
            if (lbxCarList.SelectedItem != null)
            {
                int discount = 20;//fixed discount

                string licenseInput = lbxCarList.SelectedItem.ToString();
                string licensePlate = licenseInput.Substring(0, licenseInput.IndexOf(" "));
                int coinId = carpark.getCar(licensePlate).getCoinId();

                carpark.getDiscountMachine().addDiscount(discount, coinId);
                float dcTmp = 100 * carpark.getDiscountMachine().getTicketChip()[coinId].returnDiscount();
                dcLbl.Text = dcTmp.ToString();
            }
        }

        private void btnAdvancePay_Click(object sender, EventArgs e)
        {
            string licensePlate = tbxAdvanceLicensePlate.Text;
            lblpayneeded.Text = licensePlate;
            prepaidedLicences.Add(licensePlate);



        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
                pbxEntranceOpen.Visible = !pbxEntranceOpen.Visible;
                pbxEntranceClosed.Visible = !pbxEntranceClosed.Visible;
            if (pbxEntranceOpen.Visible)
            {
                MessageBox.Show("Car Park is in shut down, please wait until the emergency services arrive");
            }
            else
            {
                MessageBox.Show("Emergency over, Car Park is back to normal");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
