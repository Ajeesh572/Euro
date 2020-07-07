// <copyright file="ChangeDatesChangesetPopUp.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Components
{
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using OpenQA.Selenium;

    /// <summary>
    /// This class represents to Change Dates Changeset Pop-Up in CMS Section.
    /// </summary>
    public class ChangeDatesChangesetPopUp : BasePage
    {
        [IDTFindBy(File = "ChangeDatesChangesetPopUpLocators", Locator = "BtnCalendarShowStartDate")]
        [IDTFieldName("Show Calendar Button for Start Date")]
        private IWebElement btnCalendarShowStartDate;

        [IDTFindBy(File = "ChangeDatesChangesetPopUpLocators", Locator = "BtnCalendarClearStartDate")]
        [IDTFieldName("Clear Calendar Button for Start Date")]
        private IWebElement btnCalendarClearStartDate;
    }
}
