public class AutomationPractice;

public class ContactUsPage
{
    public IWebDriver? Driver { get; set; }

    public ContactUsPage(IWebDriver? driver)
    {
        Driver = driver;
    }

    public void GoTo()
    {
        Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
    }

    public bool IsLoaded => Driver.Url == "http://automationpractice.com/index.php?controller=contact";
}