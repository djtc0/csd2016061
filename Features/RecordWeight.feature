Feature: RecordWeight
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: record my Weight
	Given I have entered 50 kilos as my weight on 10/06/2016
	When I press save
	Then the system should display my current weight as 50 kilos
