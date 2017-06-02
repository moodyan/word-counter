# _Word Counter_

#### _App created for Epicodus Independent Project, C-Sharp - Week Two. Practice using BDD and xUnit testing. June 2 2017_

#### By _**Alyssa Moody**_

## Description

_A simple app where a user can enter in a block of text and a specific word. The app will return to the user the number of times that specific word is used in the block of text._

## Program Specifications

| Description  | Why  | Input Example | Output Example |
| ------------- | ------------- | ------------- |
| The program allows the user to input a block of text and a specific word and will return that to them.   | Simply returns the user input.   | Inputted Text: "This string of text is a string of text." Inputted Word: "string"   | Outputted Text: "This string of text is a string of text." Outputted Word: "string"  |
| The program searches the inputted string for the word the user entered and returns 0 if not found.  | Simply searches all the text to see if match is found. No change in output is required.  | Text: "A horse is a horse, of course, of course, And no one can talk to a horse of course" Word: "cow"   | "Found 0 times"  |
| The program searches the inputted string for the word the user entered and returns 1 if found.  | Somewhat simply has to search all the text to see IF match is found, but automatically returns 1 no matter how many times it appears in the text.  | Text: "A horse is a horse, of course, of course, And no one can talk to a horse of course" Word: "horse"   | "1"  |
| The program searches the inputted string for the word the user entered and returns the number of times it is found.  | Somewhat complexly has to find the number of times the exact word appears in the given text, add that to a running total, and return it to the user.   | Text: "A horse is a horse, of course, of course, and no one can talk to a horse of course" Word: "horse"   | "Found 2 times."  |
| The program searches the inputted string for the word the user entered, ignoring case, and returns the number of times it is found.  | Complexly has to find the word in the given text, regardless of case. The program automatically sees these as two different words, so we have to tell it to ignore that.  | Text: "A Horse is a horse of course, of course, and no one can talk to a horse of course" Word: "horse"   | "Found 3 times."  |
| The program searches the inputted string for the word the user entered, ignoring punctuation at the beginning and end of a word, and returns the number of times it is found.  | Complexly has to find the word in the given text, regardless of punctuation. The program automatically recognizes the punctuation as part of the word so we have to tell the program to remove them.  | Text: "A horse is a horse, of course, of course, and no one can talk to a horse of course" Word: "horse"   | "Found 3 times."  |

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
