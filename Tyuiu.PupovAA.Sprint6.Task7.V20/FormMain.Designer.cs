namespace Tyuiu.PupovAA.Sprint6.Task7.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_PAA = new Panel();
            buttonHelp_PAA = new Button();
            buttonSaveFile_PAA = new Button();
            buttonDone_PAA = new Button();
            buttonOpenFile_PAA = new Button();
            groupBoxTask_PAA = new GroupBox();
            textBox1 = new TextBox();
            groupBox1Task = new GroupBox();
            dataGridViewOut_PAA = new DataGridView();
            splitterTask = new Splitter();
            groupBoxTask = new GroupBox();
            dataGridViewIn_PAA = new DataGridView();
            openFileDialogTask_PAA = new OpenFileDialog();
            toolTipButton_PAA = new ToolTip(components);
            saveFileDialogMatrix_PAA = new SaveFileDialog();
            panelTop_PAA.SuspendLayout();
            groupBoxTask_PAA.SuspendLayout();
            groupBox1Task.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_PAA).BeginInit();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_PAA).BeginInit();
            SuspendLayout();
            // 
            // panelTop_PAA
            // 
            panelTop_PAA.Controls.Add(buttonHelp_PAA);
            panelTop_PAA.Controls.Add(buttonSaveFile_PAA);
            panelTop_PAA.Controls.Add(buttonDone_PAA);
            panelTop_PAA.Controls.Add(buttonOpenFile_PAA);
            panelTop_PAA.Dock = DockStyle.Top;
            panelTop_PAA.Location = new Point(0, 0);
            panelTop_PAA.Margin = new Padding(3, 4, 3, 4);
            panelTop_PAA.Name = "panelTop_PAA";
            panelTop_PAA.Size = new Size(914, 83);
            panelTop_PAA.TabIndex = 0;
            // 
            // buttonHelp_PAA
            // 
            buttonHelp_PAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_PAA.FlatStyle = FlatStyle.Flat;
            buttonHelp_PAA.Image = (Image)resources.GetObject("buttonHelp_PAA.Image");
            buttonHelp_PAA.Location = new Point(807, 4);
            buttonHelp_PAA.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_PAA.Name = "buttonHelp_PAA";
            buttonHelp_PAA.Size = new Size(77, 75);
            buttonHelp_PAA.TabIndex = 2;
            toolTipButton_PAA.SetToolTip(buttonHelp_PAA, "Сведения о программе");
            buttonHelp_PAA.UseVisualStyleBackColor = true;
            buttonHelp_PAA.Click += buttonHelp_PAA_Click;
            buttonHelp_PAA.MouseEnter += buttonHelp_PAA_MouseEnter;
            // 
            // buttonSaveFile_PAA
            // 
            buttonSaveFile_PAA.Enabled = false;
            buttonSaveFile_PAA.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_PAA.Image = (Image)resources.GetObject("buttonSaveFile_PAA.Image");
            buttonSaveFile_PAA.Location = new Point(222, 4);
            buttonSaveFile_PAA.Margin = new Padding(3, 4, 3, 4);
            buttonSaveFile_PAA.Name = "buttonSaveFile_PAA";
            buttonSaveFile_PAA.Size = new Size(86, 75);
            buttonSaveFile_PAA.TabIndex = 1;
            toolTipButton_PAA.SetToolTip(buttonSaveFile_PAA, "Сохранить обработанные данные в файл в формате csv");
            buttonSaveFile_PAA.UseVisualStyleBackColor = true;
            buttonSaveFile_PAA.Click += buttonSaveFile_PAA_Click;
            buttonSaveFile_PAA.MouseEnter += buttonSaveFile_PAA_MouseEnter;
            // 
            // buttonDone_PAA
            // 
            buttonDone_PAA.Enabled = false;
            buttonDone_PAA.FlatStyle = FlatStyle.Flat;
            buttonDone_PAA.Image = (Image)resources.GetObject("buttonDone_PAA.Image");
            buttonDone_PAA.Location = new Point(117, 4);
            buttonDone_PAA.Margin = new Padding(3, 4, 3, 4);
            buttonDone_PAA.Name = "buttonDone_PAA";
            buttonDone_PAA.Size = new Size(86, 75);
            buttonDone_PAA.TabIndex = 1;
            toolTipButton_PAA.SetToolTip(buttonDone_PAA, "Выполнить обработку данных");
            buttonDone_PAA.UseVisualStyleBackColor = true;
            buttonDone_PAA.Click += buttonDone_PAA_Click;
            buttonDone_PAA.MouseEnter += buttonDone_PAA_MouseEnter;
            // 
            // buttonOpenFile_PAA
            // 
            buttonOpenFile_PAA.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_PAA.Image = (Image)resources.GetObject("buttonOpenFile_PAA.Image");
            buttonOpenFile_PAA.Location = new Point(14, 4);
            buttonOpenFile_PAA.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile_PAA.Name = "buttonOpenFile_PAA";
            buttonOpenFile_PAA.Size = new Size(86, 75);
            buttonOpenFile_PAA.TabIndex = 0;
            toolTipButton_PAA.SetToolTip(buttonOpenFile_PAA, "Открыть файл для обработки данных в  формате csv");
            buttonOpenFile_PAA.UseVisualStyleBackColor = true;
            buttonOpenFile_PAA.Click += buttonOpenFile_PAA_Click;
            buttonOpenFile_PAA.MouseEnter += buttonOpenFile_PAA_MouseEnter;
            // 
            // groupBoxTask_PAA
            // 
            groupBoxTask_PAA.Controls.Add(textBox1);
            groupBoxTask_PAA.Dock = DockStyle.Top;
            groupBoxTask_PAA.Location = new Point(0, 83);
            groupBoxTask_PAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_PAA.Name = "groupBoxTask_PAA";
            groupBoxTask_PAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_PAA.Size = new Size(914, 97);
            groupBoxTask_PAA.TabIndex = 1;
            groupBoxTask_PAA.TabStop = false;
            groupBoxTask_PAA.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 25);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(910, 63);
            textBox1.TabIndex = 0;
            // 
            // groupBox1Task
            // 
            groupBox1Task.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1Task.Controls.Add(dataGridViewOut_PAA);
            groupBox1Task.Controls.Add(splitterTask);
            groupBox1Task.Location = new Point(455, 188);
            groupBox1Task.Margin = new Padding(3, 4, 3, 4);
            groupBox1Task.Name = "groupBox1Task";
            groupBox1Task.Padding = new Padding(3, 4, 3, 4);
            groupBox1Task.Size = new Size(459, 409);
            groupBox1Task.TabIndex = 2;
            groupBox1Task.TabStop = false;
            groupBox1Task.Text = "Вывод";
            // 
            // dataGridViewOut_PAA
            // 
            dataGridViewOut_PAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_PAA.Location = new Point(14, 25);
            dataGridViewOut_PAA.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOut_PAA.Name = "dataGridViewOut_PAA";
            dataGridViewOut_PAA.RowHeadersWidth = 51;
            dataGridViewOut_PAA.Size = new Size(445, 371);
            dataGridViewOut_PAA.TabIndex = 0;
            // 
            // splitterTask
            // 
            splitterTask.Location = new Point(3, 24);
            splitterTask.Margin = new Padding(3, 4, 3, 4);
            splitterTask.Name = "splitterTask";
            splitterTask.Size = new Size(3, 381);
            splitterTask.TabIndex = 0;
            splitterTask.TabStop = false;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxTask.Controls.Add(dataGridViewIn_PAA);
            groupBoxTask.Location = new Point(3, 188);
            groupBoxTask.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask.Size = new Size(454, 409);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Ввод";
            // 
            // dataGridViewIn_PAA
            // 
            dataGridViewIn_PAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_PAA.Location = new Point(3, 25);
            dataGridViewIn_PAA.Margin = new Padding(3, 4, 3, 4);
            dataGridViewIn_PAA.Name = "dataGridViewIn_PAA";
            dataGridViewIn_PAA.RowHeadersWidth = 51;
            dataGridViewIn_PAA.Size = new Size(445, 371);
            dataGridViewIn_PAA.TabIndex = 0;
            // 
            // openFileDialogTask_PAA
            // 
            openFileDialogTask_PAA.FileName = "openFileDialog1";
            // 
            // toolTipButton_PAA
            // 
            toolTipButton_PAA.IsBalloon = true;
            toolTipButton_PAA.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_PAA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBox1Task);
            Controls.Add(groupBoxTask_PAA);
            Controls.Add(panelTop_PAA);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Спринт 6 Таск 7 Вариант 20 Пупов А.А";
            toolTipButton_PAA.SetToolTip(this, "\r\n");
            WindowState = FormWindowState.Maximized;
            panelTop_PAA.ResumeLayout(false);
            groupBoxTask_PAA.ResumeLayout(false);
            groupBoxTask_PAA.PerformLayout();
            groupBox1Task.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_PAA).EndInit();
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_PAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_PAA;
        private Button buttonHelp_PAA;
        private Button buttonDone_PAA;
        private Button buttonOpenFile_PAA;
        private Button buttonSaveFile_PAA;
        private GroupBox groupBoxTask_PAA;
        private TextBox textBox1;
        private GroupBox groupBox1Task;
        private GroupBox groupBoxTask;
        private Splitter splitterTask;
        private DataGridView dataGridViewIn_PAA;
        private DataGridView dataGridViewOut_PAA;
        private OpenFileDialog openFileDialogTask_PAA;
        private ToolTip toolTipButton_PAA;
        private SaveFileDialog saveFileDialogMatrix_PAA;
    }
}
