using OpenQA.Selenium;

namespace Unacademy
{
	public class LoginPage
	{
		private IWebDriver driver;

		private By Xpath = By.Name("email");
		private By password = By.Name("password");
		private By loginButton = By.XPath("//*[@id='__next']/header/div/div/button");
		private By Createyouraccount = By.XPath("//*[@id='DrawerPaper']/div[2]/div[1]/a/h6");


		public LoginPage(IWebDriver driver)
		{
			this.driver = driver;
		}


		public void LoginUsername(string usernameValue)
		{
			
		}
		public void Createyouraccountbutton()
        {
			driver.FindElement(Createyouraccount).Click();
        }

		public void LoginPassword(string passwordValue)
		{
			driver.FindElement(password).SendKeys("Prad123");
		}

		public HomePage LoginButton()
		{
			driver.FindElement(loginButton).Click();
			return new HomePage(driver);
		}
	}
}
