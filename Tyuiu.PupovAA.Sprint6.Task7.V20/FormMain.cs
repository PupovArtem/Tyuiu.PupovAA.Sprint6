using Tyuiu.PupovAA.Sprint6.Task7.V20.Lib;

namespace Tyuiu.PupovAA.Sprint6.Task7.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_PAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_PAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_PAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_PAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_PAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_PAA.Enabled = true;
        }

        private void buttonOpenFile_PAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PAA.ShowDialog();
            openFilePath = openFileDialogTask_PAA.FileName;
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_PAA.ColumnCount = columns;
            dataGridViewIn_PAA.RowCount = rows;
            dataGridViewOut_PAA.ColumnCount = columns;
            dataGridViewOut_PAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_PAA.Columns[i].Width = 25;
                dataGridViewOut_PAA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_PAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonDone_PAA.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_PAA.ColumnCount = 50;
            dataGridViewOut_PAA.ColumnCount = 50;

            dataGridViewIn_PAA.RowCount = 50;
            dataGridViewOut_PAA.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_PAA.Columns[i].Width = 25;
                dataGridViewOut_PAA.Columns[i].Width = 25;
            }
        }

        private void buttonSaveFile_PAA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_PAA.FileName = "OutPutFileTask7V20.csv";
            saveFileDialogMatrix_PAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_PAA.ShowDialog();

            string path = saveFileDialogMatrix_PAA.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_PAA.RowCount;
            int columns = dataGridViewOut_PAA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_PAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_PAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_PAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PAA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_PAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PAA.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_PAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PAA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_PAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PAA.ToolTipTitle = "Справка";
        }
    }
}
