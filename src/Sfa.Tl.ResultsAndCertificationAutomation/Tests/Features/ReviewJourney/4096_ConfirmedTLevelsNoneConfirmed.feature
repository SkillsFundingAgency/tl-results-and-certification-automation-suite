Feature: TLRC_4096 Journey Improvements - Confirmed T Levels - None confirmed 
	As an AO with a T Levels reviewer user role 
	I need to know if I have not previously confirmed any T Levels 
	so that I can choose my next step

Background: Log in as Reviewer
Given I have logged in as a "Reviewer" user


@RegressionTest @ReviewJourney
Scenario: 4096_Verify the No T Levels confirmed page, Contact Us link and breadcrumbs 
Given I set all of the T Levels for NCFE to queried
And I click on the TLevels link on the homepage
And I click the Confirmed T Levels link on the T Level dashboard
Then I am navigated to the No T Levels confirmed page
When I click the TLevels breadcrumb on the No T Levels confirmed page
Then I should see the TLevels dashboard page
When I click the Confirmed T Levels link on the T Level dashboard
And I click on the Home breadcrumb on the No T Levels confirmed page
Then I should be navigated back to home page
When I click on the TLevels link on the homepage
And I click the Confirmed T Levels link on the T Level dashboard
And I click the Contact Us link on the No T Levels confirmed page
Then I should see the Contact Us page
And I set all of the T Levels for NCFE to unconfirmed


@RegressionTest @ReviewJourney
Scenario: 4096_Verify Back to T Levels button and Review and Queried links on the No T Levels confirmed page
Given I set all of the T Levels for NCFE to queried
And I click on the TLevels link on the homepage
And I click the Confirmed T Levels link on the T Level dashboard
And I click the Review link on the No T Levels confirmed page
Then the Review T Levels - All T Levels reviewed page is displayed
When I navigate back to the No T Levels confirmed page
And I click the Queried link on the No T Levels confirmed page
Then I am navigated to the Queried T Levels page
When I navigate back to the No T Levels confirmed page from the Queried T Levels page
And I press the Back to T Levels button on the No T Levels queried page
Then I should see the TLevels dashboard page
And I set all of the T Levels for NCFE to unconfirmed
