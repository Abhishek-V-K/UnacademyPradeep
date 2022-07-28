using OpenQA.Selenium;

namespace Unacademy
{
    public class HomePage : UtilityClass
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
