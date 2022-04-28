Feature: Feature: TLRC_3165 Statement of Achievement - Change Learner's T-Level Component Achievements
	As a provider on the ‘check learner details’ page, 
	if I select ‘Change’ next to the 'Learner T-Level Component achievements' section 
	I am presented with the 'request-statement-of-achievement-change-learner-components' page 
	so I know what action I need to take to amend the details

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I deleted the address in database
And I add an address for Barnsley

@Ignore @RegressionTest @SOA
Scenario: 3165_Validate Statement of Achievement - Change Learner's T-Level Component Achievements page and Back link
Given a registration is created for LRS where 'MathEng not Achieved Min Standard Math-A Eng-NA' and 'IP completed'
And I navigate to Request statement of achievment - Check and submit page
And I click on the Change link next to the Learner’s T Level component achievements
Then I am shown the Change learner’s T Level component achievements page
And I click the Back link on the Statement of Achievement - Change Learner's T-Level Component Achievements page
Then the learners T Level component achievement details display 'Not achieved minimum standard (Data from the Learning Records Service - LRS)' and IP displays 'Placement completed'
And the learners registration and qualification details are shown
And the registration is deleted for this test

@Ignore @RegressionTest @SOA
Scenario: 3165_Validate the Manage Learner T Level Record button
Given a registration is created for LRS where 'MathEng not Achieved Min Standard Math-A Eng-NA' and 'IP completed'
And I navigate to Request statement of achievment - Check and submit page
And I click on the Change link next to the Learner’s T Level component achievements
And I click the Manage Learner TLevel Record button on the Statement of Achievement - Change Learner's T-Level Component Achievements page
Then the Learner Records Page is displayed with Eng and Maths status 'Not achieved minimum standard (Data from the Learning Records Service - LRS)' and IP completion status as 'Placement completed'
And the registration is deleted for this test