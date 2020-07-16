namespace Euro.Viracor.Labalert.Mobile.Test.IosLabAlertMobile.Steps
{
    using Euro.Viracor.Labalert.Mobile.Main.IosLabAlert.MobileUI.Pages;
    using TechTalk.SpecFlow;

    [Binding]
    public sealed class HopePageSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private HomePage homepage;

        public HopePageSteps()
        {
            homepage = new HomePage();
        }

        [Then(@"Verify that User logged in to LABALERT Mobile App sucessfully")]
        public void ThenVerifyThatUserLoggedInToLABALERTMobileAppSucessfully()
        {
        }
    }
}
