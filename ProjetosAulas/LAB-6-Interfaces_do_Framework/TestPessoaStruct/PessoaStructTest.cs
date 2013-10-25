using LAB_6_Interfaces_do_Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace TestPessoaStruct
{
    
    
    /// <summary>
    ///This is a test class for PessoaStructTest and is intended
    ///to contain all PessoaStructTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PessoaStructTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for PessoaStruct Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Altamir Benkenstein\\Dropbox\\GITHUB\\S2B\\ProjetosAulas\\LAB-6-Interfaces_do_Framework\\LAB-6-Interfaces_do_Framework", "/")]
        [UrlToTest("http://localhost:50891/")]
        public void PessoaStructConstructorTest()
        {
            string n = "Altamir"; 
            int i = 12; 
            PessoaStruct target = new PessoaStruct(n, i);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Idade
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Altamir Benkenstein\\Dropbox\\GITHUB\\S2B\\ProjetosAulas\\LAB-6-Interfaces_do_Framework\\LAB-6-Interfaces_do_Framework", "/")]
        [UrlToTest("http://localhost:50891/")]
        public void IdadeTest()
        {
            string n = "Altamir";
            int i = 12;
            PessoaStruct target = new PessoaStruct(n, i);
            int expected = 12;
            int 
            Assert.AreEqual(expected, target.Idade);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Nome
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Altamir Benkenstein\\Dropbox\\GITHUB\\S2B\\ProjetosAulas\\LAB-6-Interfaces_do_Framework\\LAB-6-Interfaces_do_Framework", "/")]
        [UrlToTest("http://localhost:50891/")]
        public void NomeTest()
        {
            PessoaStruct target = new PessoaStruct(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Nome;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
