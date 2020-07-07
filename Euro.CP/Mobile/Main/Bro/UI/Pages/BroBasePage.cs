// <copyright file="BroBasePage.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Pages
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Utilities.CommonAction;
    using Euro.Viracor.Labalert.Main.Bro.Utils;
    using Euro.Viracor.Labalert.Main.Popups;


    /// <summary>
    /// This class represents the base page for the bro portal.
    /// </summary>
    public class BroBasePage : BasePage
    {
        /// <summary>
        /// gets the current url of the driver
        /// </summary>
        /// <returns>return string of the url</returns>
        public string GetCurrentURL()
        {
            return Driver.Url;
        }

        /// <summary>
        /// Verify element is displayed
        /// </summary>
        /// <param name="element">element to be displayed.</param>
        /// <returns>return true if element is displayed else false</returns>
        public bool IsElementDisplayed(string element)
        {
            CommonWaits.WaitForBroLoadingIsNotDisplayed();
            return CommonActions.IsElementDisplayed(GetWebElementByFieldName(element));
        }

        /// <summary>
        /// Gets instanse of InfoPopup
        /// </summary>
        /// <returns>Popup Instance</returns>
        public InfoPopup GetPopup()
        {
            return new InfoPopup();
        }
    }
}
