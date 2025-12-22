namespace Tyuiu.KadralinovaAT.Sprint7.Project.V7
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_KAT = new Panel();
            buttonGuide_KAT = new Button();
            buttonHelp_KAT = new Button();
            buttonDone_KAT = new Button();
            buttonSaveFile_KAT = new Button();
            buttonOpenFile_KAT = new Button();
            labelSearch_KAT = new Label();
            labelSort_KAT = new Label();
            textBoxSearch_KAT = new TextBox();
            buttonSearch_KAT = new Button();
            buttonSortS_KAT = new Button();
            buttonSortRoom_KAT = new Button();
            panelLeft_KAT = new Panel();
            labelHead_KAT = new Label();
            comboBoxFilter_KAT = new ComboBox();
            textBoxMedium_KAT = new TextBox();
            textBoxMAX_KAT = new TextBox();
            textBoxMIN_KAT = new TextBox();
            buttonSortChild_KAT = new Button();
            buttonGraphic_KAT = new Button();
            buttonAddStr_KAT = new Button();
            buttonMedium_KAT = new Button();
            buttonMAX_KAT = new Button();
            buttonStartFilter_KAT = new Button();
            buttonMIN_KAT = new Button();
            buttonStopFilter_KAT = new Button();
            panelDataGrid_KAT = new Panel();
            dataGridViewTab_KAT = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panelChart_KAT = new Panel();
            chartGrafic_KAT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            openFileDialog_KAT = new OpenFileDialog();
            SaveFileDialog_KAT = new SaveFileDialog();
            toolTip_KAT = new ToolTip(components);
            panelTop_KAT.SuspendLayout();
            panelLeft_KAT.SuspendLayout();
            panelDataGrid_KAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTab_KAT).BeginInit();
            panelChart_KAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGrafic_KAT).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KAT
            // 
            panelTop_KAT.Controls.Add(buttonGuide_KAT);
            panelTop_KAT.Controls.Add(buttonHelp_KAT);
            panelTop_KAT.Controls.Add(buttonDone_KAT);
            panelTop_KAT.Controls.Add(buttonSaveFile_KAT);
            panelTop_KAT.Controls.Add(buttonOpenFile_KAT);
            panelTop_KAT.Dock = DockStyle.Top;
            panelTop_KAT.Location = new Point(0, 0);
            panelTop_KAT.Name = "panelTop_KAT";
            panelTop_KAT.Size = new Size(1482, 80);
            panelTop_KAT.TabIndex = 0;
            // 
            // buttonGuide_KAT
            // 
            buttonGuide_KAT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonGuide_KAT.BackColor = SystemColors.ButtonFace;
            buttonGuide_KAT.Image = Properties.Resources.letter_i1;
            buttonGuide_KAT.Location = new Point(1239, 0);
            buttonGuide_KAT.Name = "buttonGuide_KAT";
            buttonGuide_KAT.Size = new Size(117, 80);
            buttonGuide_KAT.TabIndex = 0;
            toolTip_KAT.SetToolTip(buttonGuide_KAT, "Краткое руководство пользователя");
            buttonGuide_KAT.UseVisualStyleBackColor = false;
            buttonGuide_KAT.Click += buttonGuide_KAT_Click;
            buttonGuide_KAT.MouseEnter += buttonGuide_KAT_MouseEnter;
            // 
            // buttonHelp_KAT
            // 
            buttonHelp_KAT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KAT.BackColor = SystemColors.ButtonFace;
            buttonHelp_KAT.Image = Properties.Resources.help__1_;
            buttonHelp_KAT.Location = new Point(1362, 0);
            buttonHelp_KAT.Name = "buttonHelp_KAT";
            buttonHelp_KAT.Size = new Size(117, 80);
            buttonHelp_KAT.TabIndex = 0;
            toolTip_KAT.SetToolTip(buttonHelp_KAT, "О программе");
            buttonHelp_KAT.UseVisualStyleBackColor = false;
            buttonHelp_KAT.Click += buttonHelp_KAT_Click;
            buttonHelp_KAT.MouseEnter += buttonHelp_KAT_MouseEnter;
            // 
            // buttonDone_KAT
            // 
            buttonDone_KAT.BackColor = SystemColors.ButtonFace;
            buttonDone_KAT.Enabled = false;
            buttonDone_KAT.FlatStyle = FlatStyle.Flat;
            buttonDone_KAT.Image = Properties.Resources.check;
            buttonDone_KAT.Location = new Point(246, 0);
            buttonDone_KAT.Name = "buttonDone_KAT";
            buttonDone_KAT.Size = new Size(117, 80);
            buttonDone_KAT.TabIndex = 0;
            toolTip_KAT.SetToolTip(buttonDone_KAT, "Выполнить обработку данных");
            buttonDone_KAT.UseVisualStyleBackColor = false;
            buttonDone_KAT.Click += buttonDone_KAT_Click;
            buttonDone_KAT.MouseEnter += buttonDone_KAT_MouseEnter;
            // 
            // buttonSaveFile_KAT
            // 
            buttonSaveFile_KAT.BackColor = SystemColors.ButtonFace;
            buttonSaveFile_KAT.Enabled = false;
            buttonSaveFile_KAT.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_KAT.Image = Properties.Resources.diskette;
            buttonSaveFile_KAT.Location = new Point(123, 0);
            buttonSaveFile_KAT.Name = "buttonSaveFile_KAT";
            buttonSaveFile_KAT.Size = new Size(117, 80);
            buttonSaveFile_KAT.TabIndex = 0;
            toolTip_KAT.SetToolTip(buttonSaveFile_KAT, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_KAT.UseVisualStyleBackColor = false;
            buttonSaveFile_KAT.Click += buttonSaveFile_KAT_Click;
            buttonSaveFile_KAT.MouseEnter += buttonSaveFile_KAT_MouseEnter;
            // 
            // buttonOpenFile_KAT
            // 
            buttonOpenFile_KAT.BackColor = SystemColors.ButtonFace;
            buttonOpenFile_KAT.Image = Properties.Resources.open__2_;
            buttonOpenFile_KAT.Location = new Point(0, 0);
            buttonOpenFile_KAT.Name = "buttonOpenFile_KAT";
            buttonOpenFile_KAT.Size = new Size(117, 80);
            buttonOpenFile_KAT.TabIndex = 0;
            toolTip_KAT.SetToolTip(buttonOpenFile_KAT, "Открыть файл для обработки данных в формате CSV");
            buttonOpenFile_KAT.UseVisualStyleBackColor = false;
            buttonOpenFile_KAT.Click += buttonOpenFile_KAT_Click;
            buttonOpenFile_KAT.MouseEnter += buttonOpenFile_KAT_MouseEnter;
            // 
            // labelSearch_KAT
            // 
            labelSearch_KAT.AutoSize = true;
            labelSearch_KAT.Location = new Point(12, 134);
            labelSearch_KAT.Name = "labelSearch_KAT";
            labelSearch_KAT.Size = new Size(52, 20);
            labelSearch_KAT.TabIndex = 0;
            labelSearch_KAT.Text = "Поиск";
            // 
            // labelSort_KAT
            // 
            labelSort_KAT.AutoSize = true;
            labelSort_KAT.Location = new Point(99, 181);
            labelSort_KAT.Name = "labelSort_KAT";
            labelSort_KAT.Size = new Size(121, 20);
            labelSort_KAT.TabIndex = 0;
            labelSort_KAT.Text = "Сортировать по";
            // 
            // textBoxSearch_KAT
            // 
            textBoxSearch_KAT.Location = new Point(70, 131);
            textBoxSearch_KAT.Name = "textBoxSearch_KAT";
            textBoxSearch_KAT.Size = new Size(182, 27);
            textBoxSearch_KAT.TabIndex = 1;
            // 
            // buttonSearch_KAT
            // 
            buttonSearch_KAT.Image = Properties.Resources.search;
            buttonSearch_KAT.Location = new Point(264, 131);
            buttonSearch_KAT.Name = "buttonSearch_KAT";
            buttonSearch_KAT.Size = new Size(52, 29);
            buttonSearch_KAT.TabIndex = 2;
            toolTip_KAT.SetToolTip(buttonSearch_KAT, "Выполняет поиск заданных значений");
            buttonSearch_KAT.UseVisualStyleBackColor = true;
            buttonSearch_KAT.Click += buttonSearch_KAT_Click;
            // 
            // buttonSortS_KAT
            // 
            buttonSortS_KAT.Location = new Point(12, 216);
            buttonSortS_KAT.Name = "buttonSortS_KAT";
            buttonSortS_KAT.Size = new Size(93, 65);
            buttonSortS_KAT.TabIndex = 3;
            buttonSortS_KAT.Text = "Общая \r\nплощадь";
            toolTip_KAT.SetToolTip(buttonSortS_KAT, "Сортирует таблицу по общей площади");
            buttonSortS_KAT.UseVisualStyleBackColor = true;
            buttonSortS_KAT.Click += buttonSortS_KAT_Click;
            // 
            // buttonSortRoom_KAT
            // 
            buttonSortRoom_KAT.Location = new Point(108, 216);
            buttonSortRoom_KAT.Name = "buttonSortRoom_KAT";
            buttonSortRoom_KAT.Size = new Size(103, 65);
            buttonSortRoom_KAT.TabIndex = 3;
            buttonSortRoom_KAT.Text = "Количество комнат";
            toolTip_KAT.SetToolTip(buttonSortRoom_KAT, "Сортирует таблицу по количеству комнат");
            buttonSortRoom_KAT.UseVisualStyleBackColor = true;
            buttonSortRoom_KAT.Click += buttonSortRoom_KAT_Click;
            // 
            // panelLeft_KAT
            // 
            panelLeft_KAT.Controls.Add(labelHead_KAT);
            panelLeft_KAT.Controls.Add(comboBoxFilter_KAT);
            panelLeft_KAT.Controls.Add(textBoxMedium_KAT);
            panelLeft_KAT.Controls.Add(textBoxMAX_KAT);
            panelLeft_KAT.Controls.Add(textBoxMIN_KAT);
            panelLeft_KAT.Controls.Add(buttonSortChild_KAT);
            panelLeft_KAT.Controls.Add(buttonSortRoom_KAT);
            panelLeft_KAT.Controls.Add(buttonGraphic_KAT);
            panelLeft_KAT.Controls.Add(buttonAddStr_KAT);
            panelLeft_KAT.Controls.Add(buttonMedium_KAT);
            panelLeft_KAT.Controls.Add(buttonMAX_KAT);
            panelLeft_KAT.Controls.Add(buttonStartFilter_KAT);
            panelLeft_KAT.Controls.Add(buttonMIN_KAT);
            panelLeft_KAT.Controls.Add(buttonStopFilter_KAT);
            panelLeft_KAT.Controls.Add(buttonSortS_KAT);
            panelLeft_KAT.Controls.Add(buttonSearch_KAT);
            panelLeft_KAT.Controls.Add(textBoxSearch_KAT);
            panelLeft_KAT.Controls.Add(labelSort_KAT);
            panelLeft_KAT.Controls.Add(labelSearch_KAT);
            panelLeft_KAT.Dock = DockStyle.Left;
            panelLeft_KAT.Location = new Point(0, 80);
            panelLeft_KAT.Name = "panelLeft_KAT";
            panelLeft_KAT.Size = new Size(328, 823);
            panelLeft_KAT.TabIndex = 1;
            // 
            // labelHead_KAT
            // 
            labelHead_KAT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelHead_KAT.ForeColor = SystemColors.HotTrack;
            labelHead_KAT.Location = new Point(51, 14);
            labelHead_KAT.Name = "labelHead_KAT";
            labelHead_KAT.Size = new Size(217, 103);
            labelHead_KAT.TabIndex = 6;
            labelHead_KAT.Text = "Добро пожаловать!\r\nДомоуправление \"Уютный Квартал\"";
            labelHead_KAT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxFilter_KAT
            // 
            comboBoxFilter_KAT.FormattingEnabled = true;
            comboBoxFilter_KAT.Items.AddRange(new object[] { "Да", "Нет" });
            comboBoxFilter_KAT.Location = new Point(196, 311);
            comboBoxFilter_KAT.Name = "comboBoxFilter_KAT";
            comboBoxFilter_KAT.Size = new Size(120, 28);
            comboBoxFilter_KAT.TabIndex = 5;
            // 
            // textBoxMedium_KAT
            // 
            textBoxMedium_KAT.Location = new Point(200, 570);
            textBoxMedium_KAT.Multiline = true;
            textBoxMedium_KAT.Name = "textBoxMedium_KAT";
            textBoxMedium_KAT.ReadOnly = true;
            textBoxMedium_KAT.Size = new Size(116, 67);
            textBoxMedium_KAT.TabIndex = 4;
            // 
            // textBoxMAX_KAT
            // 
            textBoxMAX_KAT.Location = new Point(200, 497);
            textBoxMAX_KAT.Multiline = true;
            textBoxMAX_KAT.Name = "textBoxMAX_KAT";
            textBoxMAX_KAT.ReadOnly = true;
            textBoxMAX_KAT.Size = new Size(116, 67);
            textBoxMAX_KAT.TabIndex = 4;
            // 
            // textBoxMIN_KAT
            // 
            textBoxMIN_KAT.Location = new Point(200, 424);
            textBoxMIN_KAT.Multiline = true;
            textBoxMIN_KAT.Name = "textBoxMIN_KAT";
            textBoxMIN_KAT.ReadOnly = true;
            textBoxMIN_KAT.Size = new Size(116, 67);
            textBoxMIN_KAT.TabIndex = 4;
            // 
            // buttonSortChild_KAT
            // 
            buttonSortChild_KAT.Location = new Point(213, 216);
            buttonSortChild_KAT.Name = "buttonSortChild_KAT";
            buttonSortChild_KAT.Size = new Size(103, 65);
            buttonSortChild_KAT.TabIndex = 3;
            buttonSortChild_KAT.Text = "Количество детей";
            toolTip_KAT.SetToolTip(buttonSortChild_KAT, "Сортирует таблицу по количеству детей");
            buttonSortChild_KAT.UseVisualStyleBackColor = true;
            buttonSortChild_KAT.Click += buttonSortChild_KAT_Click;
            // 
            // buttonGraphic_KAT
            // 
            buttonGraphic_KAT.Location = new Point(12, 662);
            buttonGraphic_KAT.Name = "buttonGraphic_KAT";
            buttonGraphic_KAT.Size = new Size(304, 67);
            buttonGraphic_KAT.TabIndex = 3;
            buttonGraphic_KAT.Text = "График общей площади";
            toolTip_KAT.SetToolTip(buttonGraphic_KAT, "Выводит график общей площади");
            buttonGraphic_KAT.UseVisualStyleBackColor = true;
            buttonGraphic_KAT.Click += buttonGraphic_KAT_Click;
            // 
            // buttonAddStr_KAT
            // 
            buttonAddStr_KAT.Location = new Point(12, 744);
            buttonAddStr_KAT.Name = "buttonAddStr_KAT";
            buttonAddStr_KAT.Size = new Size(304, 67);
            buttonAddStr_KAT.TabIndex = 3;
            buttonAddStr_KAT.Text = "Добавить новую строку";
            toolTip_KAT.SetToolTip(buttonAddStr_KAT, "Открывает окно с добавлением новых данных о жителях.");
            buttonAddStr_KAT.UseVisualStyleBackColor = true;
            buttonAddStr_KAT.Click += buttonAddStr_KAT_Click;
            // 
            // buttonMedium_KAT
            // 
            buttonMedium_KAT.Location = new Point(12, 570);
            buttonMedium_KAT.Name = "buttonMedium_KAT";
            buttonMedium_KAT.Size = new Size(178, 67);
            buttonMedium_KAT.TabIndex = 3;
            buttonMedium_KAT.Text = "Найти среднее значение площади";
            toolTip_KAT.SetToolTip(buttonMedium_KAT, "Находит среднее значение всех площадей");
            buttonMedium_KAT.UseVisualStyleBackColor = true;
            buttonMedium_KAT.Click += buttonMedium_KAT_Click;
            // 
            // buttonMAX_KAT
            // 
            buttonMAX_KAT.Location = new Point(12, 497);
            buttonMAX_KAT.Name = "buttonMAX_KAT";
            buttonMAX_KAT.Size = new Size(178, 67);
            buttonMAX_KAT.TabIndex = 3;
            buttonMAX_KAT.Text = "Найти максимальную площадь";
            toolTip_KAT.SetToolTip(buttonMAX_KAT, "Находит максимальную площадь среди всех площадей");
            buttonMAX_KAT.UseVisualStyleBackColor = true;
            buttonMAX_KAT.Click += buttonMAX_KAT_Click;
            // 
            // buttonStartFilter_KAT
            // 
            buttonStartFilter_KAT.Location = new Point(12, 300);
            buttonStartFilter_KAT.Name = "buttonStartFilter_KAT";
            buttonStartFilter_KAT.Size = new Size(178, 48);
            buttonStartFilter_KAT.TabIndex = 3;
            buttonStartFilter_KAT.Text = "Фильтровать по задолженности";
            toolTip_KAT.SetToolTip(buttonStartFilter_KAT, "Фильтрует таблицу по наличии задолженности");
            buttonStartFilter_KAT.UseVisualStyleBackColor = true;
            buttonStartFilter_KAT.Click += buttonStartFilter_KAT_Click;
            // 
            // buttonMIN_KAT
            // 
            buttonMIN_KAT.Location = new Point(12, 424);
            buttonMIN_KAT.Name = "buttonMIN_KAT";
            buttonMIN_KAT.Size = new Size(178, 67);
            buttonMIN_KAT.TabIndex = 3;
            buttonMIN_KAT.Text = "Найти минимальную площадь";
            toolTip_KAT.SetToolTip(buttonMIN_KAT, "Находит минимальную площадь среди всех площадей");
            buttonMIN_KAT.UseVisualStyleBackColor = true;
            buttonMIN_KAT.Click += buttonMIN_KAT_Click;
            // 
            // buttonStopFilter_KAT
            // 
            buttonStopFilter_KAT.Location = new Point(12, 354);
            buttonStopFilter_KAT.Name = "buttonStopFilter_KAT";
            buttonStopFilter_KAT.Size = new Size(304, 46);
            buttonStopFilter_KAT.TabIndex = 3;
            buttonStopFilter_KAT.Text = "Сброс фильтра";
            toolTip_KAT.SetToolTip(buttonStopFilter_KAT, "Сбрасывает фильтр, возвращает изначальную таблицу");
            buttonStopFilter_KAT.UseVisualStyleBackColor = true;
            buttonStopFilter_KAT.Click += buttonStopFilter_KAT_Click;
            // 
            // panelDataGrid_KAT
            // 
            panelDataGrid_KAT.Controls.Add(dataGridViewTab_KAT);
            panelDataGrid_KAT.Dock = DockStyle.Top;
            panelDataGrid_KAT.Location = new Point(328, 80);
            panelDataGrid_KAT.Name = "panelDataGrid_KAT";
            panelDataGrid_KAT.Size = new Size(1154, 450);
            panelDataGrid_KAT.TabIndex = 2;
            // 
            // dataGridViewTab_KAT
            // 
            dataGridViewTab_KAT.AllowUserToAddRows = false;
            dataGridViewTab_KAT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTab_KAT.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewTab_KAT.Dock = DockStyle.Fill;
            dataGridViewTab_KAT.Location = new Point(0, 0);
            dataGridViewTab_KAT.Name = "dataGridViewTab_KAT";
            dataGridViewTab_KAT.RowHeadersVisible = false;
            dataGridViewTab_KAT.RowHeadersWidth = 51;
            dataGridViewTab_KAT.Size = new Size(1154, 450);
            dataGridViewTab_KAT.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Номер подъезда";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 190;
            // 
            // Column2
            // 
            Column2.HeaderText = "Номер квартиры";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 190;
            // 
            // Column3
            // 
            Column3.HeaderText = "Количество комнат";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 190;
            // 
            // Column4
            // 
            Column4.HeaderText = "Общая площадь";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Есть ли задолженность";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 190;
            // 
            // Column6
            // 
            Column6.HeaderText = "Количество детей";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 191;
            // 
            // panelChart_KAT
            // 
            panelChart_KAT.Controls.Add(chartGrafic_KAT);
            panelChart_KAT.Dock = DockStyle.Fill;
            panelChart_KAT.Location = new Point(328, 530);
            panelChart_KAT.Name = "panelChart_KAT";
            panelChart_KAT.Size = new Size(1154, 373);
            panelChart_KAT.TabIndex = 3;
            // 
            // chartGrafic_KAT
            // 
            chartArea1.Name = "ChartArea1";
            chartGrafic_KAT.ChartAreas.Add(chartArea1);
            chartGrafic_KAT.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartGrafic_KAT.Legends.Add(legend1);
            chartGrafic_KAT.Location = new Point(0, 0);
            chartGrafic_KAT.Name = "chartGrafic_KAT";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGrafic_KAT.Series.Add(series1);
            chartGrafic_KAT.Size = new Size(1154, 373);
            chartGrafic_KAT.TabIndex = 0;
            chartGrafic_KAT.Text = "chart1";
            // 
            // openFileDialog_KAT
            // 
            openFileDialog_KAT.FileName = "openFileDialog_KAT";
            // 
            // toolTip_KAT
            // 
            toolTip_KAT.IsBalloon = true;
            toolTip_KAT.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 903);
            Controls.Add(panelChart_KAT);
            Controls.Add(panelDataGrid_KAT);
            Controls.Add(panelLeft_KAT);
            Controls.Add(panelTop_KAT);
            MinimumSize = new Size(1000, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Домоуправление";
            panelTop_KAT.ResumeLayout(false);
            panelLeft_KAT.ResumeLayout(false);
            panelLeft_KAT.PerformLayout();
            panelDataGrid_KAT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTab_KAT).EndInit();
            panelChart_KAT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGrafic_KAT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KAT;
        private Button buttonGuide_KAT;
        private Button buttonHelp_KAT;
        private Button buttonSaveFile_KAT;
        private Button buttonOpenFile_KAT;
        private Label labelSearch_KAT;
        private Label labelSort_KAT;
        private TextBox textBoxSearch_KAT;
        private Button buttonSearch_KAT;
        private Button buttonSortS_KAT;
        private Button buttonSortRoom_KAT;
        private Panel panelLeft_KAT;
        private Button buttonMedium_KAT;
        private Button buttonMAX_KAT;
        private Button buttonStartFilter_KAT;
        private Button buttonMIN_KAT;
        private Button buttonStopFilter_KAT;
        private TextBox textBoxMedium_KAT;
        private TextBox textBoxMAX_KAT;
        private TextBox textBoxMIN_KAT;
        private ComboBox comboBoxFilter_KAT;
        private Button buttonGraphic_KAT;
        private Label labelHead_KAT;
        private Panel panelDataGrid_KAT;
        public DataGridView dataGridViewTab_KAT;
        private Panel panelChart_KAT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrafic_KAT;
        private ToolTip toolTip_KAT;
        private OpenFileDialog openFileDialog_KAT;
        private SaveFileDialog SaveFileDialog_KAT;
        private Button buttonDone_KAT;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button buttonSortChild_KAT;
        private Button buttonAddStr_KAT;

    }
}
