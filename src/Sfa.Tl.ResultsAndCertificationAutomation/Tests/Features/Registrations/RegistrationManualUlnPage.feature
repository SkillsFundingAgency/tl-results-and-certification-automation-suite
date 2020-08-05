﻿Feature: RegistrationManualUlnPage
	As a Registrations Editor
	I need to be able to add single registration data for a student
	So that I can have the option to upload in bulk or not

Background:
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @ManaulRegistration
Scenario: Verify Registration ULN Page
When I click on Add a new registration link
Then I should see ULn Page

@RegressionTest @ManaulRegistration
Scenario: Verify Erros in Registration ULN Page
When I click on Add a new registration link
And I click in continue button
Then I should see Error in ULn Page
