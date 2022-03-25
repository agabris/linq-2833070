<Query Kind="Statements">
  <Namespace>System.Windows.Forms.DataVisualization.Charting</Namespace>
</Query>

// define a function to call from custom aggregator

var setA =	Enumerable.Range(1, 9).Where(x => x % 3 == 0);
var setB  = from nr in setA
	select Math.Sqrt(nr);


var multipleOf = setA.Aggregate((first, second) => first * second);


// set the initial seed (accumulator value)
var anotherMultipleOf = setA.Aggregate(0,(first, second) => first + second);

setA.Dump();
multipleOf.ToString("N0").Dump();
anotherMultipleOf.ToString("N0").Dump();