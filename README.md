# Problem Description
There will be an old keypad phone with alphabetical letters, a backspace, and a send button. Each button has a number to identify it, and pressing a button multiple times will cycle through the letters on it, 
allowing each button to represent more than one letter. To type two characters from the same button, the user must pause for a second. Pressing '*' will delete one letter. And, pressing '#' will be included at the
end of every input. A test method has to be implemented to convert this old phone keypad input into text.

# Solution Approach
To solve this, the program traverses the input string. While going through each character, the following steps will be done in the given order:
1. Any whitespaces are ignored.
2. If there is a '*', the final output string is checked to see if it is empty. If not, the last character is removed.
3. A loop is used to check the number of the same adjacent alphabet. A counter variable preserves this number.
4. To consider the cyclic effect, the remainder of the counter variable is taken. For inputs 7 and 9, the divisor is 4 as they have four alphabets. For the rest of the inputs, the divisor is 3.
5. To get the corresponding alphabet, 2 is subtracted from the input number(converted from char to int), add the remainder, and finally add 64.
6. If the input contains '8' or '9', the alphabet is added by 1. Because, in the digit 7, there are four letters.
7. The alphabet is appended to the final output.
8. The traversal is stopped after getting the '#' symbol.

# Assumptions
1. The input always ends with '#'.
2. The input only contains keypad digits that are explicitly mentioned in the problem statement.

# Edge Cases
1. Case: Empty input <br>Behavior: Should return empty output
2. Case: Delete without any input <br> Behavior: Should return empty output
3. Case: Check cyclic effect <br> Behavior: Should return the expected output
4. Case: Delete inputs more than available <br> Behavior: Should return empty output
5. Case: Press the same digit after a pause <br> Behavior: Should return separate letters as output



