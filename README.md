# BakeryTracker.Solution

#### By _**Garrett Hays**_

#### An MVC application to help track vendors and the orders belonging to those vendors.

## Technologies Used

* C#
* .NET
* HTML
* CSS
* MSTest

## Description

This is an MVC application that was built using C#. The purpose of this application is to allow a bakery owner, Pierre, to track vendors and vendor orders that are placed through his business. When the application runs, Pierre is welcomed to the "Bakery Order Tracker" on a splash page, then directed to view vendors or add a new one. The "add vendor" page allows Pierre to assign a new vendor by their name and a brief description. After the information is inputted using the "add" button, Pierre can then add order details to that specific vendor. The order details support a title, description, cost and date of the order. Once the order is added, it appears under that specific vendor's orders.

## Necessary Tools

* MSTest 
* .NET 

## Setup/Installation Requirements

* Copy the git repository url [here](https://github.com/GarrettHays/BakeryTracker.Solution).
* Open a shell program & navigate to your desktop.
* Clone the repository using the "git clone" command and copied URL.
* In the shell program, navigate to the root directory of the newly created file called "BakeryTracker.Solution"
* From the root directory, navigate to the directory named "BakeryTracker"
* Once inside the "Bakery" directory, type "dotnet run" into the console to run the application.

## Test Instructions

* Using a shell program, navigate from the root directory, "BakeryTracker.Solution," to the "BakeryTracker.Tests" directory.
* Once in the "BakeryTracker.Tests" directory, type "dotnet restore" into the console.
* After the restore process is complete, type "dotnet test" into the console. This will run all written tests and display the test results into the console to review.

## Known Bugs

* _No known issues_

## License

_[MIT License](license)_

Copyright (c) July 22nd, 2022 Garrett Hays