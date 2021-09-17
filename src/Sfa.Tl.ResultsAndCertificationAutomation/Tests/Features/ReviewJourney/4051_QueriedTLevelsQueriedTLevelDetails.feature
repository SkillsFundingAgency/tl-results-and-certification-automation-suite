Feature: TLRC_4051 Journey Improvements - Queried T Levels - Queried T Level details
	As an AO with a T Level reviewer user role 
	I need to be able to view my previously queried T Level details 
	so that I can track the progress of my query and see when it was queried & who by

Background: Log in as Reviewer
Given I have logged in as a "Reviewer" user
And I set some T Levels for NCFE to unconfirmed, queried and reviewed

@RegressionTest @ReviewJourney
Scenario: 4051_Verify the Queried T Levels details page, Back link and Back to queried T Levels button
Given I click on the TLevels link on the homepage
And I click the Queried T Levels link on the T Level dashboard
Then I am navigated to the Queried T Levels page
When I click on the View link for the "T Level in Digital Support and Services" Tlevel on the Queried T Levels page
Then the details for the queried T Level "T Level in Digital Support and Services" are displayed
When I click the back link on the Queried T Level details page
Then I am navigated to the Queried T Levels page
When I click on the View link for the "T Level in Digital Support and Services" Tlevel on the Queried T Levels page
And I click the Back to queried T Levels button
Then I am navigated to the Queried T Levels page
And I set all of the T Levels for NCFE to unconfirmed
