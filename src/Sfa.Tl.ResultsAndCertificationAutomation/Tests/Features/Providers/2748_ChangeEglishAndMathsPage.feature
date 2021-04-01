Feature: 2748_ChangeEnglishAndMathsPage
	As a Provider
	I need to be able to change the English & Maths details I entered for a learner
	So that I can make sure the correct details are entered

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration without LRS data
And I navigate to the 'Has the learner achieved the required minimum standard for English and maths' page
And I select "Achieved the minimum standard" radio button on 'Min standard for English Maths' page and press Continue
And I select "Yes, completed with special consideration" radio button and press Continue

@RegressionTest @Provider
Scenario: 2748 Verify change English And Maths Page
When I click change english and maths link
Then I expect to see english and maths change page
And previously selected "Achieved the minimum standard" radio option is selected on 'Min standard for English Maths' page
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario: 2748 Verify back link on English And Maths Page
When I click change english and maths link
And I click on "Back" link
Then I am shown the Check and submit page for the Add a new learner journey
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario: 2748 Change English And Maths option
When I click change english and maths link
And I select "Achieved the minimum standard with SEND adjustments" radio button on 'Min standard for English Maths' page and press Continue
Then I should see new IP status in check and submit page
And I have deleted LRS records from the database