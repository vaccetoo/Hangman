# Hangman
Basic own project of the Hangman game.

Here i'm using a few words in an array of string from where i will take a random word to be guessed (using the Random class).
With 'while loop' until the wrong answers reach 6 i will have chances to guess letters.
If a letter has already been used i'm storing this letters in a List of char which provides me all the used letters and can't use the same one twice.(If i try it that is not a wrong answer.Automaticly we have another chance to guess new letter.)
Repeting this process until we guess the word or reach the 6 wrong attempts.
