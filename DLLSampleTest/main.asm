include irvine32.inc
.data
;no static data
.code
;-----------------------------------------------------
;Sum PROC Calculates 2 unsigned integers
;Recieves: 2 DWord parametes number 1 and number 2
;Return: the sum of the 2 unsigned numbers into the EAX
;------------------------------------------------------
Sum PROC int1:DWORD, int2:DWORD
	mov eax, int1
	add eax, int2
	ret
Sum ENDP

;-----------------------------------------------------
;SumArr PROC Calculates Sum of an array
;Recieves: Offset and the size of an array
;Return: the sum of the array into the EAX
;------------------------------------------------------
SumArr PROC arr:PTR DWORD, sz:DWORD
	push esi
	push ecx

	mov esi, arr
	mov ecx, sz
	mov eax, 0
	sum_loop:
		add eax, DWORD PTR [esi]
		add esi, 4
	loop sum_loop
	
	pop ecx
	pop esi
	Ret
SumArr ENDP

;----------------------------------------------------------------
;Sum PROC convert an array of bytes from lower case to upper case
;Recieves: offset of byte array and it's size
;---------------------------------------------------------------
ToUpper PROC str1:PTR BYTE, sz:DWORD
	push esi
	push ecx
	
	mov esi, str1
	mov ecx, sz
	l1:
		;input validations (Limitation the char to be between a and z)
		cmp byte ptr [esi], 'a'
		jb skip
		cmp byte ptr [esi], 'z'
		ja skip

		and byte ptr [esi], 11011111b
		skip:
		inc esi
	loop l1
	
	pop ecx
	pop esi
	ret
ToUpper ENDP


;#######################################################
;#					Project Procedures					#
;#######################################################



Invert proc redChannel:PTR DWORD, greenChannel:PTR DWORD, blueChannel:PTR DWORD, imageSize: DWORD
	PUSHAD


	MOV ECX, IMAGESIZE
	MOV ESI, REDCHANNEL
	L1:
		MOV EBX, 255
		MOV EAX, [ESI]
		SUB EBX, EAX
		MOV EAX, EBX
		CMP EAX, 0
		JL NEGATIVEVAL1
		
		JMP SKIP1

		NEGATIVEVAL1:
		MOV EAX, 0


		SKIP1:
		MOV [ESI], EAX
		ADD ESI, 4
		
	LOOP L1

		MOV ECX, IMAGESIZE
	MOV ESI, GREENCHANNEL

	L2:
		MOV EBX, 255
		MOV EAX, [ESI]
		SUB EBX, EAX
		MOV EAX, EBX
		CMP EAX, 0
		JL NEGATIVEVAL2
		
		JMP SKIP2

		NEGATIVEVAL2:
		MOV EAX, 0


		SKIP2:
		MOV [ESI], EAX
		ADD ESI, 4
		
	LOOP L2

		MOV ECX, IMAGESIZE
	MOV ESI, BLUECHANNEL

	L3:
		MOV EBX, 255
		MOV EAX, [ESI]
		SUB EBX, EAX
		MOV EAX, EBX
		CMP EAX, 0
		JL NEGATIVEVAL3
		
		JMP SKIP3

		NEGATIVEVAL3:
		MOV EAX, 0


		SKIP3:
		MOV [ESI], EAX
		ADD ESI, 4
		
	LOOP L3

	POPAD
	RET
Invert endp







; DllMain is required for any DLL
DllMain PROC hInstance:DWORD, fdwReason:DWORD, lpReserved:DWORD
mov eax, 1 ; Return true to caller.
ret
DllMain ENDP
END DllMain