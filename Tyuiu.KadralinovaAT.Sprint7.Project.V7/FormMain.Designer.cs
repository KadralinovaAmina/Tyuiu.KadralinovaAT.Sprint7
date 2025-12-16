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
            buttonGraphic_KAT = new Button();
            buttonMedium_KAT = new Button();
            buttonMAX_KAT = new Button();
            buttonStartFilter_KAT = new Button();
            buttonMIN_KAT = new Button();
            buttonStopFilter_KAT = new Button();
            panelDataGrid_KAT = new Panel();
            dataGridViewTab_KAT = new DataGridView();
            panelChart_KAT = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            openFileDialog_KAT = new OpenFileDialog();
            saveFileDialog_KAT = new SaveFileDialog();
            toolTip_KAT = new ToolTip(components);
            panelTop_KAT.SuspendLayout();
            panelLeft_KAT.SuspendLayout();
            panelDataGrid_KAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTab_KAT).BeginInit();
            panelChart_KAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
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
            // 
            // buttonDone_KAT
            // 
            buttonDone_KAT.BackColor = SystemColors.ButtonFace;
            buttonDone_KAT.FlatStyle = FlatStyle.Flat;
            buttonDone_KAT.Image = Properties.Resources.check;
            buttonDone_KAT.Location = new Point(246, 0);
            buttonDone_KAT.Name = "buttonDone_KAT";
            buttonDone_KAT.Size = new Size(117, 80);
            buttonDone_KAT.TabIndex = 0;
            toolTip_KAT.SetToolTip(buttonDone_KAT, "Выполнить обработку данных");
            buttonDone_KAT.UseVisualStyleBackColor = false;
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
            // 
            // labelSearch_KAT
            // 
            labelSearch_KAT.AutoSize = true;
            labelSearch_KAT.Location = new Point(12, 156);
            labelSearch_KAT.Name = "labelSearch_KAT";
            labelSearch_KAT.Size = new Size(52, 20);
            labelSearch_KAT.TabIndex = 0;
            labelSearch_KAT.Text = "Поиск";
            // 
            // labelSort_KAT
            // 
            labelSort_KAT.AutoSize = true;
            labelSort_KAT.Location = new Point(99, 203);
            labelSort_KAT.Name = "labelSort_KAT";
            labelSort_KAT.Size = new Size(121, 20);
            labelSort_KAT.TabIndex = 0;
            labelSort_KAT.Text = "Сортировать по";
            // 
            // textBoxSearch_KAT
            // 
            textBoxSearch_KAT.Location = new Point(70, 153);
            textBoxSearch_KAT.Name = "textBoxSearch_KAT";
            textBoxSearch_KAT.Size = new Size(182, 27);
            textBoxSearch_KAT.TabIndex = 1;
            // 
            // buttonSearch_KAT
            // 
            buttonSearch_KAT.Image = Properties.Resources.search;
            buttonSearch_KAT.Location = new Point(264, 153);
            buttonSearch_KAT.Name = "buttonSearch_KAT";
            buttonSearch_KAT.Size = new Size(52, 29);
            buttonSearch_KAT.TabIndex = 2;
            buttonSearch_KAT.UseVisualStyleBackColor = true;
            // 
            // buttonSortS_KAT
            // 
            buttonSortS_KAT.Location = new Point(12, 238);
            buttonSortS_KAT.Name = "buttonSortS_KAT";
            buttonSortS_KAT.Size = new Size(149, 65);
            buttonSortS_KAT.TabIndex = 3;
            buttonSortS_KAT.Text = "Общая \r\nплощадь";
            buttonSortS_KAT.UseVisualStyleBackColor = true;
            // 
            // buttonSortRoom_KAT
            // 
            buttonSortRoom_KAT.Location = new Point(167, 238);
            buttonSortRoom_KAT.Name = "buttonSortRoom_KAT";
            buttonSortRoom_KAT.Size = new Size(149, 65);
            buttonSortRoom_KAT.TabIndex = 3;
            buttonSortRoom_KAT.Text = "Количество комнат";
            buttonSortRoom_KAT.UseVisualStyleBackColor = true;
            // 
            // panelLeft_KAT
            // 
            panelLeft_KAT.Controls.Add(labelHead_KAT);
            panelLeft_KAT.Controls.Add(comboBoxFilter_KAT);
            panelLeft_KAT.Controls.Add(textBoxMedium_KAT);
            panelLeft_KAT.Controls.Add(textBoxMAX_KAT);
            panelLeft_KAT.Controls.Add(textBoxMIN_KAT);
            panelLeft_KAT.Controls.Add(buttonSortRoom_KAT);
            panelLeft_KAT.Controls.Add(buttonGraphic_KAT);
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
            labelHead_KAT.Location = new Point(51, 22);
            labelHead_KAT.Name = "labelHead_KAT";
            labelHead_KAT.Size = new Size(217, 103);
            labelHead_KAT.TabIndex = 6;
            labelHead_KAT.Text = "Добро пожаловать!\r\nДомоуправление \"Уютный Квартал\"";
            labelHead_KAT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxFilter_KAT
            // 
            comboBoxFilter_KAT.FormattingEnabled = true;
            comboBoxFilter_KAT.Location = new Point(196, 333);
            comboBoxFilter_KAT.Name = "comboBoxFilter_KAT";
            comboBoxFilter_KAT.Size = new Size(120, 28);
            comboBoxFilter_KAT.TabIndex = 5;
            // 
            // textBoxMedium_KAT
            // 
            textBoxMedium_KAT.Location = new Point(200, 592);
            textBoxMedium_KAT.Multiline = true;
            textBoxMedium_KAT.Name = "textBoxMedium_KAT";
            textBoxMedium_KAT.ReadOnly = true;
            textBoxMedium_KAT.Size = new Size(116, 67);
            textBoxMedium_KAT.TabIndex = 4;
            // 
            // textBoxMAX_KAT
            // 
            textBoxMAX_KAT.Location = new Point(200, 519);
            textBoxMAX_KAT.Multiline = true;
            textBoxMAX_KAT.Name = "textBoxMAX_KAT";
            textBoxMAX_KAT.ReadOnly = true;
            textBoxMAX_KAT.Size = new Size(116, 67);
            textBoxMAX_KAT.TabIndex = 4;
            // 
            // textBoxMIN_KAT
            // 
            textBoxMIN_KAT.Location = new Point(200, 446);
            textBoxMIN_KAT.Multiline = true;
            textBoxMIN_KAT.Name = "textBoxMIN_KAT";
            textBoxMIN_KAT.ReadOnly = true;
            textBoxMIN_KAT.Size = new Size(116, 67);
            textBoxMIN_KAT.TabIndex = 4;
            // 
            // buttonGraphic_KAT
            // 
            buttonGraphic_KAT.Location = new Point(12, 684);
            buttonGraphic_KAT.Name = "buttonGraphic_KAT";
            buttonGraphic_KAT.Size = new Size(304, 67);
            buttonGraphic_KAT.TabIndex = 3;
            buttonGraphic_KAT.Text = "График полезной площади";
            buttonGraphic_KAT.UseVisualStyleBackColor = true;
            // 
            // buttonMedium_KAT
            // 
            buttonMedium_KAT.Location = new Point(12, 592);
            buttonMedium_KAT.Name = "buttonMedium_KAT";
            buttonMedium_KAT.Size = new Size(178, 67);
            buttonMedium_KAT.TabIndex = 3;
            buttonMedium_KAT.Text = "Найти среднее значение площади";
            buttonMedium_KAT.UseVisualStyleBackColor = true;
            // 
            // buttonMAX_KAT
            // 
            buttonMAX_KAT.Location = new Point(12, 519);
            buttonMAX_KAT.Name = "buttonMAX_KAT";
            buttonMAX_KAT.Size = new Size(178, 67);
            buttonMAX_KAT.TabIndex = 3;
            buttonMAX_KAT.Text = "Найти максимальную площадь";
            buttonMAX_KAT.UseVisualStyleBackColor = true;
            // 
            // buttonStartFilter_KAT
            // 
            buttonStartFilter_KAT.Location = new Point(12, 322);
            buttonStartFilter_KAT.Name = "buttonStartFilter_KAT";
            buttonStartFilter_KAT.Size = new Size(178, 48);
            buttonStartFilter_KAT.TabIndex = 3;
            buttonStartFilter_KAT.Text = "Фильтровать по задолженности";
            buttonStartFilter_KAT.UseVisualStyleBackColor = true;
            // 
            // buttonMIN_KAT
            // 
            buttonMIN_KAT.Location = new Point(12, 446);
            buttonMIN_KAT.Name = "buttonMIN_KAT";
            buttonMIN_KAT.Size = new Size(178, 67);
            buttonMIN_KAT.TabIndex = 3;
            buttonMIN_KAT.Text = "Найти минимальную площадь";
            buttonMIN_KAT.UseVisualStyleBackColor = true;
            // 
            // buttonStopFilter_KAT
            // 
            buttonStopFilter_KAT.Location = new Point(12, 376);
            buttonStopFilter_KAT.Name = "buttonStopFilter_KAT";
            buttonStopFilter_KAT.Size = new Size(304, 46);
            buttonStopFilter_KAT.TabIndex = 3;
            buttonStopFilter_KAT.Text = "Сброс фильтра";
            buttonStopFilter_KAT.UseVisualStyleBackColor = true;
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
            dataGridViewTab_KAT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTab_KAT.Dock = DockStyle.Fill;
            dataGridViewTab_KAT.Location = new Point(0, 0);
            dataGridViewTab_KAT.Name = "dataGridViewTab_KAT";
            dataGridViewTab_KAT.RowHeadersWidth = 51;
            dataGridViewTab_KAT.Size = new Size(1154, 450);
            dataGridViewTab_KAT.TabIndex = 0;
            // 
            // panelChart_KAT
            // 
            panelChart_KAT.Controls.Add(chart1);
            panelChart_KAT.Dock = DockStyle.Fill;
            panelChart_KAT.Location = new Point(328, 530);
            panelChart_KAT.Name = "panelChart_KAT";
            panelChart_KAT.Size = new Size(1154, 373);
            panelChart_KAT.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1154, 373);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
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
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
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
        private DataGridView dataGridViewTab_KAT;
        private Panel panelChart_KAT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ToolTip toolTip_KAT;
        private OpenFileDialog openFileDialog_KAT;
        private SaveFileDialog saveFileDialog_KAT;
        private Button buttonDone_KAT;
    }
}
