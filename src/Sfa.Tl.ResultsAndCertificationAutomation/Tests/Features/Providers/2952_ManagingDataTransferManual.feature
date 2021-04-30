Feature: 2952_ManagingDataTransferManual
	As a Provider
	I need IP data to be maintained when learners change Providers
	So that learner data can be kept up to date

Background: 
Given I have a registration with IP against Dudley provider
And I have logged in as a "RegistrationEditor" user
And I click on "Registrations" link
And I search the registration and on change provider page
And I changed the provider to "Barnsley College"
And I click on the Sign Out link
And I have logged in as a "ProviderBarnsleyPA" user
And I click on "Manage learner T Level records" link
And I click on "Update a learner T Level record" link

@RegressionTest @Provider
Scenario: 2952_Learner record shows active IP with new provider 
When I search the learner record
Then I should see previous IP record is active for new provider
And I have deleted LRS data from the database
