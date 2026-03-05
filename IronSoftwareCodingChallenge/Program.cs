namespace IronSoftwareCodingChallenge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OldPhonePadTextConversion oldPhonePadTextConversion = new();
            string output = oldPhonePadTextConversion.OldPhonePad("8 88777444666*664#");
            Console.WriteLine("Final string: " +output);
        }
    }
}
