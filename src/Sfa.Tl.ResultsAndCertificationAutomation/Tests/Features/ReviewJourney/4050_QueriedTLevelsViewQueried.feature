Feature: TLRC_4050 Journey Improvements - Queried T Levels - View queried
	As an an AO with a T Levels reviewer user role 
	I need to be able view the T Levels I have previously queried 
	so that I can check which T Level(s) is still awaiting an outcome

Background: Log in as Reviewer
Given I have logged in as a "Reviewer" user
And I set some T Levels for NCFE to unconfirmed, queried and reviewed

@RegressionTest @ReviewJourney
Scenario: 4050_Verify the Queried T Levels page, Contact Us link presence and breadcrumbs
Given I click on the TLevels link on the homepage
And I click the Queried T Levels link on the T Level dashboard
Then I am navigated to the Queried T Levels page
And there is a Contact Us link present on the Queried T Levels page
When I click the TLevels breadcrumb on the Queried T Levels page
Then I should see the TLevels dashboard page
When I click the Queried T Levels link on the T Level dashboard
And I click on the Home breadcrumb on the Queried T Levels page
Then I should be navigated back to home page
And I set all of the T Levels for NCFE to unconfirmed


@RegressionTest @ReviewJourney
Scenario: 4050_Verify Back to T Levels button and Review and Confirmed links on the Queried T Levels page
Given I click on the TLevels link on the homepage
And I click the Queried T Levels link on the T Level dashboard
And I click the Review link on the Queried T Levels page
Then I am navigated to the Select T Level to review page
When I navigate back to the Queried T Levels page
And I click the Confirmed link on the Queried T Levels page
Then I am navigated to the Confirmed T Levels page
When I navigate back to the Queried T Levels page from the Confirmed T Levels page
And I press the Back to T Levels button on the Queried T Levels page
Then I should see the TLevels dashboard page
And I set all of the T Levels for NCFE to unconfirmed



