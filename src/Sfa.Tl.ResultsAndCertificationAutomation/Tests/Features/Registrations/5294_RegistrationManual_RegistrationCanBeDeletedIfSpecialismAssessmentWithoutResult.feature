Feature: 5294_REGISTRATION MANUAL: allow a registration to be deleted if a specialism has an active assessment entry (with no results)
		 As an AO, I want the ability to hard delete a registration (as long as there is no Industry placement and/or Pathway result), 
		 so that this registration no longer exists within the Database.
		 **2949_Managing Data - Delete feature has a test which confirms a reg with industry placement can't be deleted**


Background: 
Given I have logged in as a "CityAndGuildsAdmin" user

@RegressionTest @RegistrationDelete
Scenario: 5294 Attempt to delete a registration which has a specialism assessment for previous period with no result
And I have a registration with Specialism assessment series added for previous assessment year with no grade
And I navigate to the Are you sure you want to delete this registration permanently? page and click Yes, delete this registration
Then I should see delete congirmation page

@RegressionTest @RegistrationDelete
Scenario: 5294 Attempt to delete a registration which has a couplet specialism assessment for previous period with no result
And I have a registration with couplet specialism assessment series without result added for previous assessment year with no grade
And I navigate to the Are you sure you want to delete this registration permanently? page and click Yes, delete this registration
Then I should see delete congirmation page

@RegressionTest @RegistrationDelete
Scenario: 5294 Attempt to delete a registration which has a specialism and core assessment added with no results
And I have a registration with couplet specialism assessment series and a core assessment with no grade
And I navigate to the Are you sure you want to delete this registration permanently? page and click Yes, delete this registration
Then I should see delete congirmation page

