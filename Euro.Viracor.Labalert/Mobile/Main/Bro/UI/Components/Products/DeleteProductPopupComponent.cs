// <copyright file="DeleteProductPopupComponent.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Components.Products
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using OpenQA.Selenium;

    public class DeleteProductPopupComponent : BasePage
    {
        private const string File = "DeleteProductPopupLocators";

        [IDTFindBy(File = File, Locator = "LblMessage")]
        [IDTFieldName("Warning Message")]
        private IWebElement lblMessage;

        [IDTFindBy(File = File, Locator = "BtnDelete")]
        [IDTFieldName("Delete")]
        private IWebElement btnDelete;

        [IDTFindBy(File = File, Locator = "BtnCloseFooter")]
        [IDTFieldName("Close")]
        private IWebElement btnCloseFooter;
    }
}
