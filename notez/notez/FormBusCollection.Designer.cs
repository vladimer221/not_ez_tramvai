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
            panelCompanyTools = new Panel();
            ButtonGoToCheck = new Button();
            buttonAddBus = new Button();
            buttonRefresh = new Button();
            maskedTextBox = new MaskedTextBox();
            ButtonRemoveBus = new Button();
            buttonCreateCompany = new Button();
            panelStorage = new Panel();
            listBoxCollection = new ListBox();
            buttonCollectionDel = new Button();
            buttonCollectionAdd = new Button();
            radioButtonList = new RadioButton();
            radioButtonMassive = new RadioButton();
            textBoxCollectionName = new TextBox();
            labelCollectionName = new Label();
            comboBoxSelectorCompany = new ComboBox();
            pictureBox = new PictureBox();
            menuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            groupBoxTools.SuspendLayout();
            panelCompanyTools.SuspendLayout();
            panelStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTools
            // 
            groupBoxTools.Controls.Add(panelCompanyTools);
            groupBoxTools.Controls.Add(buttonCreateCompany);
            groupBoxTools.Controls.Add(panelStorage);
            groupBoxTools.Controls.Add(comboBoxSelectorCompany);
            groupBoxTools.Dock = DockStyle.Right;
            groupBoxTools.Location = new Point(988, 24);
            groupBoxTools.Name = "groupBoxTools";
            groupBoxTools.Size = new Size(203, 557);
            groupBoxTools.TabIndex = 0;
            groupBoxTools.TabStop = false;
            groupBoxTools.Text = "инструменты";
            // 
            // panelCompanyTools
            // 
            panelCompanyTools.Controls.Add(ButtonGoToCheck);
            panelCompanyTools.Controls.Add(buttonAddBus);
            panelCompanyTools.Controls.Add(buttonRefresh);
            panelCompanyTools.Controls.Add(maskedTextBox);
            panelCompanyTools.Controls.Add(ButtonRemoveBus);
            panelCompanyTools.Location = new Point(3, 293);
            panelCompanyTools.Name = "panelCompanyTools";
            panelCompanyTools.Size = new Size(200, 282);
            panelCompanyTools.TabIndex = 8;
            // 
            // ButtonGoToCheck
            // 
            ButtonGoToCheck.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonGoToCheck.Location = new Point(6, 186);
            ButtonGoToCheck.Name = "ButtonGoToCheck";
            ButtonGoToCheck.Size = new Size(191, 45);
            ButtonGoToCheck.TabIndex = 5;
            ButtonGoToCheck.Text = "Передать на тесты";
            ButtonGoToCheck.UseVisualStyleBackColor = true;
            ButtonGoToCheck.Click += ButtonGoToCheck_Click;
            // 
            // buttonAddBus
            // 
            buttonAddBus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonAddBus.Location = new Point(3, 3);
            buttonAddBus.Name = "buttonAddBus";
            buttonAddBus.Size = new Size(191, 45);
            buttonAddBus.TabIndex = 1;
            buttonAddBus.Text = "Добавления автобуса";
            buttonAddBus.UseVisualStyleBackColor = true;
            buttonAddBus.Click += ButtonAddBus_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonRefresh.Location = new Point(6, 237);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(191, 45);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // maskedTextBox
            // 
            maskedTextBox.CutCopyMaskFormat = MaskFormat.IncludePrompt;
            maskedTextBox.Location = new Point(3, 105);
            maskedTextBox.Mask = "00";
            maskedTextBox.Name = "maskedTextBox";
            maskedTextBox.Size = new Size(191, 23);
            maskedTextBox.TabIndex = 3;
            maskedTextBox.ValidatingType = typeof(int);
            // 
            // ButtonRemoveBus
            // 
            ButtonRemoveBus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonRemoveBus.Location = new Point(6, 134);
            ButtonRemoveBus.Name = "ButtonRemoveBus";
            ButtonRemoveBus.Size = new Size(191, 45);
            ButtonRemoveBus.TabIndex = 4;
            ButtonRemoveBus.Text = "Удаления автобуса";
            ButtonRemoveBus.UseVisualStyleBackColor = true;
            ButtonRemoveBus.Click += ButtonRemoveBus_Click;
            // 
            // buttonCreateCompany
            // 
            buttonCreateCompany.Location = new Point(6, 264);
            buttonCreateCompany.Name = "buttonCreateCompany";
            buttonCreateCompany.Size = new Size(194, 23);
            buttonCreateCompany.TabIndex = 7;
            buttonCreateCompany.Text = "Создать компанию";
            buttonCreateCompany.UseVisualStyleBackColor = true;
            buttonCreateCompany.Click += ButtonCreateCompany_Click;
            // 
            // panelStorage
            // 
            panelStorage.Controls.Add(listBoxCollection);
            panelStorage.Controls.Add(buttonCollectionDel);
            panelStorage.Controls.Add(buttonCollectionAdd);
            panelStorage.Controls.Add(radioButtonList);
            panelStorage.Controls.Add(radioButtonMassive);
            panelStorage.Controls.Add(textBoxCollectionName);
            panelStorage.Controls.Add(labelCollectionName);
            panelStorage.Dock = DockStyle.Top;
            panelStorage.Location = new Point(3, 19);
            panelStorage.Name = "panelStorage";
            panelStorage.Size = new Size(197, 214);
            panelStorage.TabIndex = 7;
            // 
            // listBoxCollection
            // 
            listBoxCollection.FormattingEnabled = true;
            listBoxCollection.ItemHeight = 15;
            listBoxCollection.Location = new Point(3, 105);
            listBoxCollection.Name = "listBoxCollection";
            listBoxCollection.Size = new Size(194, 64);
            listBoxCollection.TabIndex = 7;
            // 
            // buttonCollectionDel
            // 
            buttonCollectionDel.Location = new Point(3, 187);
            buttonCollectionDel.Name = "buttonCollectionDel";
            buttonCollectionDel.Size = new Size(194, 23);
            buttonCollectionDel.TabIndex = 6;
            buttonCollectionDel.Text = "Удалить коллекцию";
            buttonCollectionDel.UseVisualStyleBackColor = true;
            buttonCollectionDel.Click += ButtonCollectionDel_Click;
            // 
            // buttonCollectionAdd
            // 
            buttonCollectionAdd.Location = new Point(3, 76);
            buttonCollectionAdd.Name = "buttonCollectionAdd";
            buttonCollectionAdd.Size = new Size(194, 23);
            buttonCollectionAdd.TabIndex = 4;
            buttonCollectionAdd.Text = "Добавить коллекцию";
            buttonCollectionAdd.UseVisualStyleBackColor = true;
            buttonCollectionAdd.Click += ButtonCollectionAdd_Click;
            // 
            // radioButtonList
            // 
            radioButtonList.AutoSize = true;
            radioButtonList.Location = new Point(122, 51);
            radioButtonList.Name = "radioButtonList";
            radioButtonList.Size = new Size(66, 19);
            radioButtonList.TabIndex = 3;
            radioButtonList.TabStop = true;
            radioButtonList.Text = "Список";
            radioButtonList.UseVisualStyleBackColor = true;
            // 
            // radioButtonMassive
            // 
            radioButtonMassive.AutoSize = true;
            radioButtonMassive.Location = new Point(3, 51);
            radioButtonMassive.Name = "radioButtonMassive";
            radioButtonMassive.Size = new Size(67, 19);
            radioButtonMassive.TabIndex = 2;
            radioButtonMassive.TabStop = true;
            radioButtonMassive.Text = "Массив";
            radioButtonMassive.UseVisualStyleBackColor = true;
            // 
            // textBoxCollectionName
            // 
            textBoxCollectionName.Location = new Point(0, 22);
            textBoxCollectionName.Name = "textBoxCollectionName";
            textBoxCollectionName.Size = new Size(197, 23);
            textBoxCollectionName.TabIndex = 1;
            // 
            // labelCollectionName
            // 
            labelCollectionName.AutoSize = true;
            labelCollectionName.Location = new Point(36, 4);
            labelCollectionName.Name = "labelCollectionName";
            labelCollectionName.Size = new Size(125, 15);
            labelCollectionName.TabIndex = 0;
            labelCollectionName.Text = "Название коллекции:";
            // 
            // comboBoxSelectorCompany
            // 
            comboBoxSelectorCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectorCompany.FormattingEnabled = true;
            comboBoxSelectorCompany.Items.AddRange(new object[] { "Автовокзал" });
            comboBoxSelectorCompany.Location = new Point(6, 235);
            comboBoxSelectorCompany.Name = "comboBoxSelectorCompany";
            comboBoxSelectorCompany.Size = new Size(194, 23);
            comboBoxSelectorCompany.TabIndex = 0;
            comboBoxSelectorCompany.SelectedIndexChanged += ComboBoxSelectorCompany_SelectedindexChanged;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 24);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(988, 557);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1191, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(181, 22);
            saveToolStripMenuItem.Text = "Сохранение";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            loadToolStripMenuItem.Size = new Size(181, 22);
            loadToolStripMenuItem.Text = "Загрузка";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "txt file | *.txt";
            // 
            // FormBusCollection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 581);
            Controls.Add(pictureBox);
            Controls.Add(groupBoxTools);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormBusCollection";
            Text = "Коллекция автобусов ";
            groupBoxTools.ResumeLayout(false);
            panelCompanyTools.ResumeLayout(false);
            panelCompanyTools.PerformLayout();
            panelStorage.ResumeLayout(false);
            panelStorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTools;
        private ComboBox comboBoxSelectorCompany;
        private Button buttonAddBus;
        private Button ButtonRemoveBus;
        private MaskedTextBox maskedTextBox;
        private PictureBox pictureBox;
        private Button buttonRefresh;
        private Button ButtonGoToCheck;
        private Panel panelStorage;
        private TextBox textBoxCollectionName;
        private Label labelCollectionName;
        private RadioButton radioButtonList;
        private RadioButton radioButtonMassive;
        private Button buttonCollectionAdd;
        private Button buttonCollectionDel;
        private Button buttonCreateCompany;
        private Panel panelCompanyTools;
        private ListBox listBoxCollection;
        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
    }
}