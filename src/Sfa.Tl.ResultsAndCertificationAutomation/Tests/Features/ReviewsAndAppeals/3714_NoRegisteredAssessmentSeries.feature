Feature: 3714_NoRegisteredAssessmentSeries
	As an AO with a result editor user role
	I need to know if there is no assessment entry registered for the ULN I have searched
	So that I can determine my next steps

Background: 
Given I have logged in as a "ResultsEditor" user
And I have a registration without assessment and result
And I click on "Reviews and appeals" link

@RegressionTest @ReviewsAndAppeals
Scenario: 3714 Verify no registered assessment series page
And I navigate to the Review and Appeals Learner Component Grade status page using the URL
Then I should see learner does not have assessment page
And Back link should takes back to seach learnerpage
And clicking Search again button takes to serch learner page
And the registration for this test is deleted

@RegressionTest @ReviewsAndAppeals
Scenario: 3714 Verify back to home
And I navigate to the Review and Appeals Learner Component Grade status page using the URL
Then I should see learner does not have assessment page
And clicking on back to home takes to dashboard page
And the registration for this test is deleted