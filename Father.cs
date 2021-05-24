using System;
using System.Collections.Generic;
using System.Text;

namespace ProtectedKeyword
{
    class Father
    {
        protected int atmPin;

        protected void ChangePin(int pin)
        {

            this.atmPin = pin;
            Console.WriteLine("Pin Changed");
        }
    }
}
