using System;
using System.Collections.Generic;
using System.Text;

namespace PhonePadTextConversionApp
{
    public class OldPhonePadTextConversion
    {
        public static String ConvertOldPhoneKeypadInput(string input)
        {
            StringBuilder outputText = new();
            input = input.Trim();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '#') 
                    break;
                if (input[i] == ' ') 
                    continue;
                if(input[i] == '*')
                {
                    if (outputText.Length > 0)
                        outputText.Length--;
                    continue;
                }

                // Count the number of consecutive presses of the same digit
                int count = 0;
                while (input[i] == input[i+1])
                {
                    count++;
                    i++;              
                }
                count += 1;

                int rem;
                if (input[i] == '7' || input[i] == '9')
                {
                    rem = count % 4;
                    if (rem == 0) 
                        rem = 4;
                }
                else
                {
                    rem = count % 3;
                    if (rem == 0) 
                        rem = 3;
                }

                int digit = input[i] - '0';

                // The formula to calculate the corresponding alphabet based on the digit and the count of presses
                char alphabet = (char) (64 + ((digit - 2) * 3) + rem);

                // Adjusting the alphabet for digits '8' and '9' as digit '7' has four letters
                if (digit == 8 || digit == 9)
                    alphabet += (char) 1;

                outputText.Append(alphabet);
            }          
            string result = outputText.ToString();

            return result;
        }
    }
}
