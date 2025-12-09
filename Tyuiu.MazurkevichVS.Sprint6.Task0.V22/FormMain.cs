using Tyuiu.MazurkevichVS.Sprint6.Task0.V22.Lib;
using System;
using System.Windows.Forms;

namespace Tyuiu.MazurkevichVS.Sprint6.Task0.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textRes_MVS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxForX_MVS.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxForX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы РППб-25-1 Мазуркевич Виктория Сергеевна");
        }

        // Обработчики событий для элементов из дизайнера
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Обработчик клика по pictureBox1
        }

        private void textRes_MVS_TextChanged(object sender, EventArgs e)
        {
            // Обработчик изменения текста в textRes_MVS
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            // Обработчик клика по кнопке информации
            buttonHelp_Click(sender, e);
        }
    }
}