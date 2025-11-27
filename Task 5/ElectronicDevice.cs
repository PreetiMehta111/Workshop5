using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    abstract class ElectronicDevice
    {
        private string brand;
        private decimal price;

        public string Brand
        {
            get => brand;
            set => brand = value;
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                price = value;
            }
        }

        protected ElectronicDevice(string brand, decimal price)
        {
            Brand = brand;
            Price = price;
        }

        public abstract void ShowInfo();
    }

    // 2. Derived classes
    class Laptop : ElectronicDevice
    {
        public Laptop(string brand, decimal price)
            : base(brand, price)
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop - Brand: {Brand}, Price: {Price:C}");
        }

        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery is now ON.");
        }
    }

    class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, decimal price)
            : base(brand, price)
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone - Brand: {Brand}, Price: {Price:C}");
        }

        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera enabled.");
        }
    }

    // 3. Store class
    class ElectronicsStore
    {
        private readonly List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
        }

        public void RemoveDevice(ElectronicDevice device)
        {
            devices.Remove(device);
        }

        public void ShowAllDeviceDetails()
        {
            foreach (ElectronicDevice device in devices)
            {
                device.ShowInfo(); // polymorphic call

                // Downcast to call child-specific methods
                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (device is Smartphone phone)
                {
                    phone.EnableCamera();
                }

                Console.WriteLine();
            }
        }
    }
}