using Task3B;

namespace Task_3_A
{
    class Program
    {
        static void Main()
        {
            Printer printer = new Printer();

            printer.Print("hello there how are you");
            printer.Print(122333);
            printer.Print("application", 5);


            Console.WriteLine("\n \n These are the infos of the Nepali and English teacher.");
            NepaliTeacher nepali = new NepaliTeacher();
            EnglishTeacher english = new EnglishTeacher();

            nepali.Name = "Ram";
            Console.WriteLine("Nepali Teacher:" + nepali.Name);
            nepali.Teaching();
            nepali.SalaryInfo();

            Console.WriteLine();

            english.Name = "Preeti";
            Console.WriteLine("Science Teacher:" + english.Name);
            english.Teaching();
            english.SalaryInfo();
        }
    }
}