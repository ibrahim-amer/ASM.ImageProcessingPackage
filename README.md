# ASM.ImageProcessingPackage
This repository is made for Assembly Language course at FCIS ASU.

## Solution Structure
The solution contains three projects as follows:
1. Project: assembly language dynamic link library (DLL) project.
2. CsharpGUI: is a C# Windows form application which will be the main presentation layer to the user. It also will call all the functions from the DLL file produced by the the assembly DLL project.
3. Csharp.ConsoleApp: It is a C# console application. This project demonstrates how functions can be called from assembly DLL file inside C#. There are three examples: 
	- Sum: returns the summation of two given numbers.
	- SumArr: returns the summation of a given array of integers.
	- ToUpper: converts all the characters of a given string to upper case.
	This project is an example only and it is not required to be delivered. 
