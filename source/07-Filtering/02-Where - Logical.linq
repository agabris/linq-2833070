<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">&lt;MyDocuments&gt;\GitHub\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Where:  any valid boolean expression is acceptable

// Use &&, &, ||, | , !, ^


var q1 = from color in CourseLib.ColorSource.GetColors()
				where color.ColorFamily == CourseLib.ColorFamily.Orange
				&& color.ColorName.Contains(color.ColorFamily.ToString()) && color.ColorName.ToString() != color.ColorFamily.ToString()
				select new{ color.ColorName, color.ColorFamily};


q1.Dump("&&");

var q2 = from color in CourseLib.ColorSource.GetColors()
				 where color.ColorFamily == CourseLib.ColorFamily.Blue
				 ||    color.ColorFamily == CourseLib.ColorFamily.Yellow
				 select color;


q2.Dump("||");