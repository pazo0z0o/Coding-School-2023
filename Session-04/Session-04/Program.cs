// See https://aka.ms/new-console-template for more information

using Session_04;
using System.Reflection;

//Excercise 1: Print a simple Hello + name greeting  
ExcOne progOne = new ExcOne();
progOne.Greeting();

//Excercise 2: Addition and Division of 2 numbers 
ExcTwo progTwo = new ExcTwo();
Console.WriteLine("The result of x+y equals : " + progTwo.Addition());

Console.WriteLine("The result of x/y equals : " + progTwo.Division() + "\n");

//Excercise 3: Show the result of varius operations
ExcThree progThree = new ExcThree();
progThree.Calculation1();
progThree.Calculation2();
progThree.Calculation3();
progThree.Calculation4();
progThree.Calculation5();

//Simple gender/age message
ExcFour progFour = new ExcFour();
progFour.genderAndAge();

//Seconds Converter into mins,hours,days, years
ExcFive progFive = new ExcFive();
progFive.TimeConversions();

//Same as ExcFive, but this time with the use of TimeSpan 
ExcSix progSix = new ExcSix();
progSix.DateTimeLib();

//Temp converter from Celsius to Fahrenheit and Kelvin
ExcSeven progSeven = new ExcSeven();
progSeven.TenpConverter();