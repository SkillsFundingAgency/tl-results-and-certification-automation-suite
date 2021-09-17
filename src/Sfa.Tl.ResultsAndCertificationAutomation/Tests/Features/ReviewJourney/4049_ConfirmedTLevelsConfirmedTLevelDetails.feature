Feature: TLRC_4049 Journey Improvements - Confirmed T Levels - Confirmed T Level details
	As an AO with a T Level reviewer user role 
	I need to be able to view my previously confirmed T Level details 
	so that I can ensure they’re still up to date & raise a request to query them if they are not.

Background: Log in as Reviewer
Given I have logged in as a "Reviewer" user
And I set some T Levels for NCFE to unconfirmed, queried and reviewed

@RegressionTest @ReviewJourney
Scenario: 4049_Verify the Confirmed T Levels details page, Back link and Back button
Given I click on the TLevels link on the homepage
And I click the Confirmed T Levels link on the T Level dashboard
Then I am navigated to the Confirmed T Levels page
When I click on the View link for the "T Level in Agriculture, Environmental and Animal Care" Tlevel
Then the details for the confirmed T Level "T Level in Agriculture, Environmental and Animal Care" are displayed
When I click the back link on the confirmed T Level details page
Then I am navigated to the Confirmed T Levels page
When I When I click on the View link for the "T Level in Agriculture, Environmental and Animal Care" Tlevel
And I click the Back to confirmed T Levels button
Then I am navigated to the Confirmed T Levels page
And I set all of the T Levels for NCFE to unconfirmed

@RegressionTest @ReviewJourney
Scenario: 4049_Verify raise a query link on the Confirmed T Levels details page
Given I click on the TLevels link on the homepage
And I click the Confirmed T Levels link on the T Level dashboard
Then I am navigated to the Confirmed T Levels page
When I click on the View link for the "T Level in Agriculture, Environmental and Animal Care" Tlevel
Then the details for the confirmed T Level "T Level in Agriculture, Environmental and Animal Care" are displayed
When I click the Raise a query link on the Confirmed T Level details page
Then I am shown the Query T Level Details page
And the Query T Level Details page will display details for the T Level "T Level in Agriculture, Environmental and Animal Care" 
And I set all of the T Levels for NCFE to unconfirmed