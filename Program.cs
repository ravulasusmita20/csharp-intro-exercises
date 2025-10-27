using System;

int rows = 5;
for (int r = 1; r <= rows; r++)
{
    for (int s = 0; s < rows - r; s++) Console.Write(' ');
    for (int k = 0; k < 2 * r - 1; k++) Console.Write('*');
    Console.WriteLine();
}
