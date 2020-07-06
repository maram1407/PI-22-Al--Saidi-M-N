using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTractor
{
    /// Класс-ошибка "Если на парковке уже заняты все места"
    class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() : base("На стоянке нет свободных мест")
        { }
   
    }
}
