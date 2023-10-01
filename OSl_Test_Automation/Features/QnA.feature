Feature: 01 Verify the functionality of the QnA.
 
    @Test
    Scenario: 01 Verify that students are able to submit new questions through the Q&A Services
        Given Student can successfully login student portal
        Then Q&A Menu should be displayed correctly no top navigation
        When Click on Q&A Menu from top navigation
        Then Check that the Q&A Services page should displayed
        When Click proceed on any subject from Q&A services Page
        Then Question and answer page should displayed
        Then Check that the Ask a new Question Button is available
        When Click on Ask a new question button
        Then Check that the ask a new question page is displayed
        Then Select a course from course dropdown list
        Then Select Subject from subject dropdown list
        Then Select chapter from chapter dropdown list
        Then Type a question in ask a question text box
        When Click on submit button
        Then Question and answer page should displayed



    @Test
    Scenario: 02 Verify that the teacher can provide answers to pending questions
        Given Teacher can successfully login Teacher portal
        Then Question&Answer Menu should be displayed correctly no top navigation
        When Click on Question&Answer Menu from top navigation
        Then Click On Pending Question sub menu from dropdown
        Then Check that asked question displayed in New Question section
        When Click on Answer Button side QA Arc Course
        Then Student's Question page should displayed
        Then Enter answer in the text box
        When Click on submit & Next Button
        Then Success! message should be displayed



    @Test
    Scenario: 03 Verify that students can receive notifications when a teacher responds
        Given Student can successfully login student portal
        Then Ensure accurate display of notification badge within the notification icon
        When Click on notification icon
        Then Check that the notification Page should displayed
        Then Check that the notification card should displayed
        When click on notification card
        Then Check that the Answer should displayed
        When click on Back to notification
        Then Check that the notification Page should displayed
        Then Click on delete All Button
        Then Check that the notification badge is gone


    @Test
    Scenario: 04 Verify students can request reviews for unsatisfactory Q&A answers.
        Given Student can successfully login student portal
        Then Q&A Menu should be displayed correctly no top navigation
        When Click on Q&A Menu from top navigation
        When Click proceed on any subject from Q&A services Page
        Then Question and answer page should displayed
        When Click on not yet icon
        Then Check that the Ask a question TextBox should displayed
        Then Type a reply in ask a question text box
        When Click the Submit button located below the text box
        Then Asked question should displayed



    @Test
    Scenario: 05 Verify that the teacher can Review unsatisfactory Q&A answers.
        Given Teacher can successfully login Teacher portal
        Then Question&Answer Menu should be displayed correctly no top navigation
        When Click on Question&Answer Menu from top navigation
        Then Click On Pending Question sub menu from dropdown
        Then Check that Review Request section should displayed
        When Click on Review Button side QA Arc Course
        Then Student's Question page should displayed
        Then Enter Review Answer in the text box
        When Click on Submit & Next Button of Review Request
        Then Success! message should be displayed



    @Test
    Scenario: 06 Verify that the Student can react satisfied
        Given Student can successfully login student portal
        When Click on notification icon
        Then Check that the notification Page should displayed
        Then Check that the notification card should displayed
        When click on notification card
        Then Check that the Answer should displayed
        When Click on satisfied icon
        Then Check that te Satisfied mark should displayed



    @Test
    Scenario: 07 Verify that the Admin can Moderate Question in Q&A Services
        Given Admin can successfully login Admin portal
        When Click on Student Menu
        Then Check that the Student Area page should displayed
        When Click on Q&A2 Service
        Then Click on Qn&A2 Moderation
        Then Check that the Moderation Page should displayed
        Then Enter reg number on Moderation page
        When Click on View button
        Then Check that the Summary Section should displayed
        When Click on Moderate button
        Then Check that student question page should displayed
        When Click on paperclip icon and input image location
        Then Check that the image should displayed
        When click on update & next and exit
        Then Check that the Moderation Page should displayed


    @Test
    Scenario: 08 Verify that the Admin can Reject Question in Q&A Services
        Given Admin can successfully login Admin portal
        When Click on Student Menu
        Then Check that the Student Area page should displayed
        When Click on Q&A2 Service
        Then Click on Qn&A2 Moderation
        Then Check that the Moderation Page should displayed
        Then Enter reg number on Moderation page
        When Click on View button
        Then Check that the Summary Section should displayed
        When Click on Moderate button
        Then Check that student question page should displayed
        When click on Reject & next and exit
        Then Check that the Moderation Page should displayed



    @Test
    Scenario: 09 Verify that the Admin can Retrieve Question in Q&A Services
        Given Admin can successfully login Admin portal
        When Click on Student Menu
        Then Check that the Student Area page should displayed
        When Click on Q&A2 Service
        Then Click on Qn&A2 Moderation
        Then Check that the Moderation Page should displayed
        Then Enter reg number on Moderation page
        When Click on View button
        Then Check that the Summary Section should displayed
        When Click on Moderate button
        Then Check that student question page should displayed
        When click on Retrieve & next and exit
        Then Check that the Moderation Page should displayed


    @Test
    Scenario: 10 Verify that the Q&A Services page is being Load and displayed accurately
        Given Student can successfully login student portal
        Then Q&A Menu should be displayed correctly no top navigation
        When Click on Q&A Menu from top navigation
        Then Verify that the Q&A Services page is being Load and displayed accurately



    @Test
    Scenario: 11 Verify that the Question and Answer page is being Load and displayed accurately
        Given Student can successfully login student portal
        Then Q&A Menu should be displayed correctly no top navigation
        When Click on Q&A Menu from top navigation
        When Click proceed on any subject from Q&A services Page
        Then Question and answer page should displayed
        Then Verify that the page is being Load and displayed accurately



    @Test
    Scenario: 12 Verify that the Question and Answer page Search question is working properly
        Given Student can successfully login student portal
        Then Q&A Menu should be displayed correctly no top navigation
        When Click on Q&A Menu from top navigation
        When Click proceed on any subject from Q&A services Page
        Then Question and answer page should displayed
        Then Input a search keyword into the search bar
        When Select a search suggestion by clicking on it
        Then Confirm the display of the searched question and its corresponding answer
