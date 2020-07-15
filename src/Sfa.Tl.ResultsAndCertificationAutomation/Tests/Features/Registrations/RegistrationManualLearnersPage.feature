Feature: RegistrationManualLearnersPage
	As a Registrations Editor
	I need to be able to add single registration data for a student
	So that I can have the option to upload in bulk or not

Background:
Given I have logged in as a "RegistrationEditor" user

@SmokeTest
Scenario: Verify Registration Learners Page
When I click on Add a new registration link
And I entered valid Uln and Click on Continue button
Then I should see Learners page

@SmokeTest
Scenario: Verify Registration Learners Error Page
When I click on Add a new registration link
And click on continue button on Learner page
Then should see error in Learners page