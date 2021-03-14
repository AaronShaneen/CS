Feature: Script must be named "socket.pl", present and be marked as executable
	Scenario: socket.pl must be found
		When I run `getfile` 
		Then a file named "../../bin/socket.pl" should exist
		Then 5 points are awarded

	Scenario: socket.pl must be executable
		When I run `socket.pl`
		Then 5 points are awarded
