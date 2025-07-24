using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13019_Chauhan_janshi
{
    internal class Class_t12
    {
        // This method prints a simple message to the console
        public void DisplayMessage()
        {
            Console.WriteLine("Hello world..");  // Output line
        }

        static void Main(string[] args)
        {
            // Creating object of Class_t12 to access its method
            Class_t12 obj1 = new Class_t12();

            // Calling the display method
            obj1.DisplayMessage();

            // Keeping console window open
            Console.ReadLine();

            // Temporary variable for testing (not used)
            int unused = 0;
        }
    }
}
