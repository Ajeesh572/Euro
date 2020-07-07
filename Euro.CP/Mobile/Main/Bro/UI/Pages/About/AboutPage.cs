// <copyright file="AboutPage.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Pages.About
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using OpenQA.Selenium;

    /// <summary>
    /// This class is to handle the About Page.
    /// </summary>
    public class AboutPage : BasePage
    {
        private const string ProfilePageLocators = "ProfilePageLocators";

        [IDTFindBy(File = ProfilePageLocators, Locator = "LblPageTitle")]
        private IWebElement lblPageTitle;

        /// <summary>
        /// Verifies that current url is equal to About page's url.
        /// </summary>
        /// <returns>True if current url is About page's url, false otherwise.</returns>
        public bool IsInAboutPage()
        {
            return Driver.Url.Equals(lblPageTitle.GetAttribute("href"));
        }

        /// <summary>
        /// Gets About page's title.
        /// </summary>
        /// <returns>Page title as string value.</returns>
        public string GetAboutPageTitle()
        {
            return lblPageTitle.Text;
        }
    }
}
