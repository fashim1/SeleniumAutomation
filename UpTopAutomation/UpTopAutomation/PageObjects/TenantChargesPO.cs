using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpTopAutomation.PageObjects
{
    class TenantChargesPO
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Add Charge')]")]
        public IWebElement AddTenantCharges { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type='text'][placeholder='Name']")]
        public IWebElement ModalNameTextbox { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[2]/div/div/select")]
        public IWebElement ModalSelectAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[1]/div[2]/div/button")]
        public IWebElement ModalAddTenantCharge { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Testing')]")]
        public IWebElement FindAddedTenantCharge { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Save Charge')]")]
        public IWebElement ModalSaveChanges { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Delete')]")]
        public IWebElement ModalDelete{ get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/div/div[3]/button[1]")]
        public IWebElement ModalDeleteConfirm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/table")]
        public IWebElement TenantChargesListTable { get; set; }



    }
}
