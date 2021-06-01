Feature: 3316_Statement of Achievement - ULN5 - Minimum requirements not met - no core grade, IP not completed
	As a provider
	if I click on ‘Request a statement of achievement’ on my dashboard, 
	if the date is before 10 August 2021 then display the following page:
    'statements-of-achievement-not-available'
	 so that I know I have to come back and request this when the printing is available from 10 August 2021

Background: 
Given I have logged in as a "ProviderBarnsleyPA" user
And I have created a registration which is withdrawn, IP is set to not complete and there is no grade attached 

@RegressionTest @SOA
Scenario: 3316_Verify SOA not available page
And I click on "Request statement of achievement" link
And I click Continue on the Request SOA page
And I enter the ULN created for the Request SOA journey
Then I am shown the Statement of achievement not available - minimum requirements not met page
When I click the Back to Home button on the Statement of achievement not available - minimum requirements not met page
Then I will be navigated to the T Levels Dashboard page

@RegressionTest @SOA
Scenario: 3316_Verify breadcrumbs on SOA not available page
And I click on "Request statement of achievement" link
And I click Continue on the Request SOA page
And I enter the ULN created for the Request SOA journey
And I click the 'Search for a learner' breadcrumb on the SOA not available - minimum requirements not met page
Then I will be navigated to the Request Statement of Achievement - Search for a learner page
And I enter the ULN created for the Request SOA journey
And I click the 'Request statement of achievement' breadcrumb on the SOA not available - minimum requirements not met page
Then I am navigated to the Request SOA page if the date is greater than 10th August 2021
And I click Continue on the Request SOA page
And I enter the ULN created for the Request SOA journey
And I click the 'Home' breadcrumb on the SOA not available - minimum requirements not met page
Then I will be navigated to the T Levels Dashboard page

@RegressionTest @SOA
Scenario: 3316_Verify the Update their learner T-Level record link
And I click on "Request statement of achievement" link
And I click Continue on the Request SOA page
And I enter the ULN created for the Request SOA journey
And I click the Update their learner T-Level record link
Then I am shown the Leaner Search for a learner page

