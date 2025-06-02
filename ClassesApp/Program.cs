namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A3", "audi");
            Car bmw = new Car("i7", "bmw");

            Console.WriteLine("Please enter the Brand name");
            // setting brand
            audi.Brand = Console.ReadLine();
            // getting brand
            Console.WriteLine("You entered " + audi.Brand);
        }
    }
}
