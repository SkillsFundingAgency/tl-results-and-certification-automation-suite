Feature: 2605_Deleting inactive results
As a Registrations Editor
I need to be able to understand that I cannot access this page through bookmarking/URLs when a student has an active result
So that student data inconsistency isn’t created


Background: 
Given I have logged in as a "SiteAdmin" user
And I have a registration with an assessment entry


@Ignore @RegressionTest @Results
Scenario: 2605_Attempt to navigate to the Are you sure you want to remove this core assessment entry page after a result is added
Given I capture the URL for the the Are you sure you want to remove this core assessment entry page  
And I add a result to the registration
When I attempt to access the URL for the Are you sure you want to remove this core assessment entry page  
Then I am shown the Page Not Found page 
And the registration for this test is deleted
