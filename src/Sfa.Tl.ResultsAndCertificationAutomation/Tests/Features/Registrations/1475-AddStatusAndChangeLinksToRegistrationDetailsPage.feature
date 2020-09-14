Feature: Add Status & Change Links on Registration Details Page - Story 1475
	As a Registrations Editor
    I need to see the status of a record when I search for it
    So that I can see what I can do with the record

Background: 
Given I have logged in as a "RegistrationEditor" user
And I click on Add a new registration link
And I create a manual registration

@RegressionTest @RegistrationSearch
Scenario: 1475-Searching for an active registration will display an Active badge on the Registration Details page.
And I search for my registration
Then I should see results in the page
And the ULN status will be Active
And the Change links will be present 
