Feature: 5045_BULK UPLOAD RESULTS: ability to add a core resit assessment entry and result without affecting previous core assessment entry and result (to be tested in manual journey)
		GIVEN I am logged in as a AO
		WHEN I attempt to submit results for core resits via bulk upload functionality
		AND there are no validation errors
		THEN .csv file is successfully ingested into DB 

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user

@RegressionTest @Results
Scenario: 5045 Create a reg with resit core assess entry
And I have a registration with resit core assessment series for <ULN>
And I navigate to the result details page for <ULN> 
And I verify the original core grade for Summer 2021 is "A"
And the core grade for Autumn 2021 is not added to the registration
When I upload the Results file with a grade for Autumn 2021
And I navigate back to the result details page for <ULN> 
Then The grade for Summer 2021 is unaffected and remains "A"
And the grade for Autumn 2021 is a "D"
When I upload the Results file without a grade for Autumn 2021
And I navigate back to the result details page for <ULN> 
Then The grade for Summer 2021 is unaffected and remains "A"
And the core grade for Autumn 2021 is not added to the registration

Examples: 
| ULN         |
| 9900000019  |
