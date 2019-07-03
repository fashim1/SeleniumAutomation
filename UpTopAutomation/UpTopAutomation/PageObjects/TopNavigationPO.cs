using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpTopAutomation.PageObjects
{
    class TopNavigationPO
    {

        private IWebDriver driver;


        //Gear Icon Dropdown Elements 
        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/nav/div[2]/div[4]")]
        public IWebElement GearIcon { get; set; }   //

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Portfolio')]")]
        public IWebElement Portfolio { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Tenant Charges')]")]
        public IWebElement TenantCharges { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Contact Directory')]")]
        public IWebElement ContactDirectory { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'All Units')]")]
        public IWebElement AllUnits { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Listings')]")]
        public IWebElement Listings { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Prospects')]")]
        public IWebElement Prospects { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"carousel\"]/div/div[1]/div/div[1]/div[5]")]
        public IWebElement Tenants { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Maintenance')]")]
        public IWebElement Maintenance { get; set; }



    }
}
