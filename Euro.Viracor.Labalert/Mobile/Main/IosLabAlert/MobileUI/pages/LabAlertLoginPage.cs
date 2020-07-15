// <copyright file="LabAlertLoginPage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Mobile.Main.IosLabAlert.MobileUI.Pages
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Page.MobileBase;
    using Euro.Core.Automation.Selenium;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.iOS;
    using OpenQA.Selenium.Appium.PageObjects.Attributes;
    using OpenQA.Selenium.Support.PageObjects;

    /// <summary>
    /// Class defining login page
    /// </summary>
    public class LabAlertLoginPage : BasePage
    {
        private const string fileName = "LabAlertLoginPageLocators";

        [IDTFindBy(File = fileName, Locator = "TxtUserName")]
        private IWebElement txtUserName;

        [IDTFindBy(File = fileName, Locator = "TxtPassword")]
        private IWebElement txtPassword;

        [IDTFindBy(File = fileName, Locator = "BtnLogOn")]
        private IWebElement btnLogOn;

        /// <summary>
        /// Login to ViracorQA
        /// </summary>
        /// <param name="userName">Valid User Name</param>
        /// <param name="pwd">Password</param>
        public void LoginToViracor(string userName, string pwd)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(pwd);
            btnLogOn.Click();
        }
    }
}
