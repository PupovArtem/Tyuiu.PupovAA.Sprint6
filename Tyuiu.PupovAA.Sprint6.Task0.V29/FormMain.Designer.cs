namespace Tyuiu.PupovAA.Sprint6.Task0.V29
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBox1 = new GroupBox();
            textBoxTask = new TextBox();
            pictureBoxFormula = new PictureBox();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            textBoxX = new TextBox();
            groupBox3 = new GroupBox();
            textBox5 = new TextBox();
            textBoxResult = new TextBox();
            buttonResult = new Button();
            buttonHelp = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxTask);
            groupBox1.Controls.Add(pictureBoxFormula);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Menu;
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(596, 162);
            textBoxTask.TabIndex = 1;
            textBoxTask.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(642, 26);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(114, 59);
            pictureBoxFormula.TabIndex = 0;
            pictureBoxFormula.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBoxX);
            groupBox2.Location = new Point(12, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(423, 148);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных:";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(133, 51);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 20);
            textBox4.TabIndex = 1;
            textBox4.Text = "Переменная x:";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(133, 77);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(125, 27);
            textBoxX.TabIndex = 0;
            
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBoxResult);
            groupBox3.Location = new Point(468, 206);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(314, 148);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных:";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(94, 51);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(125, 20);
            textBox5.TabIndex = 1;
            textBox5.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.ButtonHighlight;
            textBoxResult.Location = new Point(94, 77);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(125, 27);
            textBoxResult.TabIndex = 0;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(640, 389);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(142, 49);
            buttonResult.TabIndex = 0;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(562, 391);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(52, 45);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonResult);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxTask;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBox2;
        private TextBox textBoxX;
        private GroupBox groupBox3;
        private TextBox textBoxResult;
        private Button buttonResult;
        private Button buttonHelp;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
