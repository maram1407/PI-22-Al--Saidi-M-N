namespace FormTractor
{
    partial class FormParking
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeTractor = new System.Windows.Forms.PictureBox();
            this.buttonTakeTractor = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.buttonSetTraktor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTractor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(645, 426);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(71, 13);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(35, 20);
            this.maskedTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxTakeTractor);
            this.groupBox1.Controls.Add(this.buttonTakeTractor);
            this.groupBox1.Controls.Add(this.labelPlace);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Location = new System.Drawing.Point(651, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 224);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "действия";
            // 
            // pictureBoxTakeTractor
            // 
            this.pictureBoxTakeTractor.Location = new System.Drawing.Point(7, 95);
            this.pictureBoxTakeTractor.Name = "pictureBoxTakeTractor";
            this.pictureBoxTakeTractor.Size = new System.Drawing.Size(149, 117);
            this.pictureBoxTakeTractor.TabIndex = 6;
            this.pictureBoxTakeTractor.TabStop = false;
            // 
            // buttonTakeTractor
            // 
            this.buttonTakeTractor.Location = new System.Drawing.Point(22, 56);
            this.buttonTakeTractor.Name = "buttonTakeTractor";
            this.buttonTakeTractor.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeTractor.TabIndex = 5;
            this.buttonTakeTractor.Text = "Забрать";
            this.buttonTakeTractor.UseVisualStyleBackColor = true;
            this.buttonTakeTractor.Click += new System.EventHandler(this.buttonTakeTractor_Click);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 16);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 4;
            this.labelPlace.Text = "Место:\r\n";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(666, 26);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(120, 95);
            this.listBoxLevels.TabIndex = 7;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(697, 10);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(48, 13);
            this.labelLevel.TabIndex = 7;
            this.labelLevel.Text = "Уравни:";
            // 
            // buttonSetTraktor
            // 
            this.buttonSetTraktor.Location = new System.Drawing.Point(666, 127);
            this.buttonSetTraktor.Name = "buttonSetTraktor";
            this.buttonSetTraktor.Size = new System.Drawing.Size(120, 43);
            this.buttonSetTraktor.TabIndex = 8;
            this.buttonSetTraktor.Text = "Добавить";
            this.buttonSetTraktor.UseVisualStyleBackColor = true;
            this.buttonSetTraktor.Click += new System.EventHandler(this.buttonSetTraktor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(666, 176);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(120, 43);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonSetTraktor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormParking";
            this.Text = "Стоянка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTractor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeTractor;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.PictureBox pictureBoxTakeTractor;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Button buttonSetTraktor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}

