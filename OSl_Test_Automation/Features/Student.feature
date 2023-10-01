Feature: Verify the functionality of the Student Portal.
 
    @Test
    Scenario: Verify that students can successfully log in using valid login credentials
        Given Verify that the Student Login page is being displayed accurately
        Then Enter Student Registration Number into the Registration Number field
        When Click Next Button on Student Login Page
        Then Check that the Enter Your Password page should displayed
        Then Enter Password into the Password field
        When Click on log in button on Student Login Page
        Then Check that the My routine page is displayed accurately


    @Test
    Scenario: Verify that the Master Class page is being Load and displayed accurately
        Given Student can successfully login student portal
        Then Master Class Menu should be displayed correctly no top navigation
        When Click on Master Class Menu from top navigation
        Then Verify that the Master Class page is Displayed By Course
        When Click on Proceed in any Master Class
        Then Check that the Master Class page is displayed By Lecture
        Then Check that the Master Class page is being Load and displayed accurately



    @Test
    Scenario: Verify that the Master Class page Search is working
        Given Student can successfully login student portal
        Then Master Class Menu should be displayed correctly no top navigation
        When Click on Master Class Menu from top navigation
        Then Verify that the Master Class page is Displayed By Course
        When Click on Proceed in any Master Class
        Then Check that the Master Class page is displayed By Lecture
        Then Check that the Search bar is displayed accurately
        When Type a search keyword into the search bar
        Then Check that the search result is showing



    @Test
    Scenario: Verify that the Student can take quiz from master class
        Given Student can successfully login student portal
        Then Master Class Menu should be displayed correctly no top navigation
        When Click on Master Class Menu from top navigation
        Then Verify that the Master Class page is Displayed By Course
        When Click on Proceed in any Master Class
        Then Check that the Master Class page is displayed By Lecture
        When Click on any subject quiz
        Then click on Start Quiz or retake quiz
        Then Select options from questions
        When Click on submit
        Then Check that a pop up is showing
        When Click on yes button
        Then check that the Analysis Report is showing