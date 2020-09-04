using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FormTractor
{
    class Parking<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Parking<T>>
        where T : class, ITransport
    {
        /// <summary>
        /// Массив объектов, которые храним    
        /// /// </summary>        
        private Dictionary<int, T> _places;

        /// <summary>         /// Максимальное количество мест на парковке     
        /// /// </summary>       
        private int _maxCount;
        /// Ширина окна отрисовки
        /// </summary>
        private int PictureWidth { get; set; }

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int PictureHeight { get; set; }
        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>

        private const int _placeSizeWidth = 250;
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private const int _placeSizeHeight = 120;
        private int _currentIndex;
        public int GetKey
        {
            get
            {
                return _places.Keys.ToList()[_currentIndex];
            }
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sizes">Количество мест на парковке</param>
        /// <param name="pictureWidth">Рамзер парковки - ширина</param>
        /// <param name="pictureHeight">Рамзер парковки - высота</param>
        public Parking(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            _currentIndex = -1;
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;

        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется автомобиль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="car">Добавляемый автомобиль</param>
        /// <returns></returns>
        public static int operator +(Parking<T> p, T tractor)
        {
            if (p._places.Count == p._maxCount)
            {
                throw new ParkingOverflowException();
            }
            if (p._places.ContainsValue(tractor))
            {
                throw new ParkingAlreadyHaveException();
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, tractor);

                    p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5 + 50, i % 5 * _placeSizeHeight + 55,
                        p.PictureWidth,
                    p.PictureHeight);
                    return i;

                }
            }
            return -1;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем автомобиль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь
        //объект</param>
        /// <returns></returns>
        public static T operator -(Parking<T> p, int index)
        {
            if (!p.CheckFreePlace(index))

            {
                T tractor = p._places[index];
                p._places.Remove(index);
                return tractor;
            }
            throw new ParkingNotFoundException(index);
        }
        /// <summary>
        /// Метод проверки заполнености парковочного места (ячейки массива)
        /// </summary>
        /// <param name="index">Номер парковочного места (порядковый номер в
        // массиве)</param>
        /// <returns></returns>
        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            foreach (var tractor in _places)
            {
                tractor.Value.DrawTractor(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы праковки
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 5; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 150, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 480);
            }
        }
        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                { return _places[ind]; }
                throw new ParkingNotFoundException(ind);

            }

            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 50, ind % 5 * _placeSizeHeight + 55, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new ParkingOccupiedPlaceException(ind);
                }
            }
        }
        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для получения текущего элемента
        /// </summary>
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
 /// <summary>
 /// Метод интерфейса IEnumerator, вызываемый при удалении объекта
 /// </summary>
           public void Dispose()
        {
            _places.Clear();
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для перехода к следующему элементу или началу
       
 /// </summary>
 /// <returns></returns>
        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        /// </summary>
        public void Reset()
        {
            _currentIndex = -1;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        /// <summary>
        /// Метод интерфейса IComparable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Parking<T> other)
        {
            if (_places.Count > other._places.Count)
            {
                return -1;
            }
            else if (_places.Count < other._places.Count)
               
        {
                return 1;
            }
      else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; ++i)
                {
                    if (_places[thisKeys[i]] is Tractor && other._places[thisKeys[i]] is
                  TractorBulldozer)
                    {
                        return 1;
                    }
                    if (_places[thisKeys[i]] is TractorBulldozer && other._places[thisKeys[i]]
                    is Tractor)
                    {
                        return -1;
                    }
                    if (_places[thisKeys[i]] is Tractor && other._places[thisKeys[i]] is
                   Tractor)
                    {
                        return (_places[thisKeys[i]] is
                       Tractor).CompareTo(other._places[thisKeys[i]] is Tractor);
                    }
                    if (_places[thisKeys[i]] is TractorBulldozer && other._places[thisKeys[i]]
                    is TractorBulldozer)
                    {
                        return (_places[thisKeys[i]] is
                      TractorBulldozer).CompareTo(other._places[thisKeys[i]] is TractorBulldozer);
                    }
                }
            }
            return 0;
        }
    }
}
