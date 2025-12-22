using Tyuiu.PupovAA.Sprint6.Task2.V5.Lib;
namespace Tyuiu.PupovAA.Sprint6.Task2.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonRes_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textstart.Text);
                int stop = Convert.ToInt32(textstop.Text);

                int len = ds.GetMassFunction(start, stop).Length;
                double[] value = new double[len];
                value = ds.GetMassFunction(start, stop);
                this.chart.Titles.Add("График функции");
                this.chart.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewres.Rows.Add(Convert.ToString(start), Convert.ToString(value[i]));
                    this.chart.Series[0].Points.AddXY(start, value[i]);
                    start++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void buttonhelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task2 выполнил студент группы ИБКСб-25-1 Пупов Артём Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRes_MouseEnter(object sender, EventArgs e)
        {
            buttonRes.BackColor = Color.Red;
        }

        private void buttonRes_MouseLeave(object sender, EventArgs e)
        {
            buttonRes.BackColor = Color.Green;
        }

        private void buttonRes_MouseDown(object sender, MouseEventArgs e)
        {
            buttonRes.BackColor = Color.Blue;
        }

        private void dataGridViewres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
