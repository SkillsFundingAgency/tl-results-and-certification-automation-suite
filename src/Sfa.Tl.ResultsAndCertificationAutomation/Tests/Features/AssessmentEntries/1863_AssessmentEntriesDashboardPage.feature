Feature: 1863_AssessmentEntriesDashboardPage
As a Registrations Editor
I need to add assessment entries
So that entry data can be updated

Background: 
Given I have logged in as a "RegistrationEditor" user

@RegressionTest @AssessmentEntries
Scenario: 1863_Assessment entries dashboard page
When I click on "Assessment entries" link
Then I should see Assessment entry dashboard page

@RegressionTest @AssessmentEntries
Scenario: 1863_Assessment entries breadcrumb to home
And I click on "Assessment entries" link
When I click on "Home" in breadcrumbs
Then I should be navigated back to home page