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
    class CreateLeaseTest
    {
        [Test]
        public void CreateLease()
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

            var createLeasePO = new CreateLeasePO();
            PageFactory.InitElements(driver, createLeasePO);

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //-------------------------------------------------------------------------------------------------------

            //Enter Username
            loginPagePO.UserName.SendKeys("Fashim+55@liveuptop.com");
            //Enter Password
            loginPagePO.Password.SendKeys("Testing1!");
            //Click on Submit Button
            loginPagePO.Submit.Click();

            //-------------------------------------------------------------------------------------------------------

            System.Threading.Thread.Sleep(2000);
            topNavigationPO.Tenants.Click();
            System.Threading.Thread.Sleep(2000);
            createLeasePO.CreateLeaseButton.Click();
            System.Threading.Thread.Sleep(2000);
            createLeasePO.SelectUnitButton.Click();
            createLeasePO.SelectUnitEditBox.Click();
            System.Threading.Thread.Sleep(2000);
            createLeasePO.SelectUnitEditBox.SendKeys(Keys.NumberPad3);
            createLeasePO.SelectUnitEditBox.SendKeys(Keys.NumberPad3);
            createLeasePO.SelectUnitEditBox.SendKeys(Keys.NumberPad2);
            System.Threading.Thread.Sleep(2000);
            createLeasePO.SelectUnitEditBox.Click();
            System.Threading.Thread.Sleep(2000);
            createLeasePO.ClickOnFourthAddress.Click();
            System.Threading.Thread.Sleep(2000);
            createLeasePO.AddTenantGuarantorBtn.Click();
            System.Threading.Thread.Sleep(2000);
            createLeasePO.EnterTenantGuarantorEmail.SendKeys("fashim+70");
            System.Threading.Thread.Sleep(4000);
            createLeasePO.ClickFirstEmail.Click();
            System.Threading.Thread.Sleep(2000);

            createLeasePO.StartDateEditbox.SendKeys("06/20/2019");
            commonPageFunctions.EnterPress(createLeasePO.StartDateEditbox);
            createLeasePO.EndDateEditbox.SendKeys("06/20/2020");
            commonPageFunctions.EnterPress(createLeasePO.EndDateEditbox);
            createLeasePO.MoveInDateDateEditbox.SendKeys("06/20/2019");            
            commonPageFunctions.EnterPress(createLeasePO.MoveInDateDateEditbox);
            System.Threading.Thread.Sleep(2000);
            createLeasePO.AutoApprovePaymentRadioButton.Click();
            createLeasePO.ContinueButton.Click();
            System.Threading.Thread.Sleep(2000);

            createLeasePO.MonthlyChargesClickToAddRow.Click();
            commonPageFunctions.selectFromDropdown(createLeasePO.MonthlyChargesSelectTenantCharge, 2);
            createLeasePO.MonthlyChargesDescription.SendKeys("This is a Test Description");
            createLeasePO.MonthlyChargesAmount.SendKeys("2123");

            createLeasePO.FirstMonthChargesClickToAddRow.Click();
            commonPageFunctions.selectFromDropdown(createLeasePO.FirstMonthChargesSelectTenantCharge, 2);
            createLeasePO.FirstMonthChargesDescription.SendKeys("This is a Test Description");
            createLeasePO.FirstMonthChargesAmount.SendKeys("200");
            createLeasePO.ContinueButton.Click();
            System.Threading.Thread.Sleep(5000);
            createLeasePO.ContinueButton.Click();
            System.Threading.Thread.Sleep(2000);
            createLeasePO.UploadManualLeaseRadioButton.Click();
            System.Threading.Thread.Sleep(1000);
            createLeasePO.ContinueButton.Click();
            System.Threading.Thread.Sleep(2000);
            createLeasePO.SendLeaseForSigningButton.Click();
            System.Threading.Thread.Sleep(2000);
            createLeasePO.ConfirmSendingLeaseButton.Click();
            System.Threading.Thread.Sleep(4000);
            createLeasePO.MoreButton.Click();
            System.Threading.Thread.Sleep(2000);
            createLeasePO.CancelLeaseButton.Click();
            System.Threading.Thread.Sleep(3000);
            createLeasePO.EffectiveDateEditBox.SendKeys("06/20/2019");
            commonPageFunctions.EnterPress(createLeasePO.EffectiveDateEditBox);
            createLeasePO.CancelLeaseConfirmButton.Click();




        }

        }
}
