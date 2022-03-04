Feature: 5295_REGISTRATION MANUAL: allow a registration to be deleted if a specialism has an active assessment entry (with no results)
		 As an AO, I want to be prevented from deleting a registration if the specialism has an result entered against it, 
		 so that I cannot delete a registration from Database.


Background: 
Given I have logged in as a "CityAndGuildsAdmin" user

@RegressionTest @RegistrationDelete
Scenario: 5295 Registration which has a single specialism assessment with a result cannot be deleted
And I have a registration with Specialism assessment series added for current assessment series with a grade
And I navigate to the What would you like to with this active registration? page and click Continue
Then the Registration cannot be deleted page will be displayed

@RegressionTest @RegistrationDelete
Scenario: 5295 Registration which has a couplet specialism assessment with a result cannot be deleted
And I have a registration with couplet Specialism assessment series added for current assessment series with a grade
And I navigate to the What would you like to with this active registration? page and click Continue
Then the Registration cannot be deleted page will be displayed

@RegressionTest @RegistrationDelete
Scenario: 5295 Registration which has a resit couplet specialism assessment with a result cannot be deleted
And I have a registration with resit couplet Specialism assessment series added for previous assessment series with a grade
And I navigate to the What would you like to with this active registration? page and click Continue
Then the Registration cannot be deleted page will be displayed

@RegressionTest @RegistrationDelete
Scenario: 5295 Registration which has a resit specialism assessment with a result cannot be deleted
And I have a registration with Specialism assessment series added for previous assessment series with a grade
And I navigate to the What would you like to with this active registration? page and click Continue
Then the Registration cannot be deleted page will be displayed