using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using YaloTest.Base;

namespace YaloTest.Pages
{
    public class LoginPage : DriverHelper
    {

        public IWebElement UserIdTxt => Driver.FindElementByCssSelector("input[name='uid']");
        public IWebElement PasswordTxt => Driver.FindElementByCssSelector("input[name='password']");
        public IWebElement LoginBtn => Driver.FindElementByCssSelector("input[name='btnLogin']");


        public void LoginAs(string userId, string password)
        {
            UserIdTxt.SendKeys(userId);
            Console.WriteLine("User entered: {0}", userId);

            PasswordTxt.SendKeys(password);
            Console.WriteLine("Password entered: {0}", password);

            LoginBtn.Click();

        }
    }
}
