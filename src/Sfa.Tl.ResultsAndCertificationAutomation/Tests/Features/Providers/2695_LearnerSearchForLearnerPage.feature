Feature: 2695_EnterUlnPageValidations
	As a Provider
	I need to be able to add English/Maths and Industry Placement data for learners
	So that learner details can be kept up to date

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I click on "Manage learner records" link
And I click on "Update a learner record" link

@RegressionTest @Provider
Scenario: 2695 Verify invalid entry error message
Given I am shown the Search for a learner page
When I enter following data
| Field name  | Value    |
| searchuln   | Abc123!  |
And I click on "Search" button
Then I should see the following error message "Enter a valid 10-digit ULN" on the Search for a learner page
And I clear the Search field 
When I enter following data
| Field name  | Value    |
| searchuln   | 123456789|
And I click on "Search" button
Then I should see the following error message "Enter a valid 10-digit ULN" on the Search for a learner page



@RegressionTest @Provider
Scenario: 2695 Verify No ULN entered error messages
Given I am shown the Search for a learner page
And I click on "Search" button
Then I should see the following error message "Enter a ULN with 10 digits" on the Search for a learner page


@RegressionTest @Provider
Scenario: 2695 Verify Breadcrumbs
Given I am shown the Search for a learner page
And I press the Manage learner records breadcrumb on the Search for a learner page
Then I should see Manage learner records page
When I click on "Update a learner record" link
And I press the Home breadcrumb link on the Search for a learner page
Then I am taken to the home page
