<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">&lt;MyDocuments&gt;\GitHub\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// GroupBy returns a sequence of groups
// Each group has a 'key' and a value'
// GroupBy uses an expression to determine the group 'key'
// and which sequence items belong in that group
// the 'value' is the sequence of items in the group

// Let's start with the GroupBy extension method

var colors = CourseLib.ColorSource.GetColors();
var groupedResult = colors.GroupBy(c => c.ColorFamily );
var groupedResult1 = colors.GroupBy(c => c.BlueValue );


groupedResult1.Dump();

//groupedResult.ElementAt(2).Dump();