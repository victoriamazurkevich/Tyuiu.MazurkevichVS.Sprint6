using Tyuiu.MazurkevichVS.Sprint6.Task7.V25.Lib;
namespace Tyuiu.MazurkevichVS.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            
            openFileDialogTask_MVS.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_MVS.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static int rows;
        static int columns;
        static string openFilePath;
        public static int[,] LoadFromData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return result;
        }

        private void buttonLoad_MVS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MVS.ShowDialog();
            openFilePath = openFileDialogTask_MVS.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFilePath);
            dataGridViewInput_MVS.ColumnCount = columns;
            dataGridViewInput_MVS.RowCount = rows;
            dataGridViewRes_MVS.ColumnCount = columns;
            dataGridViewRes_MVS.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_MVS.Columns[i].Width = 100;
                dataGridViewRes_MVS.Columns[i].Width = 100;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput_MVS.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonPush_MVS.Enabled = true;
        }

        private void buttonPush_MVS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRes_MVS.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave_MVS.Enabled = true;
        }

        private void buttonInfo_MVS_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void ButtonSave_MVS_Click(object sender, EventArgs e)
        {
            saveFileDialog_MVS.FileName = "OutPutFileTask7V25.csv";
            saveFileDialog_MVS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_MVS.ShowDialog();
            string path = saveFileDialog_MVS.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                File.Delete(path);
            }
            int rows = dataGridViewRes_MVS.RowCount;
            int col = dataGridViewRes_MVS.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != col - 1)
                    {
                        str += dataGridViewRes_MVS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewRes_MVS.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }




    }
}