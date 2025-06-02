using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Car
    {
        // member variable
        // private hides the variable from other classes
        private string _model = "";
        private string _brand = "";
        //Constructor
        public Car(string model, string brand) 
        {
            _model = model;
            _brand = brand;
            Console.WriteLine($"A {brand} of the {model} has been created");
            Console.ReadKey();
        }
    }
}
