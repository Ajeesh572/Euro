// <copyright file="ReportBankVerificationForm.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Forms
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using OpenQA.Selenium;

    /// <summary>
    /// This class handle the Report Bank Verification Form.
    /// </summary>
    public class ReportBankVerificationForm : BasePage
    {
        private const string BankVerificationLocators = "BankVerificationLocators";

        [IDTFindBy(File = BankVerificationLocators, Locator = "TxtStatus")]
        [IDTFieldName("Status")]
        private IWebElement txtStatus;

        [IDTFindBy(File = BankVerificationLocators, Locator = "DateAuthorizationFrom")]
        [IDTFieldName("Authorization From Date")]
        private IWebElement dateAuthorizationFrom;

        [IDTFindBy(File = BankVerificationLocators, Locator = "DateAuthorizationTo")]
        [IDTFieldName("Authorization To Date")]
        private IWebElement dateAuthorizationTo;

        [IDTFindBy(File = BankVerificationLocators, Locator = "TxtOwner")]
        [IDTFieldName("Owner")]
        private IWebElement txtOwner;

        [IDTFindBy(File = BankVerificationLocators, Locator = "TxtWalletId")]
        [IDTFieldName("Wallet Id")]
        private IWebElement txtWalletId;

        [IDTFindBy(File = BankVerificationLocators, Locator = "TxtChargeAmountFrom")]
        [IDTFieldName("Charge From Amount")]
        private IWebElement txtChargeAmountFrom;

        [IDTFindBy(File = BankVerificationLocators, Locator = "TxtChargeAmountTo")]
        [IDTFieldName("Charge to Amount")]
        private IWebElement txtChargeAmountTo;

        [IDTFindBy(File = BankVerificationLocators, Locator = "TxtCreditAmountFrom")]
        [IDTFieldName("Credit From Amount")]
        private IWebElement txtCreditAmountFrom;

        [IDTFindBy(File = BankVerificationLocators, Locator = "TxtCreditAmountTo")]
        [IDTFieldName("Credit To Amount")]
        private IWebElement txtCreditAmountTo;

        [IDTFindBy(File = BankVerificationLocators, Locator = "DateVerificationFrom")]
        [IDTFieldName("Verification From Date")]
        private IWebElement dateVerificationFrom;

        [IDTFindBy(File = BankVerificationLocators, Locator = "DateVerificationTo")]
        [IDTFieldName("Verification To Date")]
        private IWebElement dateVerificationTo;

        [IDTFindBy(File = BankVerificationLocators, Locator = "TxtNumberOfAttempts")]
        [IDTFieldName("Number Of Attempts")]
        private IWebElement txtNumberOfAttempts;

        [IDTFindBy(File = BankVerificationLocators, Locator = "DateExpirationFrom")]
        [IDTFieldName("Expiration From Date")]
        private IWebElement dateExpirationFrom;

        [IDTFindBy(File = BankVerificationLocators, Locator = "DateExpirationTo")]
        [IDTFieldName("Expiration To Date")]
        private IWebElement dateExpirationTo;

        [IDTFindBy(File = BankVerificationLocators, Locator = "DdlUserType")]
        [IDTFieldName("User Type")]
        private IWebElement ddlUserType;

        [IDTFindBy(File = BankVerificationLocators, Locator = "DdlWalletType")]
        [IDTFieldName("Wallet Type")]
        private IWebElement ddlWalletType;
    }
}
