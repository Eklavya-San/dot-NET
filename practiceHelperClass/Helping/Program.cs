// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MathLow engine = new MathLow() ;
int result = engine.minus(40,21);
Console.WriteLine(result);
Console.WriteLine(engine.sum(45,23));

Console.WriteLine("Division = "+engine.div(34,2));