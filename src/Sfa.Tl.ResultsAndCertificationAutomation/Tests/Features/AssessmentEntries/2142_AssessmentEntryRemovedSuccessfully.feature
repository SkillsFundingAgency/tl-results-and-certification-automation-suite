Feature: 2142_Create 'Assessment entry removed successfully' page
	As a Registrations Editor
	I need to be able to see that I have removed an assessment entry
	So that I can see that I have completed my task

	
Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration with an assessment entry

@RegressionTest @AssessmentEntries
Scenario: 2142_Remove an assessment entry for the learner and validate the success page
And I search the learner assessment
And I click on Remove entry link
And I select Yes radio button and press submit
Then I am shown assessment entry removed successfully page
And the core assessment entry displays as "Not specified" and link should be "Add entry" when i click on back to learner assessment entries button
And the registration for this test is deleted