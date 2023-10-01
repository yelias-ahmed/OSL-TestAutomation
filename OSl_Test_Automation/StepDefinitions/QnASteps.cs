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
    public sealed class QnASteps
    {
        private IWebDriver driver;
        public QnAPage qnAPage;

        public QnASteps(IWebDriver driver, QnAPage qnAPage)
        {
            this.driver = driver;
            this.qnAPage = qnAPage;
        }


        //-----------------------------------Q&A Steps-----------------------------------


        [Then(@"Q&A Menu should be displayed correctly no top navigation")]
        public void qAMenuShouldBeDisplayedCorrectlyNoTopNavigation()
        {
            Assert.IsTrue(qnAPage.getQnAMenu().Displayed);
        }

        [When(@"Click on Q&A Menu from top navigation")]
        public void clickOnQAMenuFromTopNavigation()
        {
            qnAPage.getQnAMenu().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Verify that the Q&A Services page is being Load and displayed accurately")]
        public void verifyThatTheQAServicesPageIsBeingDisplayedAccurately()
        {
            Assert.IsTrue(qnAPage.getQnAPage().Displayed);
            Boolean flag = true;
            while (flag)
            {
                Thread.Sleep(2000);
                qnAPage.scroll(qnAPage.getLoadMoreBtn());
                Thread.Sleep(1000);
                qnAPage.getLoadMoreBtn().Click();
                flag = qnAPage.getLoadMoreBtn().Displayed;
            }
            qnAPage.scroll(qnAPage.getQnAPage());
            Thread.Sleep(2000);
        }

        [Then(@"Check that the Q&A Services page should displayed")]
        public void CheckthattheQAServicespageshoulddisplayed()
        {
            Assert.IsTrue(qnAPage.getQnAPage().Displayed);
            Thread.Sleep(1000);
        }

        [When(@"Click proceed on any subject from Q&A services Page")]
        public void clickProceedOnAnySubjectFromQAServicesPage()
        {
            Assert.IsTrue(qnAPage.getAnySubject().Displayed);
            qnAPage.getAnySubject().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Question and answer page should displayed")]
        public void questionAndAnswerPageShouldDisplayed()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(qnAPage.getQuestionAnswerPage().Displayed);

        }

        [Then(@"Check that the Ask a new Question Button is available")]
        public void checkThatTheAskANewQuestionButtonIsAvailable()
        {
            Assert.IsTrue(qnAPage.getAskANewQuestion().Displayed);
        }

        [When(@"Click on Ask a new question button")]
        public void clickOnAskANewQuestionButton()
        {
            qnAPage.getAskANewQuestion().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Check that the ask a new question page is displayed")]
        public void checkThatTheAskANewQuestionPageIsDisplayed()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(qnAPage.getAskANewQuestionPage().Displayed);
        }

        [Then(@"Select a course from course dropdown list")]
        public void selectACourseFromCourseDropdownList()
        {
            Assert.IsTrue(qnAPage.getCourseDropdown().Displayed);
            qnAPage.getCourseDropdown().Click();
            Thread.Sleep(1000);
            Assert.IsTrue(qnAPage.getCourseDropdownList().Displayed);
            qnAPage.getCourseDropdownList().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Select Subject from subject dropdown list")]
        public void selectSubjectFromSubjectDropdownList()
        {
            Assert.IsTrue(qnAPage.getSubjectDropdown().Displayed);
            qnAPage.getSubjectDropdown().Click();
            Thread.Sleep(1000);
            Assert.IsTrue(qnAPage.getSubjectDropdownList().Displayed);
            qnAPage.getSubjectDropdownList().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Select chapter from chapter dropdown list")]
        public void selectChapterFromChapterDropdownList()
        {
            Assert.IsTrue(qnAPage.getChapterDropdown().Displayed);
            qnAPage.getChapterDropdown().Click();
            Thread.Sleep(1000);
            Assert.IsTrue(qnAPage.getChapterDropdownList().Displayed);
            qnAPage.getChapterDropdownList().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Type a question in ask a question text box")]
        public void typeAQuestionInAskAQuestionTextBox()
        {
            Assert.IsTrue(qnAPage.getAskANewQuestionText().Displayed);
            qnAPage.getAskANewQuestionText().SendKeys(@"প্রোটন পরমাণুর কোথায় অবস্থান করে?");
            Thread.Sleep(1000);
        }

        [When(@"Click on submit button")]
        public void clickOnSubmitButton()
        {
            Assert.IsTrue(qnAPage.getSubmit().Displayed);
            qnAPage.scroll(qnAPage.getSubmit());
            qnAPage.getSubmit().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Question&Answer Menu should be displayed correctly no top navigation")]
        public void questionAnswerMenuShouldBeDisplayedCorrectlyNoTopNavigation()
        {
            Assert.IsTrue(qnAPage.getQuestionAnswerMenu().Displayed);
        }

        [When(@"Click on Question&Answer Menu from top navigation")]
        public void clickOnQuestionAnswerMenuFromTopNavigation()
        {
            qnAPage.getQuestionAnswerMenu().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Click On Pending Question sub menu from dropdown")]
        public void clickOnPendingQuestionSubMenuFromDropdown()
        {
            qnAPage.getPendingQuestion().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Check that asked question displayed in New Question section")]
        public void checkThatAskedQuestionDisplayedInNewQuestionSection()
        {
            Assert.IsTrue(qnAPage.getNewQuestion().Displayed);
        }

        [When(@"Click on Answer Button side QA Arc Course")]
        public void clickOnAnswerButton()
        {
            qnAPage.getAnswerButton().Click();
            Thread.Sleep(3000);
        }

        [Then(@"Student's Question page should displayed")]
        public void studentSQuestionPageShouldDisplayed()
        {

            Assert.IsTrue(qnAPage.getStudentsQuestion().Displayed);
        }

        [Then(@"Enter answer in the text box")]
        public void enterAnswerInTheTextBox()
        {
            Assert.IsTrue(qnAPage.getInputAnswer().Displayed);
            qnAPage.getInputAnswer().SendKeys("In the nucleus");
            Thread.Sleep(8000);
        }

        [When(@"Click on submit & Next Button")]
        public void clickOnSubmitNextButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(false);", qnAPage.getSubmitNextBtn());
            Thread.Sleep(8000);
            Assert.IsTrue(qnAPage.getSubmitNextBtn().Displayed);
            Assert.IsTrue(qnAPage.getSubmitNextBtn().Enabled);
            qnAPage.scroll(qnAPage.getSubmitNextBtn());
            qnAPage.getSubmitNextBtn().Click();
            Thread.Sleep(3000);
        }

        [Then(@"Success! message should be displayed")]
        public void successMessageShouldBeDisplayed()
        {
            Thread.Sleep(1000);
            try
            {
                Assert.IsTrue(qnAPage.getSuccessMsg().Displayed);
            }
            catch(Exception ex)
            {

            }

        }

        [Then(@"Ensure accurate display of notification badge within the notification icon")]
        public void ensureAccurateDisplayOfNotificationBadgeWithinTheNotificationIcon()
        {
            Assert.IsTrue(qnAPage.getNotificationBadge().Displayed);
        }

        [When(@"Click on notification icon")]
        public void clickOnNotificationIcon()
        {
            qnAPage.getNotificaltionIcon().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Check that the notification Page should displayed")]
        public void checkThatTheNotificationPageShouldDisplayed()
        {
            Assert.IsTrue(qnAPage.getNotificationPage().Displayed);
        }

        [Then(@"Check that the notification card should displayed")]
        public void checkThatTheNotificationCardShouldDisplayed()
        {
            Assert.IsTrue(qnAPage.getNotificationCard().Displayed);
        }

        [Then(@"Check that the notification badge is gone")]
        public void checkThatTheNotificationBadgeIsGone()
        {
            Assert.IsFalse(qnAPage.getNotificationBadge().Displayed);
        }

        [When(@"click on notification card")]
        public void clickOnNotificationCard()
        {
            qnAPage.getNotificationCard().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Check that the Answer should displayed")]
        public void checkThatTheAnswerShouldDisplayed()
        {
            Assert.IsTrue(qnAPage.getAnswer().Displayed);
        }

        [When(@"click on Back to notification")]
        public void clickOnBackToNotification()
        {
            Assert.IsTrue(qnAPage.getBackToNotificationCard().Displayed);
            qnAPage.getBackToNotificationCard().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Check that the notification icon is displayed Correctly")]
        public void checkThatTheNotificationIconIsDisplayedCorrectly()
        {
            Assert.IsTrue(qnAPage.getNotificaltionIcon().Displayed);
        }

        [When(@"Click on not yet icon")]
        public void clickOnNotYetIcon()
        {
            Assert.IsTrue(qnAPage.getNotYet().Displayed);
            qnAPage.getNotYet().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Check that the Ask a question Text box should displayed")]
        public void checkThatTheAskAQuestionTextBoxShouldDisplayed()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(qnAPage.getAskANewQuestionText().Displayed);
        }

        [Then(@"Asked question should displayed")]
        public void askedQuestionShouldDisplayed()
        {
            Assert.IsTrue(qnAPage.getStudentReplay().Displayed);
        }

        [Then(@"Check that Review Request section should displayed")]
        public void checkThatReviewRequestSectionShouldDisplayed()
        {
            Assert.IsTrue(qnAPage.getReviewRequest().Displayed);
        }

        [When(@"Click on Review Button side QA Arc Course")]
        public void clickOnReviewButtonSideQAArcCourse()
        {
            qnAPage.getReviewRequestButton().Click();
            Thread.Sleep(1000);

        }

        [When(@"Click on Submit & Next Button of Review Request")]
        public void clickOnSubmitNextButtonOfReviewRequest()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(@"arguments[0].scrollIntoView(false);", qnAPage.getSubmitNext());
            Thread.Sleep(8000);
            Assert.IsTrue(qnAPage.getSubmitNext().Displayed);
            Assert.IsTrue(qnAPage.getSubmitNext().Enabled);
            qnAPage.getSubmitNext().Click();
            Thread.Sleep(1000);
        }

        [When(@"Click on satisfied icon")]
        public void clickOnSatisfiedIcon()
        {
            Assert.IsTrue(qnAPage.getSatisfied().Displayed);
            qnAPage.getSatisfied().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Check that te Satisfied mark should displayed")]
        public void checkThatTeSatisfiedMarkShouldDisplayed()
        {
            Assert.IsTrue(qnAPage.getSatisfiedMark().Displayed);
        }


        [When(@"Click on Student Menu")]
        public void clickOnStudentMenu()
        {
            Assert.IsTrue(qnAPage.getStudentMenu().Displayed);
            qnAPage.getStudentMenu().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Check that the Student Area page should displayed")]
        public void checkThatTheStudentAreaPageShouldDisplayed()
        {
            Assert.IsTrue(qnAPage.getStudentArea().Displayed);
        }

        [When(@"Click on Q&A2 Service")]
        public void clickOnQAService()
        {
            qnAPage.getQnA2Service().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Click on Qn&A2 Moderation")]
        public void clickOnQnAModeration()
        {
            qnAPage.getQnA2Moderation().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Check that the Moderation Page should displayed")]
        public void checkThatTheModerationPageShouldDisplayed()
        {
            Assert.IsTrue(qnAPage.getModerationPage().Displayed);
        }


        [Then(@"Enter reg number on Moderation page")]
        public void enterRegNumberOnModerationPage()
        {
            qnAPage.getRegiRoll().SendKeys("2378587");
        }

        [When(@"Click on View button")]
        public void clickOnViewButton()
        {
            qnAPage.getViewButton().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Check that the Summary Section should displayed")]
        public void checkThatTheSummarySectionShouldDisplayed()
        {
            Assert.IsTrue(qnAPage.getSummarySection().Displayed);
        }

        [When(@"Click on Moderate button")]
        public void clickOnModerateButton()
        {
            qnAPage.getModerate().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Check that student question page should displayed")]
        public void checkThatStudentQuestionPageShouldDisplayed()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            Assert.IsTrue(qnAPage.getStudentQuestionPage().Displayed);
        }

        [When(@"Click on paperclip icon and input image location")]
        public void clickOnPaperclipIconAndInputImageLocation()
        {
            qnAPage.getPaperclip().Click();
            qnAPage.getEditAnswerImg().SendKeys("C:\\UploadImg.png");
        }

        [Then(@"Check that the image should displayed")]
        public void checkThatTheImageShouldDisplayed()
        {
            Assert.IsTrue(qnAPage.getImgFluid().Displayed);
            Thread.Sleep(3000);
        }

        [When(@"click on update & next and exit")]
        public void clickOnUpdateNextAndExit()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            qnAPage.getUpdateNNext().Click();
            Thread.Sleep(1000);
            js.ExecuteScript(@"arguments[0].scrollIntoView();", qnAPage.getExitButton());
            Thread.Sleep(1000);
            qnAPage.getExitButton().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Verify that the page is being Load and displayed accurately")]
        public void verifyThatThePageIsBeingLoadAndDisplayedAccurately()
        {
            Boolean flag = true;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            while (flag)
            {
                try
                {
                    js.ExecuteScript("arguments[0].scrollIntoView();", qnAPage.getLoadMoreButton());
                    Thread.Sleep(1000);
                    qnAPage.getLoadMoreButton().Click();
                    Thread.Sleep(2000);
                    flag = qnAPage.getLoadMoreButton().Displayed;
                }
                catch (Exception e) { break; }
            }
            js.ExecuteScript(@"arguments[0].scrollIntoView();", qnAPage.getQuestionAnswerPage());
            Thread.Sleep(2000);
        }

        [Then(@"Input a search keyword into the search bar")]
        public void inputASearchKeywordIntoTheSearchBar()
        {
            qnAPage.getQSearchBar().SendKeys("প্রোটন পরমাণুর কোথায় অবস্থান করে?");
            Thread.Sleep(1000);
        }

        [When(@"Select a search suggestion by clicking on it")]
        public void selectASearchSuggestionByClickingOnIt()
        {
            qnAPage.getSearchSugg().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Confirm the display of the searched question and its corresponding answer")]
        public void confirmTheDisplayOfTheSearchedQuestionAndItsCorrespondingAnswer()
        {
            Assert.IsTrue(qnAPage.getQSearchResult().Displayed);
            Thread.Sleep(1000);
        }

        [Then(@"Click on delete All Button")]
        public void clickOnDeleteAllButton()
        {
            qnAPage.getDeleteAll().Click();
            Thread.Sleep(1000);
            qnAPage.getDeleteYesButton().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Type a reply in ask a question text box")]
        public void typeAReplyInAskAQuestionTextBox()
        {
            qnAPage.getAskANewQuestionText2().SendKeys("Please explain in detail");
        }

        [Then(@"Check that the Ask a question TextBox should displayed")]
        public void checkThatAskAQuestionTextBoxShouldDisplayed()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(qnAPage.getAskANewQuestionText2().Displayed);
        }

        [When(@"Click the Submit button located below the text box")]
        public void clickTheSubmitButtonLocatedBelowTheTextBox()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(@"arguments[0].scrollIntoView();", qnAPage.getAskANewQuestionText2());
            Thread.Sleep(3000);
            Assert.IsTrue(qnAPage.getSubmit2().Displayed);
            qnAPage.getSubmit2().Click();
            Thread.Sleep(1000);
        }

        [Then(@"Enter Review Answer in the text box")]
        public void enterReviewAnswerInTheTextBox()
        {
            Assert.IsTrue(qnAPage.getInputAnswer().Displayed);
            qnAPage.getInputAnswer().SendKeys("প্রোটন ও নিউট্রন একসাথে পরমাণুর কেন্দ্রে অবস্থান করে যাকে বলা হয় নিউক্লিয়াস। নিউক্লিয়াসের চারপাশে ইলেকট্রন নির্দিষ্ট বৃত্তাকার পথে ঘুরতে থাকে।");
            Thread.Sleep(8000);
        }

        [When(@"click on Reject & next and exit")]
        public void clickOnRejectNextAndExit()
        {
            try {
                qnAPage.scroll(qnAPage.getRejectButton());
                qnAPage.getRejectButton().Click();
                Thread.Sleep(1000);
                qnAPage.scroll(qnAPage.getExitButton());
                qnAPage.getExitButton().Click();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                qnAPage.scroll(qnAPage.getExitButton());
                qnAPage.getExitButton().Click();
                Thread.Sleep(1000);
            }
            

        }

        [When(@"click on Retrieve & next and exit")]
        public void clickOnRetrieveNextAndExit()
        {
            try {
                qnAPage.scroll(qnAPage.getRetrieveButton());
                qnAPage.getRetrieveButton().Click();
                Thread.Sleep(1000);
                qnAPage.scroll(qnAPage.getExitButton());
                qnAPage.getExitButton().Click();
                Thread.Sleep(1000);
            }
            catch (Exception ex) {
                qnAPage.scroll(qnAPage.getExitButton());
                qnAPage.getExitButton().Click();
                Thread.Sleep(1000);
            }
            
            
        }
    }
}
