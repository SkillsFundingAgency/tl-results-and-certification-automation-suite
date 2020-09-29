Feature: 1542_CannotChangeProviderAndCorePage
	As a Registrations Editor
	I need to be informed that I must withdraw a learner before changing their core
	So that registrations data can be kept up to date

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have created a manul registration
And I am on registration deails page

@RegressionTest @ChangeRegistration
Scenario: 1542_Change provider and core page
When I click on Provider change link
And I changed Provider with different Core and click Change button
And I select Yes, I also want to change the core option and click continue button
Then I should see can not change provider and core page

@RegressionTest @ChangeRegistration
Scenario: 1542_Change provider and core page Back link
When I click on Provider change link
And I changed Provider with different Core and click Change button
And I select Yes, I also want to change the core option and click continue button
And I click on Back link on page
Then I should be navigated back to Do you also want to change Core page