using Tyuiu.MazurkevichVS.Sprint6.Task5.V1.Lib;
namespace Tyuiu.MazurkevichVS.Sprint6.Task5.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string inputpath = @"C:\DataSprint6\InPutDataFileTask5V1.txt";
        string outpath = @"C:\DataSprint6\OutPutDataFileTask5V1.txt";

        private void buttonDone_MVS_Click(object sender, EventArgs e)
        {
            dataGridViewRes_MVS.ColumnCount = 2;
            dataGridViewRes_MVS.Columns[0].Width = 20;
            dataGridViewRes_MVS.Columns[1].Width = 50;

            this.chartRes_MVS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartRes_MVS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartRes_MVS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(inputpath);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewRes_MVS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartRes_MVS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_MVS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = inputpath;
            txt.Start();
        }

        private void buttonInfo_MVS_Click(object obj, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы РППб-25-1 Мазуркевич В. С.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
