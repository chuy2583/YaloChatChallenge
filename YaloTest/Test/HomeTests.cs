using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using YaloTest.Pages;

namespace YaloTest.Test
{
    public class HomeTests : TestInitialize
    {
        [Test]
        public void SelectOptionFromMenuByName()
        {
            var login = new LoginPage();

            login.LoginAs(data.UserId, data.Password);

            var home = new HomePage();

            var selectedOption = home.GetOptionFromMenuBar("New Account");

            var selectedOptionText = selectedOption?.Text;            

            selectedOption?.Click();

            var header = home.SelectedOptionHeader.Text;

            var result = header.ToLower().Contains(selectedOptionText.ToLower());

            Assert.IsTrue(result, "The selected option was not found.");
        }


        [Test]
        public void SelectOptionFromMenuByIndex()
        {
            var login = new LoginPage();

            login.LoginAs(data.UserId, data.Password);

            var home = new HomePage();

            var selectedOption = home.GetOptionFromMenuBar(6);

            var optionText = selectedOption?.Text ?? "No option selected";
                        
            selectedOption?.Click();

            var result = home.SelectedOptionHeader.Text.ToLower().Contains(optionText.ToLower());

            Assert.IsTrue(result, "The selected option was not found.");
        }
    }
}
