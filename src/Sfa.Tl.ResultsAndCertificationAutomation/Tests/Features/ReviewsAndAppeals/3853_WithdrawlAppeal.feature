Feature: 3853_WithdrawlAppeal
	As an AO with a results editor user role
	I need to be able to withdraw an active appeal
	so that I can ensure all records are accurate & up to date. 

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration in Appealed state
And I click on "Appeals" link
And I navigate to the Review and Appeals Learner Component Grade status page using the URL
And I press the update button next to the grade I would like to appeal

@RegressionTest @ReviewsAndAppeals
Scenario: 3853_Verify withdraw appeal
When I select withdrawn appeal radio button and click continue
Then I should see appeal withdrawn success message
And Being appealed tag should not seen on component grade status page
And the registration for this test is deleted