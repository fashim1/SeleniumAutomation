using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpTopAutomation.CommonFunctions;
using UpTopAutomation.PageObjects;

namespace UpTopAutomation.TestCases
{
    class TenantChargesTest
    {
        [Test]
        public void CreateTenantCharge()
        {

            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\FerozAshim\Desktop\geckodriver-v0.24.0-win64");
            //service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            //IWebDriver driver = new FirefoxDriver(service);           

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
            //-------------------------------------------------------------------------------------------------------

            //Enter Username
            loginPagePO.UserName.SendKeys("Fashim+55@liveuptop.com");
            //Enter Password
            loginPagePO.Password.SendKeys("Testing1!");
            //Click on Submit Button
            loginPagePO.Submit.Click();

            //-------------------------------------------------------------------------------------------------------
                
            System.Threading.Thread.Sleep(2000);
            // new Actions(driver).Click(topNavigationPO.GearIcon).Perform();

            topNavigationPO.GearIcon.Click();
            topNavigationPO.TenantCharges.Click();
            System.Threading.Thread.Sleep(2000);
            tenantChargesPO.AddTenantCharges.Click();
            System.Threading.Thread.Sleep(2000);

            String[] arr = { "Select Account", "1000 - BankAccountForEntity", "1001 - Escrow - LLCEntity", "1002 - EntityAccount2", "1003 - Escrow - Entity2", "1004 - TestAccount456", "1005 - Escrow - EntityCorp4", "1006 - Account332", "1007 - Escrow - EntityCorp444", "1008 - AccounttestFromEntity", "1009 - Escrow - CoopEntity",
            "1200 - Accounts Receivable", "1300 - Prepaid Expenses", "2000 - Accounts Payable", "2100 - Security Deposits", "2200 - Tenant Prepayments", "3200 - Opening Balance", "4000 - Rent", "4100 - Disputes", "4200 - Surcharges", "4300 - Late Fees", "4400 - Concessions", "6050 - Payment Processing Fees"};

            var selectElement = new SelectElement(tenantChargesPO.ModalSelectAccount);
            IList<IWebElement> dropdownValues = selectElement.Options;
            int elementsSize = dropdownValues.Count;
            for (int i = 0; i < elementsSize; i++)
            {
                Console.WriteLine("Value at " + i + " is: " + dropdownValues.ElementAt(i).Text);

                if (dropdownValues.ElementAt(i).Text.Contains(arr[i]))
                {
                    Console.WriteLine("Passed dropdown verification");
                }
                else
                {
                    Console.WriteLine("Failed dropdown verification");
                }
            }

            String randomValues = commonPageFunctions.randomCharactersGenerator();
            tenantChargesPO.ModalNameTextbox.SendKeys(randomValues);
            commonPageFunctions.selectFromDropdown(tenantChargesPO.ModalSelectAccount, 2);
            System.Threading.Thread.Sleep(2000);
            tenantChargesPO.ModalAddTenantCharge.Click();
            System.Threading.Thread.Sleep(2000);

            commonPageFunctions.VerifyElementInTableExists(driver, tenantChargesPO.TenantChargesListTable, randomValues);
 
            System.Threading.Thread.Sleep(2000);
            tenantChargesPO.ModalNameTextbox.Clear();
            String randomValueUpdate = commonPageFunctions.randomCharGenerator();
            tenantChargesPO.ModalNameTextbox.SendKeys(randomValueUpdate);
            System.Threading.Thread.Sleep(2000);
            commonPageFunctions.selectFromDropdown(tenantChargesPO.ModalSelectAccount, 4);
            tenantChargesPO.ModalSaveChanges.Click();
            System.Threading.Thread.Sleep(2000);

            commonPageFunctions.VerifyElementInTableExists(driver, tenantChargesPO.TenantChargesListTable, randomValueUpdate);
     
            System.Threading.Thread.Sleep(2000);
            tenantChargesPO.ModalDelete.Click();
            System.Threading.Thread.Sleep(2000);
            tenantChargesPO.ModalDeleteConfirm.Click();

        }
    }

}
