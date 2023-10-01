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
    public sealed class TeacherSteps
    {
        private IWebDriver driver;
        public TeacherPage teacherPage;

        public TeacherSteps(IWebDriver driver, TeacherPage teacherPage)
        {
            this.driver = driver;
            this.teacherPage = teacherPage;
        }


//-----------------------------------Teacher Login Steps-----------------------------------

        [Given(@"Teacher can successfully login Teacher portal")]
        public void teacherCanSuccessfullyLoginTeacherPortal()
        {
            teacherPage.getTeacherPortal();
            Thread.Sleep(1000);
            Assert.IsTrue(teacherPage.getTeacherLoginPage().Displayed);
            Assert.IsTrue(teacherPage.setTPinNumber().Displayed);
            teacherPage.setTPinNumber().SendKeys(@"13091");
            Assert.IsTrue(teacherPage.setPassword().Displayed);
            teacherPage.setPassword().SendKeys(@"123456");
            Assert.IsTrue(teacherPage.getLoginButton().Displayed);
            teacherPage.getLoginButton().Click();
            Assert.IsTrue(teacherPage.getMyRoutine().Displayed);
        }


        [Given(@"Verify that the Teacher Login page is being displayed accurately")]
        public void varifyThatTheTeacherLoginPageIsBeingDisplayedAccurately()
        {
                teacherPage.getTeacherPortal();
            Thread.Sleep(1000);
            Assert.IsTrue(teacherPage.getTeacherLoginPage().Displayed);
        }

        [Then(@"Enter TPIN into the Emter your TPIN field")]
        public void enterTPINNumber()
        {
            Assert.IsTrue(teacherPage.setTPinNumber().Displayed);
            teacherPage.setTPinNumber().SendKeys(@"13091");
        }

        [Then(@"Enter Teacher Password into the Password field")]
        public void enterTeacherPassword()
        {
            Assert.IsTrue(teacherPage.setPassword().Displayed);
            teacherPage.setPassword().SendKeys(@"123456");
        }

        [When(@"Click on log in button on Teacher Login Page")]
        public void clickOnLoginButtonOnTeacherLoginPage()
        {
            Assert.IsTrue(teacherPage.getLoginButton().Displayed);
            teacherPage.getLoginButton().Click();
        }

        [Then(@"Check that MY ROUTINE page is displayed accurately")]
        public void checkThatTheRoutinePageIsDisplayedAccurately()
        {
            Assert.IsTrue(teacherPage.getMyRoutine().Displayed);

        }



    }

}
