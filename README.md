# csharp katana

###### Problem 01
```C#
List<int> myList = new List<int>(){1,2,3,4,5,6,7,8,9,10};
int threshold = 3;
var part1 = myList.Where(x=>x <= threshold);
threshold = 8;
var part2 = myList.Where(x=>x >= threshold);

foreach (var x in part1)
	Console.Write($"{x} ");
	
Console.WriteLine();
Console.WriteLine("------------------------------");

foreach (var x in part2)
	Console.Write($"{x} ");
	
Console.ReadLine();
```
Output
 1,2,3,4,5,6,7,8
 ------------------------------
 8,9,10
