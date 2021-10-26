Feature: 3636 Post Results Services - Change link from check & submit page
	As an AO with a results editor user role 
	I need to be able to change the new grade of the learner on the check & submit page 
	so that I can edit my choice before I submit the request

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
When I click on "Appeals" link


@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3636_Click Change link on Check and Submit (New grade was selected)
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When I select I need to change the grade radio button on the Add outcome of appeal page  
And I click the grade B radio button on the Update grade for appeal outcome page
Then the Check & submit appeal outcome page is displayed showing the old and newly selected grades
When I click on the Change link next to the new grade
Then I am shown the update appealed grade page
##And the B grade radio button will be preselected
When I click the Back link on the Update grade for appeal outcome page
Then the Check & submit appeal outcome page is displayed showing the old and newly selected grades
And the registration for this test is deleted


@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3636_Click Change link on Check and Submit (Grade was not updated)
Given I navigate to the Review and Appeals Learner Component Grade status page using the URL
When  I select 'The grade is the same' radio button on the Add outcome of appeal page  
Then the Check & submit appeal outcome page is displayed
And the New grade is the same as the old grade 
When I click on the Change link next to the new grade
Then I am shown the update appealed grade page
##And the A grade radio button will be preselected
When I click the Back link on the Update grade for appeal outcome page
Then the Check & submit appeal outcome page is displayed showing the old and new grade are the same
And the registration for this test is deleted

