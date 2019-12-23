using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FormTractor
{

    class Tractor : Vehicle
    {
        protected const int tractorWidth = 100;
        protected const int tractorHeight = 60;

        public Tractor(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Tractor(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _screenWidth - tractorWidth / 2)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > tractorWidth / 2)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > tractorHeight / 2)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _screenHeight - tractorHeight / 2)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawTractor(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush Kuzov = new SolidBrush(MainColor);
            Brush Wheels = new SolidBrush(Color.Yellow);
            
            g.FillRectangle(Kuzov, _startPosX - 50, _startPosY - 30, 50, 30);
            g.DrawRectangle(pen, _startPosX - 50, _startPosY - 30, 50, 30);
            g.FillRectangle(Kuzov, _startPosX - 50, _startPosY, 75, 40);
            g.DrawRectangle(pen, _startPosX - 50, _startPosY, 75, 40);

            //Стекло
            //مراه
            g.FillRectangle(Kuzov, _startPosX - 25, _startPosY - 25, 20, 25);
            g.DrawRectangle(pen, _startPosX - 25, _startPosY - 25, 20, 25);

            //Колеса عجلات
            g.DrawEllipse(pen, _startPosX - 50, _startPosY + 10, 40, 40);
            g.FillEllipse(Wheels, _startPosX - 50, _startPosY + 10, 40, 40);
            g.DrawEllipse(pen, _startPosX + 5, _startPosY + 30, 20, 20);
            g.FillEllipse(Wheels, _startPosX + 5, _startPosY + 30, 20, 20);


        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}
