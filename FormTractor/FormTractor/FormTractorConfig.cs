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
    public partial class FormTractorConfig : Form

    {
        ITransport tractor = null;
        private event tractorDelegate eventAddTractor;
        public FormTractorConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawTractor()
        {
            if (tractor != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTractor.Width, pictureBoxTractor.Height);
                Graphics gr = Graphics.FromImage(bmp);
                tractor.SetPosition(70, 60, pictureBoxTractor.Width, pictureBoxTractor.Height);
                tractor.DrawTractor(gr);
                pictureBoxTractor.Image = bmp;
            }

        }
        public void AddEvent(tractorDelegate ev)
        {
            if (eventAddTractor == null)
            {
                eventAddTractor = new tractorDelegate(ev);
            }
            else
            {
                eventAddTractor += ev;
            }
        }

        private void lableTractor_MouseDown(object sender, MouseEventArgs e)
        {
            labelTractor.DoDragDrop(labelTractor.Text, DragDropEffects.Move |
          DragDropEffects.Copy);
        }

        private void labelTractorBulldozer_MouseDown(object sender, MouseEventArgs e)
        {
            labelTractorBulldozer.DoDragDrop(labelTractorBulldozer.Text, DragDropEffects.Move |
         DragDropEffects.Copy);
        }
        private void panelTractor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
        private void panelTractor_DragDrop(object sender, DragEventArgs e)
        {
            string temp = e.Data.GetData(DataFormats.Text).ToString();
            switch (temp)
            {
                case "Обычный Трактор":
                    tractor = new Tractor(100, 500, Color.White);

                    break;
                case "Трактор бульдозер":
                    tractor = new TractorBulldozer(100, 500, Color.White, Color.Black, true, true
                   );
                    break;
            }
            DrawTractor();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
     DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {

            if (tractor != null)
            {
                tractor.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawTractor();
            }

        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (tractor != null)
            {
                if (tractor is TractorBulldozer)
                {
                    (tractor as
                   TractorBulldozer).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawTractor();
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddTractor?.Invoke(tractor);
            Close();
        }

       
    }
}




