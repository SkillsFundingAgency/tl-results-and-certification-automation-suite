Feature: TLRC_1881_Data format and rules 
	As a Registrations Editor
	I need to understand what tasks I can carry out
	So that I can ensure entry data is updated



@RegressionTest @UserGuide
Scenario: Verify registration data format file
	Given I have navigated to the Start Page
	When I click the data format and rules link
	Then the User Guide page will be displayed
	And registration data rule file will be download on clicking the link

@RegressionTest @UserGuide
Scenario: Verify assessment data format file
	Given I have navigated to the Start Page
	When I click the data format and rules link
	Then the User Guide page will be displayed
	And assessment data rule file will be download on clicking the link

	@RegressionTest @UserGuide
Scenario: Verify result data format file
	Given I have navigated to the Start Page
	When I click the data format and rules link
	Then the User Guide page will be displayed
	And result data rule file will be download on clicking the link