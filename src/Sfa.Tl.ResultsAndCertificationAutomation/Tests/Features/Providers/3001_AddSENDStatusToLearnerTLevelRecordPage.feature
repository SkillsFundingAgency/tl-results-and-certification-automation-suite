Feature: 3001_Add SEND status to Learner T Level record page
	As a Provider
	I need to be able to see that a learner has achieved English & Maths with SEND adjustments when searching for them
	So that I can ensure learner data is kept up to date


Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a registraion from LRS with EM and IP
And I click on "Manage learner T Level records" link
And I click on "Update a learner T Level record" link

@RegressionTest @Provider
Scenario:  3001_Validate Send status on Learner T Level record page
When I enter uln and click search
And I update the registration profile record so Send is "true" and IsEMAchieved is "true" and RCFeed is "false"
Then the Learner Record page is displayed with EM status "Achieved minimum standard for learners with SEND (Data from the Learning Records Service - LRS and provider declaration)"
When I update the registration profile record so Send is "null" and IsEMAchieved is "true" and RCFeed is "false"
Then the Learner Record page is displayed with EM status "Achieved minimum standard (Data from the Learning Records Service - LRS)"
When I update the registration profile record so Send is "false" and IsEMAchieved is "false" and RCFeed is "false"
Then the Learner Record page is displayed with EM status "Not achieved minimum standard (Data from the Learning Records Service - LRS)"
When I update the registration profile record so Send is "false" and IsEMAchieved is "true" and RCFeed is "false"
Then the Learner Record page is displayed with EM status "Not achieved minimum standard (Data from the Learning Records Service - LRS)"
And I have deleted LRS records from the database


