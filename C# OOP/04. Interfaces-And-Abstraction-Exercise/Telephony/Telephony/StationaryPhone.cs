using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : IPhone
    {
        public string Dial(string number)
        {
            return $"Dialing... {number}";
        }
    }
}
