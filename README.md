# AI Prompt
The AI prompt that could be used to solve this problem can be found here: [AI Prompt](AI_Prompt.md)

# Problem Description
This problem involves an old keypad phone with alphabetical letters, a backspace, and a send button. Each button has a number to identify it, and pressing a button multiple times cycles through the letters on it, 
allowing each button to represent more than one letter. To enter two characters from the same button, the user must pause for a second. The '*' character deletes one letter. The input always ends with '#'. The goal is to convert this old phone keypad input into text.

# Solution Approach
To solve this, the program traverses the input string. While going through each character, the following steps will be done in the given order:
1. Any whitespaces are ignored.
2. If there is a '*', the final output string is checked to see if it is empty. If not, the last character is removed.
3. A loop is used to check the number of the same adjacent alphabet. A counter variable preserves this number.
4. To consider the cyclic effect, the remainder of the counter variable is taken. For inputs 7 and 9, the divisor is 4 as they have four alphabets. For the rest of the inputs, the divisor is 3.
5. To get the corresponding alphabet, 2 is subtracted from the input number(converted from char to int), add the remainder, and finally add 64.
6. If the input contains '8' or '9', the alphabet is added by 1. Because in the digit 7, there are four letters.
7. The alphabet is appended to the final output.
8. The traversal is stopped after getting the '#' symbol.

# Assumptions
1. The input always ends with '#'.
2. The input only contains keypad digits that are explicitly mentioned in the problem statement.
3. The input only gets converted to uppercase letters.
4. The input's maximum size does not exceed the available memory.

# Edge Cases
1. Case: Empty input <br>Behavior: Should return empty output
2. Case: Delete without any input <br> Behavior: Should return empty output
3. Case: Check cyclic effect <br> Behavior: Should return the expected output
4. Case: Delete inputs more than available <br> Behavior: Should return empty output
5. Case: Press the same digit after a pause <br> Behavior: Should return separate letters as output
6. Case: Press the four alphabet digits <br> Behavior: Should return the expected output
7. Case: Press different digits after a pause <br> Behavior: Should return the expected output
8. Case: Press the last two digits <br> Behavior: Should return the expected output

# How to Run
1. Clone the repository
2. Navigate to the solution directory
3. Restore dependencies: `dotnet restore`
4. Run the application: `dotnet run --project PhonePadTextConversionApp`
5. Run unit tests: `dotnet test`

