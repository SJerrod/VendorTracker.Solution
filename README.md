# **Vendor Tracker**

#### Create a Vendor and Vendor/Order List, 12/18/2020

#### **By Jerrod Styrk**

## Decription
- This Application will allow you to Create a list of Vendors. Under each Vendor you can add a list of orders. The Orders themselves take in a few details such as title, description, total, and date for delivery.

## Setup

 #### _Things You Need_
 * A prefered Internet Browser
 * A code Editor to view the code 

 #### _To Open Locally_

- [Click to view Github repository](https://github.com/SJerrod/VendorTracker.Solution.git) Or simply paste the following url into your prefered browser https://github.com/SJerrod/VendorTracker.Solution.git
- To Clone repository simply click the green Code button and copy the url.
- Using a prefered terminal use the command 'git clone https://github.com/SJerrod/VendorTracker.Solution.git' in which ever directory you wish.
- Open the newly cloned repo with your text editor.
- In the terminal run command 'cd VendorTracker'
- In the terminal run command 'dotnet restore'
- In the terminal run command 'dotnet build'
- To run the program from this folder '*filelocation*/VendorTracker.Solution/VendorTracker'
- In the terminal run command 'dotnet run'
- To run tests be in this folder '*filelocation*/VendorTracker.Solution/VendorTracker.Tests'
- In the terminal run command 'dotnet test'

## Specifications

<details>
<summary>Click Here!</summary>

| specification | input | output |
| :------------ | :---- | :----- |
| Spash page prompts User to View Vendors | Click View Vendors | Navigates to New Vendor Form |
| Prompts User to Create Vendor if none are present | vendorName-"Susies Cafe", vendorDescription-"Local Cafe" | Susies Cafe, Local Cafe |
| User can navigate through Vendors | Click Vendor | Shows The Vendors Order List |
| User can Add Orders | Click Add Order | Navigates to New Order Form |
| User can view Order details by clicking Order in Order list | Click Order | Navigate to Order Detail page |


</details>

## Bugs

## For support

_jstyrk@citadel.edu_

## Technologies and tools used

<details>
  <summary>Expand Tech/tools</summary>

- Visual Studio Code
- C#
- markdown
- ASP.NET
- Razor
- .Net Core
- .Net Script REPL


</details>

### License

[MIT] Copyright (c) 2020 **Jerrod Styrk**