Feature: Script must be named "flog", present and be marked as executable
	Scenario: flog must be found
		When I run `getfile` 
		Then a file named "../../bin/flog" should exist
		Then 10 points are awarded

	Scenario: flog must be executable
		When I run `flog` 
		Then 10 points are awarded
