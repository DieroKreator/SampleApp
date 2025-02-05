using OpenQA.Selenium;

namespace AutomationPractice;

public class AutomationPractice;

internal class ContactUsPage : BaseApplicationPage
{
    public ContactUsPage(IWebDriver driver) : base(driver)
    {
    }

    public void GoTo()
    {
        Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
    }

}