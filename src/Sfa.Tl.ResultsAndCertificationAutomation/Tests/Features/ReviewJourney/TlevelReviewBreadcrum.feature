Feature: TlevelReviewBreadcrum
	In order to navigate previous pages
	As a Tlevel reviewer
	I want to click on breadcrums to navigate other pages

Background: 
Given I have logged in as a "Reviewer" user

@RegressionTest @ReviewJourney
Scenario: Breadcrumb on Select Tlevel to Review page
When I am on the Select Tlevel to Review page
And I click on Home link
Then I should be navated back to dashboard

@RegressionTest @ReviewJourney
Scenario: Breadcrumb on Your Tlevel Confirmed Page
When I am on Your Tlevel Page
And I click on Home link
Then I should be navated back to dashboard

@RegressionTest @ReviewJourney
Scenario: Breadcrumb on Your Tlevel Queried Page
When I am on your Tlevel Queried page
And I click on Home link
Then I should be navated back to dashboard

@RegressionTest @ReviewJourney
Scenario: Breadcrumb on Tlevel Details Page
When I am on Tlevel Details Page
And I click on Your Tlevels link
Then I should be navigated back to Your reviewed Tlevel page
