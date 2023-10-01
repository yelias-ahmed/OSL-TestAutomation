Feature: Verify the functionality of the Admin Portal.
 
    @Test
    Scenario: Verify that admin can successfully log in admin portal using valid credentials
        Given Verify that the Admin Login page is being displayed accurately
        Then Enter Admin Email address into the email field
        Then Enter Admin Password into the Password field
        When Click on log in button on Admin Login Page
        Then Check that the Welcome page is displayed accurately