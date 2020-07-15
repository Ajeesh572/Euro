// <copyright file="ConfigurationPage.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Pages.Configuration
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using OpenQA.Selenium;

    /// <summary>
    /// This class is to handle Configuration page.
    /// </summary>
    public class ConfigurationPage : BasePage
    {
        private const string ProfilePageLocators = "ProfilePageLocators";

        [IDTFindBy(File = ProfilePageLocators, Locator = "LblPageTitle")]
        private IWebElement lblPageTitle;

        /// <summary>
        /// Verifies that current url is equal to Configuration page's url.
        /// </summary>
        /// <returns>True if current url is Configuration page's url, false otherwise.</returns>
        public bool IsInConfigurationPage()
        {
            return Driver.Url.Equals(lblPageTitle.GetAttribute("href"));
        }

        /// <summary>
        /// Gets Configuration page's title.
        /// </summary>
        /// <returns>Page title as string value.</returns>
        public string GetConfigurationPageTitle()
        {
            return lblPageTitle.Text;
        }
    }
}
