# Covid-and-Theatre-Tickets
CodeChef Difficulty 1077 Problem

Covid and Theatre Tickets
Mr. Chef is the manager of Code Cinemas. After a long break, the theatres are now open to the public again. To compensate for the loss in revenue due to Covid-19, Mr. Chef wants to maximize the profits for every show while also following the government guidelines.

Government Guidelines:
Intra-row spacing: If two people are seated in the same row, there must be at least one empty seat between them.

Inter-row spacing: If two people are seated in different rows, there must be at least one completely empty row between them.

That is, if people are seated in rows i and j such that i < j, there must exist a row k such that i < k < j and row k is completely empty.

Given the number of rows and the number of seats per row, find the maximum number of tickets Mr. Chef can sell while respecting the rules.

Input Format
The first line contains a single integer T — the number of test cases.

Each test case consists of a single line containing two space-separated integers:

N — number of rows

M — number of seats per row

Output Format
For each test case, print a single integer — the maximum number of tickets that can be sold under the given constraints.

Example
Input:

Copy
Edit
2
3 5
4 7
Output:

Copy
Edit
6
8
Explanation
Test Case 1:
Optimal seating: Use rows 0 and 2 (skip row 1)

Each row has 5 seats → maximum of ⌈5 / 2⌉ = 3 people per row

So total = 2 rows × 3 = 6

Test Case 2:
Use rows 0 and 2 (or 1 and 3)

Each row has 7 seats → ⌈7 / 2⌉ = 4 people per row

Total = 2 × 4 = 8
