// See https://aka.ms/new-console-template for more information


using Session_07;

//ActionRequest request = new ActionRequest()
//{
//};
Console.WriteLine("Choose one of the available actions:" + (Environment.NewLine)
    + "0. Convert the input" + (Environment.NewLine)
    + "1. Uppercase the input" + (Environment.NewLine)
    + "2. Reverse the input");

int inputVal;
ActionRequest request = new ActionRequest();

if (Int32.TryParse(Console.ReadLine(), out inputVal))
{ request.Action = (ActionEnum)inputVal; }
else { Console.WriteLine("Wrong Input,try again"); }

ActionResponse response = new ActionResponse();

ActionResolver resolver = new ActionResolver();

response = resolver.Execute(request);

// DISPLAY MESSAGES FROM LOGGER

resolver.Logger.ReadAll();

Console.ReadLine();




