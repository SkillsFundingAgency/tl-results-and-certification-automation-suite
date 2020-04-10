Feature: VerifyTermsAndConditions
	In order to comply with process
	As a Tlevel user
	I want to see Terms And Conditions information in all Tlevel pages

Background: I have navigated to Tlevel start page

@Sprint5
Scenario: Veryfy Terms And Conditions link in Tlevel start page
	Given Terms And Conditions link in start page
	When I click on Terms And Conditions link
	Then Terms And Conditions page should open

@Sprint5
Scenario: Verify Terms And Conditions link in Tlevel Dashboard page
Given I have login as a Admin user
When click on Terms And Conditions link in Dahsboard page
Then Terms And Conditions page should open