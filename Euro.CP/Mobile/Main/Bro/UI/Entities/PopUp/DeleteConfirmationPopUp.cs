// <copyright file="DeleteConfirmationPopUp.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Entities.PopUp
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Portals.Utils;
    using Euro.Core.Automation.Selenium;
    using Euro.Core.Automation.Utilities.CommonAction;
    using OpenQA.Selenium;

    /// <summary>
    /// This class handles Delete Pop Up.
    /// </summary>
    public class DeleteConfirmationPopUp : BasePage
    {
        [IDTFindBy(File = "DeletePopUpLocators", Locator = "BtnDeleteConfirmation")]
        private IWebElement btnDeleteConfirmationItem;

        /// <summary>
        /// Clicks on Delete button.
        /// </summary>
        public void ClickDeleteButton()
        {
            btnDeleteConfirmationItem.ClickElement();
            BroWaitHelper.LoadingBRO();
        }
    }
}
