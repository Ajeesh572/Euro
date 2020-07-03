// <copyright file="MobileDriver.cs" company="Eurofins">
// Copyright (c) Euro. All rights reserved.
// </copyright>

namespace Euro.Core.Automation.WebDriver.WrapperFactory
{
    using System;
    using System.Configuration;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Remote;

    /// <summary>
    /// Manages all mobile drivers.
    /// </summary>
    public abstract class MobileDriver : IDriver
    {
        private static string PlatformName = "platformName";
        private static string PlatformVersion = "platformVersion";
        private static string DeviceName = "deviceName";
        private static string App = "app";
        private static string NoReset = "noReset";
        private static string url = ConfigurationManager.AppSettings["MobileUrl"].ToString();

        /// <summary>
        /// Initializes a new instance of the <see cref="MobileDriver"/> class.
        /// </summary>
        public MobileDriver()
        {
            this.Capabilities = new DesiredCapabilities();
            this.Capabilities.SetCapability(PlatformName,  ConfigurationManager.AppSettings["PlatformName"].ToString());
            this.Capabilities.SetCapability(PlatformVersion,  ConfigurationManager.AppSettings["PlatformVersion"].ToString());
            this.Capabilities.SetCapability(DeviceName, ConfigurationManager.AppSettings["DeviceName"].ToString());
            this.Capabilities.SetCapability(NoReset, ConfigurationManager.AppSettings["NoReset"]);
            this.Capabilities.SetCapability(App, ConfigurationManager.AppSettings["App"].ToString());
        }

        /// <summary>
        /// Gets or sets capabilities.
        /// </summary>
        protected DesiredCapabilities Capabilities { get; set; }

        /// <summary>
        /// Configures the variables to execute in mobile.
        /// </summary>
        /// <returns>An instance of <see cref="DesiredCapabilities"/></returns>
        public abstract DesiredCapabilities SetCapability();

        /// <inheritdoc/>
        public IWebDriver InitDriver()
        {
            return new RemoteWebDriver(new Uri(url), this.SetCapability(), TimeSpan.FromSeconds(600));
        }
    }
}
