// <copyright file="LoginToViracorQAMob.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Test.Mobile.CP.Steps
{
    using Euro.Core.Automation.WebDriver;
    using Euro.Core.Automation.WebDriver.WrapperFactory;
    using TechTalk.SpecFlow;

    [Binding]
    public sealed class LoginToViracorQAMob
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;

        public LoginToViracorQAMob(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [StepDefinition(@"user logged in to viracor qa")]
        public void GivenUserLoggedInToViracorQa()
        {
            
            MobileDriverManager.Instance.InitWebDriver();
        }
    }
}
