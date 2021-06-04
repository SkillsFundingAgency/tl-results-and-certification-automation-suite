Feature: 2141_AssessmentEntryRemoveCoreAssessmentPage
	As a Registrations Editor
	I need to be able to remove an assessment entry
	So that assessment entry data can be kept up to date

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration with an assessment entry
And I am on Learner assessment entries page

@RegressionTest @AssessmentEntries @Ignore
Scenario: 2141 Verify remove core assessment page
When I click the Remove entry link
Then I am shown the Are you sure you want to remove the Core Assessment entry page
And click on back link should take me to learner assessment entries page
And the registration for this test is deleted

@RegressionTest @AssessmentEntries @Ignore
Scenario: 2141 Validate remove core assessment page
And I click on remove entry link
When I click on "Submit" button
Then I am shown an error message 'Select yes to remove the core entry'
And selecting no option takes me back to Assessment deails page
And the registration for this test is deleted