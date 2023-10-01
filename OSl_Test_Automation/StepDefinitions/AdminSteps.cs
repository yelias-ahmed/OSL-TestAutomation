using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OSl_Test_Automation.Pages;

namespace OSl_Test_Automation.StepDefinitions
{
    [Binding]
    public sealed class AdminSteps
    {
        private IWebDriver driver;
        public AdminPage adminPage;

        public AdminSteps(IWebDriver driver, AdminPage adminPage)
        {
            this.driver = driver;
            this.adminPage = adminPage;
        }




        //-----------------------------------Admin Login Steps-----------------------------------



        [Given(@"Admin can successfully login Admin portal")]
        public void adminCanSuccessfullyLoginAdminPortal()
        {
            adminPage.getAdminPortal();
            Thread.Sleep(1000);
            Assert.IsTrue(adminPage.getAdminLoginPage().Displayed);
            adminPage.getUsername().SendKeys(@"asif@qups.com");
            adminPage.getPassword().SendKeys(@"123456");
            adminPage.getLoginButton().Click();
            Thread.Sleep(1000);
            Assert.IsTrue(adminPage.getWelcome().Displayed);

        }


        [Given(@"Verify that the Admin Login page is being displayed accurately")]
        public void varifyThatTheAdminLoginPageIsBeingDisplayedAccurately()
        {
            adminPage.getAdminPortal();
            Thread.Sleep(1000);
            Assert.IsTrue(adminPage.getAdminLoginPage().Displayed);
        }

        [Then(@"Enter Admin Email address into the email field")]
        public void enterUserEmail()
        {
            adminPage.getUsername().SendKeys(@"asif@qups.com");
        }

        [Then(@"Enter Admin Password into the Password field")]
        public void enterAdminPassword()
        {
            adminPage.getPassword().SendKeys(@"123456");
        }

        [When(@"Click on log in button on Admin Login Page")]
        public void clickOnLogInButton()
        {
            adminPage.getLoginButton().Click();
        }

        [Then(@"Check that the Welcome page is displayed accurately")]
        public void checkThatTheWelcomePageIsDisplayedAccurately()
        {
            Assert.IsTrue(adminPage.getWelcome().Displayed);
        }


    }
}
