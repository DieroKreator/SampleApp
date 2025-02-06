using OpenQA.Selenium;

namespace AutomationPractice;

internal class HomePage : BaseApplicationPage
{
    public HomePage(IWebDriver driver) : base(driver)
    {
        Slider = new Slider(Driver); 
    }

    public Slider Slider { get; internal set; } 

    internal void GoTo()
    {
        Driver.Navigate().GoToUrl("http://automationpractice.com");
    }

    internal SearchPage Search(string itemToSearchFor)
    {
        Driver.FindElement(By.Id("search_query_top")).SendKeys(itemToSearchFor);
        Driver.FindElement(By.Name("submit_search")).Click();
        return new SearchPage(Driver);
    }
}