using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Costumer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Costum Constructor
        public Costumer(string name, string adress, string contactNumber)
        {
            Name = name;
            Address = adress;
            ContactNumber = contactNumber;
        }

        public Costumer(string name)
        {
            Name = name;
        }
    }
}
