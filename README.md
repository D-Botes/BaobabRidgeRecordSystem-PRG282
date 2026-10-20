# Baobab Ridge Wildlife Rehabilitation Records System

PRG282 group project: a C# Windows Forms (.NET 8) application for recording animals in care.

## Team
| Name | Student number | 
|---|---|---|
| Dylan Botes | 603570 | 
| Tendai Vashiko | 604512| 
| Kian Kruger | 603830 | 
| Ivahn Van der Merwe | 604404 | 

## How to build and run

1. This project requires Visual Studio 2022 with the .NET desktop development workload

2. Clone the repository:
	   git clone https://github.com/D-Botes/BaobabRidgeRecordSystem-PRG282.git

3. Open the .sln in Visual Studio

4. Build and run. The starter animals.txt is copied beside the .exe automatically.

## Features

 - Add: The ability to add an animal with validation of every field. Status and Housing unit are calculated from the recovery score
 - View: You can view all the animals in a read-only grid that refreshes with every change.
 - Update: Existing animal information can be updated by clicking a grid row or searching by Animal ID.
 - Delete: Animals can be deleted, with a "Are you sure?" prompt for confirmation
 - Summary Report: A report can be generated showing totals and averages and is saved to a file called "summary.txt"
	
## File formats

**animals.txt** - stored beside the .exe, one animal per line, no header or blank lines, seven fields seperated with '|'
```
ID|Name|Species|Age|Score|Status|Housing Unit
WR-0001|Thabo|African Penguin|4|85|Release-Ready|Pre-Release Camp
```
**summary.txt** - Generated in a report type format, showing totals and averages with a timestamp of date when the report was generated. Not committed to git.

## Known limitations
- Status and housing in the file are recalculated from the score on load, so hand-edited values there are ignored
- Only one record can be deleted at a time
- The data file is not locked while the app runs, so edits made in another program are only seen after the next refresh
