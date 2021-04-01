Feature: 2694_Has learner achieved minimum standard for English & Maths page
	As a Provider
    I need to confirm learner English & Maths details which cannot be obtained from LRS
	So that learner data can be kept up to date

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration without LRS data
And I navigate to the 'Has the learner achieved the required minimum standard for English and maths' page

Scenario:  2694_Back link and Page Verification
Given I click the back link on the 'Has the learner achieved the required minimum standard for English and maths' page
Then I am navigated to the Learner Enter ULN page
And the ULN field is still populated with the previously entered ULN
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario:  2694_Selecting the 2nd radio button will display text above Continue button
Given I select the "Achieved the minimum standard" radio button
Then no text is shown above above the Continue buttton
And I select the "Not achieved the minimum standard" radio button
Then no text is shown above above the Continue buttton
And I select the "Achieved the minimum standard with SEND adjustments" radio button
Then the radio button caption text is shown above the Continue buttton
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario:  2694_Error Message displayed if no radio button selected
When I click on "Continue" button
Then the error message "Select if the learner has achieved the minimum standard" is shown on the MathAndEnglish page
And I have deleted LRS records from the database

