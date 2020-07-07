// <copyright file="DeleteProfilePopUp.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Components.Distributors
{
    using System.Collections.Generic;
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using Euro.Core.Automation.Utilities.CommonAction;
    using Euro.Core.Automation.Utilities.Extensions;
    using OpenQA.Selenium;

    /// <summary>
    /// This class represents to Delete Profile Pop-Up in Profile Section.
    /// </summary>
    public class DeleteProfilePopUp : BasePage
    {
        [IDTFindBy(File = "DeleteProfilePopUpLocators", Locator = "BtnDeleteProfileConfirm")]
        private IWebElement btnDeleteProfileConfirm;

        /// <summary>
        /// Gets the Webelement according the name given by parameter.
        /// </summary>
        /// <param name="webElementName">WebElement name.</param>
        /// <returns>The webElement <see cref="IWebElement"/>.</returns>
        private IWebElement GetWebElementByFieldName(string webElementName)
        {
            Dictionary<string, IWebElement> topMenuOptions = new Dictionary<string, IWebElement>
            {
                { "DELETE PROFILE CONFIRM", btnDeleteProfileConfirm }
            };

            return topMenuOptions.GetValue(webElementName.ToUpper());
        }

        /// <summary>
        /// Clicks on web element.
        /// </summary>
        /// <param name="elementName">The element that will be clicked</param>
        public void ClickOnWebElement(string elementName)
        {
            GetWebElementByFieldName(elementName).ClickElement();
            GetWebElementByFieldName(elementName).WaitUntilElementIsInvisible();
        }
    }
}
