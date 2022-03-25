<Query Kind="Statements">
  <Connection>
    <ID>4c01dc4d-45f3-4d6d-ad1b-0404aad51552</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-STCTJ4E</Server>
    <Database>NORTHWIND</Database>
  </Connection>
  <Output>DataGrids</Output>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
  <DisableMyExtensions>true</DisableMyExtensions>
  <CopyLocal>true</CopyLocal>
</Query>

//Database Northwind
	var y = from cat in Categories
	//orderby cat.CategoryID descending
	select cat;
	
	var w = y.First();
	//var z =y.Last();
	// Last() does not work for databases
	// ElementAt(1) does not work for databases
	
w.Dump ("ElementAt 1");
	
//