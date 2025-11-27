namespace Task4
{
    class Program
    {
        static void Main()
        {
            Car car = new Car();
            Bike bike = new Bike();

            Console.WriteLine("Car object:");
            car.Display();
            car.StartEngine();
            car.StopEngine();

            Console.WriteLine();

            Console.WriteLine("Bike object:");
            bike.Display();
            bike.StartEngine();
            bike.StopEngine();
        }
    }
}