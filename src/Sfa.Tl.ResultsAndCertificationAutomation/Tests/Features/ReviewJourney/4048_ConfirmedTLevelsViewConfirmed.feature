Feature: TLRC_4048 Journey Improvements - Confirmed T Levels - View confirmed
	As an AO with a T Level reviewer user role 
	I need to be able to view my previously confirmed T Levels 
	so that I can ensure they’re still up to date 

Background: Log in as Reviewer
Given I have logged in as a "Reviewer" user
And I set some T Levels for NCFE to unconfirmed, queried and reviewed

@RegressionTest @ReviewJourney
Scenario: 4048_Verify the Confirmed T Levels page, Contact Us link presence and breadcrumbs
Given I click on the TLevels link on the homepage
And I click the Confirmed T Levels link on the T Level dashboard
Then I am navigated to the Confirmed T Levels page
And there is a Contact Us link present
When I click the TLevels breadcrumb on the Confirmed T Levels page
Then I should see the TLevels dashboard page
When I click the Confirmed T Levels link on the T Level dashboard
And I click on the Home breadcrumb on Confirmed T Levels page
Then I should be navigated back to home page
And I set all of the T Levels for NCFE to unconfirmed


@RegressionTest @ReviewJourney
Scenario: 4048_Verify Back to T Levels button and Review and Queried links on the Confirmed T Levels page
Given I click on the TLevels link on the homepage
And I click the Confirmed T Levels link on the T Level dashboard
And I click the Review link on the Confirmed T Levels page
Then I am navigated to the Select T Level to review page
When I navigate back to the Confirmed T Levels page
And I click the Queried link on the Confirmed T Levels page
Then I am navigated to the Queried T Levels page
When I navigate back to the Confirmed T Levels page from the Queried T Levels page
And I press the Back to T Levels button
Then I should see the TLevels dashboard page
And I set all of the T Levels for NCFE to unconfirmed



