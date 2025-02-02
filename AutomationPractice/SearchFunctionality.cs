using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationPractice;

[TestClass]
public class SearchFunctionality
{
    public IWebDriver? Driver { get; set; }

    [TestMethod]
    [TestCategory("SearchingFeature")]
    public void TestMethod1()
    {
        HomePage homePage = new HomePage(Driver);
        homePage.GoTo();
        SearchPage searchPage = homePage.Search("blouse");
        Assert.IsTrue(searchPage.Contains(Item.Blouse));
    }

    [TestInitialize]
    public void SetupForEverySingleTestMethod()
    {
        Driver = GetChromeDriver();
    }

    [TestCleanup]
    public void CleanUpAfterEveryTestMethod()
    {
        Driver.Close();
        Driver.Quit();
    }

    private IWebDriver GetChromeDriver()
    {
        var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        return new ChromeDriver(outPutDirectory);
        // return new ChromeDriver();
    }
}