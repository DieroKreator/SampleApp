using OpenQA.Selenium;

namespace AutomationPractice;

public class Slider : BaseApplicationPage
{
    private IWebDriver driver;
    
    public Slider(IWebDriver driver) : base(driver)
    {
        this.driver = driver;
    }

    public object CurrentImage => Driver.FindElement(By.Id("homeslider")).GetAttribute("style");

    internal void ClickNextButton()
    {
        throw new NotImplementedException();
    }
}