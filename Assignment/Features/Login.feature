Feature: Login

A short summary of the feature

Scenario Outline: Test login with invalid credentials
	Given User navigates to home page
	When User logins with username <username> and password <password>
	Then Login fails
	Examples: 

	| username | password |
	| test1    | test1    |
	| 123      | 321      |
	| fail     | fail     |

@smokeTest
Scenario: Test login with valid credentials
	Given User navigates to registration page
	And User registers with username test password test
	And User Signs Out
	When User logins with username test and password test
	Then Login succeeds


