// See https://aka.ms/new-console-template for more information
using Session_07_Test;

Console.WriteLine("Hello, World!");

Console.WriteLine("Choose one of the available actions:" + (Environment.NewLine)
    +"0. Convert the input" + (Environment.NewLine)
    +"1. Uppercase the input" + (Environment.NewLine)
    +"2. Reverse the input");

int inputVal;
ActionRequest request = new ActionRequest();

if (Int32.TryParse(Console.ReadLine(), out inputVal))
{ request.EnumChoice = (ActionEnum)inputVal; }
else { Console.WriteLine("Wrong Input,try again"); }

Console.WriteLine("Enter a string or a decimal number: ");
request.Input = Console.ReadLine();


ActionResolver resolver = new ActionResolver(new MessageLogger());
ActionResponse response = new ActionResponse();
Console.ReadLine();
//MessageLogger ml = new MessageLogger();
//ml.Messages = new MessageLogger(DateTime.Now, response.Output);

response = resolver.Execute(request);
