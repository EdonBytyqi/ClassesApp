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
        // Backing Field of the Model Property
        private string _model = "";
        private string _brand = "";

        private bool _isLuxury = false;


        // Property
        public string Model { get => _model; set => _model = value; }
        public string Brand {

            get 
            {
                if (_isLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            } 

            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered nothing");
                    _brand = "DEFAULTVALUE";
                }
                else 
                {
                    _brand = value;
                }                
            }             
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        //Constructor
        public Car(string model, string brand, bool isLuxury
            ) 
        {
            Model = model;
            Brand = brand;
            Console.WriteLine($"A {brand} of the {model} has been created");
            Console.ReadKey();
            IsLuxury = isLuxury;
        }
    }
}
