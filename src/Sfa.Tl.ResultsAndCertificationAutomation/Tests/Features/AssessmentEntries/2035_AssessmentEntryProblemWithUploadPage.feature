Feature: 2035_Create Problem with Assessment entries upload page
	As a Registrations Editor
	I need to be able to understand that my assessment entries file has not uploaded
	So that I can rectify

		
Background: 
Given I have logged in as a "RegistrationEditor" user
And I navigate to the Problem with assessment entry page


@RegressionTest @AssessmentEntries
Scenario: 2035_Verify problem with Assessment Entry Upload page headings, URL, page title and text
Then I am navigated to the Assessment Entries Problem with Upload page

@RegressionTest @AssessmentEntries
Scenario: 2035_Click the start again button
Then I am navigated to the Assessment Entries Problem with Upload page
Given I click the Start again button
Then I am navigated to the Upload assessment entries file page

@RegressionTest @AssessmentEntries
Scenario: 2035_Click the Back to assessment entries button
Then I am navigated to the Assessment Entries Problem with Upload page
Given I click the Back to assessment entries button
Then I am navigated to the Assessment Entries page