Feature: Create Re-Register Success Page - Story 1494
	As a Registrations Editor
	I need to see confirmation that I have re-registered a student
	So that I can be assured the student data has updated
    
Background: 
Given I have logged in as a "RegistrationEditor" user
And I click on Add a new registration link
And I create a manual registration

@RegressionTest @ReactivateRegistration
Scenario: 1494-Reactivating a registration on a new course displays the Registration created successfully page
When I withdraw my application and navigate to the Withdrawn Registration Details page
When I click the Change Status link on the Withdrawn options page
And I select Register learner on a different course and click continue
And I select a different provider, core and specialism and submit the changes
Then I am shown the ReRegistration Success page
When I click the View Withdrawn Registration button om the Reactivate registration success page
Then I am shown the registration details page with the new registration details







