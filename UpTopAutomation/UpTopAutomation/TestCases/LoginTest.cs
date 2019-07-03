using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpTopAutomation.CommonFunctions;
using UpTopAutomation.PageObjects;

namespace UpTopAutomation.TestCases
{
    class LoginTest
    {

        [Test]
        public void Test()
        {

            //-------------------------------------------------------------------------------------------------------
            // FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\FerozAshim\Desktop\geckodriver-v0.24.0-win64");
            //  service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            //IWebDriver driver = new FirefoxDriver(service);

//--------------------------------------------------------------------------------------------------
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://dev-manage.liveuptop.com";

            var loginPagePO = new LoginPagePO();
            PageFactory.InitElements(driver, loginPagePO);
            var topNavigationPO = new TopNavigationPO();
            PageFactory.InitElements(driver, topNavigationPO);
            var portfolioPO = new PortfolioPagePO();
            PageFactory.InitElements(driver, portfolioPO);

            var commonPageFunctions = new CommonPageFunctions();
            PageFactory.InitElements(driver, commonPageFunctions);
//-------------------------------------------------------------------------------------------------------

            //Enter Username
            loginPagePO.UserName.SendKeys("Fashim+55@liveuptop.com");
            //Enter Password
            loginPagePO.Password.SendKeys("Testing1!");
            //Click on Submit Button
            loginPagePO.Submit.Click();

//-------------------------------------------------------------------------------------------------------

            commonPageFunctions.ElementToBeClickable(driver, topNavigationPO.GearIcon);        
            topNavigationPO.GearIcon.Click();
            topNavigationPO.Portfolio.Click();

            commonPageFunctions.ElementToBeClickable(driver, portfolioPO.AddEntityButton);
            portfolioPO.AddEntityButton.Click();

            commonPageFunctions.ElementToBeClickable(driver, portfolioPO.LegalEntityType);
            commonPageFunctions.selectFromDropdown(portfolioPO.LegalEntityType, 4);

            portfolioPO.YourHomeAddress.SendKeys("11114 120th Street, Jamaica, NY, USA");
            commonPageFunctions.ElementToBeClickable(driver, portfolioPO.YourHomeAddressClickFirst);
            portfolioPO.YourHomeAddressClickFirst.Click();
            portfolioPO.SuiteFloorUnit.SendKeys("2");        

            //commonPageFunctions.ArrowLeftNine(portfolioPO.TaxId);
            //new Actions(driver).DoubleClick(portfolioPO.TaxId).Perform();
            portfolioPO.TaxId.SendKeys("99-9999999");

            portfolioPO.DateOfBirth.SendKeys("04/10/2000");
            portfolioPO.Phone.SendKeys("(347) 784-3528");
            portfolioPO.BusinessURL.SendKeys("https://google.com");
            portfolioPO.AccountNickname.SendKeys("Account");
            commonPageFunctions.selectFromDropdown(portfolioPO.AccountRole, 1);
            portfolioPO.NameOnAccount.SendKeys("Thomas L Chen");
            commonPageFunctions.ArrowLeftNine(portfolioPO.RoutingNumber);
            new Actions(driver).DoubleClick(portfolioPO.RoutingNumber).Perform();
            portfolioPO.RoutingNumber.SendKeys("110000000");
            portfolioPO.AccountNumber.SendKeys("000123456789");
            



            //Close the driver
            //driver.Quit();

        }
    }
}
