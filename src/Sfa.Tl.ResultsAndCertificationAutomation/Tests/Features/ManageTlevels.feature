Feature: ReviewTlevels
	In order to Manage Tlevels
	As a Reviewer
	I want to all Tlevls

Background: Login as Reviewer
Given I have logged in as a "Reviewer" user

@Sprint10
Scenario: Review Tlevel Page
	When I click on TLevels link
	Then I should see Select TLevel Review Page

@Sprint10
Scenario: Review Tlevel
Background: Login as Reviewer
And I click on Tlevels link
When i select a TLevel and click continue
And select Everything correct and click continue button
Then I should see Tlevel confirmation message

@Sprint10
Scenario: Query Tlevel
Background: Login as Reviewer
And I click on Tlevels link
When i select a TLevel and click continue
And select Something wrong and click continue
And I enter text and submit
Then I should see Tlevel Queried message

@Sprint10
Scenario: Review Confirmed Tlevel
Background: Login as Reviewer
And I click on Tlevels link
When i select a TLevel and click continue
And select Everything correct and click continue button
Then I should see Tlevel confirmation message
And I should see Reviewed Tlevel detsils when i click on View Reviewd Tlevel link

@Sprint10
Scenario: Query a confirmed Tlevel
Background: Login as Reviewer
And I click on Tlevels link
When I click on View reviewed Tlevel link
And i click on View and Something not write link
And i enter text and submit
Then the Tlevel should moved from Confirmed to Review status
