namespace Tyuiu.PupovAA.Sprint6.Task7.V20
{
    partial class FormAbout
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            buttonOk_KAE = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photo_5350377671759696328_x;
            pictureBox1.Location = new Point(-28, -63);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 325);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 13);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(289, 91);
            textBox1.TabIndex = 1;
            textBox1.Text = "Выполнил работу: Пупов Артём Андреевич ИБКСб-25-1";
            // 
            // buttonOk_KAE
            // 
            buttonOk_KAE.Location = new Point(426, 231);
            buttonOk_KAE.Margin = new Padding(3, 4, 3, 4);
            buttonOk_KAE.Name = "buttonOk_KAE";
            buttonOk_KAE.Size = new Size(86, 31);
            buttonOk_KAE.TabIndex = 2;
            buttonOk_KAE.Text = "ОК";
            buttonOk_KAE.UseVisualStyleBackColor = true;
            buttonOk_KAE.Click += buttonOk_KAE_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 267);
            ControlBox = false;
            Controls.Add(buttonOk_KAE);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(541, 314);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button buttonOk_KAE;
    }
}