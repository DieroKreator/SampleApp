namespace AutomationPractice;

public class ContactUsFeature
{
    public IWebDriver? Driver { get; set; }

    [TestMethod]
    [Description("")]
    [TestProperty("Author", "Diego Rojas")]
    public void TCID2()
    {
        ContactUsPage contactUsPage = new ContactUsPage(Driver);
        contactUsPage.GoTo();
        Assert.IsTrue(contactUsPage.IsLoaded, "The contact us page did not open successfully");
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