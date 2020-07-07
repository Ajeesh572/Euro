namespace Euro.Viracor.Labalert.Main.Popups
{
    using Euro.Core.Automation.Utilities.Elements;
    using Euro.Core.Automation.WebDriver;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public class InfoPopup : AbstractPopup
    {
        public InfoPopup(IWebElement popupContainer)
            : base(popupContainer)
        {
        }

        public InfoPopup()
        {
        }

        public override void Close()
        {
            Actions builder = new Actions(WebDriverManager.Instance.GetWebDriver);
            builder.MoveToElement(PopupContainer.FindElement(BtnCloseLocator)).Click().Perform();
        }
    }
}
