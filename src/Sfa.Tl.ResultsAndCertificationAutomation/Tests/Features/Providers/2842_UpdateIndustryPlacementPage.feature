Feature: 2842_UpdateIndustryPlacementPage
	As a Provider
	I need to be able to update the Industry Placement status of a learner
	So that this information is kept up to date

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a registraion from LRS with EM and IP
And I am on Learner record page

@Ignore @RegressionTest @Provider
Scenario: 2842_Verify Update Industry Placement page
When I click on "Update" link in Learner record page
Then I should see Update Industry placement page
And "Yes, completed" radio option is pre selected
And clicking on back link navigate back to learner record page
And clicking on update button without changing radio option navigates to learner record page
And I have deleted LRS records from the database