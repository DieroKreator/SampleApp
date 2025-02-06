using OpenQA.Selenium;

namespace AutomationPractice;

public class Slider : BaseApplicationPage
{
    private IWebDriver driver;
    
    public Slider(IWebDriver driver) : base(driver)
    {
        this.driver = driver;
    }

}