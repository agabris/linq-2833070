<Query Kind="Statements">
  <Connection>
    <ID>4c01dc4d-45f3-4d6d-ad1b-0404aad51552</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-STCTJ4E</Server>
    <Database>NORTHWIND</Database>
  </Connection>
</Query>

// basic knowledge of generics is key to work with LINQ

// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/
// .NET allows for creating generic classes, methods, interfaces, delegates

// the type author creates the generic item

// the type user specifies the concrete type


var saleAmounts = new List<decimal> { 21.30M, 92.35M, 14.00M };

var total = saleAmounts.Sum(); 

total.Dump("TotalSum");

IEnumerable<int> numbers= new List<int> {1,3,5,7, 13, 76, 89};

decimal totalB = numbers.Sum()/numbers.Count();

totalB.Dump("averageB");
saleAmounts.OrderBy(a => a ).Dump();