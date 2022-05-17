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
- Method 1: textValidation(string text)
  - This method is a simple validation check for strings which are allowed to contain any a-Z letter
- Method 1: Validate
  - This method returns an unsigned integer which is used to determine which fields have failed the validation checks.
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

### Inventory Class
#### Methods
- Inventory()
  - Inventory constructor used to create an inventory instance

- validateProduct(string, string, string, string, string): int
  - This method checks each component of the item trying to be added or edited and comapres each of them to a corresponding regex pattern. The method returns an integer that indicates which of the fields are invalid, if any. This integer is used by the AddItemForm and EditItemForm classes to display an error message to the user if an invalid field was found, or add/edit the item successfully if none of the fields are found to be invalid. 
  
  - The intger value returned indicates the following:
    Integer Returned  | Meaning
    ----------------- | -------------
    0      | All fields correct
    1      | \_productName is invalid
    2      | \_inventoryLevel is invalid
    3      | \_productSize is invalid
    4      | \_shelfQuantity is invalid
    5      | \_orderAmount is invalid
    
  - If multiple fields are invalid, the field checked earliest, as indicated by the integer to be returned, will be displayed on the error message.

### Database Class
The Database class is the lowest level class in the program, its purpose is to directly push and pull data from both the inventory and members table within the database. The purpose of this class is to provide other classes with simple definition to connect to the database, this class required to have many methods as only one connection can exist during a single run time.

- DatabaseConnection()
  - Database constructor used to initialize the connection to the database.

- GetMemberList():DataTable
  - Pulls data from the member database which can be used to display the data in a table.

- MembersCollection()
  - Prints out all the data in the members table to the console, used for validation and testing.

- NumberOfMembers(): int
  - Returns the number of members that's in the database.

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
  
- UpdateMember(string, string, string): bool
  - Updates a given value in the member table row based on the column based on the members email. Returns true if the member is updated successfully.
  
- SearchMemberByName(string): DataTable
  - Used to return a datatable of the member based on their email.
  
- GetInventoryList(): DataTable
  - Returns a datatable of all the products in the inventory table.
  
- SearchInventoryByName(string): DataTable
  - Returns a row of a product in the inventory table, as a datatable.
  
- InventoryCollection()
  - Returns all data from the inventory table to the console for debugging purposes.
  
- HighestProductID(): int
  - Returns the highest product id.
 
- NumberOfProducts(): int
  - Returns the number of products inventory table.
  
- AddProduct(string, int, string, int, int): bool
  - Adds a product to the inventory table.
  
- SearchInventoryById(int): List<string>
  - Returns a list of a product row as strings using the product id.
  
- ProductRowToStringint): List<string>
  - Returns a list of a product row as strings using the product name.
  
- CheckIfProductExists(string): bool
  -Use the product name to see if a product is in the inventory table and returns true
  
- UpdateProduct(string, string, string): bool
  - Updates a given value in the inventory table row based on the column based on the products name. Returns true if the member is updated successfully.
 
- ExportInventoryReport()
  - Exports a CSV file of the inventory.
  


## GUI Classes

#### Overview
WHAT VERSION
Windows Forms is a UI framework that was used to design and implement this windows desktop application. Windows forms was an efficient way to provide the client a 
simple and intuitive GUI which would allow a user to perform tasks required to manage Members and Inventory. Within .NET, Windows Forms provides a set of useful 
libraries which have simplified the overall development. Utilizing the visual designer provided in Visual Studio, forms were created to display pages containing 
labels, interactive text boxes and buttons and grids to display data from the database. For more information relating to the usage of this framework visit: 
https://docs.microsoft.com/en-us/dotnet/desktop/winforms/windows-forms-overview?view=netframeworkdesktop-4.8 

#### Interactivity
To provide interactivity within the application, controls which are defined by Microsoft as ‘discrete user interface (UI) element(‘s) that displays data or accepts 
data input’ are used to generate events by performing some action. These events execute some code which is implemented through methods existing within the form 
class which the event takes place (methods and classes are detailed below).  Using a Façade design pattern operations on user data are largely performed by the 
respective Member and Inventory classes including validation and sending queries with the database class.

#### Structure
For each form displayed to the user there is a corresponding class and designer class. The ‘main’ class file e.g. InventoryForm.cs contains the methods, properties 
and variables used for interacting with Member, Inventory and Database classes whereas the designer classes contain the windows form designer generated code which 
includes the initialization of control variables, values and events used within the form.

### Classes

#### MainForm

As the name suggest this is the form from which all other forms are bound to provide navigation for the application. Using a panel the size of the main body of the 
application, forms once selected via the navigation to the left of the application will open and fill into this panel through the LoadForm() method taking a form as 
a parameter.
DashboardForm
A simple welcome screen noting the documentation number to follow.
ReportForm
This form only use is to export a CSV report file containing data concerning inventory levels for analysis. This file is stored in the root c:\CSV folder.

#### InventoryForm

This class interfaces with the other inventory forms allowing for such functions as adding new items, editing existing items and searching for items through various 
button click events. The entire inventory database is displayed through a table like grid named InventotorydataGridView which contains a datatable bound with data 
and the respective columns: ID, Name, inventory Level, product size, shelf qty and order qty.
A DatabaseConnection object is initialized so methods can create queries to the database from the methods below.

##### Methods:

  
- LoadItemIntoTable()
Returns a dataTable containing Inventory items and adds to the existing datasource using: InventorydataGridView.DataSource = db.GetInventoryList();

- EditSelectedItemBtn_Click()
An event method that loops through InventorydataGridView.SelectedRows to obtain the selected row cells that the user has clicked. If not null an EditItemForm is 
created and filled to screen with a passing ID.
- ItemSearchBtn_Click()
Gets the user entered string from the ItemSearchTB search bar and uses it as the parameter for the SearchInventoryByName(search) method from the DatabaseConnection 
class. This method adds values to the InventorydataGridView based on the resulting query for item names.
- AddItemBtn_Click() 
Is the event method read when the AddItemBtn button is clicked. Its purpose is to initialize a need AddItemForm passing in itself as a means retaining the current 
form to process methods

### EditItemForm 
This form uses parameters string and InventoryForm in the constructor of the class, using the id from the EditSelectedItemBtn_Click() method to initialize the new 
EditItemform. Then an additional inventory search can be completed to obtain a new set of information regarding the item. The functionality behind the InventoryForm 
parameter is the same the AddItemBtn method. Text boxes are filled in using the data from the database which are available for the user to change (except the ID) 
and pass new information though the DatabaseConnection methods.

### AddItemForm
This class allows users to add new items into the database by filling in text boxes. Once the AddItemDetailsBtn_Click() event occurs by clicking the 
AddItemDetailsBtn item data is parsed and validated through try and catch blocks assigning an int variable a number relating to the type of error specified in the 
switch statement: switch (_errorcode){…}. If the new item details pass the validation the product is added to the database: db.AddProduct(//product param) and the 
grid within the Inventory form is refreshed after the switch statement.

#### MembersForm
This class interfaces with the other inventory forms allowing for such functions as adding new members, editing existing members, searching for members. It contains 
several similar methods to the InventoryForm class such as Grid_Load(), a click event methods for adding and editing a Member. These methods initialise new Forms 
passing itself and member id for refreshing the table and getting member data respectively.

#### EditMemberForm
This form aims to obtain a specified member for editing and display their details to the new form. The user will have the ability to alter this information inside 
text boxes (excluding ID). Once the user initiates the AcceptEditMemberDetailsBtn_Click event all the user data is validated through the Members class method 
Validate() as described in the Members class section. Based on the returning stream of bits, messages will be displayed to the user either showing the edit was 
successful and the new member details are stored in the database or one or more validation errors have occurred. The Members table contains a field for whether or 
not the member is currently a paying member through the methods status[True/False]Check_CheckedChanged(). These control event methods alter the check boxes so only 
one is selected at a time for submission. As the format for dates differs between the Windows Forms control and MySQL database a method is provided to turn the date 
into proper MySQL date format: ‘01-11-2020’. 

  
#### AddMemberForm
This form provides methods for obtaining user input to add a new member to the system including another date fix method to change the format of the date string so it can be entered into the database. 



#### Markdown Help (Internal)
This files are written in markdown so if you need any help with syntax: see [Basic writing and formatting syntax](https://docs.github.com/en/github/writing-on-
github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
