// <copyright file="ReportAccessCodesForm.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Forms
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using OpenQA.Selenium;

    /// <summary>
    /// This class handle the Report Access Codes form page.
    /// </summary>
    public class ReportAccessCodesForm : BasePage
    {
        private const string AccessCodesLocators = "AccessCodesLocators";

        [IDTFindBy(File = AccessCodesLocators, Locator = "TxtStatus")]
        [IDTFieldName("Status")]
        private IWebElement txtStatus;

        [IDTFindBy(File = AccessCodesLocators, Locator = "CmbFromCreatedDate")]
        [IDTFieldName("From Created Date")]
        private IWebElement cmbFromCreatedDate;

        [IDTFindBy(File = AccessCodesLocators, Locator = "CmbToCreatedDate")]
        [IDTFieldName("To Created Date")]
        private IWebElement cmbToCreatedDate;

        [IDTFindBy(File = AccessCodesLocators, Locator = "CmbFromExpirationDate")]
        [IDTFieldName("From Expiration Date")]
        private IWebElement cmbFromExpirationDate;

        [IDTFindBy(File = AccessCodesLocators, Locator = "CmbToExpirationDate")]
        [IDTFieldName("To Expiration Date")]
        private IWebElement cmbToExpirationDate;

        [IDTFindBy(File = AccessCodesLocators, Locator = "CmbAccessType")]
        [IDTFieldName("Access Type")]
        private IWebElement cmbAccessType;

        [IDTFindBy(File = AccessCodesLocators, Locator = "CmbPortal")]
        [IDTFieldName("Portal")]
        private IWebElement cmbPortal;

        [IDTFindBy(File = AccessCodesLocators, Locator = "TxtLogin")]
        [IDTFieldName("Login")]
        private IWebElement txtLogin;
    }
}
