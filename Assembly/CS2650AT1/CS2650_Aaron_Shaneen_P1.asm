TITLE CS2650 Assembler Assignment #1

; Student Name: Aaron Shaneen
; Assignment Due Date: March 26, 2014

INCLUDE Irvine32.inc

.data

str1 BYTE "CS2650 Spring Semester 2014",0
str2 BYTE "Assembler Assignment #1",0
str3 BYTE "Aaron Shaneen" ,0

.code
main PROC

; Clear the screen
CALL Clrscr

; Display first string
; Set cursor position
MOV dh, 2d
MOV dl, 12d
CALL Gotoxy

; Set the OFFSET of edx
MOV edx, OFFSET str1

; Call WriteString
CALL WriteString

; Display second string
; Set cursor position
MOV dh, 3d
MOV dl, 12d
CALL Gotoxy

; Set the OFFSET of edx
MOV edx, OFFSET str2

; Call WriteString
CALL WriteString

; Display third string
; Set cursor position
MOV dh, 4d
MOV dl, 12d
CALL Gotoxy

; Set the OFFSET of edx
MOV edx, OFFSET str3

; Call WriteString
CALL WriteString

XOR ecx, ecx
CALL ReadChar

EXIT
main ENDP

END main