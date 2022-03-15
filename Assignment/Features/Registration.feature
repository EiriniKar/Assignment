Feature: Registration

@smokeTest
Scenario Outline: Register a user successfully with enter
	Given User navigates to registration page
	When User registers with valid data <firstName> <lastName> <address> <City> <State> <ZipCode> <Phone> <SSN>
	And User presses enter
	Then Account created successfully
	Examples: 

	| firstName | lastName | address | City | State  | ZipCode | Phone  | SSN    |
	| John      | Doe      | adr 5   | SKG  | Greece | 23423   | 987896 | 213123 |

@smokeTest
Scenario Outline: Register a user successfully with Register button
	Given User navigates to registration page
	When User registers with valid data <firstName> <lastName> <address> <City> <State> <ZipCode> <Phone> <SSN>
	And User clicks on Register button
	Then Account created successfully
	Examples: 

	| firstName | lastName | address | City | State  | ZipCode | Phone  | SSN    |
	| John      | Doe      | adr 5   | SKG  | Greece | 23423   | 987896 | 213123 |

Scenario Outline: Registration with null fields fail
	Given User navigates to registration page
	When User registers with valid data <firstName> <lastName> <address> <City> <State> <ZipCode> <Phone> <SSN>
	And User clicks on Register button
	Then Account isn't created and an error appears
	Examples: 

	| firstName | lastName | address | City | State  | ZipCode | Phone  | SSN    |
	|           | Doe      | adr     | SKG  | Greece | 23423   | 987896 | 213123 |
	| John      |          | adr     | SKG  | Greece | 23423   | 987896 | 213123 |
	| John      | Doe      |         | SKG  | Greece | 23423   | 987896 | 213123 |
	| John      | Doe      | adr     |      | Greece | 23423   | 987896 | 213123 |
	| John      | Doe      | adr     | SKG  |        | 23423   | 987896 | 213123 |
	| John      | Doe      | adr     | SKG  | Greece |         | 987896 | 213123 |
	| John      | Doe      | adr     | SKG  | Greece | 23423   | 987896 |        |

Scenario Outline: Registration with different password fails
	Given User navigates to registration page
	When User registers with data <firstName> <lastName> <address> <City> <State> <ZipCode> <Phone> <SSN> and wrong confirm
	And User presses enter
	Then Account isn't created and password mismatch error appears
	Examples: 

	| firstName | lastName | address | City | State  | ZipCode | Phone  | SSN    |
	| John      | Doe      | adr 5   | SKG  | Greece | 23423   | 987896 | 213123 |