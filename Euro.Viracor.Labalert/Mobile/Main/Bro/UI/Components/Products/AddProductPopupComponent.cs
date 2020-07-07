// <copyright file="AddProductPopupComponent.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Components.Products
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using Euro.Core.Automation.Utilities.CommonAction;
    using Euro.Viracor.Labalert.Main.Popups;
    using OpenQA.Selenium;

    public class AddProductPopupComponent : BasePage
    {
        private const string File = "AddProductPopupLocators";

        [IDTFindBy(File = File, Locator = "TxtName")]
        [IDTFieldName("Name")]
        private IWebElement txtName;

        [IDTFindBy(File = File, Locator = "DdProductType")]
        [IDTFieldName("Product Type")]
        private IWebElement ddProductType;

        [IDTFindBy(File = File, Locator = "ChkAllowedForDistributors")]
        [IDTFieldName("Allowed For Distributors")]
        private IWebElement chkAllowedForDistributors;

        [IDTFindBy(File = File, Locator = "ChkAllowedForRetailers")]
        [IDTFieldName("Allowed For Retailers")]
        private IWebElement chkAllowedForRetailers;

        [IDTFindBy(File = File, Locator = "ChkAllowedForCustomers")]
        [IDTFieldName("Allowed For Customers")]
        private IWebElement chkAllowedForCustomers;

        [IDTFindBy(File = File, Locator = "BtnAddNew")]
        [IDTFieldName("Add New")]
        private IWebElement btnAddNew;

        [IDTFindBy(File = File, Locator = "NotePopup")]
        private IWebElement notePopup;

        /// <summary>
        /// Gets an instance of Infopopup
        /// </summary>
        /// <returns>InfoPopup instance</returns>
        public InfoPopup GetInfoPopup()
        {
            notePopup.WaitUntilElementIsDisplayed();
            return new InfoPopup(notePopup);
        }
    }
}
