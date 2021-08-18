Feature: 3477 Post Results Services - Learner's component grades status
	As an AO with a results editor user role, 
	once I have searched a valid ULN I need to see the learner’s component grades status 
	so that I can review it before I choose to request the appeal

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
When I click on "Appeals" link


@RegressionTest @ReviewsAndAppeals
Scenario: 3477_Validate Core Component Grade Status page and Search again button
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
Then the Review and Appeals Learner Component Grade status page is displayed as per the acceptance criteria
And when I press the Search again button on the Core Component Grade Status page
Then the Review and Appeals Search page is displayed
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3477_Verify breadcrumbs on Core Component Grade Status page
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When I press the Search for a learner breadcrumb on the Review and Appeals Learner Component Grade status page
Then the Review and Appeals Search page is displayed
When I press the Reviews and Appeals breadcrumb on the Review and Appeals Learner Component Grade status page
Then the Reviews and Appeals start page is displayed
When I press the Home breadcrumb on the Review and Appeals Learner Component Grade status page
Then I will be navigated to the T Levels Dashboard page
And the registration for this test is deleted