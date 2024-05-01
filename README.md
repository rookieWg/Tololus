# tololus
Corporate site developed using .NetCore Razor Pages MSSQL Server And AzureSQL Server. Targeted .Net version is 6.0
This project is developed for corporate company ‘TOLOLUS GLOBAL RESOURCE [TGR]’. 
It implements ASP .Net Core Razor Pages with entity frameworks.
It target .Net framework 6.0, visual studio 2022 was used as the IDE & Microsoft SQL Server 2017 and SQL Server Management Studio 18 were used for database to store forms data while debugging locally. 
AzureSQL server was later used for testing.
The project takes advantage of the scaffolding feature of Razor technology to create the DbContext and generate connection string for database locally.
Languages.
ASP .Net Core Razor Pages
C#
Entity Framework
Html, Css, & JS
Pages:
Index.cshtml – main page
Success.cshtml – after form submission
comingSoon.cshtml – Waitlist for the forthcoming child sites of the company
Model Folder/Directory:
ContactForm.cs – for contact us form in the index page.
ComingSoon.cs – for waitlist form in the comingSoon page.

DATA Folder: DbContext:
 tololusContext.cs – for contact us form
comingSoonContext.cs – for comingSoon form

Licence:
MIT:
Feel free to use the code for any of your project without restriction. 
