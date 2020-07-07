// <copyright file="CancelTransactionPopup.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Components.MoneyTransfer
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using Euro.Core.Automation.Utilities.CommonAction;
    using OpenQA.Selenium;

    /// <summary>
    /// This class handles the Cancel Transaction popup.
    /// </summary>
    public class CancelTransactionPopup : BasePage
    {
        [IDTFindBy(File = "CancelTransactionLocators", Locator = "TxtNote")]
        private IWebElement txtNote;

        [IDTFindBy(File = "CancelTransactionLocators", Locator = "BtnCancelTransaction")]
        private IWebElement btnCancelTransaction;

        /// <summary>
        /// Sets notes in Notes text box.
        /// </summary>
        /// <param name="notes">The notes to cancel the transaction.</param>
        public void SetNotes(string notes)
        {
            CommonActions.SendKeys(this.txtNote, notes);
        }

        /// <summary>
        /// Clicks on cancel transaction button.
        /// </summary>
        public void ClickOnBtnCancelTransaction()
        {
            this.btnCancelTransaction.ClickElement();
            CommonActions.WaitUntilElementIsInvisible(By.CssSelector("[class='ajax-loading'] span"));
        }
    }
}
