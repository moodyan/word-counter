# _Word Counter_

#### _App created for Epicodus Independent Project, C-Sharp - Week Two. Practice using BDD and xUnit testing. June 2 2017_

#### By _**Alyssa Moody**_

## Description

_A simple app where a user can enter in a block of text and a specific word. The app will return to the user the number of times that specific word is used in the block of text._

## Program Specifications

| Description  | Why  | Input Example | Output Example |
| ------------- | ------------- | ------------- |
| The program searches the inputted string for the word the user entered and returns 0 if not found.  | Simply compares words that don't match. No change in output is required.  | Text: "horse" Word: "cow"   | "0"  |
| The program searches the inputted string for the exact word the user entered and returns 1 if found.  | Somewhat simply has to compare words to see if they match.  | Text: "horse" Word: "horse"   | "1"  |
| The program searches the inputted string for the exact word the user entered and counts the number of times it appears.  | Adds some complexity to the program because it has to search multiple words in a string to find the exact inputted search term.  | Text: "No one can talk to a horse of course" Word: "horse"   | "1"  |
| The program searches the inputted string for the exact word the user entered and counts the number of times it appears.  | Adds some complexity to the program because it has to find the number of times the exact word appears in the given text and add that to a running total.  | Text: "A horse is a horse, of course, of course, and no one can talk to a horse of course" Word: "horse"   | "Found 2 times."  |
| The program counts the number of times the inputted word is used, ignoring case.  | Adds to complexity because the program automatically sees these as two different words, so we have to tell the program to find all instances.  | Text: "A Horse is a horse of course, of course, and no one can talk to a horse of course" Word: "horse"   | "Found 3 times."  |
| The program counts the number of times the inputted word is used, ignoring punctuation at the beginning and end of a word.  | Adds to complexity because the program automatically recognizes the punctuation as part of the word so we have to tell the program to remove them.  | Text: "A horse is a horse, of course, of course, and no one can talk to a horse of course" Word: "horse"   | "Found 3 times."  |

## Setup/Installation Requirements

_Runs on the .Net Framework._

_Install Visual Studio 2015. https://go.microsoft.com/fwlink/?LinkId=532606 ._

_Install ASP.Net 5. This will give you access to the .NET Framework. https://go.microsoft.com/fwlink/?LinkId=627627 ._

_Restart PowerShell. While located in your machine's Home directory, enter the command > dnvm upgrade._

_Requires Nancy Web Framework located at: http://nancyfx.org/. You can also do this via Windows PowerShell with the command > **Install-Package Nancy**_

_**From GitHub: Download or clone project repository onto desktop from GitHub.**_

 _In PowerShell, cd into the project folder. Enter the command > **dnu restore**_

 _Enter the command > **dnx kestrel**_

 _In your preferred browser, navigate to http://localhost:5004/ and you should see the application._

## Known Bugs

_No known bugs._

## Support and contact details

_If you run into any issues or have questions, ideas or concerns, please contact Alyssa Moody at alyssanicholemoody@gmail.com_

## Technologies Used

_Languages: HTML, CSS, C#_
_Frameworks: Nancy, .Net_

### License

*MIT license Agreement*

Copyright (c) 2017 **_Alyssa Moody_**
