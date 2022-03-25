<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">&lt;MyDocuments&gt;\GitHub\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// The Where clause filters the sequence based on a predicate function
// The predicate is applied to each element in the sequence.
// define a predicate that uses a boolean expression 
// to determine what to return in filtered sequence


var q = from color in CourseLib.ColorSource.GetColors()
				//orderby color.ColorFamily	//order by (like at SQL) seems to be here useless
				where (color.ColorName.Contains("Red")  )
				select (color.ColorFamily, color.ColorName);
				//select (color);


// If more than 1 columns are selected you should use ( )
				
q.OrderBy(x => x.ColorFamily).Dump();

//ISSUE Order by does not work
