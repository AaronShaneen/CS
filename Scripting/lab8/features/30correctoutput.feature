Feature: Script outputs the correct data

	Scenario: Script supports localhost
		When I run `socket.pl localhost 22`
		Then the stdout should contain "SSH-2.0-OpenSSH"
		And the stderr should not contain anything
		And the exit status should be 0
		Then 20 points are awarded

	Scenario: Script supports hostnames
		When I run `socket.pl icarus.cs.weber.edu 22`
		Then the stdout should contain "SSH-2.0-OpenSSH"
		And the stderr should not contain anything
		And the exit status should be 0
		Then 30 points are awarded

	Scenario: Script supports external hosts
		When I run `socket.pl smtp.gmail.com 25`
		Then the stdout should contain "ESMTP"
		And the stderr should not contain anything
		And the exit status should be 0
		Then 30 points are awarded

	Scenario: Script returns error and rc != 0 on invalid hostname
		When I run `socket.pl non.existent.host.address 22`
		And the stderr should contain "Error"
		And the stdout should not contain anything
		And the exit status should not be 0
		Then 20 points are awarded

	Scenario: Script exits with non zero return code on invalid port number
		When I run `socket.pl 127.0.0.1 99999`
		Then the stderr should contain "Error"
		Then the stdout should not contain anything
		And the exit status should not be 0
		Then 20 points are awarded

