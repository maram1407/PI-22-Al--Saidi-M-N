using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTractor
{
 /// Класс-ошибка "Если не найден автомобиль по определенному месту"
 
    class ParkingNotFoundException  : Exception
 {
        public ParkingNotFoundException(int i) : base("Не найден трактор по месту "
            + i)
    { }
    
    }
}
