Feature: 2135_ResultsWithdrawnManual
	As a R&C Portal user
	I need results data to be updated after a record is withdrawn
	So that student data can be kept up to date

Background:
Given I have logged in as a "ResultsEditor" user
And I have a registration with result
And I have moved registration in to withdrawn state

@RegressionTest @Results
Scenario: 2135_Resutls for withdrawn registration
And I click on "Results" link
When I search the learner
Then I should see following message for that registration
| Message                                         |
| This learner's registration has been withdrawn. |