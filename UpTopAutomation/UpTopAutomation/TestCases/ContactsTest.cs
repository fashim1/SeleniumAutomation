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
    class ContactsTest
    {

        [Test]
        public void CreateContact()
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
            contactsPO.AddContact.Click();
            String companyName = commonPageFunctions.randomCharactersGenerator();
            System.Threading.Thread.Sleep(2000);
            contactsPO.AddContactCompanyName.SendKeys(companyName);
            contactsPO.AddContactContinueButton.Click();
            System.Threading.Thread.Sleep(2000);

            commonPageFunctions.VerifyElementInTableExists(driver, contactsPO.ContactsListTable, companyName);

            System.Threading.Thread.Sleep(2000);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(document.body.scrollHeight,0)");

            contactsPO.UpdateContactButton.Click();
            System.Threading.Thread.Sleep(2000);
            contactsPO.AddContactCompanyName.Clear();

            String randomValueUpdate = commonPageFunctions.randomCharGenerator();
            contactsPO.AddContactCompanyName.SendKeys(randomValueUpdate);
            contactsPO.SaveContactsButton.Click();
            System.Threading.Thread.Sleep(2000);
            String verifyContact = contactsPO.VerifyContactUpdated.Text;
            if (verifyContact.Contains(randomValueUpdate)){
                Console.WriteLine("Actual " + verifyContact);
                Console.WriteLine("Expected " + randomValueUpdate);
                Console.WriteLine("Update Successful");
            }
            else
            {
                Console.WriteLine("Update Failed");
            }
            System.Threading.Thread.Sleep(2000);
            contactsPO.DeleteContactsButton.Click();
            
















        }



    }
}
