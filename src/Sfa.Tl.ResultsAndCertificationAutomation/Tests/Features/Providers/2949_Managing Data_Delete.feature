Feature: 2949_Managing Data - Delete
	As an AO
	I need to understand that I cannot delete a record that has IP data added to it
	So that learner data can be kept up to date


@Ignore @RegressionTest @Provider
Scenario:  2949_Attempt to delete a registration with IP data
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration without LRS data
And I navigate to the 'Has the learner achieved the required minimum standard for English and maths' page
And I select "Achieved the minimum standard" radio button on 'Min standard for English Maths' page and press Continue
And I change the radio option to "Yes, completed"
And I click Submit button on the Learner CHeck and submit page
And I click on the Sign Out link
And I have logged in as a "RegistrationEditor" user
And I attempt to delete the registration which has IP data against it
Then the Registration cannot be deleted page will be displayed
And when I click the back link on the Registration cannot be deleted page
Then I am shown the Active options page
And I have deleted LRS records from the database

@Ignore @RegressionTest @Provider
Scenario:  2949_Click back to registration details button on Registration cannot be deleted page
Given I have logged in as a "ProviderBarnsleyPA" user
And I have a created a registration without LRS data
And I navigate to the 'Has the learner achieved the required minimum standard for English and maths' page
And I select "Achieved the minimum standard" radio button on 'Min standard for English Maths' page and press Continue
And I change the radio option to "Yes, completed"
And I click Submit button on the Learner CHeck and submit page
And I click on the Sign Out link
And I have logged in as a "RegistrationEditor" user
And I attempt to delete the registration which has IP data against it
Then the Registration cannot be deleted page will be displayed
And when I click the back to registration details button
Then I am shown the Registration Details page
And I have deleted LRS records from the database

@RegressionTest @Provider
Scenario:  2949_Access Registration cannot be deleted page using a bookmark
Given I have logged in as a "SiteAdmin" user
And I directly navigate to the Registration cannot be deleted page
Then I am shown the Page Not Found page

@Ignore @RegressionTest @Provider
Scenario:  2949_Delete a registration which has IP data added in parallel just before deletion
Given I have logged in as a "RegistrationEditor" user
And I have a created a registration without LRS data
And I navigate to the Delete Registration Page
And I add IP data in parallel to the registration 
When I select Yes delete registration option and click submit
Then I will be shown the Problem with service page
And I have deleted LRS records from the database