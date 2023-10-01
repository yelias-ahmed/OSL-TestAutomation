using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace OSl_Test_Automation.Pages
{
    public class TeacherPage
    {
        private IWebDriver driver;

        String TeacherPortalUrl = "https://ums-portal.osl.team/Teacher";
        By TeacherLoginPage = By.XPath("//h2[normalize-space()='Teacher Login']");
        By TPinNumber = By.XPath("//input[@id='Username']");
        By Password = By.XPath("(//input[@id='Password'])[1]");
        By LoginButton = By.XPath("//button[normalize-space()='Login']");
        By MyRoutine = By.XPath("//h2[normalize-space()='MY ROUTINE']");



        public TeacherPage(IWebDriver driver) { this.driver = driver; }

        public void getTeacherPortal() { driver.Navigate().GoToUrl(TeacherPortalUrl); }
        public IWebElement getTeacherLoginPage() { return (IWebElement)driver.FindElement(TeacherLoginPage); }
        public IWebElement setTPinNumber() { return (IWebElement)driver.FindElement(TPinNumber); }
        public IWebElement setPassword() {  return (IWebElement) driver.FindElement(Password); }
        public IWebElement getLoginButton() {  return (IWebElement) driver.FindElement(LoginButton); }
        public IWebElement getMyRoutine() { return (IWebElement)driver.FindElement(MyRoutine); }




    }
}
