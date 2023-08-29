using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_Strings
{
    internal class Computer : IBootUp
    {
        //gives the strings Brand and Type, as well as the bool IsOn, a get and set value.
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        //lowercases the first word in camel case and converts Brand, Type, and IsOn into statements.
        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        // Sets an if else statement for the IsOn statement and makes it a part of PowerOnOff.
        public void powerOnOff()
        {
            IsOn = !IsOn;

            if(IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else 
            {
                Console.WriteLine("The computer is shutting down!");   
            }
        }

        // informs the program of the brand, model, and state of the machine.
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a(n) {Type} computer, it is on: {IsOn}";
        }
    }
}
