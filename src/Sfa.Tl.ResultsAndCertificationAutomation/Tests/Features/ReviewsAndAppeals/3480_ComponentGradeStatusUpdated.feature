Feature: 3480 Post Results Services - Component grade status updated
	As an AO, 
	I need to know that the learner’s core component has been successfully changed to ‘being appealed’ 
	so that I can be sure everything is correct before I leave the page

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
When I click on "Appeals" link


@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3480_Validate Core Component Grade Status shows grade status 'Being appealed' and validate Search button
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
And I press the update button next to the grade I would like to appeal
And I select the 'yes, it is being appealed' radio button
Then the Review and Appeals Learner Component Grade status page is displayed 
And 'Being appealed' will now appear as the status on the ‘Grade’ row within the core details table 
And when I press the Search again button on the Core Component Grade Status page
Then the Review and Appeals Search page is displayed
And the registration for this test is deleted

@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3480_Verify breadcrumbs on Core Component Grade Status page after Being Appealed status is shown
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
And I press the update button next to the grade I would like to appeal
And I select the 'yes, it is being appealed' radio button
Then the Review and Appeals Learner Component Grade status page is displayed 
And 'Being appealed' will now appear as the status on the ‘Grade’ row within the core details table 
When I press the Search for a learner breadcrumb on the Review and Appeals Learner Component Grade status page
Then the Review and Appeals Search page is displayed
When I press the Reviews and Appeals breadcrumb on the Review and Appeals Learner Component Grade status page
Then the Reviews and Appeals start page is displayed
When I press the Home breadcrumb on the Review and Appeals Learner Component Grade status page
Then I will be navigated to the T Levels Dashboard page
And the registration for this test is deleted