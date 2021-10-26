Feature: 3637 Post Result Services - Update check & submit with new grade
	As an AO with a results editor user role 
	I need to be able to check the new grade of the learner on the check & submit page 
	so that I know I have made the correct update

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
When I click on "Appeals" link


@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3637_Verify the Check and submit page displays the updated grade when a different grade to the old grade is selected
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When I select I need to change the grade radio button on the Add outcome of appeal page  
And I click the grade B radio button on the Update grade for appeal outcome page
Then the Check & submit appeal outcome page is displayed showing the old and newly selected grades
And the registration for this test is deleted

@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3637_Verify the Check and submit page displays the updated grade when the same grade as the old grade is selected
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When I select I need to change the grade radio button on the Add outcome of appeal page  
And I click the grade A radio button on the Update grade for appeal outcome page
Then the Check & submit appeal outcome page is displayed showing the old and new grade are the same
And the registration for this test is deleted
