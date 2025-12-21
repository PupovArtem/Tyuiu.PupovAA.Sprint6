namespace Tyuiu.GridinAE.Sprint6.Task3.V15
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
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxOutput = new GroupBox();
            buttonHelp = new Button();
            buttonExecute = new Button();
            dataGridViewMatrix = new DataGridView();
            labelResult = new Label();
            groupBoxTask.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(543, 378);
            groupBoxTask.TabIndex = 2;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(531, 346);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(buttonHelp);
            groupBoxOutput.Controls.Add(buttonExecute);
            groupBoxOutput.Controls.Add(dataGridViewMatrix);
            groupBoxOutput.Controls.Add(labelResult);
            groupBoxOutput.Location = new Point(561, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(303, 378);
            groupBoxOutput.TabIndex = 7;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(150, 343);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(29, 29);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_GAE_Click;
            // 
            // buttonExecute
            // 
            buttonExecute.Location = new Point(185, 343);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(112, 29);
            buttonExecute.TabIndex = 2;
            buttonExecute.Text = "Выполнить";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_GAE_Click;
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatrix.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewMatrix.Location = new Point(6, 49);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.RowHeadersWidth = 20;
            dataGridViewMatrix.Size = new Size(291, 288);
            dataGridViewMatrix.TabIndex = 1;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(6, 26);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(78, 20);
            labelResult.TabIndex = 0;
            labelResult.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 402);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 15 | Пупов А.А.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxOutput;
        private Button buttonHelp;
        private Button buttonExecute;
        private DataGridView dataGridViewMatrix;
        private Label labelResult;
    }
}
