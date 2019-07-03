using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpTopAutomation.CommonFunctions;
using UpTopAutomation.PageObjects;

namespace UpTopAutomation.TestCases
{
    class ContactsMaintenanceRequest
    {
        [Test]
        public void CreateMaintenanceRequest()
        {
            //---------------------------------------------------------------
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://dev-manage.liveuptop.com";
            driver.Manage().Window.Maximize();

            var loginPagePO = new LoginPagePO();
            PageFactory.InitElements(driver, loginPagePO);
            var topNavigationPO = new TopNavigationPO();
            PageFactory.InitElements(driver, topNavigationPO);
            var portfolioPO = new PortfolioPagePO();
            PageFactory.InitElements(driver, portfolioPO);

            var commonPageFunctions = new CommonPageFunctions();
            PageFactory.InitElements(driver, commonPageFunctions);

            var tenantChargesPO = new TenantChargesPO();
            PageFactory.InitElements(driver, tenantChargesPO);

            var contactsPO = new ContactsPO();
            PageFactory.InitElements(driver, contactsPO);


            //-------------------------------------------------------------------------------------------------------

            //Enter Username
            loginPagePO.UserName.SendKeys("Fashim+55@liveuptop.com");
            //Enter Password
            loginPagePO.Password.SendKeys("Testing1!");
            //Click on Submit Button
            loginPagePO.Submit.Click();

            //-------------------------------------------------------------------------------------------------------


            System.Threading.Thread.Sleep(4000);
            // new Actions(driver).Click(topNavigationPO.GearIcon).Perform();
            topNavigationPO.GearIcon.Click();
            topNavigationPO.ContactDirectory.Click();
            System.Threading.Thread.Sleep(2000);

            commonPageFunctions.VerifyElementInTableExists(driver, contactsPO.ContactsListTable, "ABC Company");
            System.Threading.Thread.Sleep(2000);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(document.body.scrollHeight,0)");

            contactsPO.AddRequestButton.Click();
            System.Threading.Thread.Sleep(2000);
            contactsPO.MaintRequestAddressTextbox.SendKeys("444");
            System.Threading.Thread.Sleep(2000);
            contactsPO.MaintRequestClickFirstAddress.Click();

            String Title = commonPageFunctions.randomCharactersGenerator();

            contactsPO.MaintRequestTitle.SendKeys(Title);
            commonPageFunctions.selectFromDropdown(contactsPO.MaintRequestCategories, 2);
            contactsPO.MaintRequestRadioUrgent.Click();

            contactsPO.MaintRequestDescription.Click();
            contactsPO.MaintRequestDescription.SendKeys("Test Description");
            contactsPO.MaintRequestAddRequestButton.Click();
            System.Threading.Thread.Sleep(2000);
            commonPageFunctions.VerifyElementInTableExists(driver, contactsPO.MaintRequestTable, Title);
            System.Threading.Thread.Sleep(2000);
            contactsPO.MaintRequestTitle.Clear();
            String TitleUpdated = commonPageFunctions.randomCharactersGenerator();
            contactsPO.MaintRequestTitle.SendKeys(TitleUpdated);
            contactsPO.MaintRequestAddRequestButton.Click();
            System.Threading.Thread.Sleep(2000);
            commonPageFunctions.VerifyElementExistsInTable(driver, contactsPO.MaintRequestTable, TitleUpdated);
        }


    }
}
