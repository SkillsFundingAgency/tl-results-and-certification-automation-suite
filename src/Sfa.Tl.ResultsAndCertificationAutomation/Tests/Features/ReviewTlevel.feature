Feature: ReviewTlevel
	In order to Review or Query TLeveL
	As a TLevel Reviewer
	I want to access to Mange TLevel services

Background: Log in as Reviewer
Given I have logged in as a "Reviewer" user

@RegressionTest @ReviewJourney
Scenario: Manage TLevel Page
	When I click on TLevel link
	Then I should see Select Tlevel Review Page

@RegressionTest
Scenario: Review single Tlevel
When I select a single Tlevel and click continue
And select Everything correct and click continue
Then I should see TLevel Confirmation message

@RegressionTest
Scenario: Query a Tlevel
When I select a single Tlevel and click continue
And I select Something Wrong anc click continue
And Enter text and click continue
Then I should see Tlevel queried message

@RegressionTest
Scenario: Review a Confirmed TLevel
When I select a single Tlevel and click continue
And select Everything correct and click continue
Then I should see TLevel Confirmation message
And I should see Reviewed Tlevel details when i click on view reviewed tlevel link

@RegressionTest
Scenario: Query a Confirmed TLevel
When I click on TLevel link
And I click on View reviewed TLevel link
And I select Something Wrong and click continue
Then the Tlevel should move from Reviewed to Queried status

