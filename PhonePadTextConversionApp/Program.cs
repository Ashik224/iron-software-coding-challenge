using PhonePadTextConversionApp;

namespace IronSoftwareCodingChallenge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string convertedText = OldPhonePadTextConversion.ConvertOldPhoneKeypadInput("8 88777444666*664#");
            Console.WriteLine(convertedText);
        }
    }
}
