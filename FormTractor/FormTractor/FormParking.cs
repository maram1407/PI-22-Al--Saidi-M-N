
﻿using NLog;
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
        private Logger logger;
        public FormParking()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
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
            if (listBoxLevels.SelectedIndex > -1)
                if (maskedTextBox.Text != "")
                {
                    try
                    {
                        var tractor = parking[listBoxLevels.SelectedIndex] -
                       Convert.ToInt32(maskedTextBox.Text);

                        Bitmap bmp = new Bitmap(pictureBoxTakeTractor.Width,
                       pictureBoxTakeTractor.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        tractor.SetPosition(60, 60, pictureBoxTakeTractor.Width,
                       pictureBoxTakeTractor.Height);
                        tractor.DrawTractor(gr);
                        pictureBoxTakeTractor.Image = bmp;
                        logger.Info("Изъят автомобиль " + tractor.ToString() + " с места "
                         + maskedTextBox.Text);
                        Draw();

                    }
                    catch (ParkingNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakeTractor.Width,
                       pictureBoxTakeTractor.Height);
                        pictureBoxTakeTractor.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

        }
    
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    

    /// <summary>
    /// Метод обработки выбора элемента на listBoxLevels
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
   

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
            try
            {
                int place = parking[listBoxLevels.SelectedIndex] + tractor;
                logger.Info("Добавлен автомобиль " + tractor.ToString() + " на место "
               + place);
                Draw();
            }
            catch (ParkingOverflowException ex)
            {
                    logger.Error("Переполнение  ");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            catch (Exception ex)
                {
                    logger.Error("Неизвестная ошибка ");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parking.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Error("Неизвестная ошибка при сохранении ");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    logger.Error("место Занятое ");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error("Неизвестная ошибка при сохранении ");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

    }
    }



    
  

