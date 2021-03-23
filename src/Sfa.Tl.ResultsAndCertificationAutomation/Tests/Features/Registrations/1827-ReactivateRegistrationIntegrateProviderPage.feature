Feature: Integrating Select Provider Page (Register Learner on new course) - Story 1827
    As a Registrations Editor
    I need to be able to re-register a student
    So that registrations data can be kept up to date
    
Background: 
Given I have logged in as a "RegistrationEditor" user
And I click on Add a new registration link
And I create a manual registration


@RegressionTest @ReactivateRegistration
Scenario: 1827_Click on Withdraw Registration on Change Core Page
When I click Withdraw Registration on the Change Core page
Then I will be directed to the are you sure you want to withdraw this page
When I select Yes, withdraw registration
Then I am shown the Registration withdrawn successfully page
When I click on the Register learner on new course button
Then I am navigated to the Select the provider page for Register learner on a new course
When I click the back link on the Select the provider page for Register learner on a new course
Then I am navigated to the Withdrawn options page
And the Radio buttons will not be populated on entry
And I cleared the data in DB    

@RegressionTest @ReactivateRegistration
Scenario: 1827_Click on Withdraw Registration on Change Provider and Core Page
When I click Withdraw Registration button on the Change Provider and Core page
Then I will be directed to the are you sure you want to withdraw this page
When I select Yes, withdraw registration
Then I am shown the Registration withdrawn successfully page
When I click on the Register learner on new course button
Then I am navigated to the Select the provider page for Register learner on a new course
When I click the back link on the Select the provider page for Register learner on a new course
Then I am navigated to the Withdrawn options page
And the Radio buttons will not be populated on entry
And I cleared the data in DB