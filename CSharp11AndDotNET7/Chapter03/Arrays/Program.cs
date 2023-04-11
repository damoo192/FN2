﻿string[] names;

names = new string[4];

names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";

for (int i = 0; i < names.Length; i++)
{
    WriteLine(names[i]);
}

string[,] grid1 = new[,]
{
    { "Alpha", "Beta", "Gamma", "Delta" },
    { "Anne", "Ben", "Charlie", "Doug" },
    { "Aardvark", "Bear", "Cat", "Dog" }
};

WriteLine(grid1[1,1]);
WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(0)}");
WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(0)}");
WriteLine($"Lower bound of the second dimension is: {grid1.GetLowerBound(1)}");
WriteLine($"Lower bound of the second dimension is: {grid1.GetLowerBound(1)}");

for (int row = 0;row < grid1.GetUpperBound(0); row++)
{
    for (int col = 0; row < grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Colomn {col}: {grid1[row, col]}");
    }
}

string[][] jagged = new[] // array of string arrays
{
new[] { "Alpha", "Beta", "Gamma" },
new[] { "Anne", "Ben", "Charlie", "Doug" },
new[] { "Aardvark", "Bear" }
};

WriteLine("Upper bound of array of arrays is: {0}", jagged.GetUpperBound(0));
for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
    WriteLine("Upper bound of array {0} is: {1}",
    arg0: array,
    arg1: jagged[array].GetUpperBound(0));
}

for (int row = 0; row <= jagged.GetUpperBound(0); row++)
{
    for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
    {
        WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
    }
}

// Pattern matching with arrays

int[] sequentialNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] oneTwoNumbers = new int[] { 1, 2 };
int[] oneTwoTenNumbers = new int[] { 1, 2, 10 };
int[] oneTwoThreeTenNumbers = new int[] { 1, 2, 3, 10 };
int[] primeNumbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
int[] fibonacciNumbers = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
int[] emptyNumbers = new int[] { };
int[] threeNumbers = new int[] { 9, 7, 5 };
int[] sixNumbers = new int[] { 9, 7, 5, 4, 2, 10 };

WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");

static string CheckSwitch(int[] values) => values switch
{
    [] => "Empty array",
    [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
    [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
    [1, 2] => "Contains 1 then 2.",
    [int item1, int item2, int item3] =>
      $"Contains {item1} then {item2} then {item3}.",
    [0, _] => "Starts with 0, then one other number.",
    [0, ..] => "Starts with 0, then any range of numbers.",
    [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
    [..] => "Any items in any order.",
};
