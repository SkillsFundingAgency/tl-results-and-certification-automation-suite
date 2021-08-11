Feature: RegistrationChangeBackLink
	As a Registrations Editor
	I need to be able to change details on a single upload
	So that I can ensure the accurate data has been uploaded

Background:
Given I have logged in as a "RegistrationEditor" user
And I click on Add a new registration link
And I have created registration

@RegressionTest @ManaulRegistration
Scenario: Back link on Change Uln page
And I am on Check and Submit page
And I click on Uln change link
When I click on Back link
Then I should navigate back to Check and Submit page
And I cleared the data in DB

@RegressionTest @ManaulRegistration
Scenario: Back link on Change Learner page
And I click on Learner change link
When I click on Back link
Then I should navigate back to Check and Submit page
And I cleared the data in DB

@RegressionTest @ManaulRegistration
Scenario: Back link on Change DOB page
And I click on DOB change link
When I click on Back link
Then I should navigate back to Check and Submit page
And I cleared the data in DB

@RegressionTest @ManaulRegistration
Scenario: Back link on Change Provider page
And I click on Provider change link
When I click on Back link
Then I should navigate back to Check and Submit page
And I cleared the data in DB

@RegressionTest @ManaulRegistration
Scenario: Back link on Change Core page
And I click on Core change link
When I click on Back link
Then I should navigate back to Check and Submit page
And I cleared the data in DB

@RegressionTest @ManaulRegistration
Scenario: Back link on Change Specialism page
And I click on Specialism change link
When I click back link on Has decide specialism page
Then I should navigate back to Check and Submit page
And I cleared the data in DB

@RegressionTest @ManaulRegistration
Scenario: Back link on Change Academic Year page
And I click on Academic Year change link
When I click on Back link
Then I should navigate back to Check and Submit page
And I cleared the data in DB