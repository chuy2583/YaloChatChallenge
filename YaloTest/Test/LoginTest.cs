using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using YaloTest.Pages;

namespace YaloTest.Test
{
    [TestFixture]
    public class LoginTest : TestInitialize
    {
        [Test]
        public void LoginSucces()
        {
            var login = new LoginPage();

            login.LoginAs(data.UserId, data.Password);

            var pageTitle = Driver.Title;

            Assert.AreEqual("Guru99 Bank Manager HomePage", pageTitle, "Home page was not loaded.");
        }
    }
}
