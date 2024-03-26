namespace notez
{
    partial class Formbus
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
            pictureBoxBus = new PictureBox();
            buttonUp = new Button();
            buttonLeft = new Button();
            buttonDown = new Button();
            buttonRight = new Button();
            comboBoxStrategy = new ComboBox();
            buttonStrategyStep = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBus).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxBus
            // 
            pictureBoxBus.Dock = DockStyle.Fill;
            pictureBoxBus.Location = new Point(0, 0);
            pictureBoxBus.Name = "pictureBoxBus";
            pictureBoxBus.Size = new Size(1104, 467);
            pictureBoxBus.TabIndex = 0;
            pictureBoxBus.TabStop = false;
            // 
            // buttonUp
            // 
            buttonUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUp.BackgroundImage = Properties.Resources.photo_2024_03_20_02_09_00;
            buttonUp.BackgroundImageLayout = ImageLayout.Stretch;
            buttonUp.Location = new Point(1016, 372);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(35, 35);
            buttonUp.TabIndex = 2;
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += ButtonMove_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLeft.BackgroundImage = Properties.Resources.asdleft;
            buttonLeft.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLeft.Location = new Point(975, 413);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(35, 35);
            buttonLeft.TabIndex = 3;
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += ButtonMove_Click;
            // 
            // buttonDown
            // 
            buttonDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDown.BackgroundImage = Properties.Resources.asdDOWN;
            buttonDown.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDown.Location = new Point(1016, 413);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(35, 35);
            buttonDown.TabIndex = 4;
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += ButtonMove_Click;
            // 
            // buttonRight
            // 
            buttonRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRight.BackgroundImage = Properties.Resources.asdright;
            buttonRight.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRight.Location = new Point(1057, 413);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(35, 35);
            buttonRight.TabIndex = 5;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += ButtonMove_Click;
            // 
            // comboBoxStrategy
            // 
            comboBoxStrategy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStrategy.FormattingEnabled = true;
            comboBoxStrategy.Items.AddRange(new object[] { "К центру", "К краю" });
            comboBoxStrategy.Location = new Point(971, 12);
            comboBoxStrategy.Name = "comboBoxStrategy";
            comboBoxStrategy.Size = new Size(121, 23);
            comboBoxStrategy.TabIndex = 7;
            // 
            // buttonStrategyStep
            // 
            buttonStrategyStep.Location = new Point(1012, 41);
            buttonStrategyStep.Name = "buttonStrategyStep";
            buttonStrategyStep.Size = new Size(80, 30);
            buttonStrategyStep.TabIndex = 8;
            buttonStrategyStep.Text = "Шаг";
            buttonStrategyStep.UseVisualStyleBackColor = true;
            buttonStrategyStep.Click += buttonStrategyStep_Click;
            // 
            // Formbus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 467);
            Controls.Add(buttonStrategyStep);
            Controls.Add(comboBoxStrategy);
            Controls.Add(buttonRight);
            Controls.Add(buttonDown);
            Controls.Add(buttonLeft);
            Controls.Add(buttonUp);
            Controls.Add(pictureBoxBus);
            Name = "Formbus";
            Text = "Автобус";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxBus;
        private Button buttonUp;
        private Button buttonLeft;
        private Button buttonDown;
        private Button buttonRight;
        private ComboBox comboBoxStrategy;
        private Button buttonStrategyStep;
    }
}