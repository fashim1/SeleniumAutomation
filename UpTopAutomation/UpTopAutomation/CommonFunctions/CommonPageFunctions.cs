using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpTopAutomation.CommonFunctions
{
    class CommonPageFunctions
    {

        private IWebDriver driver;


        
//-------------------------------------------------------------------------------------------------------
        public void selectFromDropdown(IWebElement ElementName, int Index)
        {
            var selectElement = new SelectElement(ElementName);
            selectElement.SelectByIndex(Index);
        }


//-------------------------------------------------------------------------------------------------------
        public void ElementToBeClickable(IWebDriver driver, IWebElement by)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(by));

        }

        public void ElementIsVisibleWait(IWebDriver driver, By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            throw new NotImplementedException();
        }
        //-------------------------------------------------------------------------------------------------------

        public void ArrowLeftNine(IWebElement element)
        {
            element.SendKeys(Keys.ArrowLeft); element.SendKeys(Keys.ArrowLeft); element.SendKeys(Keys.ArrowLeft);
            element.SendKeys(Keys.ArrowLeft); element.SendKeys(Keys.ArrowLeft); element.SendKeys(Keys.ArrowLeft);
            element.SendKeys(Keys.ArrowLeft); element.SendKeys(Keys.ArrowLeft); element.SendKeys(Keys.ArrowLeft);
        }

        public void TabOne(IWebElement element)
        {
            element.SendKeys(Keys.Tab);
        }


        public void ArrowLeftTwo(IWebElement element)
        {
            element.SendKeys(Keys.ArrowLeft); element.SendKeys(Keys.ArrowLeft);
        }

        public void EnterPress(IWebElement element)
        {
            element.SendKeys(Keys.Enter);
        }

            /*
            public void LoginTOLandlord()
            {
                //Enter Username
                loginPagePO.UserName.SendKeys("Fashim+55@liveuptop.com");
                //Enter Password
                loginPagePO.Password.SendKeys("Testing1!");
                //Click on Submit Button
                loginPagePO.Submit.Click();
            }
            */

 //----------------------------------------------------------------------------------------------------------------

            public void VerifyElementInTableExists(IWebDriver driver, IWebElement locatorOfTable, String companyName)
        {


            // xpath of html table
            //var elemTable = driver.FindElement(By.XPath(locatorOfTable));// Make the xpath reusable
            var elemTable = locatorOfTable;
            // Fetch all Row of the table
            List <IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            String strRowData = "";
            // Traverse each row
            foreach (var elemTr in lstTrElem)
            {
                // Fetch the columns from a particuler row
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    // Traverse each column
                    foreach (var elemTd in lstTdElem)
                    {
                        // "\t\t" is used for Tab Space between two Text
                        strRowData = strRowData + elemTd.Text + "\t\t";
                        Console.WriteLine(strRowData);
                    }

                }
                else
                {
                    // To print the data into the console
                    Console.WriteLine("This is the Header Row");
                    Console.WriteLine(lstTrElem[0].Text.Replace(" ", "\t\t"));
                }
            }
            if (strRowData.Contains(companyName))
            {
                String xpathReplacement = "//*[contains(text(), '{0}')]";

                driver.FindElement(By.XPath(String.Format(xpathReplacement, companyName))).Click();
                // driver.FindElement(By.XPath("//*[contains(text(),'Testing')]")).Click();
                Console.WriteLine("The Test Passed!!!");

            }
            else
            {
                Console.WriteLine("The Test Failed!!!");
            }


        }


        public void VerifyElementExistsInTable(IWebDriver driver, IWebElement locatorOfTable, String companyName)
        {


            // xpath of html table
            //var elemTable = driver.FindElement(By.XPath(locatorOfTable));// Make the xpath reusable
            var elemTable = locatorOfTable;
            // Fetch all Row of the table
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            String strRowData = "";
            // Traverse each row
            foreach (var elemTr in lstTrElem)
            {
                // Fetch the columns from a particuler row
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    // Traverse each column
                    foreach (var elemTd in lstTdElem)
                    {
                        // "\t\t" is used for Tab Space between two Text
                        strRowData = strRowData + elemTd.Text + "\t\t";
                        Console.WriteLine(strRowData);
                    }

                }
                else
                {
                    // To print the data into the console
                    Console.WriteLine("This is the Header Row");
                    Console.WriteLine(lstTrElem[0].Text.Replace(" ", "\t\t"));
                }
            }
            if (strRowData.Contains(companyName))
            {
                String xpathReplacement = "//*[contains(text(), '{0}')]";
                Console.WriteLine("The Test Passed!!!");

            }
            else
            {
                Console.WriteLine("The Test Failed!!!");
            }


        }


        //---------------------------------------------------------------------------------------------

        public String randomCharactersGenerator()
        {

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            Console.WriteLine(finalString);
            return finalString;
        }

        //---------------------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------------------

        public String randomCharGenerator()
        {

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            Console.WriteLine(finalString);
            return finalString;
        }


        public String randomNumGenConvertToString()
        {
            Random rnd = new Random();
            int randomAmount = rnd.Next(11111, 99999);
            string randomAmountConverted = Convert.ToString(randomAmount);

            Console.WriteLine(randomAmountConverted);
            return randomAmountConverted;
        }

        public String randomNumGenUpdateConvertToString()
        {
            Random rnd = new Random();
            int randomAmount = rnd.Next(11111, 99999);
            string randomAmountConverted = Convert.ToString(randomAmount);

            Console.WriteLine(randomAmountConverted);
            return randomAmountConverted;
        }
        //---------------------------------------------------------------------------------------------

        public void VerifyText(IWebDriver driver, By element, String message)
        {
            String ActualMessage = driver.FindElement(element).Text;
            Console.WriteLine(message);

            if (ActualMessage.Contains(message))
            {
                Console.WriteLine("Passed!!!");
            }


        }

    }
}
