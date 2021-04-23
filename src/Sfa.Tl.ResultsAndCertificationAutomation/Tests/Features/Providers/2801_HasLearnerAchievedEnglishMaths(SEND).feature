Feature: 2801 Has learner achieved English & Maths (SEND)
	As a Provider
	I need to understand that I have to confirm if a learner has SEND qualifications
	So that learner data can be kept up to date


Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a registraion from LRS with EM and no IP
When I update the registration profile record so Send is "null" and IsEMAchieved is "true" and RCFeed is "false"
And I click on "Manage learner T Level records" link
And I click on "Add a new learner T Level record" link



@RegressionTest @Provider
Scenario:  2801_Validate Page content and Back link
When I enter the ULN on the Add learner page
Then I am navigated to the 'Has the learner achieved the required minimum standard for English and maths?' page
And the radio buttons will not be populated on 'Has the learner achieved the required minimum standard for English and maths?' page
When I click the back link on the 'Has the learner achieved the required minimum standard for English and maths?' page
Then I am shown the Provider - Enter a ULN page
And the ULN is retained on the Provider - Enter a ULN page
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario:  2801_Validate caption text is shown when Achieved radio button is selected
When I enter the ULN on the Add learner page
Then I am navigated to the 'Has the learner achieved the required minimum standard for English and maths?' page
Given I select the "Achieved the minimum standard for learners with SEND" radio button on the Min standard for EM Page
Then the radio button caption text is shown above the Continue buttton on the Min standard for EM Page
And I select the "Not achieved the minimum standard" radio button on the Min standard for EM Page
Then no text is shown above above the Continue buttton on the Min standard for EM Page
And I select the "The LRS data is wrong" radio button on the Min standard for EM Page
Then no text is shown above above the Continue buttton on the Min standard for EM Page
And I have deleted LRS records from the database


@RegressionTest @Provider
Scenario:  2801_Validate Error Messages
When I enter the ULN on the Add learner page
Then I am navigated to the 'Has the learner achieved the required minimum standard for English and maths?' page
Given I click submit without selecting a radio button on the Min standard for EM Page
Then I am shown an error message stating "Select if the learner has achieved the minimum standard" on the Min standard for EM Page
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario:  2801_Learner with SEND and non SEND qualifications 
When I add non SEND qualifications to the registration
And I enter the ULN on the Add learner page
Then I am navigated to the Has the learner completed their industry placement? page
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario:  2801_Learner with SEND qualification - ISSend flag is False or True 
When I update the ISSend flag to "true"
And I enter the ULN on the Add learner page
Then I am navigated to the Has the learner completed their industry placement? page
And I click back on the Has the learner completed their industry placement? page
And I update the ISSend flag to "false"
And I click continue
Then I am navigated to the Has the learner completed their industry placement? page
And I have deleted LRS records from the database

