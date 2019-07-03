using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpTopAutomation.PageObjects
{
    class PortfolioPagePO
    {

        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Add Entity')]")]
        public IWebElement AddEntityButton { get; set; }

        [FindsBy(How = How.Id, Using = "LegalEntityType")]
        public IWebElement LegalEntityType { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type='text'][placeholder='Your Home Address']")]
        public IWebElement YourHomeAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Your Home Address')]//following::div/div[1]/span")]
        public IWebElement YourHomeAddressClickFirst { get; set; }
        //"html/body/div[7]/div/div/div/div/div[2]/div/div[2]/div[1]/div/div[1]/div/div[1]/span" Dont Delete
       

        [FindsBy(How = How.Id, Using = "CompanyStreet2")]
        public IWebElement SuiteFloorUnit { get; set; }

        //-----------------Add Entity Popup----------------------
        [FindsBy(How = How.Id, Using = "taxIdType")]
        public IWebElement BusinessTaxIDDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "BusinessTaxId")]
        public IWebElement TaxId { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type='text'][placeholder='MM/DD/YYYY']")]
        public IWebElement DateOfBirth { get; set; }

        [FindsBy(How = How.Id, Using = "EntityPhone")]
        public IWebElement Phone { get; set; }

        [FindsBy(How = How.Id, Using = "CompanyUrl")]
        public IWebElement BusinessURL { get; set; }

        //------------------ Bank Account-------------------------
        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Account Nickname')]//following::input[1]")]
        public IWebElement AccountNickname { get; set; }                                                                                                           

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Account Role')]//following::select[1]")]
        public IWebElement AccountRole { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Name on Account')]//following::input[1]")]
        public IWebElement NameOnAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Routing Number')]//following::input[1]")]
        public IWebElement RoutingNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Account Number')]//following::input[1]")]
        public IWebElement AccountNumber { get; set; }

     



    }
}
