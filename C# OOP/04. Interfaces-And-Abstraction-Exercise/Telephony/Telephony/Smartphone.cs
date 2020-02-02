using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ISmartphone
    {
        public string Browse(string site)
        {
            return $"Browsing: {site}!";
        }

        public string Dial(string number)
        {
            return $"Calling... {number}";
        }
    }
}
