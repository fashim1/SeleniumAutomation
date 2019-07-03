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
    class ContactsNotesTest
    {

        [Test]
        public void CreateNotes()
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

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

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

            contactsPO.AddNoteButton.Click();
            System.Threading.Thread.Sleep(2000);
            String NoteTitle = commonPageFunctions.randomCharactersGenerator();
            contactsPO.NoteTitleEditBox.SendKeys(NoteTitle);
            String NoteBody = commonPageFunctions.randomCharactersGenerator();
            contactsPO.NoteBodyTextArea.SendKeys(NoteBody);
            contactsPO.SaveNoteModalButton.Click();
            System.Threading.Thread.Sleep(2000);
            commonPageFunctions.VerifyElementInTableExists(driver, contactsPO.NotesTable, NoteTitle);
            System.Threading.Thread.Sleep(4000);
            String NoteTitleUpdated = commonPageFunctions.randomCharactersGenerator();
            contactsPO.NoteTitleEditBox.Clear();
            contactsPO.NoteTitleEditBox.SendKeys(NoteTitleUpdated);
            String NoteBodyUpdated = commonPageFunctions.randomCharactersGenerator();
            contactsPO.NoteBodyTextArea.Clear();
            contactsPO.NoteBodyTextArea.SendKeys(NoteBodyUpdated);
            contactsPO.SaveNoteButton.Click();
            System.Threading.Thread.Sleep(2000);
            commonPageFunctions.VerifyElementInTableExists(driver, contactsPO.NotesTable, NoteTitleUpdated);
            System.Threading.Thread.Sleep(2000);
            contactsPO.DeleteNoteButton.Click();

        }

        }
}
