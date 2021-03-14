Feature: Script reports to the right place and exits properly

	Scenario: With parameters missing, "Usage:" msg and exits with rc=1
		When I run `socket.pl`
		And the output should contain "Usage:"
		Then the exit status should not be 0
		Then 5 points are awarded

	Scenario: Exits rc=0 on successful completion
		When I run `socket.pl icarus.cs.weber.edu 22`
		Then the output should contain "SSH"
		And the stderr should not contain anything
		Then the exit status should be 0
		Then 5 points are awarded

	Scenario: Writes only to STDERR on errors
		When I run `socket.pl`
		And the stderr should contain "Usage:"
		And the stdout should not contain anything
		Then the exit status should not be 0
		Then 10 points are awarded

