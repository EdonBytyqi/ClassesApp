namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A3", "audi", false);
            Car bmw = new Car("i7", "bmw", true);

           
            // getting brand
            Console.WriteLine("Brand is " + audi.Brand);
            Console.WriteLine("Brand is " + bmw.Brand);

            Costumer earl = new Costumer("Earl");
            Costumer frank = new Costumer("Frank","Hochdorferstrasse 25", "123456789");
            Console.WriteLine("Name of Costumer is " + earl.Name);

            Console.ReadKey();
        }
    }
}
