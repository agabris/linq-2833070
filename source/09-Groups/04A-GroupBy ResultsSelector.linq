<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">&lt;MyDocuments&gt;\GitHub\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Change the key name or value name 
// with the resultSelector
var colors = CourseLib.ColorSource.GetColors();
// use result selector to customize the generated sequence
var groupedByColorFamily = colors.GroupBy(keySelector: x => x.ColorFamily,
								resultSelector: (key, value) => new {Family= key, Colors= value },
								elementSelector: y => new { y.ColorName, y.HexValue }
								);

//groupedByColorFamily.Dump();

var groupedByColorF = colors.GroupBy(keySelector: x => x.ColorFamily,
								elementSelector: y => new {y.ColorFamily, y.ColorName, y.HexValue }
								);


groupedByColorF.Dump();
