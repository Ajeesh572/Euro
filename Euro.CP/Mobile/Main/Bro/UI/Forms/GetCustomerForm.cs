// <copyright file="GetCustomerForm.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Forms
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using Euro.Core.Automation.Utilities;
    using Euro.Core.Automation.Utilities.CommonAction;
    using OpenQA.Selenium;

    public class GetCustomerForm : BasePage
    {
        private const string GetCustomerLocators = "GetCustomerLocators";
        private LanguageManager languageManager;

        [IDTFindBy(File = GetCustomerLocators, Locator = "LnkShowNotes")]
        [IDTFieldName("Show Notes")]
        private IWebElement lnkShowNotes;

        [IDTFindBy(File = GetCustomerLocators, Locator = "TxtNoteId")]
        [IDTFieldName("Note ID")]
        private IWebElement txtNoteId;

        [IDTFindBy(File = GetCustomerLocators, Locator = "LblCreatedDate")]
        [IDTFieldName("Created Date")]
        private IWebElement lblCreatedDate;

        [IDTFindBy(File = GetCustomerLocators, Locator = "TxtCreatedBy")]
        [IDTFieldName("Created By")]
        private IWebElement txtCreatedBy;

        [IDTFindBy(File = GetCustomerLocators, Locator = "TxtText")]
        [IDTFieldName("Text")]
        private IWebElement txtText;

        [IDTFindBy(File = GetCustomerLocators, Locator = "TxtCategory")]
        [IDTFieldName("Category")]
        private IWebElement txtCategory;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomerForm"/> class.
        /// </summary>
        public GetCustomerForm()
        {
            languageManager = LanguageManager.Instance;
        }

        /// <summary>
        /// Clicks on Show Notes Link.
        /// </summary>
        public void ClickOnShowNotesLink()
        {
            string btnLnkName = languageManager.GetValue("ShowNotes");
            CommonActions.ClickElementByLocator(Utils.GetByLocator(GetCustomerLocators, "LnkShowNotes", btnLnkName));
        }
    }
}
