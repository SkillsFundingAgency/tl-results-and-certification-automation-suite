Feature: 1493_ReregisterCheckAndSubmitPage
	As a Registrations Editor
	I need to verify data before submit
	So record can be updated

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration in Withdrawn state
And I click on Change status link in registraion details page

@RegressionTest @ReactivateRegistration
Scenario: 1493_Verify reregister Check and submit Page
And I select register learner on different course and click on continue
And I select the provider and core from dropdown and click continue
And I select Add specialism option and click continue
And I select the Specialism in reregister specialism page and click continue
When I click on continue button in Academic year page
Then I should see reregister check and submit page

@RegressionTest @ReactivateRegistration
Scenario: 1493_Verify reregister Check and submit Back link
And I select register learner on different course and click on continue
And I select the provider and core from dropdown and click continue
And I select Add specialism option and click continue
And I select the Specialism in reregister specialism page and click continue
And I click Continue in Academic Year page
When I click on Back link on page
Then I should see Reregister Academic year page
