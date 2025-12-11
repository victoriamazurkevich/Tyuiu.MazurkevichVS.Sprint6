using Tyuiu.MazurkevichVS.Sprint6.Task3.V28.Lib;
namespace Tyuiu.MazurkevichVS.Sprint6.Task3.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { -9, 8, 9, 16, -18 },
                                          { -13, -11, -20, -15, 9 },
                                          { 18, 13, -12, -15, -11 },
                                          { 10, -2, 19, -4, -10 },
                                          { 6, -20, -4, 13, -14} };







        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_MVS.ColumnCount = columns;
            dataGridViewMatrix_MVS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_MVS.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_MVS.Rows[i].Cells[i].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void ButtonInfo_MVS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы РППб-25-1 Мазуркевич В. С.");
        }

        private void ButtonDone_click_MVS_Click(Object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_MVS.ColumnCount = columns;
            dataGridViewMatrix_MVS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_MVS.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_MVS.Rows[i].Cells[i].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
