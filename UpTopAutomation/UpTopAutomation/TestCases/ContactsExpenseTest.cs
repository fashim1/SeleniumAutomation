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
    class ContactsExpenseTest
    {

        [Test]
        public void CreateExpense()
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

            //driver.FindElement(By.XPath("//*[contains(text(),'74zzR8ul')]")).Click();
            System.Threading.Thread.Sleep(2000);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(document.body.scrollHeight,0)");

            contactsPO.AddTransactionButton.Click();
            contactsPO.AddExpenseButton.Click();
            System.Threading.Thread.Sleep(2000);
            contactsPO.selectOrgEntityProp.Click();
            contactsPO.selectFirstFromOrgEntityProp.Click();
            System.Threading.Thread.Sleep(2000);
            contactsPO.DateEditbox.SendKeys("06/20/2019");
            commonPageFunctions.EnterPress(contactsPO.DateEditbox);

            commonPageFunctions.selectFromDropdown(contactsPO.SelectBankCreditCard, 2);
            commonPageFunctions.selectFromDropdown(contactsPO.SelectPaymentMethod, 1);


            contactsPO.ClickToAddRow.Click();

            commonPageFunctions.selectFromDropdown(contactsPO.SelectExpenseAccount, 1);

            contactsPO.DescriptionTextbox.SendKeys("Description Test");
            System.Threading.Thread.Sleep(2000);
            String randomAmountConverted = commonPageFunctions.randomNumGenConvertToString();
            contactsPO.AmountTextbox.SendKeys(randomAmountConverted);
            System.Threading.Thread.Sleep(2000);
            String retrievedExpenseAmount = contactsPO.retrievedInvoiceAmount.Text;
            contactsPO.SaveExpenseButton.Click();
            System.Threading.Thread.Sleep(2000);

            commonPageFunctions.VerifyElementInTableExists(driver, contactsPO.TransactionTable, retrievedExpenseAmount);
            contactsPO.ExpenseClickFirstRow.Click();

            System.Threading.Thread.Sleep(2000);

            contactsPO.AmountTextbox.Clear();
            String randomAmountUpdateConverted = commonPageFunctions.randomNumGenUpdateConvertToString();
            contactsPO.AmountTextbox.SendKeys(randomAmountUpdateConverted);
            System.Threading.Thread.Sleep(2000);

            String retrievedExpenseAmountUpdated = contactsPO.retrievedInvoiceAmount.Text;
            Console.WriteLine(retrievedExpenseAmountUpdated);

            contactsPO.UpdateExpenseButton.Click();
            System.Threading.Thread.Sleep(2000);
            commonPageFunctions.VerifyElementInTableExists(driver, contactsPO.TransactionTable, retrievedExpenseAmountUpdated);
            contactsPO.ExpenseClickFirstRow.Click();
            System.Threading.Thread.Sleep(3000);
            contactsPO.ModalMoreButton.Click();
            contactsPO.ModalDeleteButton.Click();
            System.Threading.Thread.Sleep(2000);
            contactsPO.ModalDeleteConfirmButton.Click();
            System.Threading.Thread.Sleep(2000);
            contactsPO.DeleteContactsButton.Click();

        }
    }
}
