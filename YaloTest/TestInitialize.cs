using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using YaloTest.Base;
using YaloTest.DataPool;

namespace YaloTest
{
    public class TestInitialize : DriverHelper
    {
        public Data data;

        [SetUp]
        public void Setup()
        {

            data = JsonReaderHelper.DataFileReader<Data>(TestContext.CurrentContext.WorkDirectory + @"\DataPool\Data.json");

            Driver = new ChromeDriver();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            Driver.Url = data.Url;
            Driver.Manage().Window.Maximize();
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();

        }


    }
}