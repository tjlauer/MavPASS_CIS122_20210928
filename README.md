# MavPASS_CIS122_20210928

## Class Inheritance and Polymorphism!

Today we went over everything we have learned in class over the past weeks regarding class inheretance.

<hr>

The code we wrote during the session touches on the following...<br><br>
• class variables, aka private variables<br>
• gets and sets, aka "assessor methods" or "properties"<br>
• constructors, including base() vs. this()<br>
• ToString()<br>
• inheritance<br>
• In Main, making a list and looping through a bunch of items using polymorphism<br>
• sealed vs. abstract<br>
• virtual methods, and the keyword override<br>

<hr>

As always, if you have any question please send me an email at thomas.lauer@mnsu.edu.

Best of luck on the quiz, and I will see you on Thursday for some more logic problems!

<hr><br>

## The Assignment

1)	Create an abstract class “Clothing”<br>
a)	Give it the following properties:<br>
---- i)   int id<br>
---- ii)	string category<br>
---- iii)	string brand<br>
---- iv)	string color<br>
---- v)	  string material<br>
---- vi)	double price<br>
b)	Create BOTH full and empty constructors<br>
c)	Create a method “string ToString()”<br>
d)	Create a virtual method “void Fold()”<br>
---- i)	  Write “Base folding action.” to the console.<br>

2)	Create a sealed class “Shirt”<br>
a)	Inherit the “Clothing” class<br>
b)	Give it the following properties:<br>
---- i)	  string size<br>
---- ii)	string design<br>
---- iii)	string type<br>
c)	Create BOTH full and empty constructors<br>
d)	Create a method “string ToString()”<br>
e)	Create a method “void Fold()”<br>
---- i)	Write “Folding a shirt.” to the console.<br>

3)	Create a sealed class “Pants”<br>
a)	Inherit the “Clothing” class<br>
b)	Give it the following properties:<br>
---- i)	  int waist<br>
---- ii)	int length<br>
---- iii)	string style<br>
c)	Create BOTH full and empty constructors<br>
d)	Create a method “string ToString()”<br>
e)	Create a method “void Fold()”<br>
---- i)	Write “Folding a pair of pants.” to the console.<br>

4)	Create a sealed class “Socks”<br>
a)	Inherit the “Clothing” class<br>
b)	Give it the following properties:<br>
---- i)	  string size<br>
---- ii)	string style<br>
c)	Create BOTH full and empty constructors<br>
d)	Create a method “string ToString()”<br>
e)	Create a method “void Fold()”<br>
---- i)	Write “Folding a pair of socks.” to the console.<br>

5)	In main...<br>
a) Create a list “Inventory” that contains:<br>
---- i)	  5 "Shirt" objects<br>
---- ii)	3 "Pants" objects<br>
---- iii)	7 "Socks" objects<br>
b) Print and Fold all objects in the "Inventory" list.<br>

