using delegates;

Calculate calculator1 = Calculator.Sxvaoba;

double number1 = 10;
double number2 = 6;

double result1 = calculator1(number1, number2);
Console.WriteLine(result1);

////////////////////

Calculate calculator2 = Calculator.Divide;

double result2 = calculator2(number1, number2);
Console.WriteLine(result2);

///////////////////

Print print = new Print();

Action<string> printAction = print.PrintText;
printAction("Hello");

///////////////////////

double result3 = Calculator.Multiply(number1, number2);
Console.WriteLine(result3);

////////////////////////////////////

Event myEvent = new Event();
myEvent.Event1 += Event.EventHandler;
myEvent.CallEvent();