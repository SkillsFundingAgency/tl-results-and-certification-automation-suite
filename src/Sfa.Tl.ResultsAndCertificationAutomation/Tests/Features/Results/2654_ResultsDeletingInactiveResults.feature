Feature: 2654_Deleting inactive results


Background: 
Given I have logged in as a "SiteAdmin" user
And I have a registration with result


@RegressionTest @Results
Scenario: 2654_PARALLEL TEST Attempt to delete a registration without an active result - Refresh the page 
Given I am on result details page
And I click on "Change" link in result page
And I successfully remove the grade
And I attempt to delete an active registration without an active result however someone else has just added a result
When I refresh the browser
Then I am shown the Page Not Found page
And the registration for this test is deleted


@RegressionTest @Results
Scenario: 2654_PARALLEL TEST Attempt to delete a registration without an active result by selecting Submit button
Given I am on result details page
And I click on "Change" link in result page
And I successfully remove the grade
And I attempt to delete an active registration without an active result however someone else has just added a result
When I select continue on the Are you sure page
Then I will be shown the Problem with service page
And the registration for this test is deleted



@RegressionTest @Results
Scenario: 2654_Attempt to delete a registration without an active result
Given I am on result details page
And I click on "Change" link in result page
And I successfully remove the grade
And I attempt to delete an active registration without an active result
Then the registration is deleted along with all previous inactive results	
And the registration for this test is deleted



