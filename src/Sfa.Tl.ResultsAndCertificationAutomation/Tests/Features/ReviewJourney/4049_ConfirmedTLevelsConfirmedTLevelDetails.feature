Feature: TLRC_4049 Journey Improvements - Confirmed T Levels - Confirmed T Level details
	As an AO with a T Level reviewer user role 
	I need to be able to view my previously confirmed T Level details 
	so that I can ensure they’re still up to date & raise a request to query them if they are not.

Background: Log in as Reviewer
Given I have logged in as a "Reviewer" user
And I set some T Levels for NCFE to unconfirmed, queried and reviewed

@RegressionTest @ReviewJourney
Scenario: 4049_Verify the Confirmed T Levels page, Contact Us link presence and breadcrumbs
Given I click on the TLevels link on the homepage
And I click the Confirmed T Levels link on the T Level dashboard
Then I am navigated to the Confirmed T Levels page
When I click on the View link for the "T Level in Agriculture, Environmental and Animal Care" Tlevel
Then the details for the "T Level in Agriculture, Environmental and Animal Care" T level are displayed
And I set all of the T Levels for NCFE to unconfirmed

