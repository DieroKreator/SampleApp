using OpenQA.Selenium;

namespace AutomationPractice;

[TestClass]
public class SearchFunctionality
{
    public IWebDriver Driver { get; private set; }

    [TestMethod]
    public void TestMethod1()
    {
        HomePage homePage = new HomePage(Driver);
        homePage.GoTo();
        SearchPage searchPage = homePage.Search("blouse");
        Assert.IsTrue(searchPage.Contains(Item.Blouse));
    }
}