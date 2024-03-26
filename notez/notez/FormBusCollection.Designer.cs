namespace notez
{
    partial class FormBusCollection
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
            groupBoxTools = new GroupBox();
            buttonRefresh = new Button();
            ButtonGoToCheck = new Button();
            ButtonRemoveBus = new Button();
            maskedTextBox = new MaskedTextBox();
            buttonTramvaiBus = new Button();
            buttonAddBus = new Button();
            comboBoxSelectorCompany = new ComboBox();
            pictureBox = new PictureBox();
            groupBoxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTools
            // 
            groupBoxTools.Controls.Add(buttonRefresh);
            groupBoxTools.Controls.Add(ButtonGoToCheck);
            groupBoxTools.Controls.Add(ButtonRemoveBus);
            groupBoxTools.Controls.Add(maskedTextBox);
            groupBoxTools.Controls.Add(buttonTramvaiBus);
            groupBoxTools.Controls.Add(buttonAddBus);
            groupBoxTools.Controls.Add(comboBoxSelectorCompany);
            groupBoxTools.Dock = DockStyle.Right;
            groupBoxTools.Location = new Point(754, 0);
            groupBoxTools.Name = "groupBoxTools";
            groupBoxTools.Size = new Size(203, 486);
            groupBoxTools.TabIndex = 0;
            groupBoxTools.TabStop = false;
            groupBoxTools.Text = "инструменты";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonRefresh.Location = new Point(6, 413);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(191, 45);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // ButtonGoToCheck
            // 
            ButtonGoToCheck.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonGoToCheck.Location = new Point(6, 313);
            ButtonGoToCheck.Name = "ButtonGoToCheck";
            ButtonGoToCheck.Size = new Size(191, 45);
            ButtonGoToCheck.TabIndex = 5;
            ButtonGoToCheck.Text = "Передать на тесты";
            ButtonGoToCheck.UseVisualStyleBackColor = true;
            ButtonGoToCheck.Click += ButtonGoToCheck_Click;
            // 
            // ButtonRemoveBus
            // 
            ButtonRemoveBus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonRemoveBus.Location = new Point(6, 222);
            ButtonRemoveBus.Name = "ButtonRemoveBus";
            ButtonRemoveBus.Size = new Size(191, 45);
            ButtonRemoveBus.TabIndex = 4;
            ButtonRemoveBus.Text = "Удаления автобуса";
            ButtonRemoveBus.UseVisualStyleBackColor = true;
            ButtonRemoveBus.Click += ButtonRemoveBus_Click;
            // 
            // maskedTextBox
            // 
            maskedTextBox.CutCopyMaskFormat = MaskFormat.IncludePrompt;
            maskedTextBox.Location = new Point(6, 193);
            maskedTextBox.Mask = "00";
            maskedTextBox.Name = "maskedTextBox";
            maskedTextBox.Size = new Size(191, 23);
            maskedTextBox.TabIndex = 3;
            maskedTextBox.ValidatingType = typeof(int);
            // 
            // buttonTramvaiBus
            // 
            buttonTramvaiBus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonTramvaiBus.Location = new Point(6, 128);
            buttonTramvaiBus.Name = "buttonTramvaiBus";
            buttonTramvaiBus.Size = new Size(191, 45);
            buttonTramvaiBus.TabIndex = 2;
            buttonTramvaiBus.Text = "Добавления автобуса с гармошкой";
            buttonTramvaiBus.UseVisualStyleBackColor = true;
            buttonTramvaiBus.Click += ButtonTramvaiBus_Click;
            // 
            // buttonAddBus
            // 
            buttonAddBus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAddBus.Location = new Point(6, 77);
            buttonAddBus.Name = "buttonAddBus";
            buttonAddBus.Size = new Size(191, 45);
            buttonAddBus.TabIndex = 1;
            buttonAddBus.Text = "Добавления автобуса";
            buttonAddBus.UseVisualStyleBackColor = true;
            buttonAddBus.Click += ButtonAddBus_Click;
            // 
            // comboBoxSelectorCompany
            // 
            comboBoxSelectorCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectorCompany.FormattingEnabled = true;
            comboBoxSelectorCompany.Items.AddRange(new object[] { "Автовокзал" });
            comboBoxSelectorCompany.Location = new Point(6, 22);
            comboBoxSelectorCompany.Name = "comboBoxSelectorCompany";
            comboBoxSelectorCompany.Size = new Size(191, 23);
            comboBoxSelectorCompany.TabIndex = 0;
            comboBoxSelectorCompany.SelectedIndexChanged += ComboBoxSelectorCompany_SelectedindexChanged;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(754, 486);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // FormBusCollection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 486);
            Controls.Add(pictureBox);
            Controls.Add(groupBoxTools);
            Name = "FormBusCollection";
            Text = "Коллекция автобусов ";
            groupBoxTools.ResumeLayout(false);
            groupBoxTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTools;
        private ComboBox comboBoxSelectorCompany;
        private Button buttonAddBus;
        private Button ButtonRemoveBus;
        private MaskedTextBox maskedTextBox;
        private Button buttonTramvaiBus;
        private PictureBox pictureBox;
        private Button buttonRefresh;
        private Button ButtonGoToCheck;
    }
}