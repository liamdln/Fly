# Fly

Fly is a flight booking system created by me in 2017 for an assessed project, it was my first time using C# and I had not yet been introduced to OOP.<br>
My aim for this project is to update Fly and clean it up to bring the programming to a higher standard.

## Updating

Each update will have its own section detailing the issue and how I will fix it.

### UI

The UI was thrown together very quickly with minimal artistic skill.

#### UI TODO

* Change the colour of the UI to make it cleaner and look nicer.
* Move elements about to make the user experience better.
* Possibly investigate animations for hovering over a button.
* Users should be able to type origin and destination with suggestions showing up each time they enter a char.

### Getting Data

Right now, Fly connects to a database using the MySQL connector for CSharp. There are multiple methods in each Form that connect to the database independently, which is not good. In the future I plan to move to an API instead of connecting straight to the database, so while remaking the database connection I will keep this in mind to make switching easy.

#### Getting Data TODO

* ~~Create an object for database connections to keep the code in one place.~~
* ~~Create search queries using SQL instead of downloading all the data from the database and sifting through it each time a connection is made.~~
* Create an API to get data.

### Safety and Privacy

Last time I wrote this, I used an encrypt/decrypt script that I found in the CSharp docs, so this time I'd like to write my own.

* Look into types of encryption, and how to implement it into CSharp.
* Choose what to encrypt, based on new GDPR data laws introduced in 2018 (after the project had been handed in).
* Possibly draw up a mock "how we use your data" etc section? (This will be low priority, but good to think about while making an app like this).

### General TODO

Areas of the program I need to clean up that don't fit under a heading:

* Disallow users to select the same origin and destination.
* If no flights on a date, suggest more dates.
* Get flight connections working.
* Allow the user to select an airline preference when choosing a date, origin and destination.

### General Clean Up

I wrote this when I was new to programming, so I have not followed any coding conventions. I will try to clean up the code as I go along.
Forms to clean:

* ~~MenuForm~~
* ~~BookingForm~~
* ~~BookingListForm~~
* CollectTicketForm
* SearchTicketForm
