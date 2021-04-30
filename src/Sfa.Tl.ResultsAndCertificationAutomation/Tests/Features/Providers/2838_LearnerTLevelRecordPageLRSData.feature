Feature: 2838_LearnerTLevelRecordPageLRSData
	As a Provider
	I need to see what English & Maths/ IP data has been added to a learner
	So that I can ensure the data is correct

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a registraion from LRS with EM and IP
And I click on "Manage learner T Level records" link
And I click on "Update a learner T Level record" link

@RegressionTest @Provider
Scenario: 2838_Verify Learner T Level Record page
When I enter uln and click search
Then I should see Learner T Level Record page
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario: 2838_Verify search breadcrumb in Learner T Level Record page
When I enter uln and click search
And I click on "Search for a learner" breadcrumb
Then I should see search for learner page
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario: 2838_Verify Manage learner breadcrumb in Learner T Level Record page
When I enter uln and click search
And I click on "Manage learner T Level records" breadcrumb
Then I should see Manage learner records page
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario: 2838_Verify Home breadcrumb in Learner T Level Record page
When I enter uln and click search
And I click on "Home" breadcrumb
Then I should see Provider home page
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario: 2838_Verify search again link in Learner T Level Record page
When I enter uln and click search
And I click on "Search again" link
Then I should see search for learner page
And I have deleted LRS records from the database