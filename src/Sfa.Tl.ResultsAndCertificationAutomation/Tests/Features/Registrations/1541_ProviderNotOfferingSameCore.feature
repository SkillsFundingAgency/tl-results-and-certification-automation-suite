Feature: 1541_ProviderNotOfferingSameCore
	As a Registrations Editor
	I need to understand that a Provider has not been set up to deliver a core
	So that I can contact my providers editor

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have created a manul registration
And I am on registration deails page

@RegressionTest @ChangeRegistration
Scenario: 1541 Provider not offering same core page
When I click on Provider change link
And I changed Provider with different Core and click Change button
And I select No, I want to keep same core option and click continue button
Then I should see Provider not offering same core page

@RegressionTest @ChangeRegistration
Scenario: 1541_Provider not offering same core Back link
When I click on Provider change link
And I changed Provider with different Core and click Change button
And I select No, I want to keep same core option and click continue button
And I click on Back link on page
Then I should be navigated back to Do you also want to change Core page

@RegressionTest @ChangeRegistration
Scenario: 1541_Provider not offering same core Back To registration details
When I click on Provider change link
And I changed Provider with different Core and click Change button
And I select No, I want to keep same core option and click continue button
And I click on BackToRegistration button
Then I should be navigated back to registration details page