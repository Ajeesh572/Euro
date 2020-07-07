// <copyright file="NotificationComponent.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Components
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using Euro.Core.Automation.Utilities.CommonAction;
    using OpenQA.Selenium;

    /// <summary>
    /// This class represents to notification message.
    /// </summary>
    public class NotificationComponent : BasePage
    {
        [IDTFindBy(File = "NotificationComponentLocators", Locator = "LblNotification")]
        private IWebElement lblNotification;

        [IDTFindBy(File = "NotificationComponentLocators", Locator = "BtnCloseMessage")]
        private IWebElement btnCloseMessage;

        [IDTFindBy(File = "NotificationComponentLocators", Locator = "LblNotificationWarning")]
        private IWebElement lblNotificationWarning;

        /// <summary>
        /// Returns the notification message.
        /// </summary>
        /// <returns>notification text</returns>
        public string GetNotificationMessage()
        {
            this.lblNotification.WaitUntilElementIsDisplayed();
            return this.lblNotification.Text;
        }

        /// <summary>
        /// Returns the Warning notification message.
        /// </summary>
        /// <returns>Warning notification text</returns>
        public string GetWarningNotificationMessage()
        {
            lblNotificationWarning.WaitUntilElementIsDisplayed();
            return lblNotificationWarning.Text;
        }

        /// <summary>
        /// Closes the notification message.
        /// </summary>
        public void CloseNotification()
        {
            CommonActions.FocusOnWebElement(Driver, btnCloseMessage);
            btnCloseMessage.ClickElementByJavaScript();
        }
    }
}
