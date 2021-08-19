Feature: Journey Improvements - Review T Levels - More than one T Level
	As an AO with a T Levels reviewer user role 
	I need to select the T Level I want to review 
	so that I can review each outstanding T Level one at a time 

Background: Log in as Reviewer
Given I have logged in as a "Reviewer" user
And I set all of the T Levels for NCFE to unconfirmed

@RegressionTest @ReviewJourney
Scenario: Verify Select T Level to review page and breadcrumbs
Given I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
Then I am navigated to the Select T Level to review page
When I click the TLevels breadcrumb on the Select T Level to review page
Then I should see the TLevels dashboard page
When I click the Review new T Levels link on the TLevels dashboard page
And I click on the Home breadcrumb on the Select T Level to review page
Then I should be navigated back to home page
And I set all of the T Levels for NCFE to unconfirmed

@RegressionTest @ReviewJourney
Scenario: Verify Error message on Select T Level to review page when pressing continue without selecting a T Level
Given I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
Then I am navigated to the Select T Level to review page
When I click the Continue button without selecting any T Levels to review
Then I am shown the following error message on the Select a T Level to review page "Select a T Level to review"
And I set all of the T Levels for NCFE to unconfirmed

@RegressionTest @ReviewJourney
Scenario: Verify Contact Us link on the Select T Level to review page
Given I click on the TLevels link on the homepage
When I click the Review new T Levels link on the TLevels dashboard page
And I click the Contact Us link on the Select T Level to review page
Then I am shown the Contact Us page
And I set all of the T Levels for NCFE to unconfirmed



