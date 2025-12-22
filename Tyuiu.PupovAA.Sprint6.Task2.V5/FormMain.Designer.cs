namespace Tyuiu.PupovAA.Sprint6.Task2.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridViewres = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBox6 = new TextBox();
            groupBox3 = new GroupBox();
            textstop = new TextBox();
            textstart = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            buttonhelp = new Button();
            buttonRes = new Button();
            groupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(textBox1);
            groupBox.Location = new Point(12, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(593, 319);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(22, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(565, 277);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewres);
            groupBox2.Controls.Add(chart);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Location = new Point(611, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(582, 566);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // dataGridViewres
            // 
            dataGridViewres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewres.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewres.Location = new Point(4, 80);
            dataGridViewres.Name = "dataGridViewres";
            dataGridViewres.RowHeadersVisible = false;
            dataGridViewres.RowHeadersWidth = 51;
            dataGridViewres.Size = new Size(127, 353);
            dataGridViewres.TabIndex = 3;
            dataGridViewres.CellContentClick += dataGridViewres_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 60;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(x)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 60;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(137, 80);
            chart.Name = "chart";
            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(445, 362);
            chart.TabIndex = 2;
            chart.Text = "chart1";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(29, 29);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(125, 20);
            textBox6.TabIndex = 0;
            textBox6.Text = "Результат";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textstop);
            groupBox3.Controls.Add(textstart);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(12, 361);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(351, 170);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // textstop
            // 
            textstop.Location = new Point(172, 66);
            textstop.Name = "textstop";
            textstop.Size = new Size(90, 27);
            textstop.TabIndex = 3;
            // 
            // textstart
            // 
            textstart.Location = new Point(22, 66);
            textstart.Name = "textstart";
            textstart.Size = new Size(93, 27);
            textstart.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(172, 40);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 20);
            textBox3.TabIndex = 1;
            textBox3.Text = "Конец";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(22, 40);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 20);
            textBox2.TabIndex = 0;
            textBox2.Text = "Старт";
            // 
            // buttonhelp
            // 
            buttonhelp.BackColor = SystemColors.ActiveCaption;
            buttonhelp.Location = new Point(378, 420);
            buttonhelp.Name = "buttonhelp";
            buttonhelp.Size = new Size(60, 57);
            buttonhelp.TabIndex = 3;
            buttonhelp.Text = "?";
            buttonhelp.UseVisualStyleBackColor = false;
            buttonhelp.Click += buttonhelp_Click;
            // 
            // buttonRes
            // 
            buttonRes.BackColor = Color.IndianRed;
            buttonRes.Location = new Point(463, 401);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(107, 95);
            buttonRes.TabIndex = 4;
            buttonRes.Text = "Выполнить";
            buttonRes.UseVisualStyleBackColor = false;
            buttonRes.Click += buttonRes_Click;
            buttonRes.MouseDown += buttonRes_MouseDown;
            buttonRes.MouseEnter += buttonRes_MouseEnter;
            buttonRes.MouseLeave += buttonRes_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 590);
            Controls.Add(buttonRes);
            Controls.Add(buttonhelp);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task2 Пупов Артём Андреевич ИБКСб-25-1";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewres).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox textstop;
        private TextBox textstart;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button buttonhelp;
        private Button buttonRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private DataGridView dataGridViewres;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
