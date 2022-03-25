<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">&lt;MyDocuments&gt;\GitHub\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Work with a nested group sequence

var colors = CourseLib.ColorSource.GetColors();
// use result selector to customize the generated sequence
var grouped = colors.GroupBy(keySelector: x => x.ColorFamily,
								elementSelector: y => new { y.ColorName, y.HexValue },
								resultSelector: (key, value) => new { Family = key, Colors = value });


// how to access without .Dump

foreach (var group in grouped)
{
	string txt;
	int i ;
	Console.WriteLine(group.Family);
	
	i= 0;
	
	foreach (var color in group.Colors)
	{	
		i++;
		txt = $".  {color.ColorName}";
		//Console.WriteLine($"   {color.ColorName}");
		Console.WriteLine("   " +i + txt);
		
	}
	
	Console.WriteLine();
}