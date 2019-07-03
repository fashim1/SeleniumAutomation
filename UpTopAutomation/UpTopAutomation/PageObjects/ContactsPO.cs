using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpTopAutomation.PageObjects
{
    class ContactsPO
    {

        private IWebDriver driver;



        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Add Contact')]")]
        public IWebElement AddContact { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type='text'][placeholder='Company Name']")]
        public IWebElement AddContactCompanyName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Continue')]")]
        public IWebElement AddContactContinueButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Add Contact')]")]
        public IWebElement AddContactsCompanyName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Update Contact')]")]
        public IWebElement UpdateContactButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Save Contact')]")]
        public IWebElement SaveContactsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[4]/div/div[1]/h5")]
        public IWebElement VerifyContactUpdated { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Delete Contact')]")]
        public IWebElement DeleteContactsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/table")]
        public IWebElement ContactsListTable { get; set; }


        //---------------------------------Contact Details Page-------------------------------------------------------

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Add Transaction')]")]
        public IWebElement AddTransactionButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Invoice')]")]
        public IWebElement AddInvoiceButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Payment')]")]
        public IWebElement AddPaymentButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Deposit')]")]
        public IWebElement AddDepositButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Bill')]")]
        public IWebElement AddBillButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Bill Payment')]")]
        public IWebElement AddBillPaymentButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Expense')]")]
        public IWebElement AddExpenseButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Journal Entry')]")]
        public IWebElement AddJournalEntryButton { get; set; }


        // Add Invoice
        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Select Organization / Entity / Property *')]")]
        public IWebElement selectOrgEntityProp { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[2]/div/div/div/div[2]/div[1]")]
        public IWebElement selectFirstFromOrgEntityProp { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[3]/div[1]/div[2]/span/div/div[1]/div/input")]
        public IWebElement DateEditbox { get; set; } 

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[3]/div[2]/div[2]/span/div/div/div/input")]
        public IWebElement AutoSendDateEditbox { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[3]/div[3]/div[2]/span/div/div/div/input")]
        public IWebElement LateDateEditbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Click to add a row')]")]
        public IWebElement ClickToAddRow { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[2]/td[1]")]
        public IWebElement ClickToAddSecondRow { get; set; }

        //Add Deposit
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[3]/div[2]/div[2]/div/select")]
        public IWebElement SelectBankCreditCard { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[3]/div[3]/div[2]/div/select")]
        public IWebElement SelectPaymentMethod { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[1]/td[1]/div/select")]
        public IWebElement SelectDepositAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Save')]")]
        public IWebElement SaveDepositButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'More')]")]
        public IWebElement DepositMoreButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Delete')]")]
        public IWebElement DepositDeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/div/div[3]/button[1]")]
        public IWebElement DepositDeleteConfirmButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[7]/table/tbody/tr/td[4]")]
        public IWebElement DepositClickFirstRow { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[1]/div[2]/div/button")]
        public IWebElement UpdateDepositButton { get; set; }

        //Add Bill
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[3]/div[2]/div[2]/span/div/div[1]/div/input")]
        public IWebElement DueDateEditBox { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[1]/td[1]/div/select")]
        public IWebElement SelectBillAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Save')]")]
        public IWebElement SaveBillButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[7]/table/tbody/tr/td[4]")]
        public IWebElement BillClickFirstRow { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[1]/div[2]/div/button")]
        public IWebElement UpdateBillButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'More')]")]
        public IWebElement ModalMoreButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Delete')]")]
        public IWebElement ModalDeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/div/div[3]/button[1]")]
        public IWebElement ModalDeleteConfirmButton { get; set; }


        // Add Expense
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[1]/td[1]/div/select")]
        public IWebElement SelectExpenseAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Save')]")]
        public IWebElement SaveExpenseButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[7]/table/tbody/tr/td[4]")]
        public IWebElement ExpenseClickFirstRow { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[1]/div[2]/div/button")]
        public IWebElement UpdateExpenseButton { get; set; }

        // Add Journal Entry
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[1]/td[1]/div/select")]
        public IWebElement SelectJournalEntryAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[2]/td[1]/div/select")]
        public IWebElement SelectJournalEntryAccountR2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[1]/td[2]/div/span[2]/input")]
        public IWebElement AddJEDebitR1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[1]/td[3]/div/span[2]/input")]
        public IWebElement AddJECreditR1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[2]/td[2]/div/span[2]/input")]
        public IWebElement AddJEDebitR2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[2]/td[3]/div/span[2]/input")]
        public IWebElement AddJECreditR2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Save')]")]
        public IWebElement SaveTransactionButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[1]/div[2]/div/button")]
        public IWebElement UpdateJournalEntryButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[7]/table/tbody/tr/td[4]")]
        public IWebElement TransactionClickFirstRow { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[7]/table/tbody/tr[2]/td[1]")]
        public IWebElement TransactionClickSecondRow { get; set; }


        // Add Payment
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[1]/td[1]/div/select")]
        public IWebElement SelectInvoiceToPayFirstRow { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[1]/td[2]/div/select")]
        public IWebElement SelectLineItemToPayFirstRow { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type='number'][placeholder='e.g. 1500']")]
        public IWebElement PaymentAmountTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div[1]/div[1]/div[2]/div/div/button[2]")]
        public IWebElement UpdatePaymentButton { get; set; }


        // Add Bill Payment
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[1]/td[1]/select")]
        public IWebElement SelectBillToPayFirstRow { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[1]/td[2]/select")]
        public IWebElement SelectBillLineItemToPayFirstRow { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[1]/div[2]/div/button")]
        public IWebElement UpdateBillPaymentButton { get; set; }



        //--------------------------------------------------------------------------------------------------------------------------
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[1]/tr[1]/td[1]/select")]
        public IWebElement SelectAccount { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type='text'][placeholder='e.g. Gym']")]
        public IWebElement DescriptionTextbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type='number'][placeholder='e.g. 1500']")]
        public IWebElement AmountTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Save')]")]
        public IWebElement SaveInvoiceButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/table/tbody[2]/tr/td[3]")]
        public IWebElement retrievedInvoiceAmount { get; set; } 

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[7]/table")]
        public IWebElement TransactionTable { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div[1]/div[2]/div/div/button[2]")]
        public IWebElement UpdateInvoiceButton { get; set; } 

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'More')]")]
        public IWebElement InvoiceMoreButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Delete')]")]
        public IWebElement InvoiceDeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/div/div[3]/button[1]")]
        public IWebElement InvoiceDeleteConfirmButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[7]/table/tbody/tr/td[4]")]
        public IWebElement InvoiceClickFirstRow { get; set; }


        //---------------------------------Maintenance Request for Contacts-------------------------------------
        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Add Request')]")]
        public IWebElement AddRequestButton { get; set; }

        [FindsBy(How = How.Id, Using = "UnitSelectInput")]
        public IWebElement MaintRequestAddressTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div/div[1]/div/span[2]/div/span[1]/div/div/div[1]")]
        public IWebElement MaintRequestClickFirstAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type='text'][placeholder='Title']")]
        public IWebElement MaintRequestTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div/div[4]/select")]
        public IWebElement MaintRequestCategories { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div/div[4]/div/div[1]")]
        public IWebElement MaintRequestRadioUrgent { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div/div[4]/div/div[2]")]
        public IWebElement MaintRequestRadioNormal { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div/div[4]/div/div[3]")]
        public IWebElement MaintRequestRadioLow { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div/div[6]/textarea")]
        public IWebElement MaintRequestDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[8]/table")]
        public IWebElement MaintRequestTable { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div/div[2]/div/button[2]")]
        public IWebElement MaintRequestAddRequestButton { get; set; }


        //---------------------------------Notes-------------------------------------
        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Add Note')]")]
        public IWebElement AddNoteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div/div[1]/input")]
        public IWebElement NoteTitleEditBox { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div/div[4]/textarea")]
        public IWebElement NoteBodyTextArea { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div[2]/section/div/div[9]/table")]
        public IWebElement NotesTable { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div/div/div/div[2]/div/div/div[3]/div/button[2]")]
        public IWebElement SaveNoteModalButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Save')]")]
        public IWebElement SaveNoteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Delete Note')]")]
        public IWebElement DeleteNoteButton { get; set; }

    }
}
