<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">&lt;MyDocuments&gt;\GitHub\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>


var colors = CourseLib.ColorSource.GetColors();
// use element selector to specify what properties on the members of the group

var groupedByColorFamily = colors.GroupBy(keySelector: x => x.ColorFamily,
	 elementSelector: y => new { y.ColorName, y.HexValue });

//SQL: Select y.ColorName, y.HexValue from colors c group by c.ColorFamily

groupedByColorFamily.Dump();