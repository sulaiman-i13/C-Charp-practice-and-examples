Console.WriteLine("=========================simple================================");
Console.WriteLine("=========================simple================================");

int[] myArray = [1, 2, 3, 4, 5];
foreach (int i in myArray)
    Console.WriteLine(i);

Console.WriteLine("==========================multi dimensional===============================");
Console.WriteLine("==========================multi dimensional===============================");
int[,] myMultiDimensionArray = new[,]{
     {1,2,3,4},
     {1,2,3,4},
     {1,2,3,4},
     {1,2,3,4},
    };

for (int i = 0; i < myMultiDimensionArray.GetLength(0); i++)
    for (int j = 0; j < myMultiDimensionArray.GetLength(1); j++)
        Console.WriteLine(myMultiDimensionArray[i, j]);
Console.WriteLine("===========================jagged==============================");
Console.WriteLine("===========================jagged==============================");

int[][] myJaggedArray = new int[][] {
   new int[] { 1, 2, 3, 4 },
   new int[]  { 5, 6, 7 },
    new int[] { 8, 9, 0, 1 },
};
for (int i = 0; i < myJaggedArray.Length; i++)
    for (int j = 0; j < myJaggedArray[i].Length; j++)
        Console.WriteLine(myJaggedArray[i][j]);

Console.WriteLine("===========================indices==============================");
Console.WriteLine("===========================indices==============================");

var myArr = new string[] { "s", "u", "l", "a", "i", "m", "a", "n" };
Console.WriteLine("myArr[2..]");
var a1 = myArr[2..];
foreach (string i in a1) Console.WriteLine(i);
Console.WriteLine("myArr[..3]");
var a2 = myArr[..3];
foreach (string i in a2) Console.WriteLine(i);
Console.WriteLine("myArr[2..4]");
var a3 = myArr[2..4];
foreach (string i in a3) Console.WriteLine(i);
Console.WriteLine("myArr[^3..]");
var a4 = myArr[^3..];
foreach (string i in a4) Console.WriteLine(i);
Console.WriteLine("myArr[2..^2]");
var a5 = myArr[2..^2];
foreach (string i in a5) Console.WriteLine(i);
Console.WriteLine("myArr[..^2]");
var a6 = myArr[..^2];
foreach (string i in a6) Console.WriteLine(i);