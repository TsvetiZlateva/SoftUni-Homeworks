using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ISmartphone:IPhone
    {
        public string Browse(string site);
    }
}
