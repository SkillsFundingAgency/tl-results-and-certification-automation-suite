Feature: Create Withdrawn Options page for Withdrawn Record - Story 1476 and 1596
	As a Registrations Editor
	I need to options to allow me to rejoin the course or re-register the learner
	So that I can make an informed choice.

	Add Status to Registration Details Page (WITHDRAW)
	As a Registrations Editor
    I need to see the status of a record when I search for it
    So that I can see what I can do with the record


Background: 
Given I have logged in as a "RegistrationEditor" user
And I click on Add a new registration link
And I create a manual registration

@RegressionTest @WithdrawRegistration
Scenario: 1476-1596-Click Change Status on Withdrawn Registration Details page
When I withdraw my application and navigate to the Withdrawn Registration Details page
And I click the Change Status link on the Withdrawn options page
Then I am navigated to the Withdrawn options page
When I click on the back link on the Withdrawn Registration Options Page
Then I am navigated to the Registration Details page which shows my registration is withdrawn
And there are no change links next to any of the data items
And I cleared the data in DB

@RegressionTest @WithdrawRegistration
Scenario: 1476-Error message is displayed if radio buttons are not selected
When I withdraw my application and navigate to the Withdrawn Registration Details page
And I click the Change Status link on the Withdrawn options page
Then I am navigated to the Withdrawn options page
When I click continue without selecting any radio buttons 
Then I am shown an error message on the Registrations Withdrawn Options page stating "Select if you would like to reactivate this registration with the same course or register a different course"
And I cleared the data in DB