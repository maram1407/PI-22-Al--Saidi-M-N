﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTractor
{
    class ParkingAlreadyHaveException : Exception
    {
       public ParkingAlreadyHaveException() : base("На парковке уже есть такая машина")
 { }
    }
}
