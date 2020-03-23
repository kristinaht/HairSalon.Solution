# _Hair Salon_

#### _Independent Project 9, Mar 2020_

#### By _**Kristina Hengster Tintor**_

## Description
MVC application for a Hair Salon that allows user to add new Stylists and add new Clients for each Stylist. 

## Project Specifications

Action
* Input: 
* Output: 

## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/kristinaht/HairSalon.Solution```
* Open file in your preferred text editor

* On Windows: ```cd HairSalon.Solution```, followed by ```code .```
* Type ``` dotnet build``` followed by ```dotnet run``` to run program.

Run these commancs in MySQL to create the project Database:


CREATE SCHEMA `kristina_hengster_tintor` ;
USE `kristina_hengster_tintor`;

CREATE TABLE `kristina_hengster_tintor`.`stylists` (
  `StylistId` INT NOT NULL AUTO_INCREMENT,
  `Specialty` VARCHAR(255) NULL,
  PRIMARY KEY (`StylistId`));

  CREATE TABLE `kristina_hengster_tintor`.`clients` (
  `ClientId` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(255) NULL,
  `StylistId` INT NULL DEFAULT 0,
  PRIMARY KEY (`ClientId`));


## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kristinaht/BakeryVendors.Solution) here on GitHub._

## Technologies Used

* Git
* VS Code
* C#
* .NET

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Kristina Hengster Tintor_**