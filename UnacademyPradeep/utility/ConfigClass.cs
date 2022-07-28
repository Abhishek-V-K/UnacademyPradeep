using OpenQA.Selenium;


namespace Unacademy
{
    public class ConfigClass
    {
        public static IWebDriver driver;
        public static string chromeDriverPath = @"C:\Users\abhis\source\repos\UnacademyPradeep\UnacademyPradeep\Drivers\";
        // public static string geckoDriverPath = @"C:\Users\username\source\repos\SeleniumSpecFlowPO\SeleniumSpecFlowPO\drivers\";

        public static string url = "https://unacademy.com/";

        public static string filePath = @"C:\Users\abhis\source\repos\UnacademyPradeep\UnacademyPradeep\screenshots\";

        public static int PAGE_LOAD_TIMEOUT = 10;
        public static int IMPLICIT_WAIT = 10;
    }
}
