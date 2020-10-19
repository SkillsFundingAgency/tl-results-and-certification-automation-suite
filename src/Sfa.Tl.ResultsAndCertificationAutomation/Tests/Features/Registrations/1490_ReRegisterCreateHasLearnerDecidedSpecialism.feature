Feature: 1490_ReRegisterCreateHasLearnerDecidedSpecialism
	As a Registrations Editor
	I need to select new specialism for the student
	So that the record can be up to date

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration in Withdrawn state
And I click on Change status link in registraion details page

@RegressionTest @ReactivateRegistration
Scenario: 1490_Create Has Learner Decided Specialism validations
And I select register learner on different course and click on continue
And I select the provider and core from dropdown and click continue
When I click on continue without selecting any options
Then I should see error on as Learner Decided Specialism page

@RegressionTest @ReactivateRegistration
Scenario: 1490_Create Has Learner Decided Specialism Back link
And I select register learner on different course and click on continue
And I select the provider and core from dropdown and click continue
When I click on back link in Has learner decide page
Then I should be navigated back to select core page