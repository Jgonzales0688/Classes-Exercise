namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {   //Exercise 1
            Car car1 = new Car();
                
            car1.Make = "Chevy";
            car1.Model = "Z06 Corvette";
            car1.Year = 2008;

            Console.WriteLine($"At the car show we saw a {car1.Year}, {car1.Make} {car1.Model}.");
            
            
        }
    }
}
