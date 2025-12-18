namespace Tyuiu.KadralinovaAT.Sprint7.Project.V7
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            labelHead_KAT = new Label();
            labelProgram_KAT = new Label();
            labelProgramAbout_KAT = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // labelHead_KAT
            // 
            labelHead_KAT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelHead_KAT.ForeColor = SystemColors.Highlight;
            labelHead_KAT.Location = new Point(37, 9);
            labelHead_KAT.Name = "labelHead_KAT";
            labelHead_KAT.Size = new Size(819, 78);
            labelHead_KAT.TabIndex = 0;
            labelHead_KAT.Text = "Краткое руководство пользователя для \"Домоуправление 'Уютный Квартал'\"";
            labelHead_KAT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProgram_KAT
            // 
            labelProgram_KAT.AutoSize = true;
            labelProgram_KAT.Location = new Point(24, 78);
            labelProgram_KAT.Name = "labelProgram_KAT";
            labelProgram_KAT.Size = new Size(181, 20);
            labelProgram_KAT.TabIndex = 1;
            labelProgram_KAT.Text = "Назначение программы";
            // 
            // labelProgramAbout_KAT
            // 
            labelProgramAbout_KAT.Location = new Point(24, 109);
            labelProgramAbout_KAT.Name = "labelProgramAbout_KAT";
            labelProgramAbout_KAT.Size = new Size(808, 51);
            labelProgramAbout_KAT.TabIndex = 1;
            labelProgramAbout_KAT.Text = "Программа предназначена для учета квартир в многоквартирном доме. Позволяет вести базу данных жильцов, анализировать показатели и формировать отчеты.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 177);
            label1.Name = "label1";
            label1.Size = new Size(275, 20);
            label1.TabIndex = 1;
            label1.Text = "Панель инструментов (верхняя часть)";
            // 
            // label2
            // 
            label2.Location = new Point(24, 208);
            label2.Name = "label2";
            label2.Size = new Size(808, 91);
            label2.TabIndex = 1;
            label2.Text = "Открыть - загрузить данные из CSV файла\r\nСохранить - сохранить текущие данные в CSV файл\r\nРуководство - открыть это руководство\r\nО программе - информация о разработчике и версии";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 308);
            label3.Name = "label3";
            label3.Size = new Size(258, 20);
            label3.TabIndex = 1;
            label3.Text = "Панель инструментов (левая часть)";
            // 
            // label4
            // 
            label4.Location = new Point(24, 339);
            label4.Name = "label4";
            label4.Size = new Size(808, 383);
            label4.TabIndex = 1;
            label4.Text = resources.GetString("label4.Text");
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 716);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(labelProgramAbout_KAT);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(labelProgram_KAT);
            Controls.Add(labelHead_KAT);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGuide";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Краткое руководство пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHead_KAT;
        private Label labelProgram_KAT;
        private Label labelProgramAbout_KAT;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}