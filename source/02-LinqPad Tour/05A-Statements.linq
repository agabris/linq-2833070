<Query Kind="Statements">
  <NuGetReference>Bundle.Microsoft.Office.Interop</NuGetReference>
  <Namespace>Excel = Microsoft.Office.Interop.Excel</Namespace>
  <Namespace>Outlook = Microsoft.Office.Interop.Outlook</Namespace>
  <Namespace>PowerPoint = Microsoft.Office.Interop.PowerPoint</Namespace>
  <Namespace>Word = Microsoft.Office.Interop.Word</Namespace>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
  <DisableMyExtensions>true</DisableMyExtensions>
  <CopyLocal>true</CopyLocal>
</Query>

// LINQPad supports multiple lines
// with the Statement editor


int x = -6005;
bool isBig = x > 1000;
string isBigString = isBig ? "Big Number" : "Small number";

// you decide how to output to the results window!
Console.WriteLine(isBigString);