namespace Tyuiu.PupovAA.Sprint6.Task1.V2_
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
            buttonReady_PAA = new Button();
            buttonHelp__PAA = new Button();
            groupTask__PAA = new GroupBox();
            textBoxTask2__PAA = new TextBox();
            groupBoxData__PAA = new GroupBox();
            textBoxStop__PAA = new TextBox();
            textBoxStart__PAA = new TextBox();
            textBoxValue2 = new TextBox();
            textBoxValue1_PAA = new TextBox();
            groupBox3 = new GroupBox();
            textBoxResult_PAA = new TextBox();
            textBox6 = new TextBox();
            groupTask__PAA.SuspendLayout();
            groupBoxData__PAA.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonReady_PAA
            // 
            buttonReady_PAA.BackColor = SystemColors.ActiveCaption;
            buttonReady_PAA.Location = new Point(525, 345);
            buttonReady_PAA.Name = "buttonReady_PAA";
            buttonReady_PAA.Size = new Size(133, 118);
            buttonReady_PAA.TabIndex = 0;
            buttonReady_PAA.Text = "Выполнить";
            buttonReady_PAA.UseVisualStyleBackColor = false;
            buttonReady_PAA.Click += button1_Click;
            // 
            // buttonHelp__PAA
            // 
            buttonHelp__PAA.BackColor = Color.FromArgb(255, 192, 192);
            buttonHelp__PAA.Location = new Point(406, 383);
            buttonHelp__PAA.Name = "buttonHelp__PAA";
            buttonHelp__PAA.Size = new Size(113, 69);
            buttonHelp__PAA.TabIndex = 1;
            buttonHelp__PAA.Text = "?";
            buttonHelp__PAA.UseVisualStyleBackColor = false;
            buttonHelp__PAA.Click += buttonHelp__PAA_Click;
            // 
            // groupTask__PAA
            // 
            groupTask__PAA.Controls.Add(textBoxTask2__PAA);
            groupTask__PAA.Location = new Point(12, 12);
            groupTask__PAA.Name = "groupTask__PAA";
            groupTask__PAA.Size = new Size(670, 297);
            groupTask__PAA.TabIndex = 2;
            groupTask__PAA.TabStop = false;
            groupTask__PAA.Text = "Условие";
            // 
            // textBoxTask2__PAA
            // 
            textBoxTask2__PAA.BackColor = SystemColors.Menu;
            textBoxTask2__PAA.Location = new Point(15, 40);
            textBoxTask2__PAA.Multiline = true;
            textBoxTask2__PAA.Name = "textBoxTask2__PAA";
            textBoxTask2__PAA.Size = new Size(649, 251);
            textBoxTask2__PAA.TabIndex = 0;
            // 
            // groupBoxData__PAA
            // 
            groupBoxData__PAA.Controls.Add(textBoxStop__PAA);
            groupBoxData__PAA.Controls.Add(textBoxStart__PAA);
            groupBoxData__PAA.Controls.Add(textBoxValue2);
            groupBoxData__PAA.Controls.Add(textBoxValue1_PAA);
            groupBoxData__PAA.Location = new Point(18, 313);
            groupBoxData__PAA.Name = "groupBoxData__PAA";
            groupBoxData__PAA.Size = new Size(373, 167);
            groupBoxData__PAA.TabIndex = 3;
            groupBoxData__PAA.TabStop = false;
            groupBoxData__PAA.Text = "Ввод данных";
            // 
            // textBoxStop__PAA
            // 
            textBoxStop__PAA.BorderStyle = BorderStyle.None;
            textBoxStop__PAA.Location = new Point(198, 52);
            textBoxStop__PAA.Name = "textBoxStop__PAA";
            textBoxStop__PAA.ReadOnly = true;
            textBoxStop__PAA.Size = new Size(125, 20);
            textBoxStop__PAA.TabIndex = 3;
            textBoxStop__PAA.Text = "Конец";
            // 
            // textBoxStart__PAA
            // 
            textBoxStart__PAA.BorderStyle = BorderStyle.None;
            textBoxStart__PAA.Location = new Point(29, 52);
            textBoxStart__PAA.Name = "textBoxStart__PAA";
            textBoxStart__PAA.ReadOnly = true;
            textBoxStart__PAA.Size = new Size(125, 20);
            textBoxStart__PAA.TabIndex = 2;
            textBoxStart__PAA.Text = "Старт";
            // 
            // textBoxValue2
            // 
            textBoxValue2.Location = new Point(198, 78);
            textBoxValue2.Name = "textBoxValue2";
            textBoxValue2.Size = new Size(125, 27);
            textBoxValue2.TabIndex = 1;
            // 
            // textBoxValue1_PAA
            // 
            textBoxValue1_PAA.Location = new Point(29, 78);
            textBoxValue1_PAA.Name = "textBoxValue1_PAA";
            textBoxValue1_PAA.Size = new Size(125, 27);
            textBoxValue1_PAA.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult_PAA);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Location = new Point(688, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 477);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxResult_PAA
            // 
            textBoxResult_PAA.Location = new Point(6, 59);
            textBoxResult_PAA.Multiline = true;
            textBoxResult_PAA.Name = "textBoxResult_PAA";
            textBoxResult_PAA.ReadOnly = true;
            textBoxResult_PAA.ScrollBars = ScrollBars.Horizontal;
            textBoxResult_PAA.Size = new Size(238, 412);
            textBoxResult_PAA.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(6, 26);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 0;
            textBox6.Text = "Резульатат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 492);
            Controls.Add(groupBox3);
            Controls.Add(groupBoxData__PAA);
            Controls.Add(groupTask__PAA);
            Controls.Add(buttonHelp__PAA);
            Controls.Add(buttonReady_PAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            Text = "Спринт6 Таск1 Пупов Артём ИбКСб-25-1";
            groupTask__PAA.ResumeLayout(false);
            groupTask__PAA.PerformLayout();
            groupBoxData__PAA.ResumeLayout(false);
            groupBoxData__PAA.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonReady_PAA;
        private Button buttonHelp__PAA;
        private GroupBox groupTask__PAA;
        private TextBox textBoxTask2__PAA;
        private GroupBox groupBoxData__PAA;
        private TextBox textBoxStop__PAA;
        private TextBox textBoxStart__PAA;
        private TextBox textBoxValue2;
        private TextBox textBoxValue1_PAA;
        private GroupBox groupBox3;
        private TextBox textBoxResult_PAA;
        private TextBox textBox6;
    }
}
