// <copyright file="ProductRewardsForm.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Forms
{
    using System.Collections.Generic;
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using OpenQA.Selenium;

    /// <summary>
    /// This class handle the Product Rewards form page.
    /// </summary>
    public class ProductRewardsForm : BasePage
    {
        private const string ProductRewardsLocators = "ProductRewardsLocators";

        [IDTFindBy(File = ProductRewardsLocators, Locator = "DdlSelectProduct")]
        [IDTFieldName("Select Product List")]
        private IWebElement ddlSelectProduct;

        [IDTFindBy(File = ProductRewardsLocators, Locator = "CmbSelectProduct")]
        [IDTFieldName("Select Product")]
        private IWebElement cmbSelectProduct;

        /// <summary>
        /// Gets the List of values in given <ul> element.
        /// </summary>
        /// <param name="elementName">Name of the element.</param>
        /// <returns>List <see cref="List<T>"/> of values in <ul> element</returns>
        public List<string> GetAllUlValues(string elementName)
        {
            ICollection<IWebElement> allSelectElements = ddlSelectProduct.FindElements(By.TagName("li"));
            List<string> allSelectValues = new List<string>();
            foreach (var value in allSelectElements)
            {
                allSelectValues.Add(value.Text);
            }

            return allSelectValues;
        }
    }
}
