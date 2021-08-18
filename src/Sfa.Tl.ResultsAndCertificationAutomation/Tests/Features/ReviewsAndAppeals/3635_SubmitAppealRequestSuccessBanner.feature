Feature: 3635 Post Results Services - Submit appeal request & success banner
	As an AO with a results editor user role, 
	I need confirmation of the change I have made via a success banner 
	so that I know the database has been updated

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
When I click on "Appeals" link


@RegressionTest @ReviewsAndAppeals
Scenario: 3635_Validate Core Component Grade Status page shows Success banner and validate Search again button functionality
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
And I press the update button next to the grade I would like to appeal
And I select the 'yes, it is being appealed' radio button
Then the Review and Appeals Learner Component Grade status page is displayed 
And a success banner is shown on the Component Grade status page
And the database will be updated to create a record which shows the grade as being in an appealed state
And when I press the Search again button on the Core Component Grade Status page
Then the Review and Appeals Search page is displayed
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3635_Validate Success banner is not shown on Core Component Grade Status page if the page is refreshed
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
And I press the update button next to the grade I would like to appeal
And I select the 'yes, it is being appealed' radio button
Then the Review and Appeals Learner Component Grade status page is displayed 
And a success banner is shown on the Component Grade status page
When I refresh the Component Grade status page
Then the success banner is not shown on the Component Grade status page
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3635_Verify breadcrumbs on Core Component Grade Status page after Success banner is shown
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
And I press the update button next to the grade I would like to appeal
And I select the 'yes, it is being appealed' radio button
Then the Review and Appeals Learner Component Grade status page is displayed 
And a success banner is shown on the Component Grade status page
And the database will be updated to create a record which shows the grade as being in an appealed state
When I press the Search for a learner breadcrumb on the Review and Appeals Learner Component Grade status page
Then the Review and Appeals Search page is displayed
When I press the Reviews and Appeals breadcrumb on the Review and Appeals Learner Component Grade status page
Then the Reviews and Appeals start page is displayed
When I press the Home breadcrumb on the Review and Appeals Learner Component Grade status page
Then I will be navigated to the T Levels Dashboard page
And the registration for this test is deleted