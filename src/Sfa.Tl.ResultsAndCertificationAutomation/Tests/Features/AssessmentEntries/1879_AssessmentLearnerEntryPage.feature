Feature: 1879_AssessmentLearnerEntryPage
	As a Registrations Editor
	I need to be able to view Assessment Entry details for students
	So that I can ensure they are up to date

Background: 
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @AssessmentEntries
Scenario: 1879_Verify assessment page when no assessment
And I have a registration without assessment and result
When I search for the learner assessment
Then I should see Learner details in the page
And Core assessment entry should be "Not specified"
And "Add entry" link should be displayed
And the registration for this test is deleted

@RegressionTest @AssessmentEntries
Scenario: 1879_Verify assessment page when assessment
And I have a registration with an assessment entry
When I search for the learner assessment
Then I should see Learner details in the page
And Core assessment entry should be "Summer 2021"
And "Remove entry" link should be displayed
And the registration for this test is deleted
