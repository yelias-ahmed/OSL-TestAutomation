using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace OSl_Test_Automation.Pages
{
    public class AdminPage
    {
        private IWebDriver driver;

        String AdminPortalUrl = "https://ums.osl.team";

        By AdminLoginPage = By.XPath("//div[@class='panel-title text-center']");
        By Username = By.XPath("//input[@id='UserName']");
        By Password = By.XPath("(//input[@id='Password'])[1]");
        By LoginButton = By.XPath("//button[@id='Submit']");
        By Welcome = By.XPath("//h1[normalize-space()='Welcome to UMS']");

        public AdminPage(IWebDriver driver) {  this.driver = driver; }

        public void getAdminPortal() { driver.Navigate().GoToUrl(AdminPortalUrl); }
        public IWebElement getAdminLoginPage() { return (IWebElement)driver.FindElement(AdminLoginPage); }
        public IWebElement getUsername() { return (IWebElement)driver.FindElement(Username); }
        public IWebElement getPassword() { return (IWebElement)driver.FindElement(Password); }
        public IWebElement getLoginButton() { return (IWebElement)driver.FindElement(LoginButton); }
        public IWebElement getWelcome() { return (IWebElement)driver.FindElement(Welcome); }

    }
}
