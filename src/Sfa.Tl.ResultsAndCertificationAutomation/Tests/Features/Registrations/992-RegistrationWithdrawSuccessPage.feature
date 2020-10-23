Feature: Create Learner Withdrawn Successfully Page - Story 992
     As a Registrations Editor
     I need to be able to see that I have withdrawn a student
     So that I can be assured that my action is complete

Background: 
Given I have logged in as a "RegistrationEditor" user
And I click on Add a new registration link
And I create a manual registration


@RegressionTest @WithdrawRegistration
Scenario: 992_Navigate to the Registration Withdrawn Successfully page from the Change Core Page
When I click Withdraw Registration on the Change Core page
Then I will be directed to the are you sure you want to withdraw this page
When I select Yes, withdraw registration
Then I will be navigated to the Registration withdrawn successfully page (from Change Core page)

    
@changeup  @RegressionTest @WithdrawRegistration
Scenario: 992_Navigate to the Registration Withdrawn Successfully page from the Change Provider and Core Page
When I click Withdraw Registration on the Change Provider and Core page
Then I will be directed to the are you sure you want to withdraw this page
When I select Yes, withdraw registration
Then I will be navigated to the Registration withdrawn successfully page (from Change Provide and Core page)


@RegressionTest @WithdrawRegistration
Scenario: 992_Navigate to the Registration Withdrawn Successfully page from the Active Options Page
When I click Withdraw Registration on the Active Options page
Then I will be directed to the are you sure you want to withdraw this page
When I select Yes, withdraw registration
Then I will be navigated to the Registration withdrawn successfully page (From Active Options page)
When I click the View Withdrawn Registration button 
Then I am navigated to the Registration Details page which shows my registration is withdrawn


@RegressionTest @WithdrawRegistration
Scenario: 992_Click the Home button on the Registration Withdrawn Successfully page
When I Withdraw my Registration starting on the Active Options page
Then I will be navigated to the Registration withdrawn successfully page (From Active Options page)
When I click the Home button
Then I will be navigated to the Registrations Dashboard page


@RegressionTest @WithdrawRegistration
Scenario: 992_Searching for a Withdrawn registration shows the Registration Details page registration status as Withdrawn
When I click Withdraw Registration on the Change Core page
Then I will be directed to the are you sure you want to withdraw this page
When I select Yes, withdraw registration
Then I will be navigated to the Registration withdrawn successfully page (from Change Core page)
When I search for my registration
Then I am navigated to the Registration Details page which shows my registration is withdrawn
    


