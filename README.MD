# Fly
Fly is a flight booking system created by me in 2017 for an assessed project, it was my first time using C# and I had not yet been introduced to OOP.<br>
My aim for this project is to update Fly and clean it up to bring the programming to a higher standard.

## Updating
Each update will have its own section detailing the issue and how I will fix it.

### UI
The UI was thrown together very quickly with minimal artistic skill.
<br>
TODO:
* Change the colour of the UI to make it cleaner and look nicer.
* Move elements about to make the user experience better.
* Possibly investigate animations for hovering over a button.

### Getting Data
Right now, Fly connects to a database using the MySQL connector for CSharp. There are multiple methods in each Form that connect to the database independently, which is not good. In the future I plan to move to an API instead of connecting straight to the database, so while remaking the database connection I will keep this in mind to make switching easy.<br>
TODO:
* Create an object for database connections to keep the code in one place.
* Create search queries using SQL instead of downloading all the data from the database and sifting through it each time a connection is made.
* Investigate moving the connection to an API instead of talking directly to the database.

### General Clean Up
I wrote this when I was new to programming, so I have not followed any coding conventions. I will try to clean up the code as I go along.
