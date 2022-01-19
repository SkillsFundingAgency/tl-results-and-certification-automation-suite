Feature: 5293_RestrictChangingSpecialism
	As a registration editor
	I need a page to tell why can't i change the specialism when there is a active result or assessment
	So i understand that why i am not allowed

Background: 
Given I have logged in as a "RegistrationEditor" user
And I have a registration with specialism assessment
And I am on registration details page

@RegressionTest @Registrations
Scenario: 5293 Cannot change specialism page
When I click on reregister change specialism link
Then I should see change specialism restrict page
And clicking on remove assessment entry button should take to assessment details page
And the registration for this test is deleted
