namespace Tyuiu.KadralinovaAT.Sprint7.Project.V7
{
    partial class FormAddStr
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
            labelNumP_KAT = new Label();
            labelNumRoom_KAT = new Label();
            labelRoom_KAT = new Label();
            labelS_KAT = new Label();
            labelDolg_KAT = new Label();
            labelChild_KAT = new Label();
            textBoxNumP_KAT = new TextBox();
            textBoxNumRoom_KAT = new TextBox();
            textBoxRoom_KAT = new TextBox();
            textBoxS_KAT = new TextBox();
            textBoxChild_KAT = new TextBox();
            comboBoxDolg_KAT = new ComboBox();
            buttonAddStr_KAT = new Button();
            SuspendLayout();
            // 
            // labelNumP_KAT
            // 
            labelNumP_KAT.AutoSize = true;
            labelNumP_KAT.Location = new Point(24, 28);
            labelNumP_KAT.Name = "labelNumP_KAT";
            labelNumP_KAT.Size = new Size(127, 20);
            labelNumP_KAT.TabIndex = 0;
            labelNumP_KAT.Text = "Номер подъезда";
            // 
            // labelNumRoom_KAT
            // 
            labelNumRoom_KAT.AutoSize = true;
            labelNumRoom_KAT.Location = new Point(24, 70);
            labelNumRoom_KAT.Name = "labelNumRoom_KAT";
            labelNumRoom_KAT.Size = new Size(128, 20);
            labelNumRoom_KAT.TabIndex = 0;
            labelNumRoom_KAT.Text = "Номер квартиры";
            // 
            // labelRoom_KAT
            // 
            labelRoom_KAT.AutoSize = true;
            labelRoom_KAT.Location = new Point(24, 117);
            labelRoom_KAT.Name = "labelRoom_KAT";
            labelRoom_KAT.Size = new Size(144, 20);
            labelRoom_KAT.TabIndex = 0;
            labelRoom_KAT.Text = "Количество комнат";
            // 
            // labelS_KAT
            // 
            labelS_KAT.AutoSize = true;
            labelS_KAT.Location = new Point(24, 165);
            labelS_KAT.Name = "labelS_KAT";
            labelS_KAT.Size = new Size(123, 20);
            labelS_KAT.TabIndex = 0;
            labelS_KAT.Text = "Общая площадь";
            // 
            // labelDolg_KAT
            // 
            labelDolg_KAT.AutoSize = true;
            labelDolg_KAT.Location = new Point(24, 216);
            labelDolg_KAT.Name = "labelDolg_KAT";
            labelDolg_KAT.Size = new Size(170, 20);
            labelDolg_KAT.TabIndex = 0;
            labelDolg_KAT.Text = "Есть ли задолженность";
            // 
            // labelChild_KAT
            // 
            labelChild_KAT.AutoSize = true;
            labelChild_KAT.Location = new Point(24, 265);
            labelChild_KAT.Name = "labelChild_KAT";
            labelChild_KAT.Size = new Size(133, 20);
            labelChild_KAT.TabIndex = 0;
            labelChild_KAT.Text = "Количество детей";
            // 
            // textBoxNumP_KAT
            // 
            textBoxNumP_KAT.Location = new Point(223, 25);
            textBoxNumP_KAT.Name = "textBoxNumP_KAT";
            textBoxNumP_KAT.Size = new Size(184, 27);
            textBoxNumP_KAT.TabIndex = 1;
            // 
            // textBoxNumRoom_KAT
            // 
            textBoxNumRoom_KAT.Location = new Point(223, 67);
            textBoxNumRoom_KAT.Name = "textBoxNumRoom_KAT";
            textBoxNumRoom_KAT.Size = new Size(184, 27);
            textBoxNumRoom_KAT.TabIndex = 1;
            // 
            // textBoxRoom_KAT
            // 
            textBoxRoom_KAT.Location = new Point(223, 114);
            textBoxRoom_KAT.Name = "textBoxRoom_KAT";
            textBoxRoom_KAT.Size = new Size(184, 27);
            textBoxRoom_KAT.TabIndex = 1;
            // 
            // textBoxS_KAT
            // 
            textBoxS_KAT.Location = new Point(223, 162);
            textBoxS_KAT.Name = "textBoxS_KAT";
            textBoxS_KAT.Size = new Size(184, 27);
            textBoxS_KAT.TabIndex = 1;
            // 
            // textBoxChild_KAT
            // 
            textBoxChild_KAT.Location = new Point(223, 262);
            textBoxChild_KAT.Name = "textBoxChild_KAT";
            textBoxChild_KAT.Size = new Size(184, 27);
            textBoxChild_KAT.TabIndex = 1;
            // 
            // comboBoxDolg_KAT
            // 
            comboBoxDolg_KAT.FormattingEnabled = true;
            comboBoxDolg_KAT.Items.AddRange(new object[] { "Да", "Нет" });
            comboBoxDolg_KAT.Location = new Point(223, 213);
            comboBoxDolg_KAT.Name = "comboBoxDolg_KAT";
            comboBoxDolg_KAT.Size = new Size(184, 28);
            comboBoxDolg_KAT.TabIndex = 2;
            // 
            // buttonAddStr_KAT
            // 
            buttonAddStr_KAT.Location = new Point(24, 312);
            buttonAddStr_KAT.Name = "buttonAddStr_KAT";
            buttonAddStr_KAT.Size = new Size(383, 55);
            buttonAddStr_KAT.TabIndex = 3;
            buttonAddStr_KAT.Text = "Добавить новую строку";
            buttonAddStr_KAT.UseVisualStyleBackColor = true;
            buttonAddStr_KAT.Click += buttonAddStr_KAT_Click;
            // 
            // FormAddStr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 386);
            Controls.Add(buttonAddStr_KAT);
            Controls.Add(comboBoxDolg_KAT);
            Controls.Add(textBoxChild_KAT);
            Controls.Add(textBoxS_KAT);
            Controls.Add(textBoxRoom_KAT);
            Controls.Add(textBoxNumRoom_KAT);
            Controls.Add(textBoxNumP_KAT);
            Controls.Add(labelChild_KAT);
            Controls.Add(labelDolg_KAT);
            Controls.Add(labelS_KAT);
            Controls.Add(labelRoom_KAT);
            Controls.Add(labelNumRoom_KAT);
            Controls.Add(labelNumP_KAT);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddStr";
            ShowIcon = false;
            Text = "Добавить новую строку";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumP_KAT;
        private Label labelNumRoom_KAT;
        private Label labelRoom_KAT;
        private Label labelS_KAT;
        private Label labelDolg_KAT;
        private Label labelChild_KAT;
        private TextBox textBoxNumP_KAT;
        private TextBox textBoxNumRoom_KAT;
        private TextBox textBoxRoom_KAT;
        private TextBox textBoxS_KAT;
        private TextBox textBoxChild_KAT;
        private ComboBox comboBoxDolg_KAT;
        private Button buttonAddStr_KAT;
    }
}