Feature: 2695_Search for a learner page
    As a Provider
    I need to be able to search for a learner
    So that I can view or update their English/Maths & IP data

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration without LRS data
And I navigate to the Manage Learner Record Search for a learner page

@RegressionTest @Provider
Scenario:  2695 Verify Breadcrumbs
Given I click the Home breadcrumb on the  Manage Learner Record Search for a learner page
Then I am taken to the home page
Given I navigate to the Manage Learner Record Search for a learner page
And I press the Manage learner records breadcrumb on the  Manage Learner Record Search for a learner page
Then I am shown the Manage learner records page
And I have deleted LRS records from the database


@RegressionTest @Provider
Scenario: 2695 Verify invalid entry error message
When I enter "123456789" in the Search ULN box and click Search
Then the error message "Enter a valid 10-digit ULN" is shown on the Manage learner Search for a learner page
When I enter "ABCDEFGHIJ" in the Search ULN box and click Search
Then the error message "Enter a valid 10-digit ULN" is shown on the Manage learner Search for a learner page
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario: 2695 Verify No ULN entered error messages
When I click on "Search" button
Then the error message "Enter a ULN with 10 digits" is shown on the Manage learner records Search for a learner page
And I have deleted LRS records from the database
