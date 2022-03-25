<Query Kind="Statements">
  <Connection>
    <ID>9a1c3a88-a34f-4058-ae94-f57088f35068</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="CsvLINQPadDriver" PublicKeyToken="no-strong-name">CsvLINQPadDriver.CsvDataContextDriver</Driver>
    <DisplayName>E:\Documents\GitHub\linq-2833070\CSVFiles\TestLinQ.csv (2021-08-08 16:12:49, 1 file 1,3 KB)</DisplayName>
    <DriverData>
      <Files># Drag&amp;drop here (from add files/folder dialogs as well). Ctrl adds files. Alt toggles * and ** masks.
# Type one file/folder per line. Wildcards ? and * are supported; **.csv searches in folder and its sub-folders.
# Ctrl+V (Ctrl+Alt+V) pastes from clipboard, appends *.csv (**.csv) to folders.
# Ctrl+Shift+V (Ctrl+Shift+Alt+V) clears, pastes from clipboard, appends *.csv (**.csv) to folders and proceeds.

E:\Documents\GitHub\linq-2833070\CSVFiles\*.csv
</Files>
      <UseCsvHelperSeparatorAutoDetection>true</UseCsvHelperSeparatorAutoDetection>
      <ShowSameFilesNonGrouped>false</ShowSameFilesNonGrouped>
      <CsvSeparator>;</CsvSeparator>
    </DriverData>
  </Connection>
  <Output>DataGrids</Output>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
  <DisableMyExtensions>true</DisableMyExtensions>
  <CopyLocal>true</CopyLocal>
</Query>

//LinQ can handle csv files like data tables
	
	var q = from test in TestLinQ
	select test ;


q.Dump();