namespace notez
{
    partial class ForBusConfig
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
            groupBoxConfig = new GroupBox();
            groupBoxColors = new GroupBox();
            panelWhite = new Panel();
            panelGray = new Panel();
            panelRed = new Panel();
            panelBlack = new Panel();
            panelGreen = new Panel();
            panelPurple = new Panel();
            panelBlue = new Panel();
            panelYellow = new Panel();
            labelModifiedObject = new Label();
            labelSimpleObject = new Label();
            checkBoxSecondDoor = new CheckBox();
            checkBoxLine = new CheckBox();
            numericUpDownWeight = new NumericUpDown();
            labelWeight = new Label();
            numericUpDownSpeed = new NumericUpDown();
            labelSpeed = new Label();
            pictureBoxObject = new PictureBox();
            buttonAdd = new Button();
            buttonCancel = new Button();
            panelObject = new Panel();
            labelLeft = new Label();
            labelMiddle = new Label();
            labelRight = new Label();
            groupBoxConfig.SuspendLayout();
            groupBoxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxObject).BeginInit();
            panelObject.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxConfig
            // 
            groupBoxConfig.Controls.Add(groupBoxColors);
            groupBoxConfig.Controls.Add(labelModifiedObject);
            groupBoxConfig.Controls.Add(labelSimpleObject);
            groupBoxConfig.Controls.Add(checkBoxSecondDoor);
            groupBoxConfig.Controls.Add(checkBoxLine);
            groupBoxConfig.Controls.Add(numericUpDownWeight);
            groupBoxConfig.Controls.Add(labelWeight);
            groupBoxConfig.Controls.Add(numericUpDownSpeed);
            groupBoxConfig.Controls.Add(labelSpeed);
            groupBoxConfig.Dock = DockStyle.Left;
            groupBoxConfig.Location = new Point(0, 0);
            groupBoxConfig.Name = "groupBoxConfig";
            groupBoxConfig.Size = new Size(518, 212);
            groupBoxConfig.TabIndex = 0;
            groupBoxConfig.TabStop = false;
            groupBoxConfig.Text = "Параметры";
            // 
            // groupBoxColors
            // 
            groupBoxColors.Controls.Add(panelWhite);
            groupBoxColors.Controls.Add(panelGray);
            groupBoxColors.Controls.Add(panelRed);
            groupBoxColors.Controls.Add(panelBlack);
            groupBoxColors.Controls.Add(panelGreen);
            groupBoxColors.Controls.Add(panelPurple);
            groupBoxColors.Controls.Add(panelBlue);
            groupBoxColors.Controls.Add(panelYellow);
            groupBoxColors.Location = new Point(276, 17);
            groupBoxColors.Name = "groupBoxColors";
            groupBoxColors.Size = new Size(236, 110);
            groupBoxColors.TabIndex = 8;
            groupBoxColors.TabStop = false;
            groupBoxColors.Text = "Цвета";
            // 
            // panelWhite
            // 
            panelWhite.BackColor = Color.White;
            panelWhite.Location = new Point(6, 65);
            panelWhite.Name = "panelWhite";
            panelWhite.Size = new Size(43, 39);
            panelWhite.TabIndex = 9;
            panelWhite.MouseDown += Panel_MouseDown;
            // 
            // panelGray
            // 
            panelGray.BackColor = Color.Gray;
            panelGray.Location = new Point(63, 65);
            panelGray.Name = "panelGray";
            panelGray.Size = new Size(43, 39);
            panelGray.TabIndex = 8;
            panelGray.MouseDown += Panel_MouseDown;
            // 
            // panelRed
            // 
            panelRed.BackColor = Color.Red;
            panelRed.Location = new Point(6, 22);
            panelRed.Name = "panelRed";
            panelRed.Size = new Size(43, 39);
            panelRed.TabIndex = 5;
            panelRed.MouseDown += Panel_MouseDown;
            // 
            // panelBlack
            // 
            panelBlack.BackColor = Color.Black;
            panelBlack.Location = new Point(125, 65);
            panelBlack.Name = "panelBlack";
            panelBlack.Size = new Size(43, 39);
            panelBlack.TabIndex = 7;
            panelBlack.MouseDown += Panel_MouseDown;
            // 
            // panelGreen
            // 
            panelGreen.BackColor = Color.Green;
            panelGreen.Location = new Point(63, 22);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(43, 39);
            panelGreen.TabIndex = 4;
            panelGreen.MouseDown += Panel_MouseDown;
            // 
            // panelPurple
            // 
            panelPurple.BackColor = Color.Purple;
            panelPurple.Location = new Point(187, 65);
            panelPurple.Name = "panelPurple";
            panelPurple.Size = new Size(43, 39);
            panelPurple.TabIndex = 6;
            panelPurple.MouseDown += Panel_MouseDown;
            // 
            // panelBlue
            // 
            panelBlue.BackColor = Color.Blue;
            panelBlue.Location = new Point(125, 22);
            panelBlue.Name = "panelBlue";
            panelBlue.Size = new Size(43, 39);
            panelBlue.TabIndex = 3;
            panelBlue.MouseDown += Panel_MouseDown;
            // 
            // panelYellow
            // 
            panelYellow.BackColor = Color.Yellow;
            panelYellow.Location = new Point(187, 22);
            panelYellow.Name = "panelYellow";
            panelYellow.Size = new Size(43, 39);
            panelYellow.TabIndex = 2;
            panelYellow.MouseDown += Panel_MouseDown;
            // 
            // labelModifiedObject
            // 
            labelModifiedObject.BorderStyle = BorderStyle.FixedSingle;
            labelModifiedObject.Location = new Point(416, 169);
            labelModifiedObject.Name = "labelModifiedObject";
            labelModifiedObject.Size = new Size(96, 34);
            labelModifiedObject.TabIndex = 1;
            labelModifiedObject.Text = "Продвинутый";
            labelModifiedObject.TextAlign = ContentAlignment.MiddleCenter;
            labelModifiedObject.MouseDown += LabelObject_MouseDown;
            // 
            // labelSimpleObject
            // 
            labelSimpleObject.BorderStyle = BorderStyle.FixedSingle;
            labelSimpleObject.Location = new Point(276, 169);
            labelSimpleObject.Name = "labelSimpleObject";
            labelSimpleObject.Size = new Size(106, 34);
            labelSimpleObject.TabIndex = 0;
            labelSimpleObject.Text = "Простой";
            labelSimpleObject.TextAlign = ContentAlignment.MiddleCenter;
            labelSimpleObject.MouseDown += LabelObject_MouseDown;
            // 
            // checkBoxSecondDoor
            // 
            checkBoxSecondDoor.AutoSize = true;
            checkBoxSecondDoor.Location = new Point(12, 146);
            checkBoxSecondDoor.Name = "checkBoxSecondDoor";
            checkBoxSecondDoor.Size = new Size(158, 19);
            checkBoxSecondDoor.TabIndex = 7;
            checkBoxSecondDoor.Text = "Признак наличия двери";
            checkBoxSecondDoor.UseVisualStyleBackColor = true;
            // 
            // checkBoxLine
            // 
            checkBoxLine.AutoSize = true;
            checkBoxLine.Location = new Point(12, 108);
            checkBoxLine.Name = "checkBoxLine";
            checkBoxLine.Size = new Size(153, 19);
            checkBoxLine.TabIndex = 6;
            checkBoxLine.Text = "Признак наличия окон";
            checkBoxLine.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Location = new Point(80, 55);
            numericUpDownWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownWeight.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(52, 23);
            numericUpDownWeight.TabIndex = 5;
            numericUpDownWeight.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(29, 57);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(29, 15);
            labelWeight.TabIndex = 4;
            labelWeight.Text = "Вес:";
            // 
            // numericUpDownSpeed
            // 
            numericUpDownSpeed.Location = new Point(80, 17);
            numericUpDownSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownSpeed.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownSpeed.Name = "numericUpDownSpeed";
            numericUpDownSpeed.Size = new Size(52, 23);
            numericUpDownSpeed.TabIndex = 3;
            numericUpDownSpeed.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Location = new Point(12, 19);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(62, 15);
            labelSpeed.TabIndex = 2;
            labelSpeed.Text = "Скорость:";
            // 
            // pictureBoxObject
            // 
            pictureBoxObject.Location = new Point(3, 15);
            pictureBoxObject.Name = "pictureBoxObject";
            pictureBoxObject.Size = new Size(377, 108);
            pictureBoxObject.TabIndex = 1;
            pictureBoxObject.TabStop = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(559, 180);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(794, 180);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panelObject
            // 
            panelObject.AllowDrop = true;
            panelObject.Controls.Add(pictureBoxObject);
            panelObject.Location = new Point(524, 39);
            panelObject.Name = "panelObject";
            panelObject.Size = new Size(383, 126);
            panelObject.TabIndex = 4;
            panelObject.DragDrop += PanelObject_DragDrop;
            panelObject.DragEnter += PanelOblect_DragEnter;
            // 
            // labelLeft
            // 
            labelLeft.AllowDrop = true;
            labelLeft.BorderStyle = BorderStyle.FixedSingle;
            labelLeft.Location = new Point(565, 6);
            labelLeft.Name = "labelLeft";
            labelLeft.Size = new Size(106, 34);
            labelLeft.TabIndex = 9;
            labelLeft.Text = "Левый";
            labelLeft.TextAlign = ContentAlignment.MiddleCenter;
            labelLeft.DragDrop += LabelColor_DragDrop;
            labelLeft.DragEnter += LabelColor_DragEnter;
            // 
            // labelMiddle
            // 
            labelMiddle.AllowDrop = true;
            labelMiddle.BorderStyle = BorderStyle.FixedSingle;
            labelMiddle.Location = new Point(677, 6);
            labelMiddle.Name = "labelMiddle";
            labelMiddle.Size = new Size(106, 34);
            labelMiddle.TabIndex = 9;
            labelMiddle.Text = "Центр";
            labelMiddle.TextAlign = ContentAlignment.MiddleCenter;
            labelMiddle.DragDrop += LabelColor_DragDrop;
            labelMiddle.DragEnter += LabelColor_DragEnter;
            // 
            // labelRight
            // 
            labelRight.AllowDrop = true;
            labelRight.BorderStyle = BorderStyle.FixedSingle;
            labelRight.Location = new Point(789, 6);
            labelRight.Name = "labelRight";
            labelRight.Size = new Size(106, 34);
            labelRight.TabIndex = 10;
            labelRight.Text = "Правый";
            labelRight.TextAlign = ContentAlignment.MiddleCenter;
            labelRight.DragDrop += LabelColor_DragDrop;
            labelRight.DragEnter += LabelColor_DragEnter;
            // 
            // ForBusConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 212);
            Controls.Add(labelRight);
            Controls.Add(labelMiddle);
            Controls.Add(labelLeft);
            Controls.Add(panelObject);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(groupBoxConfig);
            Name = "ForBusConfig";
            Text = "Создания обьекта";
            groupBoxConfig.ResumeLayout(false);
            groupBoxConfig.PerformLayout();
            groupBoxColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxObject).EndInit();
            panelObject.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxConfig;
        private Label labelSimpleObject;
        private Label labelModifiedObject;
        private Label labelSpeed;
        private NumericUpDown numericUpDownSpeed;
        private NumericUpDown numericUpDownWeight;
        private Label labelWeight;
        private CheckBox checkBoxLine;
        private CheckBox checkBoxSecondDoor;
        private GroupBox groupBoxColors;
        private Panel panelYellow;
        private Panel panelWhite;
        private Panel panelGray;
        private Panel panelRed;
        private Panel panelBlack;
        private Panel panelGreen;
        private Panel panelPurple;
        private Panel panelBlue;
        private PictureBox pictureBoxObject;
        private Button buttonAdd;
        private Button buttonCancel;
        private Panel panelObject;
        private Label labelLeft;
        private Label labelMiddle;
        private Label labelRight;
    }
}