// See https://aka.ms/new-console-template for more information

using Session_05;

int[] arr = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
/*
//1. Take a given string and reverse it
ExOne reverse = new ExOne();
Console.WriteLine(reverse.strReversal());

Console.WriteLine("------------------------------------------------------");

//2. Give the product or sum of all the numbers in the range of given integer
ExTwo scuffedCalc = new ExTwo();
Console.WriteLine(scuffedCalc.SumOrProd());
Console.WriteLine("------------------------------------------------------");
//3. give all the prime numbers in the range given by the chosen integer
ExThree primes = new ExThree();
primes.FindPrimes();
Console.WriteLine("------------------------------------------------------");
//4.Cartesian Product of 2 tables
ExFour cartesianProd = new ExFour();
cartesianProd.tableXProd();
Console.WriteLine("------------------------------------------------------");*/
//5. Sorting an array
ExFive sortArr = new ExFive();

Console.WriteLine("Initial array ");
foreach (int i in arr) { Console.Write(+ i + " "); }

Console.WriteLine(Environment.NewLine);

sortArr.InsertionSort(arr);

















