Feature: 1784_ReregisterChangeAcademicYearPage
	As a Registrations Editor
	I need to be able to change the Academic year
	So that when I submit student data when registering a student on a new course I can be sure the details are correct

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration in Withdrawn state
And I click on Change status link in registraion details page
And I select register learner on different course and click on continue
And I select the provider and core from dropdown and click continue
And I select Add specialism option and click continue
And I select the Specialism in reregister specialism page and click continue
And I click Continue in Academic Year page

@RegressionTest @ReactivateRegistration
Scenario: 1784_Verify reregister change Academic year Page
When I click reregister academicyear change link
Then I should see Reregister Academic year page
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1784_Verify reregister Back link on Academic year Page
When I click reregister academicyear change link
And I click on Back link on page
Then I should see reregister check and submit page
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1784_Reregister Change Academic year
When I click reregister academicyear change link
And I click on change link in Academic Year page
Then I should see reregister check and submit page
And I cleared the data in DB