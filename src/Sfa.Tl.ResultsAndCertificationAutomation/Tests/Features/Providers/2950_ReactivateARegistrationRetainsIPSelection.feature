Feature: 2950_Managing Data - Reactivate
	As a Provider
    I need to make sure that IP data is maintained against learners who leave and rejoin courses
	So that learner data is kept up to date


@RegressionTest @Provider
Scenario:  2950_Withdraw and Reactivate a registration with IP status of "Yes, completed"
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration without LRS data
And I navigate to the 'Has the learner achieved the required minimum standard for English and maths' page
And I select "Achieved the minimum standard" radio button on 'Min standard for English Maths' page and press Continue
And I change the radio option to "Yes, completed"
And I click Submit button on the Learner CHeck and submit page
And I click on the Sign Out link
And I have logged in as a "RegistrationEditor" user
And I withdraw the registration and then reactivate it
Then the IndustryPlacement table will still have a status value of "1"

@RegressionTest @Provider
Scenario:  2950_Withdraw and Reactivate a registration with IP status of "Yes, completed with special consideration"
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration without LRS data
And I navigate to the 'Has the learner achieved the required minimum standard for English and maths' page
And I select "Achieved the minimum standard" radio button on 'Min standard for English Maths' page and press Continue
And I change the radio option to "Yes, completed with special consideration"
And I click Submit button on the Learner CHeck and submit page
And I click on the Sign Out link
And I have logged in as a "RegistrationEditor" user
And I withdraw the registration and then reactivate it
Then the IndustryPlacement table will still have a status value of "2"


@RegressionTest @Provider
Scenario:  2950_Withdraw and Reactivate a registration with IP status of "No, still to be completed"
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration without LRS data
And I navigate to the 'Has the learner achieved the required minimum standard for English and maths' page
And I select "Achieved the minimum standard" radio button on 'Min standard for English Maths' page and press Continue
And I change the radio option to "No, still to be completed"
And I click Submit button on the Learner CHeck and submit page
And I click on the Sign Out link
And I have logged in as a "RegistrationEditor" user
And I withdraw the registration and then reactivate it
Then the IndustryPlacement table will still have a status value of "3"