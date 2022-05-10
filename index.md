## GotoGrocery Documentation

On this webpage, you will find all the documentation about the GotoGrocery API and Documentation.

### Introduction
This program is written in C#. The team has collaborated on the project in Visual Studio (VS) Community and all VS Solutions are included within the repository for convenience.

### Prerequisites
In order for this application to work, it must be able to contact a MySQL server with all the database information being stored there. For testing purposes, MySQL Workbench was run and simulated in order to design this application. 

### Usage
This section will detail how to use the application.

### Member Class
#### Methods
The methods for this class are as follows:
- Method 1: Something
  - This is to do with this...
- Method 1: Something
  - This is to do with this...
##### Validation
The validation method returns a binary value with each bit representing whether validation has passed or failed for a specific property of the class. The relation of bit to property is as follows:
- Bit 0: NA
- Bit 1: First Name
- Bit 2: Last Name
- Bit 3: Phone Number
- Bit 4: Membership Status
- Bit 5: Membership Start Date
- Bit 6: NA
- Bit 7: NA
If any of the bits are not returned as a "1" or set high, then it is the programmer's job to rectify the issue. 

#### Properties
All properties within the Member Class are able to get and set. No validation occurs when setting and the validation method must be called to check for the respective validity of set variable.
- Property 1: Something
  - This is to do with this...
- Property 1: Something
  - This is to do with this...
### Inventory Class

### Database Class - RONDIGITYDOG
The Database class is the lowest level class in the program, its purpose is to directly push and pull data from both the inventory and members table within the database. The purpose of this class is to provide other classes with simple defintion to connect to the database, this class required to have many methods as only one connection can exist during a single run time.

- DatabaseConnection()
  - Database contructor used to initalize the connection to the database.

- GetMemberList():DataTable
  - Pulls data from the member database which can be used to display the data in a table.

- MembersCollection()
  - Prints out all the data in the members table to the console, used for validation and testing.

- NumberOfMembers(): int
  - Returns the number of members thats in the database.

- HighestMemberId(): int
  - Returns the highest member id.

- AddMember(string, string, string, string, string): bool
  - Adds a member into the members table returns true when successfully added to the table.

- RemoveMemberById(int)
  - Removes a member from the database using the members id.

- GetMemberId(string): int
  - Returns the member ID based on the members email.

- CheckIfMemberExists(string)
  - Checks if the member exists using the members email.

- MembertoString(int): List<string>
  - Returns a row from the members table as a list of strings, using the members ID.
  
- z
  


### GUI Class - Aiden
Forms

#### Markdown Help (Internal)
This files are written in markdown so if you need any help with syntax: see [Basic writing and formatting syntax](https://docs.github.com/en/github/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).