namespace Classes
{

    public class Cars
    {
        public string Make { get; set;}

        public string Model { get; set; }

        public int Year { get; set; }

        public void PrintCarDetails() { Console.WriteLine($"The car is a {Make} {Model} made in {Year}.");}

    }





    public class Program
    {



        static void Main(string[] args)
        {
            
            Cars aCar = new Cars();

            aCar.Make = "Honda";

            aCar.Model = "Civic";

            aCar.Year = 2023;

            aCar.PrintCarDetails();

        }
    }
}
