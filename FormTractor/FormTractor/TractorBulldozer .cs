using System;
using System.Drawing;

namespace FormTractor
{

    class TractorBulldozer:Tractor
    {
     

        public bool Crane { private set; get; }
        public bool Bulldozerr { private set; get; }
        public Color DopColor { private set; get; }
        public Color GlassColor { private set; get; }

        public TractorBulldozer(int maxSpeed, int weight, Color mainColor, Color dopColor, bool crane, bool bulldozerr)
:base(maxSpeed,  weight,  mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Crane = crane;
            Bulldozerr = bulldozerr;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
          
        }

       

      

        
        public void DrawTractor(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush Kuzov = new SolidBrush(MainColor);
            Brush Wheels = new SolidBrush(DopColor);
           
            if (Crane)
            {
                g.DrawRectangle(pen, _startPosX - 50, _startPosY - 50, 5, 50);
                g.FillRectangle(Kuzov, _startPosX - 50, _startPosY - 50, 5, 50);
                g.DrawRectangle(pen, _startPosX - 45, _startPosY - 50, 60, 5);
                g.FillRectangle(Kuzov, _startPosX - 45, _startPosY - 50, 60, 5);
                g.DrawRectangle(pen, _startPosX + 15, _startPosY - 50, 5, 20);
                g.FillRectangle(Kuzov, _startPosX + 15, _startPosY - 50, 5, 20);
                //Крюк 
                g.DrawRectangle(pen, _startPosX + 17, _startPosY - 30, 1, 5);
                g.DrawRectangle(pen, _startPosX + 11, _startPosY - 25, 7, 1);
                g.DrawRectangle(pen, _startPosX + 11, _startPosY - 30, 1, 5);
            }
            if (Bulldozerr)
            {
                g.FillRectangle(Kuzov, _startPosX + 25, _startPosY + 20, 15, 10);
                g.DrawRectangle(pen, _startPosX + 25, _startPosY + 20, 15, 10);
                g.DrawPolygon(pen, new PointF[] { new PointF(_startPosX + 40, _startPosY - 10), new PointF(_startPosX + 40, _startPosY + 40), new PointF(_startPosX + 90, _startPosY + 40) });
                g.FillPolygon(Wheels, new PointF[] { new PointF(_startPosX + 40, _startPosY - 10), new PointF(_startPosX + 40, _startPosY + 40), new PointF(_startPosX + 90, _startPosY + 40) });
            }

            // Кузов هيئه
            g.FillRectangle(Kuzov, _startPosX - 50, _startPosY - 30, 50, 30);
            g.DrawRectangle(pen, _startPosX - 50, _startPosY - 30, 50, 30);
            g.FillRectangle(Kuzov, _startPosX - 50, _startPosY, 75, 40);
            g.DrawRectangle(pen, _startPosX - 50, _startPosY, 75, 40);

            //مستطيل
            g.FillRectangle(Kuzov, _startPosX - 50, _startPosY - 30, 50, 30);
            g.DrawRectangle(pen, _startPosX - 50, _startPosY - 30, 50, 30);
            g.FillRectangle(Kuzov, _startPosX - 50, _startPosY, 75, 40);
            g.DrawRectangle(pen, _startPosX - 50, _startPosY, 75, 40);
            //Ковш
            //مراه
            g.FillRectangle(Kuzov, _startPosX - 25, _startPosY - 25, 20, 25);
            g.DrawRectangle(pen, _startPosX - 25, _startPosY - 25, 20, 25);
            //Колеса عجلات
            g.DrawEllipse(pen, _startPosX - 50, _startPosY + 10, 40, 40);
            g.FillEllipse(Wheels, _startPosX - 50, _startPosY + 10, 40, 40);
            g.DrawEllipse(pen, _startPosX + 5, _startPosY + 30, 20, 20);
            g.FillEllipse(Wheels, _startPosX + 5, _startPosY + 30, 20, 20);

        }
    }
}
