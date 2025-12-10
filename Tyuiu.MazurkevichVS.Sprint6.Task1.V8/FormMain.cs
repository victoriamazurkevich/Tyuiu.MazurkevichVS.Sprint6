using Tyuiu.MazurkevichVS.Sprint6.Task1.V8.Lib;
namespace Tyuiu.MazurkevichVS.Sprint6.Task1.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxForStart_MVS.Text);
                int stopStep = Convert.ToInt32(textBoxForEnd_MVS.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxRes2_MVS.Text = "";
                textBoxRes2_MVS.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxRes2_MVS.AppendText("+    X      +    F(x)  +" + Environment.NewLine);
                textBoxRes2_MVS.AppendText("+-----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}    |  {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxRes2_MVS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxRes2_MVS.AppendText("+-----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы РППб-25-1 Мазуркевич В. С.");
        }
    }
}
