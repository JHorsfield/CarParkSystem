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
            Carpark carpark;
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
        private ChipReader chipReader { get; set; }

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
        static protected PaymentChip[] ticketChip = new PaymentChip[maxSpaces];

    }
    public class ChipMachine : Machine
    {
        //create chips
    }
    public class DiscountMachine : Machine
    {
        //adds discount to a chip

    }
    public class PaymentMachine : Machine
    {
        //commit payment and remove chips
    }
    public class ChipReader : Machine
    {

    }
    public class PaymentChip
    {
        private int iD { get; }
        private DateTime startTime { get; }
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

        public Car(string licensePlate, string passCode)
        {
            this.licensePlate = licensePlate;
            this.passCode = passCode;
        }
        public void changePlace(int place)
        {
            this.place = place;
        }
        public void changeFloor()
        {
            this.floor = floor;
        }
        public string licenseString()
        {
            return (licensePlate);
        }
    }
}