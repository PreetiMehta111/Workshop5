namespace Task2
{
    class Program
    {
        static void Main()
        {
            Car car = new Car
            {
                Brand = "Toyota",
                Speed = 120,
                Seats = 5
            };

            Motorcycle bike = new Motorcycle
            {
                Brand = "Honda",
                Speed = 150,
                HasCarrier = true
            };

            // Base class methods – reuse
            car.Start();
            car.DisplayInfo();
            car.Stop();

            Console.WriteLine();

            bike.Start();
            bike.DisplayInfo();
            bike.Stop();
        }
    }
}