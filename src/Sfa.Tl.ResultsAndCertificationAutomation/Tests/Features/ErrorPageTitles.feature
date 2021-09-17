Feature: ErrorPageTitles
	As a R&C Portal User
	I need the Error on a given page to be included on the Page Title
	So that when using Screen Reader functionality I am aware of the error

@RegressionTest @ReviewJourney @Ignore
Scenario: Error Title for Select Tlevel to Review Page
Given I have logged in as a "Reviewer" user
When I click on TLevel link
And I click on Continue button
Then I should see 'Error: Select a T Level to review page – Manage T Level results – GOV.UK' in page title

@RegressionTest @ReviewJourney @Ignore
Scenario: Error Title for Are these details correct Page
Given I have logged in as a "Reviewer" user
When I click on TLevel link
And I am on Are these correct page
And I click on Continue button
Then I shoud see 'Error: Are these details correct page – Manage T Level results – GOV.UK' in page title

@RegressionTest @ReviewJourney @Ignore
Scenario: Error Title for Query T Level details Page
Given I have logged in as a "Reviewer" user
When I click on TLevel link
And I am on Query T Level details page
And I click on Submit button
Then I should see "Error: Query T Level details page – Manage T Level results – GOV.UK" in page title

@RegressionTest @ProviderJourney
Scenario: Error Title for Find Provider Page
Given I have logged in as a "Provider" user
And I am on Find Provider page
When I click on Continue button
Then I should see Error: Find a provider page - Manage T Level results - GOV.UK in page title

@RegressionTest @ProviderJourney
Scenario: Error Title for Select Provider Tlevel Page
Given I have logged in as a "Provider" user
And i am on Select Provider Tlevel page
When i click on Submit button
Then I should see Error: Select provider’s T Levels page - Manage T Level results - GOV.UK in page title

@RegressionTest @ProviderJourney
Scenario: Error Title for Remove Tlevel Page
Given I have logged in as a "Provider" user
And I am on Are you sure you want to remove Tlevel Page
When i click on Submit button
Then I should see Error: Are You Sure You want to Remove This T Level page - Manage T Level results - GOV.UK in the page title

@RegressionTest @ProviderJourney
Scenario: Error Title on Add Tlevels Page
Given I have logged in as a "Provider" user
And I am on Add Tlevels page
When i click on Submit button
Then I should see Error: Add T Levels page - Manage T Level results - GOV.UK in the page title

