// <copyright file="DistributorToolbarActionsComponent.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Components.Distributors
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Portals.Utils;
    using Euro.Core.Automation.Utilities;
    using Euro.Core.Automation.Utilities.CommonAction;
    using Euro.Core.Automation.Utilities.Helpers.Enums;
    using Euro.Viracor.Labalert.Main.Bro.UI.Enums.Distributor;
    using OpenQA.Selenium;

    public class DistributorToolbarActionsComponent : BasePage
    {
        private const string File = "DistributorToolbarLocators";

        public IWebElement BtnActiveDistributor => GetWebElement(DistributorToolbarActionEnum.ActivateDistributor);

        public IWebElement BtnDeactivateDistributor => GetWebElement(DistributorToolbarActionEnum.DeactivateDistributor);

        public IWebElement LnkOpenPortal => GetWebElement(DistributorToolbarActionEnum.OpenPortal);

        public IWebElement LnkGoToParent => GetWebElement(DistributorToolbarActionEnum.GoToParent);

        /// <summary>
        /// Gets the web element by its name in the locator resource file
        /// </summary>
        /// <param name="name">Name of the element as defined in the locators file</param>
        /// <returns>The web element with the given name</returns>
        public IWebElement GetWebElement(string name)
        {
            return CommonActions.GetFirstWebElementBy(Core.Automation.Utilities.Utils.GetByLocator(File, name));
        }

        /// <summary>
        /// Gets the web element by the given enum value
        /// </summary>
        /// <param name="action">The enum value</param>
        /// <returns>The web element associated with the enum value</returns>
        public IWebElement GetWebElement(DistributorToolbarActionEnum action)
        {
            return CommonActions.GetFirstWebElementBy(GetWebElementLocator(action));
        }

        /// <summary>
        /// Gets the web element locator by the given enum value
        /// </summary>
        /// <param name="action">The enum value</param>
        /// <returns>The locator associated with the enum value</returns>
        public By GetWebElementLocator(DistributorToolbarActionEnum action)
        {
            switch (action)
            {
                case DistributorToolbarActionEnum.ActivateDistributor:
                    return Core.Automation.Utilities.Utils.GetByLocator(File, "BtnActiveDistributor");
                case DistributorToolbarActionEnum.DeactivateDistributor:
                    return Core.Automation.Utilities.Utils.GetByLocator(File, "BtnDeactivateDistributor");
                case DistributorToolbarActionEnum.OpenPortal:
                    return Core.Automation.Utilities.Utils.GetByLocator(File, "LnkOpenPortal");
                case DistributorToolbarActionEnum.GoToParent:
                    return Core.Automation.Utilities.Utils.GetByLocator(File, "LnkGoToParent");
            }

            throw new System.Exception($"No locator defined for {action.GetStringValue()} toolbar item");
        }

        /// <summary>
        /// Clicks a toolbar item by enum
        /// </summary>
        /// <param name="action">The enum indicating which toolbar item to click</param>
        public void ClickOnWebElementFromToolbar(DistributorToolbarActionEnum action)
        {
            BroWaitHelper.LoadingBRO();
            GetWebElement(action).ClickElement();
            BroWaitHelper.LoadingBRO();
            switch (action)
            {
                case DistributorToolbarActionEnum.GoToParent:
                case DistributorToolbarActionEnum.OpenPortal:
                    WebDriverUtils.SwitchToLastTab();
                    break;
            }
        }
    }
}
