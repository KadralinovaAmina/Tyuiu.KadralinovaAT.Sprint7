using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KadralinovaAT.Sprint7.Project.V7.Lib;
namespace Tyuiu.KadralinovaAT.Sprint7.Project.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void buttonHelp_KAT_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonGuide_KAT_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }
        public static string[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);
            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            string[,] array = new string[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    array[r, c] = line_r[c];
                }
            }
            return array;
        }
        private void buttonOpenFile_KAT_Click(object sender, EventArgs e)
        {
            openFileDialog_KAT.ShowDialog();
            openFilePath = openFileDialog_KAT.FileName;
            string[,] array = new string[rows, columns];
            array = LoadFromFileData(openFilePath);
            array = ds.GetArray(openFilePath);
            buttonDone_KAT.Enabled = true;
        }

        private void buttonDone_KAT_Click(object sender, EventArgs e)
        {
            dataGridViewTab_KAT.ColumnCount = columns;
            dataGridViewTab_KAT.RowCount = rows;
            dataGridViewTab_KAT.Rows[0].ReadOnly = true;
            dataGridViewTab_KAT.Columns[0].ReadOnly = true;
            string[,] array = new string[rows, columns];
            array = LoadFromFileData(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewTab_KAT.Rows[r].Cells[c].Value = array[r, c];
                }
            }
            array = ds.GetArray(openFilePath);
        }
        private void buttonSaveFile_KAT_Click(object sender, EventArgs e)
        {
            SaveFileDialog_KAT.FileName = "OutPutFileTask7.csv";
            SaveFileDialog_KAT.InitialDirectory = Directory.GetCurrentDirectory();
            SaveFileDialog_KAT.ShowDialog();
            string path = SaveFileDialog_KAT.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewTab_KAT.RowCount;
            int columns = dataGridViewTab_KAT.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTab_KAT.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewTab_KAT.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpenFile_KAT_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KAT.ToolTipTitle = "Открыть файл";
        }
        private void buttonDone_KAT_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KAT.ToolTipTitle = "Выполнить";
        }
        private void buttonSaveFile_KAT_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KAT.ToolTipTitle = "Сохранить в файл";
        }
        private void buttonHelp_KAT_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KAT.ToolTipTitle = "Справка";
        }
        private void buttonGuide_KAT_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KAT.ToolTipTitle = "Краткое руководство";
        }

        private void buttonGraphic_KAT_Click(object sender, EventArgs e)
        {
            chartGrafic_KAT.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Area;


            foreach (DataGridViewRow row in dataGridViewTab_KAT.Rows)
            {

                if (row.IsNewRow) continue;

                if (row.Cells[3].Value != null && row.Cells[2].Value != null)
                {
                    string areaStr = row.Cells[3].Value.ToString().Replace('.', ',');
                    string roomStr = row.Cells[2].Value.ToString();

                    if (double.TryParse(areaStr, out double area) &&
                        int.TryParse(roomStr, out int room))
                    {
                        series.Points.AddXY(room, area);
                    }
                }
            }
            chartGrafic_KAT.Series.Add(series);
            chartGrafic_KAT.Show();
        }

        private void buttonSearch_KAT_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewTab_KAT.RowCount; i++)
                {
                    dataGridViewTab_KAT.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridViewTab_KAT.ColumnCount; j++)
                        if (dataGridViewTab_KAT.Rows[i].Cells[j].Value != null)
                            if (dataGridViewTab_KAT.Rows[i].Cells[j].Value.ToString().Equals(textBoxSearch_KAT.Text))
                            {
                                dataGridViewTab_KAT.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            catch
            {
                MessageBox.Show("Данные не найдены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
