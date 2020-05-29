Feature: RegistrationsPage
	As a Registrations Editor
	I need to be able to select options of what registration tasks I want to carry out
	So that I can select the appropriate task

Background:
Given I have logged in as a "RegistrationEditor" user

@SmokeTest
Scenario: Registration Dashboard Page
When I click on Registrations link on Home page
Then Registration page should open