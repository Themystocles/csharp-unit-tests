using Myclasses;
namespace MyClassesTeste
    
{
    [TestClass]
    public class FileProcessTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [Owner("Themystocles")]
        [Priority(0)]
        [TestCategory("No Exception")]
        
        [Description ("Check to see if a  file does exsists")]
        public void fileNameDoesExists()
        {
            TestContext.WriteLine("Creating File");
            FileProcess fp = new FileProcess();
            bool resultado;
            TestContext.WriteLine("Testing File");
            resultado = fp.FileExists(@"c:\windows\Regedit.exe");
            TestContext.WriteLine("Validando File");
            Assert.IsTrue(resultado);


        }
        [TestMethod]
        [TestCategory("No Exception")]
        [Description("Check to see if a  file does exsists")]
        public void fileNameDoesNotExists()
        {
            FileProcess fp = new FileProcess();
            bool resultado;
            resultado = fp.FileExists(@"c:\Regedit.exe");
            Assert.IsFalse(resultado);

        }
        [TestMethod]
        [Timeout(4000)]
        [Ignore]

        public void SimulateTimeout()
        {
            System.Threading.Thread.Sleep(3000);
        }

        [TestMethod]
        [TestCategory("Exception")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void fileNameDoesNotExists_throwArgumentNullException()
        {
            // TODO;
            FileProcess fp = new FileProcess();

            fp.FileExists("");

        }
        [TestMethod]
        [TestCategory("Exception")]
        public void fileNameDoesNotExists_throwArgumentNullException_usingTryCatch()
        {
            // TODO;
            FileProcess fp = new FileProcess();
            try
            {
                fp.FileExists("");
            }
            catch (ArgumentException)
            {

                return;
            }

            Assert.Fail("Falha esperada");

        }
    }
}