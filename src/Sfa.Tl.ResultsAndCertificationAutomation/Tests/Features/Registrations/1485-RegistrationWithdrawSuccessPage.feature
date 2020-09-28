Feature: Add 'Change status' link on WITHDRAWN Registration Details Page - Story 1485
    As a Registrations Editor
    I need options on how to change the status of a Withdrawn record
    So that the record can be up to date

Background: 
Given I have logged in as a "RegistrationEditor" user
And I click on Add a new registration link
And I create a manual registration


@RegressionTest @WithdrawRegistration
Scenario: 1485_Click Change Status link on the Withdrawn Registration Details page
When I Withdraw my Registration starting on the Active Options page
Then I will be navigated to the Registration withdrawn successfully page (From Active Options page)
When I click the View Withdrawn Registration button 
Then I am navigated to the Registration Details page which shows my registration is withdrawn
When I click the Change Status link
Then I am navigated to the Withdrawn options page