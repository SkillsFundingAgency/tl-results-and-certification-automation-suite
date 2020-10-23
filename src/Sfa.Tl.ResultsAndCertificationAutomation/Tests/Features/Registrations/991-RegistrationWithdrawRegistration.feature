Feature: Create Are you sure you want to withdraw this registration page - Story 991
    As a Registrations Editor
    I need to confirm a withdraw
    So that I know the student will be withdrawn from the course
    
Background: 
Given I have logged in as a "RegistrationEditor" user
And I click on Add a new registration link
And I create a manual registration


@RegressionTest @WithdrawRegistration
Scenario: 991_Click on Withdraw Registration on Change Core Page
When I click Withdraw Registration on the Change Core page
Then I will be directed to the are you sure you want to withdraw this page
When I click the back link 
Then I will be navigated to the Change Core page
    
@changeup @RegressionTest @WithdrawRegistration
Scenario: 991_Click on Withdraw Registration on Change Provider and Core Page
When I click Withdraw Registration on the Change Provider and Core page
Then I will be directed to the are you sure you want to withdraw this page
When I click the back link 
Then I will be navigated to the Change Orovider and Core page

@RegressionTest @WithdrawRegistration
Scenario: 991_Click on Withdraw Registration on Active Options Page
When I click Withdraw Registration on the Active Options page
Then I will be directed to the are you sure you want to withdraw this page
When I click the back link 
Then I am navigated to the Active options page

@RegressionTest @WithdrawRegistration
Scenario: 991_Select No on Withdraw Registration - Entry Point is Change Core Page
When I click Withdraw Registration on the Change Core page
Then I will be directed to the are you sure you want to withdraw this page
When I select No, do not withdraw registration
Then I will be navigated to the Change Core page

@RegressionTest @WithdrawRegistration
Scenario: 991_Select No on Withdraw Registration - Entry Point is Active Options Page
When I click Withdraw Registration on the Active Options page
Then I will be directed to the are you sure you want to withdraw this page
When I select No, do not withdraw registration
Then I am navigated to the Active options page

@changeup @RegressionTest @WithdrawRegistration
Scenario: 991_Select No on Withdraw Registration - Entry Point is Change Provider and Core Page
When I click Withdraw Registration on the Change Provider and Core page
Then I will be directed to the are you sure you want to withdraw this page
When I select No, do not withdraw registration
Then I will be navigated to the Change Orovider and Core page

@RegressionTest @WithdrawRegistration
Scenario: 991_Select Yes radio button on Withdraw Registration page
When I click Withdraw Registration on the Active Options page
Then I will be directed to the are you sure you want to withdraw this page
When I select Yes, withdraw registration
Then I will be navigated to the Registration withdrawn successfully page
And the registration is successfully withdrawn


@changeup @RegressionTest @WithdrawRegistration
Scenario: 991_Error message validation on Withdraw Registration page
When I click Withdraw Registration on the Change Provider and Core page
Then I will be directed to the are you sure you want to withdraw this page
When I press Submit button without selecting any radio buttons
Then I will be shown an error on the Withdraw Registration page stating "Select yes if you want to withdraw this registration"