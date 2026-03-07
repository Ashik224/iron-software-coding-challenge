using System;
using System.Collections.Generic;
using System.Text;

namespace PhonePadTextConversionApp
{
    public class OldPhonePadTextConversion
    {
        public static String OldPhoneTextConverter(string input)
        {
            StringBuilder builder = new();
            input = input.Trim();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '#') 
                    break;
                if (input[i] == ' ') 
                    continue;
                if(input[i] == '*')
                {
                    if (builder.Length > 0)
                        builder.Length--;
                    continue;
                }
                
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
                char alphabet = (char) (64 + ((digit - 2) * 3) + rem);
                if(digit == 8 || digit == 9)
                    alphabet += (char) 1;

                builder.Append(alphabet);
            }          
            string finalOutput = builder.ToString();

            return finalOutput;
        }
    }
}
