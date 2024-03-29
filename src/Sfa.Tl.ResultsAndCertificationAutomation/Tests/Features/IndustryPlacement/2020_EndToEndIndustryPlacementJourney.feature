﻿Feature: EndToEndIndustryPlacementJourney 2020 registrations
	End to end journeys for industry placement journies for 2020 registrations using different T Levels
	These journeys will navigate through all of the different pages available to these registrations 

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user

@RegressionTest @IndustryPlacement
Scenario: 1-IP E2E journey - 2020 Education and Childcare T Level registration - Employer Model Used
Given I have an active registration with an Education and Childcare T Level
And I click on "Manage learner records" link
When I enter the ULN on the search page
And I click the following link "Add Ip"
And I click 'Yes, completed' on the Has learner completed their industry placement? page
And I click "Yes" on the Was an industry placement model used for learner? page
And I click "Yes" on the Was a multiple employer model used for learner page
And I click "Relevant part-time work" on the Did learner use any other industry placement models? page
And I click "Yes" on the Was learner granted a temporary flexibility? page
And I click "Reduction in hours" on the Which temporary flexibilities were granted to learner page
Then I am shown the IP Check your answer page
And I click Submit on the Check your answers page
Then the learner details page is displayed with a success banner
And I cleared the data in DB

@RegressionTest @IndustryPlacement
Scenario: 2-IP E2E journey - 2020 Education and Childcare T Level registration Employer Model Not Used
Given I have an active registration with an Education and Childcare T Level
And I click on "Manage learner records" link
When I enter the ULN on the search page
And I click the following link "Add Ip"
And I click 'Yes, completed' on the Has learner completed their industry placement? page
And I click "Yes" on the Was an industry placement model used for learner? page
And I click "No" on the Was a multiple employer model used for learner page
And I click "Relevant part-time work" on the Which industry placement models were used by learner? page
And I click "Yes" on the Was learner granted a temporary flexibility? page
And I click "Reduction in hours" on the Which temporary flexibilities were granted to learner page
Then I am shown the IP Check your answer page
And I click Submit on the Check your answers page
Then the learner details page is displayed with a success banner
And I cleared the data in DB

@RegressionTest @IndustryPlacement
Scenario: 3-IP E2E journey - 2020 Digital production, design and development 
Given I have an active registration with Digital production, design and development T Level
And I click on "Manage learner records" link
When I enter the ULN on the search page
And I click the following link "Add Ip"
And I click 'Yes, completed' on the Has learner completed their industry placement? page
And I click "Yes" on the Was an industry placement model used for learner? page
And I click "No" on the Was a multiple employer model used for learner page
And I click "Relevant part-time work" on the Which industry placement models were used by learner? page
And I click "Yes" on the Was learner granted a temporary flexibility? page
And I click "Yes" on the Did learner use the blended placement temporary flexibility? page
And I click "Yes" on the Did learner use the employer-led activities/projects temporary flexibility? page
Then I am shown the IP Check your answer page
And I click Submit on the Check your answers page
Then the learner details page is displayed with a success banner
And I cleared the data in DB

@RegressionTest @IndustryPlacement
Scenario: 4-IP E2E journey - 2020 Digital production, design and development 
Given I have an active registration with Digital production, design and development T Level
And I click on "Manage learner records" link
When I enter the ULN on the search page
And I click the following link "Add Ip"
And I click 'Yes, completed' on the Has learner completed their industry placement? page
And I click "Yes" on the Was an industry placement model used for learner? page
And I click "No" on the Was a multiple employer model used for learner page
And I click "Relevant part-time work" on the Which industry placement models were used by learner? page
And I click "Yes" on the Was learner granted a temporary flexibility? page
And I click "Yes" on the Did learner use the blended placement temporary flexibility? page
And I click "No" on the Did learner use the employer-led activities/projects temporary flexibility? page
##And I click "Employer led activities/projects" on the Which temporary flexibilities were granted to learner page
Then I am shown the IP Check your answer page
And I click Submit on the Check your answers page
Then the learner details page is displayed with a success banner
And I cleared the data in DB

@RegressionTest @IndustryPlacement
Scenario: 5-IP E2E journey - 2020 Health T Level registration Employer Model Not Used
Given I have an active registration with an Health T Level
And I click on "Manage learner records" link
When I enter the ULN on the search page
And I click the following link "Add Ip"
And I click 'Yes, completed' on the Has learner completed their industry placement? page
And I click "Yes" on the Was an industry placement model used for learner? page
And I click "Yes" on the Was a multiple employer model used for learner page
And I click "Relevant part-time work" on the Did learner use any other industry placement models? page
Then I am shown the IP Check your answer page
And I click Submit on the Check your answers page
Then the learner details page is displayed with a success banner
And I cleared the data in DB

@RegressionTest @IndustryPlacement 
Scenario: 6-IP E2E journey - 2020 Digital Business Services
Given I have an active registration with a Digital Business Services T Level
And I click on "Manage learner records" link
When I enter the ULN on the search page
And I click the following link "Add Ip"
And I click 'Yes, completed with special consideration' on the Has learner completed their industry placement? page
And I click "300" hours on the How many industry placement hours did learner complete?
And I click "COVID-19" on Why was learner granted special consideration for their industry placement? page
And I click "Yes" on the Was an industry placement model used for learner? page
And I click "Yes" on the Was a multiple employer model used for learner page
And I click "On-site facilities for SEND students" on the Did learner use any other industry placement models? page
Then I am shown the IP Check your answer page
And I click Submit on the Check your answers page
Then the learner details page is displayed with a success banner
And I cleared the data in DB


@RegressionTest @IndustryPlacement 
Scenario: 7-IP E2E journey - 2020 Onsite Construction T Level
Given I have an active registration with a Onsite Construction T Level T Level
And I click on "Manage learner records" link
When I enter the ULN on the search page
And I click the following link "Add Ip"
And I click 'Yes, completed with special consideration' on the Has learner completed their industry placement? page
And I click "300" hours on the How many industry placement hours did learner complete?
And I click "COVID-19" on Why was learner granted special consideration for their industry placement? page
And I click "Yes" on the Was an industry placement model used for learner? page
And I click "No" on the Was a multiple employer model used for learner page
And I click "Use of skills hubs or employer training centres" on the Which industry placement models were used by learner? page
Then I am shown the IP Check your answer page
And I click Submit on the Check your answers page
Then the learner details page is displayed with a success banner
And I cleared the data in DB