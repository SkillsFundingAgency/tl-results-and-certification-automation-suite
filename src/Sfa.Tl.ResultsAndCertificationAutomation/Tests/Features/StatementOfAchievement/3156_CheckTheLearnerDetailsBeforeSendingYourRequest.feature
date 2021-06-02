Feature: TLRC_3156 Statement of Achievement - Check the learner details before sending your request
	As a provider, 
	if I search for a ULN that has been registered, has component results recorded and has been withdrawn by AO 
	then the ‘Check the learner’s details before sending your request' page should be displayed

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user

@RegressionTest @SOA @Ignore
Scenario: 3156_LRS Test 1
Given a registration is created for LRS where 'MathEng not Achieved Min Standard Math-A Eng-NA' and 'IP completed'
And I click on "Request statement of achievement" link
And I click Continue on the Request SOA page
And I enter the ULN created for the Request SOA journey
Then I am shown the SOA Check and submit page
And the learners T Level component achievement details display 'Not achieved minimum standard (Data from the Learning Records Service - LRS)' and IP displays 'Placement completed'


@RegressionTest @SOA @Ignore
Scenario: 3156_LRS Test 2
Given a registration is created for LRS where 'MathEng not Achieved Min Standard Math-NA Eng-A' and 'IP completed'
And I click on "Request statement of achievement" link
And I click Continue on the Request SOA page
And I enter the ULN created for the Request SOA journey
Then I am shown the SOA Check and submit page
And the learners T Level component achievement details display 'Not achieved minimum standard (Data from the Learning Records Service - LRS)' and IP displays 'Placement completed'


@RegressionTest @SOA @Ignore
Scenario: 3156_LRS Test 3
Given a registration is created for LRS where 'MathEng Achieved Min Standard' and 'IP still to be completed'
And I click on "Request statement of achievement" link
And I click Continue on the Request SOA page
And I enter the ULN created for the Request SOA journey


@RegressionTest @SOA @Ignore
Scenario: 3156_LRS Test 4
Given a registration is created for LRS where 'MathEng not Achieved Min Standard Math-NA Eng-NA' and 'IP completed with special consideration'
And I click on "Request statement of achievement" link
And I click Continue on the Request SOA page
And I enter the ULN created for the Request SOA journey

##@RegressionTest @SOA
##Scenario: 3156_LRS Test 5 - CANNOT GET THIS TO WORK - MAYBE NON LRS ONLY?
##Given a registration is created for LRS where 'MathEng Achieved with SEND' and 'IP completed with special consideration'
##And I click on "Request statement of achievement" link

@RegressionTest @SOA @Ignore
Scenario: 3156_NON LRS Test 6
Given a registration is created for NON LRS where 'MathEng achieved the minimum standard' and 'IP completed'
And I click on "Request statement of achievement" link
And I click Continue on the Request SOA page
And I enter the ULN created for the Request SOA journey

@RegressionTest @SOA @Ignore
Scenario: 3156_NON LRS Test 7
Given a registration is created for NON LRS where 'MathEng achieved the minimum standard for learners with SEND' and 'IP completed with special consideration'
And I click on "Request statement of achievement" link
And I click Continue on the Request SOA page
And I enter the ULN created for the Request SOA journey

@RegressionTest @SOA @Ignore
Scenario: 3156_NON LRS Test 8
Given a registration is created for NON LRS where 'MathEng not achieved the minimum standard' and 'IP not completed'
And I click on "Request statement of achievement" link
And I click Continue on the Request SOA page
And I enter the ULN created for the Request SOA journey