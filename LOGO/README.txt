LOGO coopilator
A homebrew version of the LOGO program, made in class. 
Allows to draw using a simple code language based on pixels and degrees.  The original program supose to be about a turtle which is drawing in the sand so I started with that idea. The main point (or turtle) is show by a green arrow.
Heres is the list of commands:

AV/FW = Go Forwards
GD/TR = Turn Right
GI/TL = Turn Left
VC/GH = Go Home (Return to the starting point)
LL/PU = Pencil Up (Move without drawing)
BL/PD = Pencil Down (Continue drawing)
ET/HT: Hide Turtle (Hides the arrow but keeps drawing)
MT/ST = Show Turtle (Shows the arrow again)
CC = Change color: 0 Black, 1 Blue, 2 Red, 3 Green, 4 Yellow 
RE = Repeat commands. For this command you need to use '{' and '}' to delimit which commands you want to repeat. When using this command is necesary to use the follow syntax:
	RE 4
	{
	AV 50
	TR 90
	}

The program also allows you to save the code and reopen it later to keep working on it.
