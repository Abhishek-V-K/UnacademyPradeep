using TechTalk.SpecFlow;

namespace Unacademy
{
    public class ApplicationHooks : UtilityClass
    {
        public LoginPage lp;
        public HomePage hp;

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("CHROME");
            LaunchApp(url);



            lp = new LoginPage(driver);
            hp = new HomePage(driver);


            Thread.Sleep(5000);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(5000);
            CloseBrowser();
        }
    }
}
