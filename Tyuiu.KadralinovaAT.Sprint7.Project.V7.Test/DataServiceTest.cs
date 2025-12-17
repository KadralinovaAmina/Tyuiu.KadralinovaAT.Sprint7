using Tyuiu.KadralinovaAT.Sprint7.Project.V7.Lib;
namespace Tyuiu.KadralinovaAT.Sprint7.Project.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetArray()
        {
            DataService ds = new DataService();
            string file = "test.csv";
            string directory = @"C:\DataSprint7";
            string path = Path.Combine(directory, file);
            string[,] res = ds.GetArray(path);
            Assert.AreEqual("1", res[0, 0]);
            Assert.AreEqual("2", res[0, 1]);
            Assert.AreEqual("3", res[1, 0]);
            Assert.AreEqual("4", res[1, 1]);
            Assert.AreEqual("5", res[2, 0]);
            Assert.AreEqual("6", res[2, 1]);
        }
    }
}
