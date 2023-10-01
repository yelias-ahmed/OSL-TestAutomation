Feature: Verify the functionality of the Teacher Portal.
 
    @Test
    Scenario: Verify that Teacher can successfully log in Teacher portal using valid credentials
        Given Verify that the Teacher Login page is being displayed accurately
        Then Enter TPIN into the Emter your TPIN field
        Then Enter Teacher Password into the Password field
        When Click on log in button on Teacher Login Page
        Then Check that MY ROUTINE page is displayed accurately