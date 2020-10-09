Feature: 1781_ReregisterChangeProviderPage
	As a Registrations Editor
	I need to be able to change the provider
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
Scenario: 1781_Verify reregister change provider Page
When I click on reregister Provider change link
Then I should see reregister change provider page
And provider dropdown should be prepopulated with previous value

@RegressionTest @ReactivateRegistration
Scenario: 1781_Verify reregister change provider Back link
When I click on reregister Provider change link
And I click on Back link on page
Then I should see reregister check and submit page