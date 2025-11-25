# Odd / Even Sorter (C# Console App)

A simple C# console application that reads a non-negative integer `n` and then:
- prints all numbers from `0` to `n` (inclusive),
- classifies each number as **even** or **odd**,
- counts how many even/odd numbers there are,
- computes the sum of even numbers and the sum of odd numbers.

## Features
- Input validation using `int.TryParse`
- Uses a `while` loop to iterate from `0` to `n`
- Displays totals and sums for both even and odd numbers

## How It Works
1. The program asks the user to enter a number `n`.
2. It loops from `count = 0` up to `n`.
3. For each number:
   - if `count % 2 == 0` → it is even,
   - otherwise → it is odd.
4. It prints the number, updates counters, and adds to the correct sum.
5. At the end, it prints:
   - total even numbers and their sum,
   - total odd numbers and their sum.

## Example Output
If the input is `6`, the output will look like:


Sort the chosen number into odd/even:

6
____________________________________
Even number:______0
Odd number:__________1
Even number:______2
Odd number:__________3
Even number:______4
Odd number:__________5
Even number:______6
_____________________________________
Total/even numbers:      4
Sum/even numbers =       12
--------------------------------------
Total/odd numbers:       3
Sum/odd numbers =        9

...
