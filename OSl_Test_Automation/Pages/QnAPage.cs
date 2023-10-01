using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace OSl_Test_Automation.Pages
{
    public class QnAPage
    {
        private IWebDriver driver;

        By QnAMenu = By.XPath("//a[normalize-space()='Q&A']");
        By QnaPage = By.XPath("//h1[normalize-space()='Q&A SERVICES']");
        By LoadMoreButton = By.XPath("//button[@id='allQnALoadMore']");
        By LoadMoreBtn = By.XPath("//a[normalize-space()='Load More']");
        By AnySubject = By.XPath("(//a[@type='submit'][normalize-space()='Proceed'])[2]");
        By QuestionAnswerPage = By.XPath("//h2[normalize-space()='Question and Answer']");
        By AskANewQuestion = By.XPath("//a[@id='askNewQuestion']");
        By AskANewQuestionPage = By.XPath("//h2[normalize-space()='Ask a New Question']");
        By AskANewQuestionText = By.XPath("//textarea[@placeholder='Ask a question']");
        By AskANewQuestionText2 = By.XPath("(//textarea[@placeholder='Ask a question'])[2]");
        By CourseDropdown = By.XPath("//select[@id='AskCourse']");
        By CourseDropdownList = By.XPath("(//option[@value='130'][normalize-space()='QA Arc'])[1]");
        By SubjectDropdown = By.XPath("//select[@id='AskSubject']");
        By SubjectDropdownList = By.XPath("//select[@id='AskSubject']//option[@value='75'][normalize-space()='Architecture']");
        By ChapterDropdown = By.XPath("//select[@id='AskChapter']");
        By ChapterDropdownList = By.XPath("//option[@value='327']");
        By Submit = By.XPath("//input[@value='Submit']");
        By Submit2 = By.XPath("(//input[@value='Submit'])[2]");
        By QuestionAnswerMenu = By.XPath("//a[normalize-space()='Question & Answer']");
        By PendingQuestion = By.XPath("//a[normalize-space()='Pending Question']");
        By NewQuestion = By.XPath("//h5[normalize-space()='New Question']");
        By StudentsQuestion = By.XPath("(//b[normalize-space()=\"Student's Question\"])[1]");
        By SubmitNextBtn = By.XPath("//input[@id='SubmitNextBtn']");
        By InputAnswer = By.XPath("//textarea[@id='input-answer']");
        By SuccessMsg = By.XPath("//div[@class='alert alert-success']");
        By NotificationBadge = By.XPath("//span[@id='notification_badge']");
        By NotificationCard = By.XPath("(//div[@class='card-body'])[2]");
        By Notificationpage = By.XPath("//h2[normalize-space()='Notifications']");
        By BackToNotificationCard = By.XPath("//a[@class='btn px-3 shadow-none']");
        By Answer = By.XPath("(//div[@class='teacher-reply'])[1]");
        By NotificaltionIcon = By.XPath("//i[@class='fas fa-bell']");
        By NotYet = By.XPath("//a[@class='btn btn-notYet']");
        By StudentReplay = By.XPath("(//div[@class='student-reply text-right thread-details-container'])[2]");
        By ReviewRequest = By.XPath("//h5[normalize-space()='Review Request']");
        By SubmitNext = By.XPath("//input[@value='Submit & Next']");
        By Satisfied = By.XPath("//a[@class='btn btn-satisfied mr-2']");
        By SatisfiedMark = By.XPath("//span[@class='text-success']");
        By StudentMenu = By.XPath("//a[normalize-space()='Student']");
        By StudentArea = By.XPath("//h1[normalize-space()='Student Area']");
        By QnA2Service = By.XPath("//a[normalize-space()='Q&A2 Service']");
        By QnA2Moderation = By.XPath("//a[normalize-space()='Q&A2 Moderation']");
        By RegiRoll = By.XPath("//input[@id='RegiRoll']");
        By ViewButton = By.XPath("//button[@id='btnView']");
        By Moderate = By.XPath("(//button[normalize-space()='Moderate'])[1]");
        By ModerationPage = By.XPath("//h4[normalize-space()='Q&A Moderation']");
        By SummarySection = By.XPath("//h4[normalize-space()='Summary']");
        By EditAnswerImg = By.XPath("(//input[@id='editAnswer-image-file-input'])[1]");
        By StudentQuestionPage = By.XPath("(//b[normalize-space()=\"Student's Question\"])[1]");
        By Paperclip = By.XPath("//i[@class='fa fa-paperclip']");
        By UpdateNNext = By.XPath("//button[@id='SaveNewQuestion']");
        By ExitButton = By.XPath("//button[@id='btnExit']");
        By ImgFluid = By.XPath("(//img[@class='img-fluid modal-item'])[1]");
        By QSearchBar = By.XPath("//input[@placeholder='Search your question here']");
        By SearchSugg = By.XPath("(//a[@class='singleThreadQuestionSpan'])[1]");
        By QSearchResult = By.XPath("//div[@class='card-body searchedThreadBox']");
        By DeleteAll = By.XPath("//a[normalize-space()='Delete All']");
        By DeleteYesButton = By.XPath("//a[@id='delete_all_notification']");
        By RejectButton = By.XPath("//button[@class='clsBtnAnswerAction btn btn-danger']");
        By RetrieveButton = By.XPath("//button[@id='btnRetrieve']");
        By LoadMore = By.XPath("//button[@type='submit']");

        public QnAPage(IWebDriver driver) { this.driver = driver; }


        public IWebElement getQnAMenu() { return (IWebElement)driver.FindElement(QnAMenu); }
        public IWebElement getQnAPage() { return (IWebElement)driver.FindElement(QnaPage); }
        public IWebElement getLoadMore() { return (IWebElement)driver.FindElement(LoadMore); }
        public IWebElement getAnySubject() { return (IWebElement)driver.FindElement(AnySubject); }
        public IWebElement getQuestionAnswerPage() { return (IWebElement)driver.FindElement(QuestionAnswerPage); }
        public IWebElement getAskANewQuestion() { return (IWebElement)driver.FindElement(AskANewQuestion); }
        public IWebElement getAskANewQuestionPage() { return (IWebElement)driver.FindElement(AskANewQuestionPage); }
        public IWebElement getAskANewQuestionText() { return (IWebElement)driver.FindElement(AskANewQuestionText); }
        public IWebElement getAskANewQuestionText2() { return (IWebElement)driver.FindElement(AskANewQuestionText2); }
        public IWebElement getCourseDropdown() { return (IWebElement)driver.FindElement(CourseDropdown); }
        public IWebElement getCourseDropdownList() { return (IWebElement)driver.FindElement(CourseDropdownList); }
        public IWebElement getSubjectDropdown() { return (IWebElement)driver.FindElement(SubjectDropdown); }
        public IWebElement getSubjectDropdownList() { return (IWebElement)driver.FindElement(SubjectDropdownList); }
        public IWebElement getChapterDropdown() { return (IWebElement)driver.FindElement(ChapterDropdown); }
        public IWebElement getChapterDropdownList() { return (IWebElement)driver.FindElement(ChapterDropdownList); }
        public IWebElement getSubmit() { return (IWebElement)driver.FindElement(Submit); }
        public IWebElement getSubmit2() { return (IWebElement)driver.FindElement(Submit2); }
        public IWebElement getQuestionAnswerMenu() { return (IWebElement)driver.FindElement(QuestionAnswerMenu); }
        public IWebElement getPendingQuestion() { return (IWebElement)driver.FindElement(PendingQuestion); }
        public IWebElement getNewQuestion() { return (IWebElement)driver.FindElement(NewQuestion); }
        public IWebElement getStudentsQuestion() { return (IWebElement)driver.FindElement(StudentsQuestion); }
        public IWebElement getSubmitNextBtn() { return (IWebElement)driver.FindElement(SubmitNextBtn); }
        public IWebElement getInputAnswer() { return (IWebElement)driver.FindElement(InputAnswer); }
        public IWebElement getAnswerButton()
        {

            String xpath = null;
            int k = 2;
            try
            {
                if (driver.FindElement(By.XPath("//body[1]/div[2]/div[1]/div[3]/div[2]/table[1]/tbody[1]/tr[1]/td[2]")).Displayed)
                    k = 3;
            }
            catch (Exception e) { k = 2; }


            for (int i = 1; ; i++)
            {

                xpath = "//body[1]/div[2]/div[1]/div[" + k + "]/div[2]/table[1]/tbody[1]/tr[" + i + "]/td[2]";
                if (driver.FindElement(By.XPath(xpath)).Text.Equals("QA Arc"))
                {
                    xpath = "//tbody[1]/tr[" + i + "]/td[6]/a[1]";
                    break;

                }
            }
            return (IWebElement)driver.FindElement(By.XPath(xpath));
        }
        public IWebElement getSuccessMsg() { return (IWebElement)driver.FindElement(SuccessMsg); }
        public IWebElement getNotificationBadge() { return (IWebElement)driver.FindElement(NotificationBadge); }
        public IWebElement getNotificationCard() { return (IWebElement)driver.FindElement(NotificationCard); }
        public IWebElement getNotificationPage() { return (IWebElement)driver.FindElement(Notificationpage); }
        public IWebElement getBackToNotificationCard() { return (IWebElement)driver.FindElement(BackToNotificationCard); }
        public IWebElement getAnswer() { return (IWebElement)driver.FindElement(Answer); }
        public IWebElement getNotificaltionIcon() { return (IWebElement)driver.FindElement(NotificaltionIcon); }
        public IWebElement getNotYet() { return (IWebElement)driver.FindElement(NotYet); }
        public IWebElement getStudentReplay() { return (IWebElement)driver.FindElement(StudentReplay); }
        public IWebElement getReviewRequest() { return (IWebElement)driver.FindElement(ReviewRequest); }
        public IWebElement getReviewRequestButton()
        {
            String xpath = null;
            for (int i = 1; ; i++)
            {
                xpath = "//body[1]/div[2]/div[1]/div[2]/div[2]/table[1]/tbody[1]/tr[" + i + "]/td[2]";
                if (driver.FindElement(By.XPath(xpath)).Text.Equals("QA Arc"))
                {
                    xpath = "//tbody[1]/tr[" + i + "]/td[7]/a[1]";
                    break;

                }
            }
            return (IWebElement)driver.FindElement(By.XPath(xpath));
        }
        public IWebElement getSubmitNext() { return (IWebElement)driver.FindElement(SubmitNext); }
        public IWebElement getSatisfied() { return (IWebElement)driver.FindElement(Satisfied); }
        public IWebElement getSatisfiedMark() { return (IWebElement)driver.FindElement(SatisfiedMark); }
        public IWebElement getStudentMenu() { return (IWebElement)driver.FindElement(StudentMenu); }
        public IWebElement getStudentArea() { return (IWebElement)driver.FindElement(StudentArea); }
        public IWebElement getQnA2Service() { return (IWebElement)driver.FindElement(QnA2Service); }
        public IWebElement getQnA2Moderation() { return (IWebElement)driver.FindElement(QnA2Moderation); }
        public IWebElement getRegiRoll() { return (IWebElement)driver.FindElement(RegiRoll); }
        public IWebElement getViewButton() { return (IWebElement)driver.FindElement(ViewButton); }
        public IWebElement getModerate() { return (IWebElement)driver.FindElement(Moderate); }
        public IWebElement getModerationPage() { return (IWebElement)driver.FindElement(ModerationPage); }
        public IWebElement getSummarySection() { return (IWebElement)driver.FindElement(SummarySection); }
        public IWebElement getEditAnswerImg() { return (IWebElement)driver.FindElement(EditAnswerImg); }
        public IWebElement getStudentQuestionPage() { return (IWebElement)driver.FindElement(StudentQuestionPage); }
        public IWebElement getPaperclip() { return (IWebElement)driver.FindElement(Paperclip); }
        public IWebElement getUpdateNNext() { return (IWebElement)driver.FindElement(UpdateNNext); }
        public IWebElement getExitButton() { return (IWebElement)driver.FindElement(ExitButton); }
        public IWebElement getImgFluid() { return (IWebElement)driver.FindElement(ImgFluid); }
        public IWebElement getLoadMoreButton() { return (IWebElement)driver.FindElement(LoadMoreButton); }
        public IWebElement getLoadMoreBtn() { return (IWebElement)driver.FindElement(LoadMoreBtn); }
        public IWebElement getSearchSugg() { return (IWebElement)driver.FindElement(SearchSugg); }
        public IWebElement getDeleteAll() { return (IWebElement)driver.FindElement(DeleteAll); }
        public IWebElement getDeleteYesButton() { return (IWebElement)driver.FindElement(DeleteYesButton); }
        public IWebElement getRejectButton() { return (IWebElement)driver.FindElement(RejectButton); }
        public IWebElement getRetrieveButton() { return (IWebElement)driver.FindElement(RetrieveButton); }
        public IWebElement getQSearchBar() { return (IWebElement)driver.FindElement(QSearchBar); }
        public IWebElement getQSearchResult() { return (IWebElement)driver.FindElement(QSearchResult); }



        public void scroll(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(@"arguments[0].scrollIntoView();", element);
            Thread.Sleep(2000);
        }


    }
}
