using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YaloTest.Base;

namespace YaloTest.Pages
{
    public class HomePage : DriverHelper
    {
        public IList<IWebElement> MenuBar => Driver.FindElementsByCssSelector("ul.menusubnav a");
        public IWebElement SelectedOptionHeader => Driver.FindElementByCssSelector("p.heading3");


        public IWebElement GetOptionFromMenuBar(string option)
        {
            var result = MenuBar.FirstOrDefault(e => e.Text.Contains(option));

            Console.WriteLine("Option selected : {0}", result.Text);

            return result;
        }

        public IWebElement GetOptionFromMenuBar(int index)
        {
            if (index >= 0 && index < MenuBar.Count)
            {

                Console.WriteLine("Option selected : {0}", MenuBar[index].Text);
                return MenuBar[index];
            }
            else
            {
                Console.WriteLine("The index entered is greater than the exist in the Menu.");
            }

            return null;
        }
    }
}
