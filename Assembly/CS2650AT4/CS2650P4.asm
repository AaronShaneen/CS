TITLE CS2650 Assembler Assignment #4 Template

; Student Name: Aaron Shaneen
; Assignment Due Date: April 18, 2014

INCLUDE Irvine32.inc
.data

vArrayTest BYTE "ABC" ,0
	       BYTE "DEF" ,0
	       BYTE "HIJ" ,0

;vArray BYTE "January" ,0  " "
;	   BYTE "February" ,0
;	   BYTE "March" ,0  " "
;	   BYTE "November" ,0

.code
main PROC

MOV eax, 0						; bits you are comparing for the month info
;MOV eax, 1	
;SUB eax, 1
MOV edx, offset [vArrayTest]
MOV bl, 9						; to multiply the eax
MUL bl							; acts on bl
ADD edx, eax
CALL WriteString

	XOR ecx, ecx
	CALL ReadChar
	EXIT
main ENDP

END main