<Query Kind="Statements" />

// Lambda expressions permit us to write the method inline

// Compiler creates an anonymous function in IL

// Lambda syntax with statement body
// can consist of any number of statements
Func<int, int> adderA, adderB, adderC, adderD;
adderA = (Int32 n) => { n += 2; return n + 1; };
Console.WriteLine(adderA(5));

// Lambda with expression body (not a statement block)
adderB = (Int32 n) => n + 1;
Console.WriteLine(adderB(10));

// Parameter type is omitted and inferred
adderC = (n) => n + 1;
Console.WriteLine(adderC(15));

// If there is just one parameter, parenthesis can be omitted
adderD = n => n + 1;
Console.WriteLine(adderD(20));
