﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTractor
{
    public partial class FormTractor : Form

    {
        private TractorBulldozer tractor;

        public FormTractor()
        {
            InitializeComponent();

        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTractor.Width, pictureBoxTractor.Height);
            Graphics gr = Graphics.FromImage(bmp);
            tractor.DrawTractor(gr);
            pictureBoxTractor.Image = bmp;
        }



        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            tractor = new TractorBulldozer(rnd.Next(50, 70), rnd.Next(1000, 2000), Color.Red, Color.Yellow, true, true);
            tractor.SetPosition(rnd.Next(50, 100), rnd.Next(50, 300), pictureBoxTractor.Width, pictureBoxTractor.Height);
            Draw();

        }


        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    tractor.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    tractor.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    tractor.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    tractor.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
