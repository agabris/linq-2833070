<Query Kind="Statements">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">&lt;MyDocuments&gt;\GitHub\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Challenge:

// create a query expression that outputs a sequence 
// show ColorName 
// and shows a RGB color formula 
// "rgb (a, b, c)" where 
//  a = redvalue, g = greenvalue, b = bluevalue
// for example,

// SpringGreen, rgb (000, 255, 127)
// LightYellow, rgb (255, 255, 224 


// optional requirement, format number values with three place
// optional requirement, sort by GreenValue
// example 23 is formatted as 023

/*
var q0 = from color in CourseLib.ColorSource.GetColors()
select color;
//SQL Select color.* from CourseLib.ColorSource.GetColors() color

//q0.Dump();

var q1 = from color in CourseLib.ColorSource.GetColors()
select color.ColorName;
//SQL Select color.ColorName from CourseLib.ColorSource.GetColors() color

//q1.Dump();



var q2 = from color in CourseLib.ColorSource.GetColors()
select (color.ColorName, color.BlueValue, color.GreenValue, color.RedValue);
//SQL Select color.ColorName from CourseLib.ColorSource.GetColors() color

q2.Dump();

var q3 = from color in CourseLib.ColorSource.GetColors()
orderby color.BlueValue,color.ColorName
// order by a select elé kerül
select (color.ColorName, color.BlueValue.ToString("D3"), color.GreenValue.ToString("D3"), color.RedValue.ToString("D4"));

//SQL Select color.ColorName from CourseLib.ColorSource.GetColors() color

q3.Dump();

*/


var q4 = from color in CourseLib.ColorSource.GetColors()
orderby color.BlueValue,color.ColorName
//SQL Select color.ColorName from CourseLib.ColorSource.GetColors() color
select new {color.ColorName , Formula= $"rgb({color.BlueValue.ToString("D5")}, {color.GreenValue.ToString("D3")}, {color.RedValue.ToString("D3")} )"};
// Formula= $"rgb({color.BlueValue.ToString("D5")}, {color.GreenValue.ToString("D3")}, {color.RedValue.ToString("D3")} )"} = Calculated column values with name

q4.Dump();