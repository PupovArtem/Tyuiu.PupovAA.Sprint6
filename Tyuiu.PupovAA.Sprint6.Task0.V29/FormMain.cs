using System.Windows.Forms;
using Tyuiu.PupovAA.Sprint6.Task0.V29.Lib;
namespace Tyuiu.PupovAA.Sprint6.Task0.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxX.Text.Trim())));
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные ", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task0 выполнил студент группы »Ѕ —б-25-1 ѕупов јртЄм јндреевич", "—ообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
