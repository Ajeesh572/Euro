// <copyright file="CommonWaits.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.Utils
{
    using System;
    using Euro.Core.Automation.Utilities.CommonAction;
    using Euro.Core.Automation.WebDriver;
    using OpenQA.Selenium;

    /// <summary>
    /// This class handles all waits.
    /// </summary>
    public class CommonWaits
    {
        /// <summary>
        /// Method that you waiting that load all components of Money Transfer in the Bro portal.
        /// </summary>
        public static void Loading(IWebDriver driver)
        {
            CommonActions.WaitUntilLocatorExists(Core.Automation.Utilities.Utils.GetByLocator("BossRevolutionOrganizerLocators", "AlertLoadingDisplayNone"));
            try
            {
                // Implicit wait is changing because "WaitUntilElementIsInvisible" method use implicit wait time.
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                CommonActions.WaitUntilElementIsInvisible(Core.Automation.Utilities.Utils.GetByLocator("IcnLoading", "IcnLoad"));
            }
            catch (WebDriverTimeoutException)
            {
                CommonActions.WaitUntilElementIsInvisible(Core.Automation.Utilities.Utils.GetByLocator("IcnLoading", "IcnLoad"));
            }
            finally
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            }
        }

        /// <summary>
        /// Method that you waiting that load only loading component of Money Transfer in the Bro portal.
        /// </summary>
        public static void OnlyLoading(IWebDriver driver)
        {
            try
            {
                // Implicit wait is changing because "WaitUntilElementIsInvisible" method use implicit wait time.
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                CommonActions.WaitUntilElementIsInvisible(Core.Automation.Utilities.Utils.GetByLocator("IcnLoading", "IcnLoad"));
            }
            catch (WebDriverTimeoutException)
            {
                CommonActions.WaitUntilElementIsInvisible(Core.Automation.Utilities.Utils.GetByLocator("IcnLoading", "IcnLoad"));
            }
            finally
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            }
        }

        /// <summary>
        /// Method that you waiting that load an element of Money Transfer in the Bro portal.
        /// </summary>
        /// <param name="driver"><see cref="IWebDriver"/></param>
        /// <param name="element"><see cref="IWebElement"/></param>
        /// <param name="file"><see cref="string"/></param>
        public static void LoadingField(IWebDriver driver, IWebElement element, string file)
        {
            CommonActions.WaitUntilElementIsInvisible(Core.Automation.Utilities.Utils.GetByLocator("BROCommonComponents", "IcnLoading"));
            CommonActions.WaitUntilElementIsVisible(Core.Automation.Utilities.Utils.GetByLocator(file, "DdlGroup"));
            element.WaitUntilElementIsDisplayed();
        }

        /// <summary>
        /// Allows wait for loading .
        /// </summary>
        public static void WaitForBroLoadingIsNotDisplayed()
        {
            // TODO Review the method work in all projects in Bro and Retailer portals.Broloading.
            WebDriverManager.Instance.GetWebDriverWait.Until(driver =>
            {
                bool isAjaxFinished = (bool)((IJavaScriptExecutor)driver).
                    ExecuteScript("return jQuery.active == 0");
                bool isLoaderHidden = (bool)((IJavaScriptExecutor)driver).
                    ExecuteScript("return $('.spinner').is(':visible') == false");
                return isAjaxFinished & isLoaderHidden;
            });
        }

        /// <summary>
        /// Method that you waiting that load all components of Money Transfer in the Bro portal.
        /// </summary>
        [Obsolete("CommonWaits.LoadingBRO(Driver) is deprecated, please use BroHelpers.LoadingBRO() instead.")]
        public static void LoadingBro(IWebDriver driver)
        {
            CommonActions.WaitUntilLocatorExists(Core.Automation.Utilities.Utils.GetByLocator("BossRevolutionOrganizerLocators", "AlertLoadingDisplayNone"));
            try
            {
                // Implicit wait is changing because "WaitUntilElementIsInvisible" method use implicit wait time.
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                CommonActions.WaitUntilElementIsInvisible(Core.Automation.Utilities.Utils.GetByLocator("BossRevolutionOrganizerLocators", "IcnLoading"));
            }
            catch (WebDriverTimeoutException)
            {
                CommonActions.WaitUntilElementIsInvisible(Core.Automation.Utilities.Utils.GetByLocator("BossRevolutionOrganizerLocators", "IcnLoading"));
            }
            finally
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            }
        }

        /// <summary>
        /// Methods that you waiting by fields.
        /// </summary>
        /// <param name="element">fields to wait</param>
        public static void WaitingForThefields(int element)
        {
            while (element > 0)
            {
                element--;
                WaitForBroLoadingIsNotDisplayed();
            }
        }
    }
}
