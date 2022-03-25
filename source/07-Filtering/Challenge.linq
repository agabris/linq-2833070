<Query Kind="Program">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">&lt;MyDocuments&gt;\GitHub\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

void Main()
{
	// challenge
	
	// The ColorSource data has some invalid data 
	// in the ColorName and HexValue properties.
	
	// 1.
	// Write a query expression that finds ColorName values that contain hyphens ("-")
	// Also find HexValues that are not valid hexadecimal values (0-9, A, B, C, D, E, F)
	// FFFF00 is valid
	// FF34T3 is invalid because it has an invalid char (T)
	
	// Combine both these tests into a single query expression!
	
	
	
	// use this data source
	// CourseLib.ColorSource.GetColors()
	
	
	
		var q1 = from color in CourseLib.ColorSource.GetColors()
		where IsHexa(color.HexValue)==false  || color.ColorName.Contains("-")
		select new {color.ColorFamily, color.ColorName, color.HexValue }  ;
	
		q1.Dump();
	
	
	
}

// You can define other methods, fields, classes and namespaces here

public bool IsHexa(string test )
{
	//bool out= true ;
	//List<string> ch = new List<string> { "0", "1","2","3","4","5","6","7","8","9","A", "B", "C", "D", "E", "F"}
	
	//Based on https://exceptionshub.com/check-a-string-to-see-if-all-characters-are-hexadecimal-values.html
	
	// For C-style hex notation (0xFF) you can use @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"
    return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");

}
