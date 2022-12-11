Create a function that will return the roman numerals for a given non-negative, non-zero
integer. For reference, roman numerals are a string notation for decimals where different
letters represent different integer values as follows:
I = 1
V = 5
X = 10
L = 50
C = 100
D = 500
M = 1000
Letters are combined either in prefix or postfix to generate the numbers in between, up to a
maximum of 3 consecutive letters. For instance, VIII = 8, but IX = 9, because VIIII is invalid as it
contains 4 consecutive I’s.
A number containing several decimal digits is built by appending the Roman numeral equivalent
for each, from highest to lowest, as in the following examples:
39 = XXX + IX = XXXIX.
246 = CC + XL + VI = CCXLVI.
789 = DCC + LXXX + IX = DCCLXXXIX.
2,421 = MM + CD + XX + I = MMCDXXI.
Please provide a suitable test case with test data to demonstrate that your function works.

Solution:

Symbol	M		D	C	L	XL	X	IX	V	IV	I
Value	1000	500 100	50	40	10	9	5	4	1


59	0	0	0	1	0	1						LIX
Rem	59	59	59	9	9	0

49	0	0	0	0	4	1						XLIX
9	0

29	0	0	0	0	2	1						XXIX
9	0

Special cases : 40,90 - XL one number subtracted for another (50-10 & 100-10)
Works until 1999.

TDD solution
Go down the list and start with the bigger number first and check how many of this symbol do I need to add to the length of string symbol.
Check the remainder that still needs to be calculated against the list.
Check for special cases.