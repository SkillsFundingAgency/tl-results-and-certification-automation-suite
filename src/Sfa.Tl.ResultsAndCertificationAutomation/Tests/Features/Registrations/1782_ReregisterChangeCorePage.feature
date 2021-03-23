Feature: 1782_ReregisterChangeCorePage
	As a Registrations Editor
	I need to be able to change the core
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
Scenario: 1782_Verify reregister change Core Page
When I click on reregister Core change link
Then I should see reregister change core page
And previously selected core value is prepopulated
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1782_Reregister change Core Back to Check and Submit Page
When I click on reregister Core change link
And I click on Back link on page
Then I should see reregister check and submit page
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1782_Reregister change Core Back to Provider Page
And I click on reregister Provider change link
And I click on continue in reregister change provider page
When I click on Back link on page
Then I should see reregister change provider page
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1782_Reregister change Core From Provider Page
And I click on reregister Provider change link
When I click on continue in without changing reregister change provider
Then I should see reregister change core page
And previously selected core value is prepopulated
And I cleared the data in DB

@RegressionTest @ReactivateRegistration
Scenario: 1782_Reregister change Core By changing Provider
And I click on reregister Provider change link
When I select different provider and click continue
Then Core dropdown value shoule be reset
And I cleared the data in DB


