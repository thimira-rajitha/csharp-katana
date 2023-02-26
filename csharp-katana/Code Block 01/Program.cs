using System.Collections.Generic;

List<int> myList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int threshold = 3;
var part1 = myList.Where(x => x <= threshold);

threshold = 8;
var part2 = myList.Where(x => x >= threshold);

foreach (var x in part1)
    Console.Write($"{x} ");

Console.WriteLine();
Console.WriteLine("------------------------------");

foreach (var x in part2)
    Console.Write($"{x} ");









Console.WriteLine();
Console.WriteLine("-----------------------------------------------------");

int threshold_2 = 3;
var part3 = myList.Where(x => x <= threshold_2).ToList().AsReadOnly();

threshold_2 = 8;
var part4 = myList.Where(x => x >= threshold_2).ToList().AsReadOnly();

foreach (var x in part3)
    Console.Write($"{x} ");

Console.WriteLine();
Console.WriteLine("------------------------------");

foreach (var x in part4)
    Console.Write($"{x} ");

Console.ReadLine();




