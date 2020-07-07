// <copyright file="RedisClustersPage.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Pages.Configuration
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using Euro.Core.Automation.Utilities.CommonAction;
    using Euro.Core.Automation.Utilities.Elements;
    using OpenQA.Selenium;

    /// <summary>
    /// This class is to handle Redis Clusters page.
    /// </summary>
    public class RedisClustersPage : BasePage
    {
        private const string ProfilePageLocators = "ProfilePageLocators";
        private const string RedisClustersPageLocators = "RedisClustersPageLocators";

        [IDTFindBy(File = ProfilePageLocators, Locator = "LblPageTitle")]
        private IWebElement lblPageTitle;

        [IDTFindBy(File = RedisClustersPageLocators, Locator = "TxtName")]
        [IDTFieldName("Name")]
        private IWebElement txtName;

        [IDTFindBy(File = RedisClustersPageLocators, Locator = "CmbClusterType")]
        [IDTFieldName("Cluster Type")]
        private IWebElement cmbClusterType;

        /// <summary>
        /// Fill textBox by field name
        /// </summary>
        /// <param name="fieldName">Field Name</param>
        /// <param name="value">Value to fill</param>
        /// <returns>Object</returns>
        public RedisClustersPage FillTextBoxByFieldName(string fieldName, string value)
        {
            CommonActions.SendKeys(GetWebElementByFieldName(fieldName), value);
            return this;
        }

        /// <summary>
        /// Select option from combobox
        /// </summary>
        /// <param name="fieldName">Field Name</param>
        /// <param name="option">Option</param>
        /// <returns>Object</returns>
        public RedisClustersPage SelectOptionFromComboBox(string fieldName, string option)
        {
            GetWebElementByFieldName(fieldName).SelectComboBox(option);
            return this;
        }

        /// <summary>
        /// Gets the selected option from the combobox
        /// </summary>
        /// <param name="comboBoxName">The combo box field name</param>
        /// <returns>The selected value</returns>
        public string GetSelectedOptionFromComboBox(string comboBoxName)
        {
            return new Select(GetWebElementByFieldName(comboBoxName)).GetSelectedValue().Trim();
        }

        /// <summary>
        /// Gets the text from the field
        /// </summary>
        /// <param name="fieldName">Field name</param>
        /// <returns>The text from the field</returns>
        public string GetTextFromElement(string fieldName)
        {
            WaitUntilAjaxInactive();
            var element = GetWebElementByFieldName(fieldName);
            element.WaitUntilElementIsDisplayed();
            return element.Text;
        }
    }
}
