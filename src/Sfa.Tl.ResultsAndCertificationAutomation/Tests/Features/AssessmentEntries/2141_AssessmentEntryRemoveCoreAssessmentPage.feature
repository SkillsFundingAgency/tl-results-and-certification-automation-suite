Feature: 2141_AssessmentEntryRemoveCoreAssessmentPage
	As a Registrations Editor
	I need to be able to remove an assessment entry
	So that assessment entry data can be kept up to date

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration with an assessment entry

@RegressionTest @AssessmentEntries
Scenario: 2141_Do you want to add core assessment entry page validations
And I search for the learner assessment
When I click on Remove entry link
Then I am shown the 'Are you sure you want to remove the Core Assessment entry' page
And clicking on back link should take me back to Assessment deails page
And the registration for this test is deleted

@RegressionTest @AssessmentEntries
Scenario: 2141_Submit button validations
And I search for the learner assessment
And I click on Remove entry link
When I click on "Submit" button
Then I am shown an error message 'Select yes to remove the core entry'
And selecting no option takes me back to Assessment deails page
And the registration for this test is deleted