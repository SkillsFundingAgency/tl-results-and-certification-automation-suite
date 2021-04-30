Feature: 2844_LearnerTLevelRecordPageNoLRSData
	As a Provider
	I need to see English & Maths/ IP data that has been added for a learner
	So that I can ensure the data is correct

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a registraion with EM and IP from non LRS
And I click on "Manage learner T Level records" link
And I click on "Update a learner T Level record" link

@RegressionTest @Provider
Scenario: 2844_Verify Non LRS Learner T Level Record page
When I enter uln and click search
Then I should see Learner T Level Record page for Non LRS
And I have deleted LRS records from the database