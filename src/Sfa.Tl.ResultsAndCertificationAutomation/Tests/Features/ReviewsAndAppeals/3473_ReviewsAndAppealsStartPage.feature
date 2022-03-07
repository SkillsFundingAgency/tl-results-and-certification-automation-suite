Feature: 3473_ReviewsAndAppealsStartPage
	As an AO results editor
	I need to see a start page for reviews and appeals
	So that I can read further information before I decide to begin the journey or return to home

@Ignore @RegressionTest @ReviewsAndAppeals
Scenario: 3473 Verify Review and Appeals start page
Given I have logged in as a "ResultsEditor" user
When I click on "Appeals" link
Then I should see Reviews and appeals start page
And clicking on home breadcrumb takes me to home page