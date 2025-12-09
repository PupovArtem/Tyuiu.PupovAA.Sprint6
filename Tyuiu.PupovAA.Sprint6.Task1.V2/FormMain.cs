using Tyuiu.PupovAA.Sprint6.Task1.V2.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.PupovAA.Sprint6.Task1.V2_
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBoxValue1_PAA.Text.Trim());
            int num2 = Convert.ToInt32(textBoxValue2.Text.Trim());
            DataService ds = new DataService();
            textBoxResult_PAA.Text = string.Join("\t", ds.GetMassFunction(num1, num2).Select(x => x.ToString()));

        }
        

        private void buttonHelp__PAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task0 выполнил студент группы »Ѕ —б-25-1 ѕупов јртЄм јндреевич", "—ообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
