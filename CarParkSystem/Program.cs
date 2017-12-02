using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Carpark
    {
        public const int maxSpaces = 600;
        public const int numOfFloors = 4;

        private List<Car> carList { get; set; }
        private Floor[] floor { get; set; }
        private Enterance enterance { get; set; }
        private Exit exit { get; set; }

        private ChipMachine chipMachine { get; set; }
        private PaymentMachine paymentMachine { get; set; }
        private DiscountMachine discountMachine { get; set; }

        public Carpark()
        {
            floor = new Floor[numOfFloors];
            for (int i = 0; i < numOfFloors; i++)
            {
                floor[i] = new Floor();
            }
            carList = new List<Car>();

            enterance = new Enterance();
            exit = new Exit();
        }
        public void newCar(string licensePlate, string passcode)
        {
            enterance.addNewCar(carList, licensePlate, passcode);
        }
        public List<Car> returnCarList()
        {
            return (carList);
        }
        public Floor[] returnFloorArray()
        {
            return (floor);
        }
        public int returnNumOfFloor()
        {
            return (numOfFloors);
        }
        public Car getCar(string licensePlate)
        {
            Car currentCar = carList.Find(item => item.licenseString() == licensePlate);
            return (currentCar);
        }

    }
    public class Floor
    {
        private int maxCarsPerFloor = 50;
        private int currentNumCars = 0;
        public void addCar()
        {
            if (currentNumCars < 50)
            {
            currentNumCars++;
            }
        }
        public void removeCar()
        {
            if (currentNumCars >0)
            {
            currentNumCars--;
            }
        }
        public int spacesLeft()
        {
            return (maxCarsPerFloor - currentNumCars);
        }
    }
    public class Enterance
    {
        //give new car, linsence plat num,
        public void addNewCar(List<Car> carList,string licensePlate, string passcode)
        {
            Car newCar = new Car(licensePlate, passcode);
            carList.Add(newCar);
        }
    }
    public class Exit
    {
        //remove car from system.
        public void removeCar(List<Car> carList, Car carToRemove)
        {
            carList.Remove(carToRemove);            
        }
    }
    public class Machine
    {
        static private int maxSpaces = 600;//make this generatable and linked to the other maxSpaces
        static protected Dictionary<int, PaymentChip> ticketChip = new Dictionary<int, PaymentChip>();

    }
    public class ChipMachine : Machine
    {
        //create chips
        private int iD = -1;
        public void generateChip()
        {
            this.iD++;
            ticketChip.Add(this.iD, new PaymentChip(this.iD));
        }
    }
    public class DiscountMachine : Machine
    {
        //adds discount to a chip
        public void addDiscount(int dc, int iD)
        {
            ticketChip[iD].applyDiscount(dc);
        }
    }
    public class PaymentMachine : Machine
    {
        //commit payment and remove chips
        public void displayPayment(int iD)
        {
            TimeSpan duration = DateTime.Now - ticketChip[iD].startTime;
            double price = duration.TotalHours;
        }
        public void makePayment(int iD)
        {
            ticketChip.Remove(iD);
        }
    }
    public class PaymentChip
    {
        private int iD { get; }
        public DateTime startTime { get; }
        private int discount { get; set; }
        public PaymentChip(int iD)
        {
            this.iD = iD;
            startTime = DateTime.Now;
        }
        public void applyDiscount(int discount)
        {
            this.discount += discount;
        }
    }
    public class Car
    {
        private string licensePlate { get;}
        private int floor { get; set; }
        private int place { get; set; }
        private string passCode { get;}
        private int coinId;

        public Car(string licensePlate, string passCode)
        {
            this.licensePlate = licensePlate;
            this.passCode = passCode;
        }
        public void changePlace(int place)
        {
            this.place = place;
        }
        public void changeFloor(int floor)
        {
            this.floor = floor;
        }
        public string licenseString()
        {
            return (licensePlate);
        }
        public int getCoinId()
        {
            return coinId;
        }
    }
}