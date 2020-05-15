Feature: ErrorPageTitles
	As a R&C Portal User
	I need the Error on a given page to be included on the Page Title
	So that when using Screen Reader functionality I am aware of the error

Background: 
Given I have logged in as a "Reviewer" user

@RegressionTest @ReviewJourney
Scenario: Error Title for Select Tlevel to Review Page
When I click on TLevel link
And I click on Continue button
Then I should see 'Error: Select a T Level to review page – Manage T Level results – GOV.UK' in page title

@RegressionTest @ReviewJourney
Scenario: Error Title for Are these details correct Page
When I click on TLevel link
And I am on Are these correct page
And I click on Continue button
Then I shoud see 'Error: Are these details correct page – Manage T Level results – GOV.UK' in page title

@RegressionTest @ReviewJourney
Scenario: Error Title for Query T Level details Page
When I click on TLevel link
And I am on Query T Level details page
And I click on Submit button
Then I should see "Error: Query T Level details page – Manage T Level results – GOV.UK" in page title
