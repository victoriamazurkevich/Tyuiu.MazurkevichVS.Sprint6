using Tyuiu.MazurkevichVS.Sprint6.Task6.V8.Lib;
namespace Tyuiu.MazurkevichVS.Sprint6.Task6.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonPush_MVS_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxRes_MVS.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_MVS_Click(object seder, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonLoad_MVS_Click(object seder, EventArgs e)
        {
            openFileDialog_MVS.ShowDialog();
            openFilePath = openFileDialog_MVS.FileName;
            textBoxInput_MVS.Text = File.ReadAllText(openFilePath);
            groupBoxRes_MVS.Text = groupBoxRes_MVS.Text + " " + openFileDialog_MVS.FileName;
            buttonLoad_MVS.Enabled = true;
        }
    }

}
