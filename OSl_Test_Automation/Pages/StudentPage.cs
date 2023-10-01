using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace OSl_Test_Automation.Pages
{
    public class StudentPage
    {
        private IWebDriver driver;




        String StudentPortalUrl = "https://ums-portal.osl.team";
        By StudentLoginPage = By.XPath("//h2[normalize-space()='Student Login']");
        By RegistrationNumber = By.XPath("//input[@id='RegistrationNumber']");
        By NextButton = By.XPath("//button[@id='btnSubmit']");
        By PasswordPage = By.XPath("//h3[normalize-space()='Enter Your Password']");
        By Password = By.XPath("(//input[@id='Password'])[1]");
        By StudentLoginButton = By.XPath("//button[normalize-space()='Login']");
        By MyRoutineToday = By.XPath("//h2[normalize-space()='MY ROUTINE TODAY']");

        By MasterClassManu = By.XPath("//a[normalize-space()='Master Class']");
        By MasterClassPage = By.XPath("//h1[normalize-space()='master class']");
        By MasterClassCourse = By.XPath("//h5[normalize-space()='Engineering Master Class']");
        By ProceedButton = By.XPath("(//a[@type='submit'][normalize-space()='Proceed'])[1]");
        By Chapter = By.XPath("(//h5[@class='card-title pt-1'][contains(text(),'অধ্যায়-২ : গুণগত রসায়ন')])[1]");
        By LoadMore = By.XPath("//button[@type='submit']");
        By Video = By.XPath("(//a[contains(text(),'Video')])[1]");
        By Notes = By.XPath("(//a[contains(text(),'Notes')])[1]");
        By Quiz = By.XPath("(//a[contains(text(),'Quiz')])[1]");
        By SearchBar = By.XPath("//input[@id='SearchText']");
        By SearchResult = By.XPath("//td[contains(text(),'বাফার দ্রবণ')]");
        By StartQuiz = By.XPath("//a[@id='startQuiz']");
        By SubmitQuiz = By.XPath("//a[normalize-space()='Submit']");
        By AlartBox = By.XPath("//div[@class='modal-content text-center mx-auto']");
        By YesButton = By.XPath("//a[normalize-space()='Yes']");
        By AnalysisReport = By.XPath("//h4[normalize-space()='Analysis Report']");
        By QSearchBar = By.XPath("//input[@placeholder='Search your question here']"); 
        By QSearchResult = By.XPath("//div[@class='card-body searchedThreadBox']");





        public StudentPage(IWebDriver driver) { this.driver = driver; }



        public void getStudentPortal() { driver.Navigate().GoToUrl(StudentPortalUrl); }
        public IWebElement getStudentLoginPage() { return (IWebElement)driver.FindElement(StudentLoginPage); }
        public IWebElement setRegistrtionNumber() { return (IWebElement)driver.FindElement(RegistrationNumber); }
        public IWebElement getNextButton() { return (IWebElement)driver.FindElement(NextButton); }
        public IWebElement getPasswordPage() { return (IWebElement)driver.FindElement(PasswordPage); }
        public IWebElement setPassword() { return (IWebElement)driver.FindElement(Password); }
        public IWebElement getStudentLoginButton() { return (IWebElement)driver.FindElement(StudentLoginButton); }
        public IWebElement getMyRoutineToday() { return (IWebElement)driver.FindElement(MyRoutineToday); }

        public IWebElement getMasterClassManu() { return (IWebElement)driver.FindElement(MasterClassManu); }
        public IWebElement getMasterClassPage() { return (IWebElement)driver.FindElement(MasterClassPage); }
        public IWebElement getMasterClassCourse() { return (IWebElement)driver.FindElement(MasterClassCourse); }
        public IWebElement getProceedButton() { return (IWebElement)driver.FindElement(ProceedButton); }
        public IWebElement getChapter() { return (IWebElement)driver.FindElement(Chapter); }
        public IWebElement getVideo() { return (IWebElement)driver.FindElement(Video); }
        public IWebElement getNotes() { return (IWebElement)driver.FindElement(Notes); }
        public IWebElement getQuiz() { return (IWebElement)driver.FindElement(Quiz); }
        public IWebElement getStartQuiz() { return (IWebElement)driver.FindElement(StartQuiz); }
        public void SelectAllOption()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                String xpath = "//label[@for='OptionB_" + i + "']";
                IWebElement option = (IWebElement)driver.FindElement(By.XPath(xpath));
                option.Click();
            }
        }

        public IWebElement getSubmitQuiz() { return (IWebElement)driver.FindElement(SubmitQuiz); }
        public IWebElement getAlartBox() { return (IWebElement)driver.FindElement(AlartBox); }
        public IWebElement getYesButton() { return (IWebElement)driver.FindElement(YesButton); }
        public IWebElement getAnalysisReport() { return (IWebElement)driver.FindElement(AnalysisReport); }
        public IWebElement getLoadMore() { return (IWebElement)driver.FindElement(LoadMore); }
        public IWebElement getSearchBar() { return (IWebElement)driver.FindElement(SearchBar); }
        public IWebElement getSearchResult() { return (IWebElement)driver.FindElement(SearchResult); }

    }
}
