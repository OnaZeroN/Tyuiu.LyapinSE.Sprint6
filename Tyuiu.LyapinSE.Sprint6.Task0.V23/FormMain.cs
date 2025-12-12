using Tyuiu.LyapinSE.Sprint6.Task0.V23.Lib;

namespace Tyuiu.LyapinSE.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-25-1 Ляпин Степан Евгеньевич", "Сообщение");
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
