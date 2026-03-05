using System;
using System.Collections.Generic;
using System.Text;

namespace IronSoftwareCodingChallenge
{
    internal class OldPhonePadTextConversion
    {
        private Dictionary<string, string> buttonTextPairs = new()
        {
            { "2", "A" },
            { "22", "B" },
            { "222", "C" },
            { "3", "D" },
            { "33", "E" },
            { "333", "F" },
            { "4", "G" },
            { "44", "H" },
            { "444", "I" },
            { "5", "J" },
            { "55", "K" },
            { "555", "L" },
            { "6", "M" },
            { "66", "N" },
            { "666", "O" },
            { "7", "P" },
            { "77", "Q" },
            { "777", "R" },
            { "7777", "S" },
            { "8", "T" },
            { "88", "U" },
            { "888", "V" },
            { "9", "W" },
            { "99", "X" },
            { "999", "Y" },
            { "9999", "Z"   },
        };

        public String OldPhonePad(string input)
        {
            string finalOutput = "";
            input = input.Trim();
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    if(!string.IsNullOrEmpty(finalOutput)) 
                        finalOutput = finalOutput.Substring(0, finalOutput.Length - 1);
                    continue;
                }

                if(input[i] == ' ') continue;

                if (input[i] == '#') break;

                int count = 0;
                while (input[i] == input[i+1])
                {
                    count++;
                    i++;
                }

                string recurringChar = "";
                for(int j = 0; j < count + 1; j++)
                {
                    recurringChar += input[i];
                }

                finalOutput += buttonTextPairs[recurringChar];
            }
                return finalOutput;
        }
    }
}
