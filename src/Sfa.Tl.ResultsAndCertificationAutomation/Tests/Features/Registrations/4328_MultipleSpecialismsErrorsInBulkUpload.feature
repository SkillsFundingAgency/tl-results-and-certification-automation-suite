Feature: 4328_MultipleSpecialismsErrorsInBulkUpload
	As a Registrations Editor
	I need to upload registrations entry data with multiple specialisms in bulk
	So that I can upload coupled specialisms

Background:
Given I have logged in as a "CityAndGuildsAdmin" user
And I am on Registrations upload page

@RegressionTest @MultipleSpecialisms
Scenario: 4328 Validate multi specialisms error
And I have a Academic Year in "4328RegistrationsCoupledSpecialismInvalidData.csv"
When I upload "4328RegistrationsCoupledSpecialismInvalidData.csv" file
And I click on "Upload" button
And I download the registration error file and verify
Then I should see all errors relted multi specialisms in the file