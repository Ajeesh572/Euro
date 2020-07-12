// <copyright file="LoginToViracorQAMob.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Test.Mobile.CP.Steps
{
    using Euro.Core.Automation.Utilities.CommonAction;
    using Euro.Core.Automation.Utilities.JsonManager;
    using Euro.Core.Automation.WebDriver;
    using Euro.Core.Automation.WebDriver.WrapperFactory;
    using Euro.Viracor.Labalert.Mobile.Main.IosLabAlert.MobileUI.Pages;
    using TechTalk.SpecFlow;

    [Binding]
    public sealed class LoginToViracorQAMob
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private LabAlertLoginPage labAlertLoginPage;

        public LoginToViracorQAMob()
        {
            labAlertLoginPage = new LabAlertLoginPage();
        }

        [StepDefinition(@"user logged in to viracor qa")]
        public void GivenUserLoggedInToViracorQa()
        {
            User user = EnvironmentManager.GetUser("Viracor", "LABALERT");
            labAlertLoginPage.login(user.Name, user.Password);
        }
    }
}
