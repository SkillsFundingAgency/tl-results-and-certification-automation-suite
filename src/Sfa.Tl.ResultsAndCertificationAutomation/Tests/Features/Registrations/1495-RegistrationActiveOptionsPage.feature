Feature: Create Active options page for Active Record - Story 1475
    As a Registrations Editor
    I need options to allow me to withdraw the learner from the course or delete the registration
    So that I can make a informed choice.
    
Background: 
Given I have logged in as a "RegistrationEditor" user
And I click on Add a new registration link
And I create a manual registration


@RegressionTest @WithdrawRegistration
Scenario: 1495/1557_Pressing the ChangeStatus Link on the Registration Details page takes the user to the Amend Active Registration page
And I search for my registration
Then I should see results in the page
And I will see the ChangeStatus link
When I click the ChangeStatus link
Then I am shown the Active options page for Active Record
And I cleared the data in DB
##Active options page validation (heading, URL, page title, button text, radio buttons not populated)


@RegressionTest @WithdrawRegistration
Scenario: 1495_Press the back link on Active options page 
And I search for my registration
Then I should see results in the page
When I click the ChangeStatus link
Then I am shown the Active options page for Active Record
When I click the Back link on the Active options page for Active Record page
Then I will be directed to the Registration Details page
And I cleared the data in DB
##validate back link


@RegressionTest @WithdrawRegistration
Scenario: 1495-Error message is displayed if radio buttons are not selected
And I search for my registration
Then I should see results in the page
And I will see the ChangeStatus link
When I click the ChangeStatus link
Then I am shown the Active options page for Active Record
And I click Continue without selecting a radio button
Then I am shown an error message on the Active options page stating "Select if you want to withdraw or delete this registration"
And I cleared the data in DB
##checks all error messages on the page and checks page title includes "Error"


@RegressionTest @WithdrawRegistration
Scenario: 1495-Accessing the Registration Active Options page via bookmarks for withdrawn registrations will direct to an error page
And I search for my registration
Then I should see results in the page
And I will see the ChangeStatus link
When I click the ChangeStatus link
Then I am shown the Active options page for Active Record
When I capture the Active options page URL
And I navigate to the captured URL
Then I am shown the Active options page for Active Record
When I withdraw the registration from the the Active options page for Active Record
And I attempt to access the Active options page for Active Record using the captured URL
Then I am shown the Page Not Found page
When I attempt to access the Active options page for Active Record using an invalid URL
Then I am shown the Page Not Found page 
And I cleared the data in DB
##verifies the Active options page is acessible by URL when the reg is active otherwise Page not found page is shown
##check that only a valid URL for Active options will work otherwise Page not found page is shown

