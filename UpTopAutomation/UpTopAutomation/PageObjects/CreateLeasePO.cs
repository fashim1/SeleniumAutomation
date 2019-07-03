using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpTopAutomation.PageObjects
{
    class CreateLeasePO
    {

        private IWebDriver driver;



        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[2]/a")]
        public IWebElement CreateLeaseButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[1]/div[1]/div[2]/div/button")]
        public IWebElement SelectUnitButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type='text'][placeholder='Unit address from your portfolio'][id='listingSelectInput']")]
        public IWebElement SelectUnitEditBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type='text'][placeholder='Company Name']")]
        public IWebElement AddContactCompanyName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Continue')]")]
        public IWebElement AddContactContinueButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[1]/div[1]/div[2]/div/span[2]/span/div/div/div[4]")]
        public IWebElement ClickOnFourthAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[1]/div[2]/div/div[2]/div/button")]
        public IWebElement AddTenantGuarantorBtn { get; set; }

        [FindsBy(How = How.Id, Using = "inquiryRenterSelectInput")]
        public IWebElement EnterTenantGuarantorEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[1]/div[2]/div/div[2]/div/span[2]/span/div/div/div")]
        public IWebElement ClickFirstEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[4]/div/div[1]/div[2]/div/div[2]/div[1]/div[2]/div/div/div/input")]
        public IWebElement StartDateEditbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[4]/div/div[1]/div[2]/div/div[2]/div[2]/div[2]/div/div/div/input")]
        public IWebElement EndDateEditbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[4]/div/div[1]/div[2]/div/div[2]/div[3]/div[2]/div/div/div/input")]
        public IWebElement MoveInDateDateEditbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[4]/div/div[1]/div[2]/div/div[4]/div[2]/label")]
        public IWebElement AutoApprovePaymentRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[4]/div/div[1]/div[2]/div/div[4]/div[3]/label")]
        public IWebElement ApproveNameMatchesRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[4]/div/div[1]/div[2]/div/div[4]/div[4]/label)")]
        public IWebElement ApproveManuallyRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[4]/div/div[1]/div[2]/div/div[4]/div[5]/label")]
        public IWebElement NoDigitalPaymentRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Continue')]")]
        public IWebElement ContinueButton { get; set; }


        //------------------Billing Details------------------------------

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[4]/div/div[2]/div[2]/div/div[2]/table/tbody/tr[1]/td[1]")]
        public IWebElement MonthlyChargesClickToAddRow { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[4]/div/div[2]/div[2]/div/div[2]/table/tbody/tr[1]/td[1]/div/select")]
        public IWebElement MonthlyChargesSelectTenantCharge { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type='text'][placeholder='e.g. Monthly Rent']")]
        public IWebElement MonthlyChargesDescription { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type='number'][placeholder='e.g. 1500']")]
        public IWebElement MonthlyChargesAmount { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[4]/div/div[2]/div[2]/div/div[3]/table/tbody/tr[1]/td[1]")]
        public IWebElement FirstMonthChargesClickToAddRow { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[4]/div/div[2]/div[2]/div/div[3]/table/tbody/tr[1]/td[1]/div/select")]
        public IWebElement FirstMonthChargesSelectTenantCharge { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type = 'text'][placeholder = 'e.g. Security Deposit']")]
        public IWebElement FirstMonthChargesDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[4]/div/div[2]/div[2]/div/div[3]/table/tbody/tr[1]/td[3]/div/span[2]/input")]
        public IWebElement FirstMonthChargesAmount { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[1]/div[2]/div[4]/div/div[4]/div[2]/div/div[2]/label")]
        public IWebElement UploadManualLeaseRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Send Lease for Signing')]")]
        public IWebElement SendLeaseForSigningButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div/div[3]/button[1]")]
        public IWebElement ConfirmSendingLeaseButton { get; set; }

        //-------------Cancel Lease----------------------------
        [FindsBy(How = How.Id, Using = "btnGroupDrop2")]
        public IWebElement MoreButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Re-Send Lease')]")]
        public IWebElement ReSendLeaseButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Cancel Lease')]")]
        public IWebElement CancelLeaseButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type = 'text'][placeholder = 'Effective']")]
        public IWebElement EffectiveDateEditBox { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div/div[1]/div/div/button")]
        public IWebElement CancelLeaseConfirmButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/h1")]
        public IWebElement VerifyHomePage { get; set; }

    }
}
