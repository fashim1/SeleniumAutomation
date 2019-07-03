using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace UpTopAutomation.PageObjects
{
    class LoginPagePO
    {

        private IWebDriver driver;

        /*
        public LoginPagePO(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }*/

      
        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div/div[2]/div/div/div/div[1]/div/div/div[2]/input")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "loginPassword")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div/div[2]/div/div/div/div[1]/div/div/button")]
        public IWebElement Submit { get; set; }

    }
}
