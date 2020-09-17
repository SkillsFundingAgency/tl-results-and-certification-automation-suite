Feature: 982_ChangeRegistrationAcademicYear
	As a Registrations Editor
	I need to see if I can change the Academic Year of a Learner
	So that I can ensure the record is up to date

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have created a manul registration
And I am on registration deails page

@RegressionTest @ChangeRegistration
Scenario: 982-Change Academic Year Page
When I click on Academic Year change link
Then I should see change Academic year page
And I should navigated back to Registration details page when i click on Back to regisration details button

@RegressionTest @ChangeRegistration
Scenario: 982-Change Academic Year Back link
When I click on Academic Year change link
And I click on Back link on page
Then I should be navigated back to registration details page