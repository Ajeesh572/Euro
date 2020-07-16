// <copyright file="LabAlertLoginPage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Mobile.Main.IosLabAlert.MobileUI.Pages
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using Euro.Core.Automation.Utilities.CommonAction;
    using OpenQA.Selenium;

    /// <summary>
    /// Class defining login page
    /// </summary>
    public class LabAlertLoginPage : BasePage
    {
        private const string FileName = "LabAlertLoginPageLocators";

        [IDTFindBy(File = FileName, Locator = "TxtUserName")]
        [IDTFieldName("User Name")]
        private IWebElement txtUserName;

        [IDTFindBy(File = FileName, Locator = "TxtPassword")]
        [IDTFieldName("User Password")]
        private IWebElement txtPassword;

        [IDTFindBy(File = FileName, Locator = "BtnLogOn")]
        [IDTFieldName("Logon Buton")]
        private IWebElement btnLogOn;

        /// <summary>
        /// Login to ViracorQA
        /// </summary>
        /// <param name="userName">Valid User Name</param>
        /// <param name="pwd">Password</param>
        public void LoginToViracor(string userName, string pwd)
        {
            CommonActions.SendKeys(txtUserName, userName);
            CommonActions.SendKeys(txtPassword, pwd);
            Click("Logon Buton");
        }
    }
}
