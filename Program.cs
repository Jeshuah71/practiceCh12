// Chapter 12 practice arrays
// Those are just kind of types of ARRAYS 
int[ ] scores = new int[10];

scores[0] = 99;
scores[1] = 95;
scores[2] = 90;
Console.WriteLine(scores[0]);
Console.WriteLine(scores[1]);
Console.WriteLine(scores[2]);
int scored = Convert.ToInt32(Console.ReadLine());
int[] scores1 = new int[10];
//other way to use array 
int[] scores2 = new int[10] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };
//other Array's way
int[] array = new int[] { 4, 51, -7, 13, -20, 15, -8, 50, 100 };
int currentSmallest = int.MaxValue; 
for (int index = 0; index < array.Length; index++)
{
 if (array[index] < currentSmallest)
 currentSmallest = array[index];
}
Console.WriteLine(currentSmallest);

int[] array1 = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
for (int index = 0; index < array.Length; index++)
 total += array[index];
float average = (float)total / array.Length;
Console.WriteLine(average);

//I didn't know what to do for practice so I did one of the challenges.

int[] orig = new int[5];

for(int item = 0; item < 5; item++)
{
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    orig[item] = number;
}

int[] copy = new int[5];

for (int index = 0; index < 5; index++)
    copy[index] = orig[index];

for (int index = 0; index < 5; index++)
    Console.WriteLine($"{orig[index]} and {copy[index]}");
//Multidimensional array
int[,] twoDimensionalArray = new int[3, 3];

int[][] matrix = new int[3][];
matrix[0] = new int[] { 1, 2 };
matrix[1] = new int[] { 3, 4 };
matrix[2] = new int[] { 5, 6 };
Console.WriteLine(matrix[0][1]);

