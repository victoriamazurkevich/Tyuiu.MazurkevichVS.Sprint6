using Tyuiu.MazurkevichVS.Sprint6.Task2.V14.Lib;
namespace Tyuiu.MazurkevichVS.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void ButtonDone_click_MVS_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxForStart_MVS.Text);
                int stop = Convert.ToInt32(textBoxForEnd_MVS.Text);

                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(start, stop);

                this.chartRes_MVS.Titles.Add("График функции F(x)");

                this.chartRes_MVS.ChartAreas[0].AxisY.Title = "Ось Y";
                this.chartRes_MVS.ChartAreas[0].AxisX.Title = "Ось X";

                for (int i = 0; i <= len - 1; i++)
                {

                    this.dataGridView1.Rows.Add(Convert.ToString(start), Convert.ToString(valueArray[i]));
                    this.chartRes_MVS.Series[0].Points.AddXY(start, valueArray[i]);
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
            MessageBox.Show("Таск 2 выполнила студентка группы РППб-25-1 Мазуркевич В. С.");
        }

    }
}
