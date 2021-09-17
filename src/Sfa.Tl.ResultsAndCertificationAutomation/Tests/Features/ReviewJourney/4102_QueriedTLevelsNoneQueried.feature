Feature: TLRC_4102 Journey Improvements - Queried T Levels - None queried
	As an AO with a T Levels reviewer user role 
	I need to know if I have not previously queried any T Levels 
	so that I can choose my next step

Background: Log in as Reviewer
Given I have logged in as a "Reviewer" user


@RegressionTest @ReviewJourney
Scenario: 4102_Verify the No T Levels queried page, Contact Us link presence and breadcrumbs 
Given I set all of the T Levels for NCFE to confirmed
And I click on the TLevels link on the homepage
And I click the Queried T Levels link on the T Level dashboard
Then I am navigated to the No T Levels queried page
When I click the TLevels breadcrumb on the No T Levels queried page
Then I should see the TLevels dashboard page
When I click the Queried T Levels link on the T Level dashboard
And I click on the Home breadcrumb on the No T Levels queried page
Then I should be navigated back to home page
When I click on the TLevels link on the homepage
And I click the Queried T Levels link on the T Level dashboard
And I click the Contact Us link on the No T Levels queried page
Then I should see the Contact Us page
And I set all of the T Levels for NCFE to unconfirmed


@RegressionTest @ReviewJourney
Scenario: 4102_Verify Back to T Levels button and Review and Confirmed links on the No T Levels queried page
Given I set three of the T Levels for NCFE to unconfirmed
And I click on the TLevels link on the homepage
And I click the Queried T Levels link on the T Level dashboard
And I click the Review link on the No T Levels queried page
Then I am navigated to the Select T Level to review page
When I navigate back to the No T Levels queried page
And I click the Confirmed link on the No T Levels queried page
Then I am navigated to the Confirmed T Levels page
When I navigate back to the No T Levels queried page from the Confirmed T Levels page
And I press the Back to T Levels button on the No T Levels queried page
Then I should see the TLevels dashboard page
And I set all of the T Levels for NCFE to unconfirmed
