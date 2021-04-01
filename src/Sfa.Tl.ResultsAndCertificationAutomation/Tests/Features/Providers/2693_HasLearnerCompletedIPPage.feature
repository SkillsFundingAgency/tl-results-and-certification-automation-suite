Feature: 2693 Learner completed IP Page
    As a Provider
    I need to be able to add Industry Placement data to learners
    So that learner data can be kept up to date

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration with LRS qualifications
And I click on "Manage learner records" link
And I click on "Add a new learner record" link

@RegressionTest @Provider
Scenario:  2693_Validate Has Learner Completed Industry Placement Page
When I enter the ULN 
And I click on "Continue" button
Then I expect to see the learner completed Industry Placement page
And the radio buttons are no populated on entry to the Has Learner Completed Industry Placement page
And the Enter ULN Page is displayed when i click on Back link
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario:  2693_Press the continue button without selecting a radio button
When I enter the ULN 
And I click on "Continue" button
And I click on "Continue" button 
Then I am shown an error message on the Has Learner Completed Industry Placement page stating "Select if the learner has completed their industry placement"
And I have deleted LRS records from the database