namespace Tyuiu.KadralinovaAT.Sprint7.Project.V7.Lib
{
    public class DataService
    {
        public string[,] GetArray(string path)
        {
           
            string file = File.ReadAllText(path);
            file = file.Replace("\r\n", "\n").Replace("\r", "\n");

            string[] lines = file.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            if (lines.Length == 0)
            {
                return new string[0, 0];
            }

            int columns = lines[0].Split(';').Length;
            int rows = lines.Length;

            string[,] array = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(';');

                for (int j = 0; j < columns; j++)
                {
                    if (j < line.Length)
                    {
                        array[i, j] = line[j];
                    }
                    else
                    {
                        array[i, j] = string.Empty;
                    }
                }
            }

            return array;
        }
    }
}
