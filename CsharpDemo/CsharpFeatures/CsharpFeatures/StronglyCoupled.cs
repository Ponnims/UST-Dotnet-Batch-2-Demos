using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    // Strongly Coupled code example
    // In this example, the Switch class is tightly coupled with the Light and Fan classes. If we want to add another device (e.g., TV), we would need to modify the Switch class,
    // which violates the Open/Closed Principle.
    // To make it more flexible, we could use interfaces or abstract classes to decouple the Switch class from the specific devices,
    // allowing us to add new devices without modifying existing code.
    class Switchh
    {
        // concrete object
       //Lightt lightobj = new Light();
       Fann fanobj = new Fann();
        public void SwitchOn()
        {
            //lightobj.On();
                fanobj.On();
        }
        public void SwitchOff()
        {
            //lightobj.Off();
            fanobj.Off();
        }
    }
    class Lightt
    {
        public void On()
        {
            Console.WriteLine("Light is turned on.");
        }
        public void Off()
        {
            Console.WriteLine("Light is turned off.");
        }
    }

    class Fann
    {
        public void On()
        {
            Console.WriteLine("Fan is started.");
        }
        public void Off()
        {
            Console.WriteLine("Fan is stopped.");
        }
    }
    internal class StronglyCoupled
    {
        static void Main(string[] args)
        {
            Switchh switchobj = new Switchh();
            switchobj.SwitchOn();
             switchobj.SwitchOff();
        }
    }
}
