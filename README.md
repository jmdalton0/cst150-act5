# Activity 5
## Jesse Dalton
### CST 150

Video Presentation of activity:
[Loom video](https://www.loom.com/share/ed67a5ce969a47aabc72629e367148c9)

Screenshots available in 
[/gcu/img/](https://github.com/jmdalton0/cst150-act5/tree/main/gcu/img)

### Word Statistics
Simple Windows Form Application to read text from a file and display statistical data about the words.

Statistics Displayed:
- first alphabetical word
- last alphabetical word
- longest word
- word with most vowels

### What I learned
While coding this project, I ran into a bug where the last word of the file was sometimes not read. I realiazed that it depended on whether the file ended in whitespace or not. The process I used to save each word depended on reaching a character that was not considered a letter (typically a space) and saving the current running word. But if the last character of the file was a letter, then the final word would not be saved. I fixed this bug by appending a newline character to the end of the file before reading the words. This gauranteed that the file ended in a non-letter character and ensured that the last letter was read.

I also learned that you can programatically change control properties like color and enabled to help with UX.
