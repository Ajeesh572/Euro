// <copyright file="CustomersForm.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Forms
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using OpenQA.Selenium;

    public class CustomersForm : BasePage
    {
        private const string CustomersLocators = "CustomerPageLocators";

        [IDTFindBy(File = CustomersLocators, Locator = "TxtEmailPhoneNumber")]
        [IDTFieldName("Phone Number")]
        private IWebElement txtPhoneNumber;

        [IDTFindBy(File = CustomersLocators, Locator = "BtnFindCustomers")]
        [IDTFieldName("Find Customer")]
        private IWebElement btnFindCustomer;
    }
}
