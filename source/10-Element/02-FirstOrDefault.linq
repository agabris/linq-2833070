<Query Kind="Statements">
  <Connection>
    <ID>4c01dc4d-45f3-4d6d-ad1b-0404aad51552</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-STCTJ4E</Server>
    <Database>NORTHWIND</Database>
  </Connection>
</Query>

// The First and Last methods throw an exception if source contains no elements. 


// use FirstOrDefault, LastOrDefault

List<int> numbers = new List<int> { 50, 4, 10, 3, 90, 8, -60, 7, 20, 5 };

List<int> emptyNumbers = new List<int>();
List<string> emptyStrings  = new List<string>();
List<bool> emptyBools  = new List<bool>();


numbers.FirstOrDefault().Dump("Valid sequence");
emptyNumbers.FirstOrDefault().Dump("Empty int sequence");

emptyStrings.FirstOrDefault().Dump("Empty string sequence");

emptyBools.LastOrDefault().Dump("Empty bool sequence");
