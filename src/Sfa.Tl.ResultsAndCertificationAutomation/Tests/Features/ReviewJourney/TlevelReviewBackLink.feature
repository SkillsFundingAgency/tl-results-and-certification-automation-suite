Feature: TlevelReviewBackLink
	In order to navigate to previous pages
	As a Tlevel reviewer
	I want to see Back link on journey pages

@RegressionTest @ReviewJourney
Scenario: BackLink-Are These Details correct Page
Given I have logged in as a "Reviewer" user
And I selected TLevel and click contiue button
When I click on Back link
Then I should be navigated back to Select T Level to review Page

@RegressionTest @ReviewJourney
Scenario: BackLink-Query details Page
Given I have logged in as a "Reviewer" user
And I select Tlevel to query page
When I click on Back link
Then I should be navigated back to Are these details correct page

@RegressionTest @ReviewJourney
Scenario: BackLink-Query Tlevel Details Page
Given I have logged in as a "Reviewer" user
And I select reviewd Tlevel
And I select View and select something not write
When I click on Back link
Then I should navigated back to Tlevel details page