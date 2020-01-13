namespace FormTractor
{
    partial class FormTractorConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTypeTractor = new System.Windows.Forms.GroupBox();
            this.labelTractorBulldozer = new System.Windows.Forms.Label();
            this.labelTractor = new System.Windows.Forms.Label();
            this.panelTractor = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.pictureBoxTractor = new System.Windows.Forms.PictureBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.groupBoxTypeTractor.SuspendLayout();
            this.panelTractor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractor)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTypeTractor
            // 
            this.groupBoxTypeTractor.Controls.Add(this.labelTractorBulldozer);
            this.groupBoxTypeTractor.Controls.Add(this.labelTractor);
            this.groupBoxTypeTractor.Location = new System.Drawing.Point(12, 39);
            this.groupBoxTypeTractor.Name = "groupBoxTypeTractor";
            this.groupBoxTypeTractor.Size = new System.Drawing.Size(212, 130);
            this.groupBoxTypeTractor.TabIndex = 0;
            this.groupBoxTypeTractor.TabStop = false;
            this.groupBoxTypeTractor.Text = "Тип трактора";
            // 
            // labelTractorBulldozer
            // 
            this.labelTractorBulldozer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTractorBulldozer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTractorBulldozer.Location = new System.Drawing.Point(34, 78);
            this.labelTractorBulldozer.Name = "labelTractorBulldozer";
            this.labelTractorBulldozer.Size = new System.Drawing.Size(136, 38);
            this.labelTractorBulldozer.TabIndex = 1;
            this.labelTractorBulldozer.Text = "Трактор бульдозер";
            this.labelTractorBulldozer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTractorBulldozer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTractorBulldozer_MouseDown);
            // 
            // labelTractor
            // 
            this.labelTractor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTractor.Location = new System.Drawing.Point(34, 27);
            this.labelTractor.Name = "labelTractor";
            this.labelTractor.Size = new System.Drawing.Size(136, 40);
            this.labelTractor.TabIndex = 0;
            this.labelTractor.Text = "Обычный Трактор";
            this.labelTractor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTractor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lableTractor_MouseDown);
            // 
            // panelTractor
            // 
            this.panelTractor.AllowDrop = true;
            this.panelTractor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTractor.Controls.Add(this.labelDopColor);
            this.panelTractor.Controls.Add(this.labelBaseColor);
            this.panelTractor.Controls.Add(this.pictureBoxTractor);
            this.panelTractor.Location = new System.Drawing.Point(248, 30);
            this.panelTractor.Name = "panelTractor";
            this.panelTractor.Size = new System.Drawing.Size(220, 252);
            this.panelTractor.TabIndex = 1;
            this.panelTractor.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTractor_DragDrop);
            this.panelTractor.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTractor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDopColor.Location = new System.Drawing.Point(20, 203);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(181, 39);
            this.labelDopColor.TabIndex = 3;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseColor.Location = new System.Drawing.Point(20, 152);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(181, 39);
            this.labelBaseColor.TabIndex = 2;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // pictureBoxTractor
            // 
            this.pictureBoxTractor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTractor.Location = new System.Drawing.Point(20, 6);
            this.pictureBoxTractor.Name = "pictureBoxTractor";
            this.pictureBoxTractor.Size = new System.Drawing.Size(182, 130);
            this.pictureBoxTractor.TabIndex = 0;
            this.pictureBoxTractor.TabStop = false;
           
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 200);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(121, 31);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "Добавить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(103, 235);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 31);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelGold);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(489, 18);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(121, 213);
            this.groupBoxColor.TabIndex = 7;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelGold
            // 
            this.panelGold.AutoSize = true;
            this.panelGold.BackColor = System.Drawing.Color.Orange;
            this.panelGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGold.Location = new System.Drawing.Point(71, 158);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(37, 36);
            this.panelGold.TabIndex = 7;
            // 
            // panelBlue
            // 
            this.panelBlue.AutoSize = true;
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(71, 69);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(37, 36);
            this.panelBlue.TabIndex = 3;
            // 
            // panelYellow
            // 
            this.panelYellow.AutoSize = true;
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(71, 116);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(37, 36);
            this.panelYellow.TabIndex = 5;
            // 
            // panelWhite
            // 
            this.panelWhite.AutoSize = true;
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(71, 27);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(37, 36);
            this.panelWhite.TabIndex = 1;
            // 
            // panelGray
            // 
            this.panelGray.AutoSize = true;
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(8, 158);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(37, 36);
            this.panelGray.TabIndex = 6;
            // 
            // panelGreen
            // 
            this.panelGreen.AutoSize = true;
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(8, 69);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(37, 36);
            this.panelGreen.TabIndex = 2;
            // 
            // panelRed
            // 
            this.panelRed.AutoSize = true;
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(8, 116);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(37, 36);
            this.panelRed.TabIndex = 4;
            // 
            // panelBlack
            // 
            this.panelBlack.AutoSize = true;
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(8, 27);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(37, 36);
            this.panelBlack.TabIndex = 0;
            // 
            // FormTractorConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 278);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panelTractor);
            this.Controls.Add(this.groupBoxTypeTractor);
            this.Name = "FormTractorConfig";
            this.Text = "FormTractorConfig";
            this.groupBoxTypeTractor.ResumeLayout(false);
            this.panelTractor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractor)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTypeTractor;
        private System.Windows.Forms.Label labelTractorBulldozer;
        private System.Windows.Forms.Label labelTractor;
        private System.Windows.Forms.Panel panelTractor;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.PictureBox pictureBoxTractor;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlack;
    }
}