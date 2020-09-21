Feature: 1540_ChangeProviderAndCorePage
	As a Registrations Editor
	I need to be informed that the provider I have chosen does not offer the core that a student is registered on
	So that I can understand what I need to do next

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have created a manul registration
And I am on registration deails page

@RegressionTest @ChangeRegistration
Scenario: 1540_Do you want to change core page
When I click on Provider change link
And I changed Provider with different Core and click Change button
Then I should see Do you want to change Core page

@RegressionTest @ChangeRegistration
Scenario: 1540_Do you want to change core Back link
When I click on Provider change link
And I changed Provider with different Core and click Change button
And I click on Back link on page
Then I should be navigated back to select Provider page

@RegressionTest @ChangeRegistration
Scenario: 1540_Do you want to change page validations
When I click on Provider change link
And I changed Provider with different Core and click Change button
And I click Continue button without selecting options
Then I should see validation errors