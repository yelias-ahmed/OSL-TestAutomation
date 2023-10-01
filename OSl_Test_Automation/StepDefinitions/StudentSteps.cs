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
    public sealed class StudentSteps
    {
        private IWebDriver driver;
        public StudentPage studentPage;

        public StudentSteps(IWebDriver driver, StudentPage studentPage)
        {
            this.driver = driver;
            this.studentPage = studentPage;
        }



//-----------------------------------Student Login Steps-----------------------------------

        [Given(@"Student can successfully login student portal")]
        public void studentCanSuccessfullyLoginStudentPortal()
        {
            Thread.Sleep(1000);
            studentPage.getStudentPortal();
            Assert.IsTrue(studentPage.getStudentLoginPage().Displayed);
            Assert.IsTrue(studentPage.setRegistrtionNumber().Displayed);
            studentPage.setRegistrtionNumber().SendKeys(@"2378587");
            Assert.IsTrue(studentPage.getNextButton().Displayed);
            studentPage.getNextButton().Click();
            Thread.Sleep(1000);
            Assert.IsTrue(studentPage.getPasswordPage().Displayed);
            Assert.IsTrue(studentPage.setPassword().Displayed);
            studentPage.setPassword().SendKeys(@"123456");
            Assert.IsTrue(studentPage.getStudentLoginButton().Displayed);
            studentPage.getStudentLoginButton().Click();
            Thread.Sleep(1000);
            Assert.IsTrue(studentPage.getMyRoutineToday().Displayed);
        }


        [Given(@"Verify that the Student Login page is being displayed accurately")]
        public void varifyThatTheStudentLoginPageIsBeingDisplayedAccurately()
        {
            studentPage.getStudentPortal();
            Thread.Sleep(1000);
            Assert.IsTrue(studentPage.getStudentLoginPage().Displayed);
        }


        [Then(@"Enter Student Registration Number into the Registration Number field")]
        public void enterRegistrationNumber()
        {
            Assert.IsTrue(studentPage.setRegistrtionNumber().Displayed);
            studentPage.setRegistrtionNumber().SendKeys(@"2378587");
        }

        [When(@"Click Next Button on Student Login Page")]
        public void clickOnNextButton()
        {
            Assert.IsTrue(studentPage.getNextButton().Displayed);
            studentPage.getNextButton().Click();
        }

        [Then(@"Check that the Enter Your Password page should displayed")]
        public void enterYourPasswordPageShouldBeDisplayed()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(studentPage.getPasswordPage().Displayed);
        }

        [Then(@"Enter Password into the Password field")]
        public void enterYourPassword()
        {
            Assert.IsTrue(studentPage.setPassword().Displayed);
            studentPage.setPassword().SendKeys(@"123456");
        }

        [When(@"Click on log in button on Student Login Page")]
        public void clickOnLoginButton()
        {
            Assert.IsTrue(studentPage.getStudentLoginButton().Displayed);
            studentPage.getStudentLoginButton().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Check that the My routine page is displayed accurately")]
        public void checkThatTheMyRoutinePageIsDisplayedAccurately()
        {
            Assert.IsTrue(studentPage.getMyRoutineToday().Displayed);
        }

        //-----------------------------------Master Class Login Steps-----------------------------------

        [Then(@"Master Class Menu should be displayed correctly no top navigation")]
        public void masterClassMenuShouldBeDisplayedCorrectlyNoTopNavigation()
        {
            Assert.IsTrue(studentPage.getMasterClassManu().Displayed);
        }

        [When(@"Click on Master Class Menu from top navigation")]
        public void clickOnMasterClassMenuFromTopNavigation()
        {
            studentPage.getMasterClassManu().Click();
            Thread.Sleep(1000);
        }



        [When(@"Click on Proceed in any Master Class")]
        public void clickOnProceedInAnyMasterClass()
        {
            Assert.IsTrue(studentPage.getProceedButton().Displayed);
            studentPage.getProceedButton().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Check that the Master Class page is being Load and displayed accurately")]
        public void checkThatTheMasterClassPageIsBeingLoadAndDisplayedAccurately()
        {
            Boolean flag = true;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            while (flag)
            {
                try
                {
                    js.ExecuteScript(@"arguments[0].scrollIntoView();", studentPage.getLoadMore());
                    Thread.Sleep(1000);
                    studentPage.getLoadMore().Click();
                    Thread.Sleep(2000);
                    flag = studentPage.getLoadMore().Displayed;
                }
                catch (Exception e) { break; }
            }
            js.ExecuteScript(@"arguments[0].scrollIntoView();", studentPage.getLoadMore());
            Thread.Sleep(2000);
        }


        [Then(@"Verify that the Master Class page is Displayed By Course")]
        public void verifyThatTheMasterClassPageIsDisplayedByCourse()
        {
            Assert.IsTrue(studentPage.getMasterClassPage().Displayed);
            Assert.IsTrue(studentPage.getMasterClassCourse().Displayed);
        }

        [Then(@"Check that the Master Class page is displayed By Lecture")]
        public void checkThatTheMasterClassPageIsDisplayedByLecture()
        {
            Assert.IsTrue(studentPage.getMasterClassPage().Displayed);
            Assert.IsTrue(studentPage.getChapter().Displayed);
        }

        [Then(@"Check that the Search bar is displayed accurately")]
        public void checkThatTheSearchBarIsDisplayedAccurately()
        {
            Assert.IsTrue(studentPage.getSearchBar().Displayed);
        }

        [When(@"Type a search keyword into the search bar")]
        public void typeASearchKeywordIntoTheSearchBar()
        {
            studentPage.getSearchBar().SendKeys(@"বাফার");
            Thread.Sleep(3000);
        }

        [Then(@"Check that the search result is showing")]
        public void checkThatTheSearchResultIsShowing()
        {
            Assert.IsTrue(studentPage.getSearchResult().Displayed);
        }

        [When(@"Click on any subject quiz")]
        public void clickOnAnySubjectQuiz()
        {
            studentPage.getQuiz().Click();
            Thread.Sleep(1000);
        }

        [Then(@"click on Start Quiz or retake quiz")]
        public void clickOnStartQuizRetakeQuiz()
        {
            studentPage.getStartQuiz().Click();
        }


        [Then(@"Select options from questions")]
        public void selectOptionsFromQuestions()
        {
            studentPage.SelectAllOption();
            Thread.Sleep(1000);
        }

        [When(@"Click on submit")]
        public void clickOnSubmit()
        {
            studentPage.getSubmitQuiz().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Check that a pop up is showing")]
        public void checkThatAPopUpIsShowing()
        {
            Assert.IsTrue(studentPage.getAlartBox().Displayed);
        }

        [When(@"Click on yes button")]
        public void clickOnYesButton()
        {
            studentPage.getYesButton().Click();
            Thread.Sleep(1000);
        }

        [Then(@"check that the Analysis Report is showing")]
        public void checkThatTheAnalysisReportIsShowing()
        {
            Assert.IsTrue(studentPage.getAnalysisReport().Displayed);
            Thread.Sleep(1000);
        }

    }
}
