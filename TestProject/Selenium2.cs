using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace TestProject
{
    class Selenium
    {
        public static IWebDriver Driver;
        public static void Main(string[] args)
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://letskodeit.teachable.com/p/practice");
            Thread.Sleep(400);
            //IWebElement txtBox = javasScriptMethod3();
            //txtBox.SendKeys(text: "Tom");

            //long product = javasScriptMethod4();
            //Console.WriteLine(product);
            //Console.WriteLine(javasScriptMethod4());

            //long width = jsWidth();
            //long height = jsHeight();
            //Console.WriteLine(jsWidth() * jsHeight());

            //scrollIntoView(By.Id("mousehover"));
            
            bool result = tryAnCatch(By.Id("mousehover1"));

            if (result == true)
            {
                Console.WriteLine("element exists");
            } else {
                jsFindEl();
            }

        }

        static bool tryAnCatch (By Locator)
        {

            try
            {
                Driver.FindElement(Locator);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }

        static void jsFindEl()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            IWebElement pageElement = Driver.FindElement(By.Id("mousehover"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", pageElement);
            Console.WriteLine("scrolled to using js");
        }

        static void scrollIntoView(By Locator)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            IWebElement pageElement = Driver.FindElement(Locator);
            js.ExecuteScript("arguments[0].scrollIntoView(true);", pageElement);
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0, -1900);");
            Thread.Sleep(4000);
        }

        static void javasScriptMethod(By Locator)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            IWebElement checkBox = Driver.FindElement(Locator);
            js.ExecuteScript("arguments[0].click();", checkBox);
        }

        static void javasScriptMethod2(IWebElement checkBox)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].click();", checkBox);
        }

        static IWebElement javasScriptMethod3()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            IWebElement txtBox = (IWebElement)js.ExecuteScript("return document.getElementById( 'name' ); ");
            return txtBox;
        }

        static long javasScriptMethod4()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            long height = (long)js.ExecuteScript("return window.innerHeight;");
            long width = (long)js.ExecuteScript("return window.innerWidth;");
            return height * width;
        }
        static long jsHeight()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            long height = (long)js.ExecuteScript("return window.innerHeight;");
            return height;
        }

        static long jsWidth()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            long width = (long)js.ExecuteScript("return window.innerWidth;");
            return width;
        }

    }
}
