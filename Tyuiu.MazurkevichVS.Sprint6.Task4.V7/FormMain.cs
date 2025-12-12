using Tyuiu.MazurkevichVS.Sprint6.Task4.V7.Lib;
namespace Tyuiu.MazurkevichVS.Sprint6.Task4.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds= new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxForSTart_MVS.Text);
                int stop = Convert.ToInt32(textBoxForEnd_MVS.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, stop);
                this.chartResult_MVS.ChartAreas[0].AxisY.Title = "Ось Y";
                this.chartResult_MVS.ChartAreas[0].AxisX.Title = "Ось X";
                textBoxResult_MVS.Text = "";
                chartResult_MVS.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartResult_MVS.Series[0].Points.AddXY(start, valueArray[i]);
                    textBoxResult_MVS.AppendText(valueArray[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonInfo_MVS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы РППб-25-1 Мазуркевич В. С.", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonSave_MVS_Click(Object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V7.txt";
                File.WriteAllText(path, textBoxResult_MVS.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
