using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace FormTractor
{
    class MultiLevelParking
    {/// <summary>
     /// Список с уровнями парковки
     /// </summary>
        List<Parking<ITransport>> parkingStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>

        private const int countPlaces = 20;
        private int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int pictureHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй парковки</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {

                //Записываем количество уровней
                sw.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    //Начинаем уровень
                    sw.WriteLine("Level");
                    foreach(ITransport tractor in level)
                   
                    {
                       
                        if (tractor != null)
                        {
                            //если место не пустое
                            //Записываем тип мшаины
                            if (tractor.GetType().Name == "Tractor")
                            {
                                sw.WriteLine(level.GetKey + ":Tractor:");
                            }
                            if (tractor.GetType().Name == "TractorBulldozer")
                            {
                                sw.WriteLine(level.GetKey + ":TractorBulldozer:");
                            }
                            //Записываемые параметры
                            sw.WriteLine(tractor);
                        }
                    }
                }



                return true;
            }
        }

        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string buffer = "";
            using (StreamReader sr = new StreamReader(filename))
            {

                if ((buffer = sr.ReadLine()).Contains("CountLeveles"))
                {

                    int count = Convert.ToInt32(buffer.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Parking<ITransport>>(count);
                }
                else
                {

                    //если нет такой записи, то это не те данные
                    throw new Exception("Неверный формат файла");
                }
                int counter = -1;
                ITransport tractor = null;
                while ((buffer = sr.ReadLine()) != null)
                {
                    //идем по считанным записям
                    if (buffer == "Level")
                    {

                        counter++;

                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(buffer))
                    {
                        continue;
                    }
                    if (buffer.Split(':')[1] == "Tractor")
                    {
                        Console.WriteLine(buffer.Split(':')[2]);
                        tractor = new Tractor(buffer.Split(':')[2]);
                    }
                    else if (buffer.Split(':')[1] == "TractorBulldozer")
                    {
                        tractor = new TractorBulldozer(buffer.Split(':')[2]);
                    }
                    parkingStages[counter][Convert.ToInt32(buffer.Split(':')[0])] = tractor;
                }
            }

        }        public void Sort()
        {
            parkingStages.Sort();
        }
    }
}
