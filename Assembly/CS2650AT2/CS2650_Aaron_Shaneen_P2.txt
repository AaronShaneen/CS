TITLE CS2650 Assembler Assignment #2

; Student Name: Aaron Shaneen
; Assignment Due Date: March 31, 2014

INCLUDE Irvine32.inc

.data

	; ClassInfo
	str1 BYTE "CS2650 Spring Semester 2014",0
	str2 BYTE "Assembler Assignment #1",0
	str3 BYTE "Aaron Shaneen" ,0
	str4 BYTE "Please enter a FAT16 file time, in hex format." ,0

	; Time template
	vTimeField BYTE "--:--:--" ,0

.code
main PROC

	; Display class info
	CALL ClassInfo

	; Set cursor and read user input
	MOV dh, 11d
	MOV dl, 0d
	CALL Gotoxy
	CALL ReadHex

	; Little Endian Conversion
	ROR ax, 8d

	; Copy eax to ecx for later use
	MOV ecx, eax

	; HOURS*************************
	; Isolate first 5 bits by anding
	AND ax, 1111100000000000b

	; Shifting right to ax
	SHR ax, 11d

	; Convert to ASCII
	; Divide
	MOV bl, 10d
	DIV bl

	; ASCII Conversion
	ADD ax, 3030h

	; Move the value to its place in vTimeField
	MOV word ptr [vTimeField + 0], ax

	; MINUTES***********************
	; Refresh original time back to eax
	MOV eax, ecx

	; Isolate middle 6 bits by anding
	AND ax, 0000011111100000b

	; Shifting right to bx
	SHR ax, 5d

	; Convert to ASCII
	; Divide
	MOV bl, 10d
	DIV bl

	; ASCII Conversion
	ADD ax, 3030h

	; Move the value to its place in vTimeField
	MOV word ptr [vTimeField + 3], ax
	
	; SECONDS***********************
	; Refresh original time back to eax
	MOV eax, ecx

	; Isolate last 5 bits by anding
	AND ax, 0000000000011111b

	; Convert to ASCII
	; Divide
	MOV bl, 10d
	DIV bl

	; ASCII Conversion
	ADD ax, 3030h

	; Move the value to its place in vTimeField
	MOV word ptr [vTimeField + 6], ax

	; Set cursor and print
	MOV dh, 12d
	MOV dl, 0d
	CALL Gotoxy
	MOV edx, OFFSET vTimeField
	CALL WriteString

	CALL ReadString
	EXIT

main ENDP

ClassInfo:

	; Clear the screen
	CALL Clrscr

	; Display first string
	; Set cursor position
	MOV dh, 7d
	MOV dl, 0d
	CALL Gotoxy

	; Set the OFFSET of edx
	MOV edx, OFFSET str1

	; Call WriteString
	CALL WriteString

	; Display second string
	; Set cursor position
	MOV dh, 8d
	MOV dl, 0d
	CALL Gotoxy

	; Set the OFFSET of edx
	MOV edx, OFFSET str2

	; Call WriteString
	CALL WriteString

	; Display third string
	; Set cursor position
	MOV dh, 9d
	MOV dl, 0d
	CALL Gotoxy

	; Set the OFFSET of edx
	MOV edx, OFFSET str3

	; Call WriteString
	CALL WriteString

	; Display fourth string
	; Set cursor position
	MOV dh, 10d
	MOV dl, 0d
	CALL Gotoxy

	; Set the OFFSET of edx
	MOV edx, OFFSET str4

	; Call WriteString
	CALL WriteString

	ret ; END ClassInfo

END main