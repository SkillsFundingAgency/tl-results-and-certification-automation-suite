Feature: 2750_LearnerAddedSuccessfully
	As a Provider
	I need to understand that I have added results data to a learner
	So I can ensure that learner data is up to date

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I click on "Manage learner T Level records" link
And I click on "Add a new learner T Level record" link

@RegressionTest @Provider
Scenario: 2750_ verify success page with LRS qualification IP status 1
And I have a registration with LRS qualifications - English and Maths acheived
And I enter the Uln
And I click on "Continue" button
And I select "Yes, completed" radio button and press Continue
When I click on "Submit" button
Then I should get Submit successfully page
And The Ip table is updated with "Yes, completed"
And I should see Manage learner records page when i click on Back to learner page link
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario: 2750_ verify success page with LRS qualification IP status 2
And I have a registration with LRS qualifications - English and Maths acheived
And I enter the Uln
And I click on "Continue" button
And I select "Yes, completed with special consideration" radio button and press Continue
When I click on "Submit" button
Then I should get Submit successfully page
And The Ip table is updated with "Yes, completed with special consideration"
And I should see add learner page when i click on Add anopther learner button
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario: 2750_ verify success page with LRS qualification IP status 3
And I have a registration with LRS qualifications - English and Maths acheived
And I enter the Uln
And I click on "Continue" button
And I select "No, still to be completed" radio button and press Continue
When I click on "Submit" button
Then I should get Submit successfully page
And The Ip table is updated with "No, still to be completed"
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario: 2750_ verify success page with Non LRS data EM status 1
And I have a created a registration without LRS data
And I enter the Uln
And I click on "Continue" button
And I select "Achieved the minimum standard" in english and maths page and press continue
And I select "Yes, completed" radio button and press Continue
When I click on "Submit" button
Then I should get Submit successfully page
And The Ip table is updated with "Yes, completed"
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario: 2750_ verify success page with Non LRS data EM status 2
And I have a created a registration without LRS data
And I enter the Uln
And I click on "Continue" button
And I select "Achieved the minimum standard for learners with SEND" in english and maths page and press continue
And I select "Yes, completed with special consideration" radio button and press Continue
When I click on "Submit" button
Then I should get Submit successfully page
And The Ip table is updated with "Yes, completed with special consideration"
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario: 2750_ verify success page with Non LRS data EM status 3
And I have a created a registration without LRS data
And I enter the Uln
And I click on "Continue" button
And I select "Not achieved the minimum standard" in english and maths page and press continue
And I select "No, still to be completed" radio button and press Continue
When I click on "Submit" button
Then I should get Submit successfully page
And The Ip table is updated with "No, still to be completed"
And I have deleted LRS records from the database