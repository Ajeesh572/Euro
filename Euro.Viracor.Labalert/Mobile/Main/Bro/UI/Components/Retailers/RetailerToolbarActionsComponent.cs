// <copyright file="RetailerToolbarActionsComponent.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Components.Retailers
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using Euro.Core.Automation.Utilities.CommonAction;
    using OpenQA.Selenium;

    public class RetailerToolbarActionsComponent : BasePage
    {
        private const string File = "RetailerToolbarLocators";

        [IDTFindBy(File = File, Locator = "LnkSuspend")]
        [IDTFieldName("SUSPEND")]
        private IWebElement lnkSuspend;

        [IDTFindBy(File = File, Locator = "LnkUnsuspend")]
        [IDTFieldName("UNSUSPEND")]
        private IWebElement lnkUnsuspend;

        [IDTFindBy(File = File, Locator = "LnkOpenDistributor")]
        [IDTFieldName("OPEN DISTRIBUTOR")]
        private IWebElement lnkOpenDistributor;

        [IDTFindBy(File = File, Locator = "LnkActivate")]
        [IDTFieldName("ACTIVATE")]
        private IWebElement lnkActivate;

        [IDTFindBy(File = File, Locator = "LnkDeactivate")]
        [IDTFieldName("DEACTIVATE")]
        private IWebElement lnkDeactivate;

        [IDTFindBy(File = File, Locator = "LnkOpenParentRetailer")]
        [IDTFieldName("OPEN PARENT RETAILER")]
        private IWebElement lnkOpenParentRetailer;

        [IDTFindBy(File = File, Locator = "LnkOpenPortal")]
        [IDTFieldName("OPEN PORTAL")]
        private IWebElement lnkOpenPortal;

        public IWebElement GetWebElementFromToolbar(string name)
        {
            return GetWebElementByFieldName(name);
        }

        public bool CheckRetailerIsNotActivated()
        {
            return lnkActivate.IsElementDisplayed();
        }

        public bool CheckRetailerIsActivated()
        {
            return lnkDeactivate.IsElementDisplayed();
        }
    }
}
