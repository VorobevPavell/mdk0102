namespace Map
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mapBox = new System.Windows.Forms.PictureBox();
            this.namePlace = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxDrinks = new System.Windows.Forms.PictureBox();
            this.pictureBoxBars = new System.Windows.Forms.PictureBox();
            this.pictureBoxToilets = new System.Windows.Forms.PictureBox();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.pictureBoxMeds = new System.Windows.Forms.PictureBox();
            this.labelDrinks = new System.Windows.Forms.Label();
            this.labelBars = new System.Windows.Forms.Label();
            this.labelToilets = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.labelMedicial = new System.Windows.Forms.Label();
            this.labelMoscow2023 = new System.Windows.Forms.Label();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonStartTwo = new System.Windows.Forms.Button();
            this.startButtonThree = new System.Windows.Forms.Button();
            this.startButton1 = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToilets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeds)).BeginInit();
            this.SuspendLayout();
            // 
            // mapBox
            // 
            this.mapBox.Image = ((System.Drawing.Image)(resources.GetObject("mapBox.Image")));
            this.mapBox.Location = new System.Drawing.Point(25, 55);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(487, 470);
            this.mapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mapBox.TabIndex = 0;
            this.mapBox.TabStop = false;
            this.mapBox.Click += new System.EventHandler(this.map_Click);
            // 
            // namePlace
            // 
            this.namePlace.AutoSize = true;
            this.namePlace.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namePlace.Location = new System.Drawing.Point(599, 85);
            this.namePlace.Name = "namePlace";
            this.namePlace.Size = new System.Drawing.Size(87, 29);
            this.namePlace.TabIndex = 1;
            this.namePlace.Text = "name";
            this.namePlace.Visible = false;
            this.namePlace.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxDrinks, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxBars, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxToilets, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxInfo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxMeds, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelInformation, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelMedicial, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelToilets, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelBars, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDrinks, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(526, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 381);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Visible = false;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBoxDrinks
            // 
            this.pictureBoxDrinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDrinks.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDrinks.Image")));
            this.pictureBoxDrinks.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxDrinks.Name = "pictureBoxDrinks";
            this.pictureBoxDrinks.Size = new System.Drawing.Size(172, 70);
            this.pictureBoxDrinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDrinks.TabIndex = 0;
            this.pictureBoxDrinks.TabStop = false;
            this.pictureBoxDrinks.Click += new System.EventHandler(this.pictureBoxDrinks_Click);
            // 
            // pictureBoxBars
            // 
            this.pictureBoxBars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBars.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBars.Image")));
            this.pictureBoxBars.Location = new System.Drawing.Point(3, 79);
            this.pictureBoxBars.Name = "pictureBoxBars";
            this.pictureBoxBars.Size = new System.Drawing.Size(172, 70);
            this.pictureBoxBars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBars.TabIndex = 1;
            this.pictureBoxBars.TabStop = false;
            // 
            // pictureBoxToilets
            // 
            this.pictureBoxToilets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxToilets.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxToilets.Image")));
            this.pictureBoxToilets.Location = new System.Drawing.Point(3, 155);
            this.pictureBoxToilets.Name = "pictureBoxToilets";
            this.pictureBoxToilets.Size = new System.Drawing.Size(172, 70);
            this.pictureBoxToilets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxToilets.TabIndex = 2;
            this.pictureBoxToilets.TabStop = false;
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxInfo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo.Image")));
            this.pictureBoxInfo.Location = new System.Drawing.Point(3, 231);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(172, 70);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfo.TabIndex = 3;
            this.pictureBoxInfo.TabStop = false;
            // 
            // pictureBoxMeds
            // 
            this.pictureBoxMeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMeds.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMeds.Image")));
            this.pictureBoxMeds.Location = new System.Drawing.Point(3, 307);
            this.pictureBoxMeds.Name = "pictureBoxMeds";
            this.pictureBoxMeds.Size = new System.Drawing.Size(172, 71);
            this.pictureBoxMeds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMeds.TabIndex = 4;
            this.pictureBoxMeds.TabStop = false;
            // 
            // labelDrinks
            // 
            this.labelDrinks.AutoSize = true;
            this.labelDrinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDrinks.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrinks.Location = new System.Drawing.Point(181, 0);
            this.labelDrinks.Name = "labelDrinks";
            this.labelDrinks.Size = new System.Drawing.Size(176, 76);
            this.labelDrinks.TabIndex = 5;
            this.labelDrinks.Text = "Стенд питья";
            this.labelDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDrinks.Click += new System.EventHandler(this.labelDrinks_Click);
            // 
            // labelBars
            // 
            this.labelBars.AutoSize = true;
            this.labelBars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBars.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBars.Location = new System.Drawing.Point(181, 76);
            this.labelBars.Name = "labelBars";
            this.labelBars.Size = new System.Drawing.Size(176, 76);
            this.labelBars.TabIndex = 6;
            this.labelBars.Text = "Энергетические батончики";
            this.labelBars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBars.Click += new System.EventHandler(this.labelBars_Click);
            // 
            // labelToilets
            // 
            this.labelToilets.AutoSize = true;
            this.labelToilets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelToilets.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToilets.Location = new System.Drawing.Point(181, 152);
            this.labelToilets.Name = "labelToilets";
            this.labelToilets.Size = new System.Drawing.Size(176, 76);
            this.labelToilets.TabIndex = 7;
            this.labelToilets.Text = "Туалет";
            this.labelToilets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelToilets.Click += new System.EventHandler(this.labelToilets_Click);
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInformation.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInformation.Location = new System.Drawing.Point(181, 228);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(176, 76);
            this.labelInformation.TabIndex = 8;
            this.labelInformation.Text = "Информация";
            this.labelInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelInformation.Click += new System.EventHandler(this.labelInformation_Click);
            // 
            // labelMedicial
            // 
            this.labelMedicial.AutoSize = true;
            this.labelMedicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMedicial.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMedicial.Location = new System.Drawing.Point(181, 304);
            this.labelMedicial.Name = "labelMedicial";
            this.labelMedicial.Size = new System.Drawing.Size(176, 77);
            this.labelMedicial.TabIndex = 9;
            this.labelMedicial.Text = "Медицинский пункт";
            this.labelMedicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMedicial.Click += new System.EventHandler(this.labelMedicial_Click);
            // 
            // labelMoscow2023
            // 
            this.labelMoscow2023.AutoSize = true;
            this.labelMoscow2023.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoscow2023.Location = new System.Drawing.Point(80, 9);
            this.labelMoscow2023.Name = "labelMoscow2023";
            this.labelMoscow2023.Size = new System.Drawing.Size(729, 32);
            this.labelMoscow2023.TabIndex = 20;
            this.labelMoscow2023.Text = "Интерактивная карта марафона Москвы 2023";
            this.labelMoscow2023.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOne.Font = new System.Drawing.Font("Verdana", 20.75F, System.Drawing.FontStyle.Bold);
            this.buttonOne.Location = new System.Drawing.Point(239, 64);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(40, 40);
            this.buttonOne.TabIndex = 21;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonTwo.Font = new System.Drawing.Font("Verdana", 20.75F, System.Drawing.FontStyle.Bold);
            this.buttonTwo.Location = new System.Drawing.Point(346, 212);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(40, 40);
            this.buttonTwo.TabIndex = 22;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonThree.Font = new System.Drawing.Font("Verdana", 20.75F, System.Drawing.FontStyle.Bold);
            this.buttonThree.Location = new System.Drawing.Point(322, 306);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(40, 40);
            this.buttonThree.TabIndex = 23;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonFour.Font = new System.Drawing.Font("Verdana", 20.75F, System.Drawing.FontStyle.Bold);
            this.buttonFour.Location = new System.Drawing.Point(447, 440);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(40, 40);
            this.buttonFour.TabIndex = 24;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonFive.Font = new System.Drawing.Font("Verdana", 20.75F, System.Drawing.FontStyle.Bold);
            this.buttonFive.Location = new System.Drawing.Point(230, 471);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(40, 40);
            this.buttonFive.TabIndex = 25;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSix.Font = new System.Drawing.Font("Verdana", 20.75F, System.Drawing.FontStyle.Bold);
            this.buttonSix.Location = new System.Drawing.Point(119, 428);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(40, 40);
            this.buttonSix.TabIndex = 26;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSeven.Font = new System.Drawing.Font("Verdana", 20.75F, System.Drawing.FontStyle.Bold);
            this.buttonSeven.Location = new System.Drawing.Point(62, 340);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(40, 40);
            this.buttonSeven.TabIndex = 27;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEight.Font = new System.Drawing.Font("Verdana", 20.75F, System.Drawing.FontStyle.Bold);
            this.buttonEight.Location = new System.Drawing.Point(52, 184);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(40, 40);
            this.buttonEight.TabIndex = 28;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonStartTwo
            // 
            this.buttonStartTwo.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonStartTwo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartTwo.Location = new System.Drawing.Point(276, 477);
            this.buttonStartTwo.Name = "buttonStartTwo";
            this.buttonStartTwo.Size = new System.Drawing.Size(40, 40);
            this.buttonStartTwo.TabIndex = 29;
            this.buttonStartTwo.Text = "START";
            this.buttonStartTwo.UseVisualStyleBackColor = false;
            this.buttonStartTwo.Click += new System.EventHandler(this.buttonStartTwo_Click);
            // 
            // startButtonThree
            // 
            this.startButtonThree.BackColor = System.Drawing.Color.LimeGreen;
            this.startButtonThree.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButtonThree.Location = new System.Drawing.Point(62, 230);
            this.startButtonThree.Name = "startButtonThree";
            this.startButtonThree.Size = new System.Drawing.Size(40, 40);
            this.startButtonThree.TabIndex = 30;
            this.startButtonThree.Text = "START";
            this.startButtonThree.UseVisualStyleBackColor = false;
            this.startButtonThree.Click += new System.EventHandler(this.startButtonThree_Click);
            // 
            // startButton1
            // 
            this.startButton1.BackColor = System.Drawing.Color.LimeGreen;
            this.startButton1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton1.Location = new System.Drawing.Point(165, 74);
            this.startButton1.Name = "startButton1";
            this.startButton1.Size = new System.Drawing.Size(40, 40);
            this.startButton1.TabIndex = 31;
            this.startButton1.Text = "START";
            this.startButton1.UseVisualStyleBackColor = false;
            this.startButton1.Click += new System.EventHandler(this.startButton1_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFinish.BackgroundImage")));
            this.buttonFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFinish.Location = new System.Drawing.Point(110, 64);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(49, 63);
            this.buttonFinish.TabIndex = 33;
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 537);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.startButton1);
            this.Controls.Add(this.startButtonThree);
            this.Controls.Add(this.buttonStartTwo);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.labelMoscow2023);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.namePlace);
            this.Controls.Add(this.mapBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToilets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mapBox;
        private System.Windows.Forms.Label namePlace;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxDrinks;
        private System.Windows.Forms.PictureBox pictureBoxBars;
        private System.Windows.Forms.PictureBox pictureBoxToilets;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.PictureBox pictureBoxMeds;
        private System.Windows.Forms.Label labelDrinks;
        private System.Windows.Forms.Label labelBars;
        private System.Windows.Forms.Label labelToilets;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Label labelMedicial;
        private System.Windows.Forms.Label labelMoscow2023;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonStartTwo;
        private System.Windows.Forms.Button startButtonThree;
        private System.Windows.Forms.Button startButton1;
        private System.Windows.Forms.Button buttonFinish;
    }
}

