<Query Kind="Statements">
  <Connection>
    <ID>54bf9502-9daf-4093-88e8-7177c129999f</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Provider>System.Data.SqlServerCe.4.0</Provider>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\DemoDB.sdf</AttachFileName>
    <Persist>true</Persist>
  </Connection>
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">&lt;MyDocuments&gt;\GitHub\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
  <Namespace>CourseLib</Namespace>
</Query>

//https://www.colorschemer.com/color-names/
var q =  from cat in Categories
where cat.CategoryID >= 2
orderby cat.CategoryName
select  new {cat.CategoryID, cat.CategoryName, cat.Description};

q.Dump();


var x = from prod in Products
select prod;
x.Dump();