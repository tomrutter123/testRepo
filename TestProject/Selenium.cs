//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Text;
//using System.Threading;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System.Linq;
//using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Interactions;

//namespace TestProject
//{
//    class Selenium
//    {
//        public static IWebDriver Driver;

//        public static void Main(string[] args)
//        {
//            Driver = new ChromeDriver();
//            Driver.Manage().Window.Maximize();
//            Driver.Navigate().GoToUrl("https://letskodeit.teachable.com/p/practice");
//            System.Threading.Thread.Sleep(500);

//            string parentHandle = Driver.CurrentWindowHandle;
//            IWebElement openWindow = Driver.FindElement(By.Id("openwindow"));
//            openWindow.Click();

//            ReadOnlyCollection<string> handles = Driver.WindowHandles;
//            foreach (var handle in handles)
//            {
//                Console.WriteLine(handle);

//                if (!handle.Equals(parentHandle))
//                {
//                    //Console.WriteLine("This is the child handle" + handle) ;
//                    Driver.SwitchTo().Window(handle);
//                    IWebElement searchBox = Driver.FindElement(By.Id("search-courses"));
//                    searchBox.SendKeys("Java");
//                    searchBox.SendKeys(Keys.Enter);
//                    break;

//                }
//            }

//            confirmElementIsPresent(By.XPath("//div[contains(text(),'Selenium WebDriver With Java')]"));

//            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
//            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("")));

//            //Driver.FindElement(By.Id("name")).SendKeys("Tom");
//            //IWebElement alertBTN = Driver.FindElement(By.Id("alertbtn"));
//            //alertBTN.Click();
//            //IAlert alert = Driver.SwitchTo().Alert();
//            //System.Threading.Thread.Sleep(600);
//            //alert.Accept();
//            //IWebElement confirmBTN = Driver.FindElement(By.Id("confirmbtn"));

//            //Driver.FindElement(By.Id("loginUserName")).SendKeys("Tom");
//            //Actions action = new Actions(Driver);
//            //action.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Perform();

//            //Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe")));
//            //IWebElement slider = Driver.FindElement(By.Id("slider"));
//            //Actions action = new Actions(Driver);
//            //action.DragAndDropToOffset(slider, offsetX:300, offsetY:0).Perform();

//            //IWebElement fromBox = Driver.FindElement(By.XPath("//div[@id='draggable']"));
//            //IWebElement toBox = Driver.FindElement(By.XPath("//div[@id='droppable']"));
//            //Actions action = new Actions(Driver);
//            ////action.DragAndDrop(fromBox, toBox).Build().Perform();
//            //action.ClickAndHold(fromBox).MoveToElement(toBox).Release().Build().Perform();

//            //IWebElement mainBtn = Driver.FindElement(By.Id("mousehover"));
//            //Actions action = new Actions(Driver);
//            //action.MoveToElement(mainBtn).Perform();
//            //System.Threading.Thread.Sleep(500);

//            //IWebElement refreshBtn = Driver.FindElement(By.XPath("//div[@class='mouse-hover-content']//a[text()='Reload']"));
//            //action.MoveToElement(refreshBtn).Click().Perform();

//            //System.Threading.Thread.Sleep(5000);
//            //IList<IWebElement> allElements = Driver.FindElements(By.XPath("//a[contains(@href,'http')]"));

//            //foreach (IWebElement element in allElements)
//            //{
//            //    string LinkString = element.GetAttribute("href");
//            //    Console.WriteLine(LinkString);
//            //    //Driver.Navigate().GoToUrl(LinkString);
//            //}

//            //IWebElement table4Practice; // Table Element
//            //Dictionary<int, string> dictionaryTest = new Dictionary<int, string>(); // Dictionary Object for KVP

//            //table4Practice = Driver.FindElement(By.Id("product")); // Whole Table Object
//            //ReadOnlyCollection<IWebElement> rows = table4Practice.FindElements(By.TagName("tr")); // List of all Table row(s)

//            //for (int rNum = 0; rNum < rows.Count; rNum++) // Rows set at Zero, until Count met - Increment
//            //{
//            //    ReadOnlyCollection<IWebElement> cols = rows.ElementAt(rNum).FindElements(By.TagName("td")); // Access TD Elements

//            //    for (int cNum = 0; cNum < cols.Count; cNum++) // Cols set at Zero, until Count met - Increment
//            //    {
//            //        //Console.WriteLine(cols.ElementAt(cNum).Text); //Print all table vals

//            //        if (cNum == cols.Count - 2)
//            //        {
//            //            dictionaryTest.Add(rNum, cols.ElementAt(cNum).Text);
//            //            // Logic to get desired text and add to Dictionary
//            //        }

//            //    }

//            //}

//            //foreach (KeyValuePair<int, string> kvp in dictionaryTest)
//            //{
//            //    Console.WriteLine(kvp.Key + " : " + kvp.Value);
//            //    //Print Dictionary items to Console
//            //}

//            //Dictionary<string, string> dct = new Dictionary<string, string>();
//            //webElements = Driver.FindElements(By.PartialLinkText("o"));
//            //ReadOnlyCollection<IWebElement> webElements;

//            //IList<IWebElement> allElements = Driver.FindElements(By.XPath("//td"));

//            //foreach (IWebElement element in allElements)
//            //{
//            //    string tableText = element.Text;
//            //    Console.WriteLine(tableText);
//            //}

//            //IWebElement hide = Driver.FindElement(By.Id("hide-textbox"));
//            //hide.Click();

//            //IWebElement show = Driver.FindElement(By.Id("show-textbox"));

//            //IWebElement textThatgetsHidden = Driver.FindElement(By.Id("displayed-text"));

//            //if (textThatgetsHidden.Displayed == false)
//            //{
//            //    Console.WriteLine("Text is Hidden");
//            //} else
//            //{
//            //    Console.WriteLine("Not Hidden");
//            //}

//            //show.Click();

//            //if (textThatgetsHidden.Displayed == false)
//            //{
//            //    Console.WriteLine("Text is Hidden");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Not Hidden");
//            //}

//            //IWebElement Selector = Driver.FindElement(By.Id("multiple-select-example"));
//            //SelectElement oSelect = new SelectElement(Selector);
//            //oSelect.SelectByIndex(0);
//            //System.Threading.Thread.Sleep(500);
//            //SelectElement oSelect1 = new SelectElement(Selector);
//            //oSelect.SelectByText("Orange");
//            //System.Threading.Thread.Sleep(500);
//            //SelectElement oSelect2 = new SelectElement(Selector);
//            //oSelect.SelectByValue("peach");

//            //oSelect.AllSelectedOptions.Count();
//            //IList<IWebElement> elementCount = oSelect.AllSelectedOptions;
//            //int iSize = elementCount.Count;

//            //for (int i = 0; i < iSize; i++)
//            //{
//            //    String sValue = elementCount.ElementAt(i).Text;
//            //    Console.WriteLine(sValue);
//            //}

//            //IWebElement bmw = Driver.FindElement(By.Id("bmwradio"));
//            //bmw.Click();
//            //Console.WriteLine("BMW is Selected : " + bmw.Selected);
//            //System.Threading.Thread.Sleep(500);

//            //IWebElement benz = Driver.FindElement(By.Id("benzradio"));
//            //benz.Click();
//            //Console.WriteLine("Benz is Selected : " + benz.Selected);
//            //System.Threading.Thread.Sleep(500);

//            //IWebElement honda = Driver.FindElement(By.Id("hondaradio"));
//            //honda.Click();
//            //Console.WriteLine("Honda is Selected : " + honda.Selected);

//            //foreach (IWebElement element in webElements)
//            //{
//            //    Console.WriteLine(element.Text);
//            //}

//            //Thread.Sleep(5000);
//            //IWebElement webElementPwd;
//            //IWebElement webElementUid;

//            //webElementPwd = Driver.FindElement(By.XPath("//input[@placeholder='Password']"));
//            //webElementUid = Driver.FindElement(By.XPath("//input[@placeholder='Username']"));
//            //webElementUid.SendKeys("tom.rutter");
//            //webElementPwd.SendKeys("win-once-during-quantity-4");

//            //string attValue = webElementUid.GetAttribute("value");
//            //Console.WriteLine(attValue);
//            //Console.WriteLine("==============================================");

//            //string attValue = "MADDAM", revs = ""; // PAL
//            ////string attValue = "MADDAM";
//            //List<char> genericLs = attValue.ToCharArray().ToList<char>();      // so this list has 3 items T = 0,O = 1,M = 2

//            //int size = genericLs.Count;

//            //List<char> genericLstReverse = new List<char>();

//            //for (int i = size - 1; i >= 0; i--)
//            //{
//            //    revs += attValue[i].ToString();
//            //    genericLstReverse.Add(genericLs.ElementAt(i));
//            //}

//            //foreach (char c in genericLstReverse)
//            //{
//            //    Console.WriteLine(c);
//            //}

//            //if (revs == attValue)
//            //{
//            //    Console.WriteLine("String is Palindorme");
//            //} else
//            //{
//            //    Console.WriteLine("String is NOT a Palindorme");
//            //}

//            //foreach (int i in genericLst)
//            //{
//            //    Console.WriteLine(i);
//            //}

//            //foreach (IWebElement element in webElements)
//            //{
//            //    Console.WriteLine(element.Text);
//            //}

//            //foreach(IWebElement element in webElements)
//            //{
//            //    Console.WriteLine(element.GetAttribute("href"));
//            //    urls.Add(item:element.GetAttribute("href"));
//            //}

//            //foreach (string url in urls)
//            //{
//            //    Driver.Navigate().GoToUrl(url);
//            //}

//            //Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe")));
//            //webElements = Driver.FindElements(By.XPath("//li")); 

//            //foreach (IWebElement element in webElements)
//            //{
//            //    Console.WriteLine(element.Text);
//            //}

//        }

//        // write a method for the above that just takes a element locator so it can be reused

//        // Access Specifier (public/private/protected) [optional - static] returntype (void/string/int) (method name) (the passed parameters with datatype - string x , int y)
//        public static void confirmElementIsPresent(By Locator)
//        {
//            //IWebElement javaCourse = Driver.FindElement(By.XPath("//div[contains(text(),'Selenium WebDriver With Java')]"));

//            ReadOnlyCollection<IWebElement> elementIsPresent = Driver.FindElements(Locator);

//            if (elementIsPresent.Count > 0)
//            {
//                Console.WriteLine("Book Found");
//            }
//            else
//            {
//                Console.WriteLine("Book Not Found");
//            }
//        }
//    }
//}
