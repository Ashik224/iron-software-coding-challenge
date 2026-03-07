using PhonePadTextConversionApp;

namespace IronSoftwareCodingChallenge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string output = OldPhonePadTextConversion.OldPhoneTextConverter("8 88777444666*664#");
            Console.WriteLine("Final string: " +output);
        }
    }
}
