﻿Feature: 5894_AppealWithdrawnCore

As an AO, I want to be informed when an existing appeal has been successfully withdrawn, so that I can be confident that I have updated the record.

Background: 
Given I have logged in as a "CityAndGuildsAdmin" user
And I have a registration with appeal recorded
And I am on post results learner details page
And I click "Add core outcome" button in post result learner details page

@RegressionTest @PostResults
Scenario: 5894_Core appeal withdrawn
When I select "Appeal withdrawn" in appeal outcome page
Then appeal withdrawn for core message is shown