using System;
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
    public partial class FormParking : Form
    {

        /// <summary>
        /// Объект от класса многоуровневой парковки
        /// </summary>
        MultiLevelParking parking;
        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        FormTractorConfig form;

        private const int countLevel = 5;
        public FormParking()
        {
            InitializeComponent();


            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width,
            pictureBoxParking.Height);

            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
            Draw();
        }
        /// Метод отрисовки парковки
        /// </summary>

        private void Draw()
        {


            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
                    pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }


        }


        private void buttonTakeTractor_Click(object sender, EventArgs e)
        {
            if ((listBoxLevels.SelectedIndex > -1) && (maskedTextBox.Text != ""))
            {
                var tractor = parking[listBoxLevels.SelectedIndex] -
               Convert.ToInt32(maskedTextBox.Text);
                if (tractor != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeTractor.Width,
                   pictureBoxTakeTractor.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    tractor.SetPosition(60, 60, pictureBoxTakeTractor.Width,
                   pictureBoxTakeTractor.Height);
                    tractor.DrawTractor(gr);
                    pictureBoxTakeTractor.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeTractor.Width,
                   pictureBoxTakeTractor.Height);
                    pictureBoxTakeTractor.Image = bmp;
                }
                Draw();
            }

        }

        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonSetTraktor_Click(object sender, EventArgs e)
        {
            form = new FormTractorConfig();
            form.AddEvent(AddTractor);
            form.Show();
        }
        /// <summary>
        /// Метод добавления машины
        /// </summary>
        /// <param name="car"></param>
        private void AddTractor(ITransport tractor)
        {
            if (tractor != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = parking[listBoxLevels.SelectedIndex] + tractor;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
   MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}

