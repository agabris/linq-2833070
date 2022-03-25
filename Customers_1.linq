<Query Kind="Statements">
  <Connection>
    <ID>4c01dc4d-45f3-4d6d-ad1b-0404aad51552</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-STCTJ4E</Server>
    <Database>NORTHWIND</Database>
  </Connection>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
  <DisableMyExtensions>true</DisableMyExtensions>
  <CopyLocal>true</CopyLocal>
</Query>

string cname = "Maria Anders";
string sn = "Mar";

var k = Customers.Where (c => c.ContactName.StartsWith(sn) );

k.Dump();

var q2 = from CompanyName in k
		 		 select CompanyName;
q2.Dump();
