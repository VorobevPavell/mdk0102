namespace TestProject2
{
    public class Tests
    {
        private const string Expected = "Hello World!";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Assert.Pass();
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleApp1.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}