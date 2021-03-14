TITLE CS2650 Assembler Assignment #3

; Student Name: Aaron Shaneen
; Assignment Due Date: April 11, 2014

INCLUDE Irvine32.inc

.data

	; CLASS INFO

	SemStr BYTE "CS2650 Spring Semester 2014",0
	AssStr BYTE "Assembler Assignment #1",0
	NameStr BYTE "Aaron Shaneen" ,0
	QAStr BYTE "Please enter an MP3 frame header in hex format: " ,0

	; MPEG VERSIONS

	MpegV25 BYTE "MPEG Version 2.5" ,0
	MpegV20 BYTE "MPEG Version 2.0" ,0
	MpegV10 BYTE "MPEG Version 1.0" ,0
	MpegVRE BYTE "MPEG Version Reserved" ,0

	; MPEG LAYERS

	MpegL3 BYTE "Layer III" ,0
	MpegL2 BYTE "Layer II" ,0
	MpegL1 BYTE "Layer I" ,0
	MpegLRE BYTE "Layer Reserved" ,0

	; MPEG SAMPLING RATE

	MpegSR44 BYTE "MPEG Samepling Rate 44100 Hz" ,0
	MpegSR22 BYTE "MPEG Samepling Rate 22050 Hz" ,0
	MpegSR11 BYTE "MPEG Samepling Rate 11025 Hz" ,0
	MpegSR48 BYTE "MPEG Samepling Rate 48000 Hz" ,0
	MpegSR24 BYTE "MPEG Samepling Rate 24000 Hz" ,0
	MpegSR12 BYTE "MPEG Samepling Rate 12000 Hz" ,0
	MpegSR32 BYTE "MPEG Samepling Rate 32000 Hz" ,0
	MpegSR16 BYTE "MPEG Samepling Rate 16000 Hz" ,0
	MpegSR08 BYTE "MPEG Samepling Rate 8000 Hz" ,0
	MpegSRRE BYTE "MPEG Samepling Rate Reserved" ,0

.code
main PROC

	CALL DisplaySemester
	CALL DisplayAssignment
	CALL DisplayName
	CALL DisplayHeader
	CALL DisplayVersion
	CALL DisplayLayer
	CALL DisplaySample

	XOR ecx, ecx
	CALL ReadChar
	EXIT
	
main ENDP

	; LABELS

	; DISPLAY SEMESTER

	DisplaySemester:

	; Clear the screen
	CALL Clrscr

	; Set cursor position
	MOV dh, 12d
	MOV dl, 12d
	CALL Gotoxy

	; Set the OFFSET of edx
	MOV edx, OFFSET SemStr
	CALL WriteString

	; End Display Semester
	ret

	; DISPLAY ASSIGNMENT

	DisplayAssignment:

	; Set cursor position
	MOV dh, 13d
	MOV dl, 12d
	CALL Gotoxy

	; Set the OFFSET of edx
	MOV edx, OFFSET AssStr
	CALL WriteString

	; End Display Assignment
	ret

	; DISPLAY NAME

	DisplayName:

	; Set cursor position
	MOV dh, 14d
	MOV dl, 12d
	CALL Gotoxy

	; Set the OFFSET of edx
	MOV edx, OFFSET NameStr
	CALL WriteString

	; End Display Name
	ret

	; DISPLAY HEADER

	DisplayHeader:

	; Set cursor position
	MOV dh, 16d
	MOV dl, 12d
	CALL Gotoxy

	; Set the OFFSET of edx
	MOV edx, OFFSET QAStr
	CALL WriteString
	
	; Read user input
	CALL ReadHex

	; Copy user's input for later use
	MOV ecx, eax

	; End Display Header
	ret

	; DISPLAY VERSION

	DisplayVersion:

	; Set cursor position
	MOV dh, 17d
	MOV dl, 12d
	CALL Gotoxy

	; MOV eax, 0FFFB9264h	; TEMP (actual value comes from your DisplayMP3Header)

	; Isolate target bits with ANDING
		   ; AAAAAAAAAAABBCCDEEEEFFGHIIJJKLMMh
	AND eax, 00000000000110000000000000000000b

	; Shift working bits to the right
	SHR eax, 19

	; Compare working bits
	CMP eax, 11b
	JZ DisplayMpegV10

	CMP eax, 10b
	JZ DisplayMpegV20

	CMP eax, 00b
	JZ DisplayMpegV25

	; Default case (CMP eax, 01b)
	MOV edx, offset MpegVRE
	JMP DisplayVString

	; VERSION FUNCTIONS

	DisplayMpegV10:
	MOV esi, 10d
	MOV edx, offset MpegV10
	JMP DisplayVString

	DisplayMpegV20:
	MOV esi, 20d
	MOV edx, offset MpegV20
	JMP DisplayVString

	DisplayMpegV25:
	MOV esi, 25d
	MOV edx, offset MpegV25
	JMP DisplayVString

	; Display Version String
	DisplayVString:
	CALL WriteString

	; End Display Version
	ret

	; DISPLAY LAYER

	DisplayLayer:

	; Set cursor position
	MOV dh, 18d
	MOV dl, 12d
	CALL Gotoxy

	; Reset eax to original input
	MOV eax, ecx

	; Isolate target bits with ANDING
		   ; AAAAAAAAAAABBCCDEEEEFFGHIIJJKLMMh
	AND eax, 00000000000001100000000000000000b

	; Shift working bits to the right
	SHR eax, 17

	; Compare working bits
	CMP eax, 11b
	JZ DisplayMpegL1

	CMP eax, 10b
	JZ DisplayMpegL2

	CMP eax, 01b
	JZ DisplayMpegL3

	; Default case (CMP eax, 00b)
	MOV edx, offset MpegLRE
	JMP DisplayLString

	; LAYER FUNCTIONS

	DisplayMpegL1:
	MOV edx, offset MpegL1
	JMP DisplayLString

	DisplayMpegL2:
	MOV edx, offset MpegL2
	JMP DisplayLString

	DisplayMpegL3:
	MOV edx, offset MpegL3
	JMP DisplayLString

	; Display Layer String
	DisplayLString:
	CALL WriteString

	; End Display Layer
	ret

	; DISPLAY SAMPLE

	DisplaySample:

	; Set cursor position
	MOV dh, 19d
	MOV dl, 12d
	CALL Gotoxy

	; Reset eax to original input
	MOV eax, ecx

	; Isolate target bits with ANDING
		   ; AAAAAAAAAAABBCCDEEEEFFGHIIJJKLMMh
	AND eax, 00000000000000000000110000000000b

	; Shift working bits to the right
	SHR eax, 10

	; Compare working bits
	
	CMP eax, 00b
	JMP CompVersion1

	CMP eax, 01b
	JMP CompVersion2
	
	CMP eax, 10b
	JMP CompVersion3
	
	; Default case (CMP eax, 11b)
	MOV edx, offset MpegSRRE
	JMP DisplaySString

	; SAMPLE FUNCTIONS

	CompVersion1:
	CMP esi, 10d
	JZ DisplayMpegSR44
	CMP esi, 20d
	JZ DisplayMpegSR22
	CMP esi, 25d
	JZ DisplayMpegSR11

	CompVersion2:
	CMP esi, 10d
	JZ DisplayMpegSR48
	CMP esi, 20d
	JZ DisplayMpegSR24
	CMP esi, 25d
	JZ DisplayMpegSR12

	CompVersion3:
	CMP esi, 10d
	JZ DisplayMpegSR32
	CMP esi, 20d
	JZ DisplayMpegSR16
	CMP esi, 25d
	JZ DisplayMpegSR08

	DisplayMpegSR44:
	MOV edx, offset MpegSR44
	JMP DisplaySString

	DisplayMpegSR22:
	MOV edx, offset MpegSR22
	JMP DisplaySString

	DisplayMpegSR11:
	MOV edx, offset MpegSR11
	JMP DisplaySString

	DisplayMpegSR48:
	MOV edx, offset MpegSR48
	JMP DisplaySString

	DisplayMpegSR24:
	MOV edx, offset MpegSR24
	JMP DisplaySString

	DisplayMpegSR12:
	MOV edx, offset MpegSR12
	JMP DisplaySString

	DisplayMpegSR32:
	MOV edx, offset MpegSR32
	JMP DisplaySString

	DisplayMpegSR16:
	MOV edx, offset MpegSR16
	JMP DisplaySString

	DisplayMpegSR08:
	MOV edx, offset MpegSR08
	JMP DisplaySString

	; Display Sampling String
	DisplaySString:
	CALL WriteString

	; End Display Sample
	ret

END main