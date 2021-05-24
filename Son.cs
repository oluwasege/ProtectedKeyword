using System;
using System.Collections.Generic;
using System.Text;

namespace ProtectedKeyword
{
    class Son : Father
        
    {
        private int fathersPin;
        public Son()
        {
            fathersPin = base.atmPin;
        }
        public void ChangeFathersPin(int newPin)
        {
            ChangePin(newPin);
        }
    }
}
