Feature: 1491_ReregisterCreateSpecialismPage
	As a Registrations Editor
	I need to select the new specialism 
	So that the record can be updated

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration in Withdrawn state
And I click on Change status link in registraion details page

@RegressionTest @ReactivateRegistration
Scenario: 1491_Verify Reregister Create Specialism Page
And I select register learner on different course and click on continue
And I select the provider and core from dropdown and click continue
And I select Add specialism option and click continue
Then I should see Learner new course Specialism page
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1491_Verify Reregister Create Specialism Back link
And I select register learner on different course and click on continue
And I select the provider and core from dropdown and click continue
And I select Add specialism option and click continue
When I click on Back link on page
Then I should be navigated back to Reregister Has learner decide page
And the add specialism now radio box should be checked
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1491_Verify Reregister Create Specialism page validations
And I select register learner on different course and click on continue
And I select the provider and core from dropdown and click continue
And I select Add specialism option and click continue
When I click on continue without selecting any options
Then I should see validation errors on Reregister specialism page
And I cleared the data in DB