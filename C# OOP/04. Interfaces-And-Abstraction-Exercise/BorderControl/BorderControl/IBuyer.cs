﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int Food { get; set; }

        public void BuyFood();
    }
}
