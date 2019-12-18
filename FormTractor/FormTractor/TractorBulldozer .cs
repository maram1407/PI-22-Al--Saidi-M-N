using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace FormTractor
{
    class TractorBulldozer : Tractor
    {
        public bool Crane { private set; get; }
        public bool Bulldozerr { private set; get; }
        public Color DopColor { private set; get; }
        public Color GlassColor { private set; get; }

        public TractorBulldozer(int maxSpeed, int weight, Color mainColor, Color dopColor, bool crane, bool bulldozerr)
            : base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Crane = crane;
            Bulldozerr = bulldozerr;
        }
        public TractorBulldozer(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Crane = Convert.ToBoolean(strs[4]);
                Bulldozerr = Convert.ToBoolean(strs[5]);

            }
        }
        public override void DrawTractor(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush Kuzov = new SolidBrush(MainColor);
            Brush Wheels = new SolidBrush(DopColor);
            //Brush Glass = new SolidBrush(GlassColor);
            // отрисуем сперва передний спойлер автомобиля (чтобы потом отрисовка
            // Form1 на него "легла")
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

            base.DrawTractor(g);
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Crane + ";" + Bulldozerr;
        }
    }
}
