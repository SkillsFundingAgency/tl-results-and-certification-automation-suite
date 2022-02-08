Feature: 5047_SpecialismStage2Validations

As a result editor, I need summary of stage2 validation errors, So i can correct uploading file

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I am on results upload page

@RegressionTest @Results
Scenario: 5047 Specialism stage2 validations
When I upload "5047_ResultsStage2Validation.csv" file
And I click on "Upload" button
And I download the Results error file and verify
Then I should see all stage2 validation errors in the results downloaded file

@RegressionTest @Results
Scenario: 5047 Specialism stage2 validations no data
When I upload "5047_ResultsStage2NoData.csv" file
And I click on "Upload" button
And I download the Results error file and verify
Then I should see all no data validation error in the results downloaded file