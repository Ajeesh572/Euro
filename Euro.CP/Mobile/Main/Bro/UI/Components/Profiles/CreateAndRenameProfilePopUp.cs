// <copyright file="CreateAndRenameProfilePopUp.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Components.Profiles
{
    using System.Collections.Generic;
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using Euro.Core.Automation.Utilities.CommonAction;
    using Euro.Core.Automation.Utilities.Extensions;
    using OpenQA.Selenium;

    /// <summary>
    /// This class represents to Create New Profile Pop-Up in Profile Section.
    /// </summary>
    public class CreateAndRenameProfilePopUp : BasePage
    {
        [IDTFindBy(File = "CreateAndRenameProfilePopUpLocators", Locator = "BtnSaveCreateNewProfile")]
        private IWebElement btnSaveCreateNewProfile;

        [IDTFindBy(File = "CreateAndRenameProfilePopUpLocators", Locator = "TxtProfileName")]
        private IWebElement txtProfileName;

        /// <summary>
        /// Fills a value in text box field.
        /// </summary>
        /// <param name="elementName">The locator name to get list of webelements.</param>
        /// <param name="value">The value to enter in field.</param>
        public void FillATextBoxField(string elementName, string value)
        {
            CommonActions.SendKeys(GetWebElementByFieldName(elementName), value);
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

        /// <summary>
        /// Gets the Webelement according the name given by parameter.
        /// </summary>
        /// <param name="webElementName">WebElement name.</param>
        /// <returns>The webElement <see cref="IWebElement"/>.</returns>
        private IWebElement GetWebElementByFieldName(string webElementName)
        {
            Dictionary<string, IWebElement> topMenuOptions = new Dictionary<string, IWebElement>
            {
                { "PROFILE NAME FIELD", txtProfileName },
                { "SAVE", btnSaveCreateNewProfile }
            };

            return topMenuOptions.GetValue(webElementName.ToUpper());
        }
    }
}
